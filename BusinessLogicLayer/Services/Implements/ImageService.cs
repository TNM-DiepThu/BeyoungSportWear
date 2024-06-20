using AutoMapper;
using BusinessLogicLayer.Services.Interface;
using BusinessLogicLayer.Viewmodels.Image;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using DataAccessLayer.Application;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Implements
{
    public class ImageService : IImageService
    {
        private readonly ApplicationDBContext _dbcontext;
        private readonly IMapper _mapper;
        private readonly Cloudinary _cloudinary;

        public ImageService(ApplicationDBContext dbContext, IMapper mapper, IConfiguration configuration, Cloudinary Cloudinary)
        {
            _dbcontext = dbContext;
            _mapper = mapper;
            _cloudinary = Cloudinary;

        }
        private string CalculateSHA1Hash(IFormFile imageFile)
        {
            using (var sha1 = SHA1.Create())
            using (var stream = imageFile.OpenReadStream())
            {
                var hashBytes = sha1.ComputeHash(stream);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        private async Task<string?> CheckIfImageExistsAsync(string sha1Hash)
        {
            var existingImage = await _dbcontext.Images.FirstOrDefaultAsync(i => i.Hash == sha1Hash);
            return existingImage?.Path;
        }

        public async Task<ImageCreateVM> CreateAsync(ImageCreateVM request, Cloudinary cloudinary)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            foreach (var imageFile in request.Path)
            {
                var sha1Hash = CalculateSHA1Hash(imageFile); 

                var existingImageUrl = await CheckIfImageExistsAsync(sha1Hash);

                if (existingImageUrl != null)
                {
                    request.UploadedImageUrls.Add(existingImageUrl);
                }
                else
                {
                    var uploadParams = new ImageUploadParams
                    {
                        File = new FileDescription(imageFile.FileName, imageFile.OpenReadStream()),
                        Folder = "BeyoungSportWear"
                    };

                    var uploadResult = await cloudinary.UploadAsync(uploadParams);

                    var uploadedImageUrl = uploadResult.SecureUrl.ToString();
                    request.UploadedImageUrls.Add(uploadedImageUrl);

                    var imageEntity = new Images
                    {
                        ID = Guid.NewGuid(),
                        Path = uploadedImageUrl,
                        Hash = sha1Hash, 
                        CreateDate = DateTime.Now,
                        CreateBy = request.CreateBy,
                        IDProductDetails = request.IDProductDetails,
                        Status = request.Status
                    };

                    _dbcontext.Images.Add(imageEntity);
                }
            }

            await _dbcontext.SaveChangesAsync();
            request.Hash = CalculateSHA1Hash(request.Path.FirstOrDefault());

            return request;
        }


        public async Task<List<ImageVM>> GetAllActiveAsync()
        {
            var activeImages = await _dbcontext.Images
                       .Where(img => img.Status == 1)
                       .Select(img => new ImageVM
                       {
                           ID = img.ID,
                           Path = img.Path,
                           Hash = img.Hash,
                           CreateDate = img.CreateDate,
                           CreateBy = img.CreateBy,
                           IDProductDetails = img.IDProductDetails,
                           Status = img.Status
                       })
                       .ToListAsync();

            return activeImages;
        }
        public async Task<List<ImageVM>> GetAllAsync()
        {
            var allImages = await _dbcontext.Images
                       .Select(img => new ImageVM
                       {
                           ID = img.ID,
                           Path = img.Path,
                           Hash = img.Hash,

                           CreateDate = img.CreateDate,
                           CreateBy = img.CreateBy,
                           IDProductDetails = img.IDProductDetails,
                           Status = img.Status
                       })
                       .ToListAsync();

            return allImages;
        }
        public async Task<ImageVM> GetByIDAsync(Guid ID)
        {
            var image = await _dbcontext.Images
                       .Where(img => img.ID == ID)
                       .Select(img => new ImageVM
                       {
                           ID = img.ID,
                           Path = img.Path,
                           Hash = img.Hash,

                           CreateDate = img.CreateDate,
                           CreateBy = img.CreateBy,
                           IDProductDetails = img.IDProductDetails,
                           Status = img.Status
                       })
                       .FirstOrDefaultAsync();

            return image ?? throw new KeyNotFoundException("Image not found");
        }
        public async Task<bool> RemoveAsync(Guid ID, string IDUserDelete)
        {
            var image = await _dbcontext.Images.FindAsync(ID);
            if (image == null)
            {
                throw new KeyNotFoundException("Image not found");
            }

            image.Status = 0;
            image.DeleteBy = IDUserDelete;

            _dbcontext.Images.Update(image);
            await _dbcontext.SaveChangesAsync();

            return true;
        }
        public Task<bool> UpdateAsync(Guid ID, ImageUpdateVM request)
        {
            throw new NotImplementedException();
        }

        public async Task<string> UploadImageAsync(IFormFile imageFile)
        {
            if (imageFile == null)
            {
                throw new ArgumentNullException(nameof(imageFile));
            }

            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(imageFile.FileName, imageFile.OpenReadStream()),
                Folder = "BeyoungSportWear"
            };

            var uploadResult = await _cloudinary.UploadAsync(uploadParams);

            if (uploadResult.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return uploadResult.SecureUrl.ToString();
            }
            else
            {
                throw new Exception("Failed to upload image to Cloudinary");
            }
        }
    }
}
