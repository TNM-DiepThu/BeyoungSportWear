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

        public ImageService(ApplicationDBContext dbContext, IMapper mapper, IConfiguration configuration)
        {
            _dbcontext = dbContext;
            _mapper = mapper;

            var account = new Account(
                configuration["Cloudinary:CloudName"],
                configuration["Cloudinary:ApiKey"],
                configuration["Cloudinary:ApiSecret"]);

            _cloudinary = new Cloudinary(account);
        }
        public async Task<string> CreateAsync(ImageCreateVM request)
        {
            try
            {
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(request.Path.FileName, request.Path.OpenReadStream())
                };

                var uploadResult = await _cloudinary.UploadAsync(uploadParams);

                var imageEntity = new Images
                {
                    ID = Guid.NewGuid(),
                    IDProductDetails = request.IDProductDetails,
                    IDOptions = request.IDOptions,
                    Status = 1,
                    Path = uploadResult.SecureUrl.AbsoluteUri, 
                    CreateBy = request.CreateBy,
                    CreateDate = DateTime.Now
                };

                _dbcontext.Images.Add(imageEntity);
                await _dbcontext.SaveChangesAsync();

                return imageEntity.Path;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to upload image and save to database: {ex.Message}");
            }
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
