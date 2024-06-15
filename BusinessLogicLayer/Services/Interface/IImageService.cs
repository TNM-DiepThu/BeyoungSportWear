using BusinessLogicLayer.Viewmodels.Brand;
using BusinessLogicLayer.Viewmodels.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Interface
{
    public interface IImageService
    {
        public Task<List<ImageVM>> GetAllAsync();
        public Task<List<ImageVM>> GetAllActiveAsync();
        public Task<ImageVM> GetByIDAsync(Guid ID);
        public Task<string> CreateAsync(ImageCreateVM request);
        public Task<bool> RemoveAsync(Guid ID, string IDUserDelete);
        public Task<bool> UpdateAsync(Guid ID, ImageUpdateVM request);
    }
}
