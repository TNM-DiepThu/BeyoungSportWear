using BusinessLogicLayer.Viewmodels.Brand;
using BusinessLogicLayer.Viewmodels.Manufacturer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Interface
{
    public interface IManufacturerService
    {
        public Task<List<ManufacturerVM>> GetAllAsync();
        public Task<List<ManufacturerVM>> GetAllActiveAsync();
        public Task<ManufacturerVM> GetByIDAsync(Guid ID);
        public Task<bool> CreateAsync(ManufacturerCreateVM request);
        public Task<bool> RemoveAsync(Guid ID, string IDUserDelete);
        public Task<bool> UpdateAsync(Guid ID, ManufacturerUpdateVM request);
    }
}
