using AutoMapper;
using BusinessLogicLayer.Services.Interface;
using BusinessLogicLayer.Viewmodels.Image;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using DataAccessLayer.Application;
using DataAccessLayer.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
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

        public async Task<List<string>> CreateAsync(ImageCreateVM request, Cloudinary cloudinary)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var uploadedImageUrls = new List<string>();

            foreach (var imageFile in request.Path)
            {
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(imageFile.FileName, imageFile.OpenReadStream()),
                };

                var uploadResult = await _cloudinary.UploadAsync(uploadParams); 

                uploadedImageUrls.Add(uploadResult.SecureUrl.ToString()); 
            }

            foreach (var imageUrl in uploadedImageUrls)
            {
                var imageEntity = new Images 
                {
                    ID = Guid.NewGuid(),
                    Path = imageUrl, 
                    CreateDate = DateTime.Now,
                    CreateBy = request.CreateBy,
                    IDProductDetails = request.IDProductDetails,
                    Status = request.Status
                };

                _dbcontext.Images.Add(imageEntity);
            }

            await _dbcontext.SaveChangesAsync();

            return uploadedImageUrls;
        }


        public Task<List<ImageVM>> GetAllActiveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<ImageVM>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ImageVM> GetByIDAsync(Guid ID)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(Guid ID, string IDUserDelete)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Guid ID, ImageUpdateVM request)
        {
            throw new NotImplementedException();
        }
    }
}
