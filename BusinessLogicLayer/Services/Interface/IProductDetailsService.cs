
using BusinessLogicLayer.Viewmodels;
using BusinessLogicLayer.Viewmodels.Brand;
using BusinessLogicLayer.Viewmodels.Manufacturer;
using BusinessLogicLayer.Viewmodels.Material;
using BusinessLogicLayer.Viewmodels.Options;
using BusinessLogicLayer.Viewmodels.ProductDetails;
using DataAccessLayer.Entity;
using static DataAccessLayer.Entity.Base.EnumBase;

namespace BusinessLogicLayer.Services.Interface
{
    public interface IProductDetailsService
    {
        public Task<List<ProductDetailsVM>> GetAllAsync();
        public Task<List<ProductDetailsVM>> GetAllActiveAsync();
        public Task<ProductDetailsVM> GetByIDAsync(Guid ID);
        public Task<List<OptionsVM>> GetOptionProductDetailsByIDAsync(Guid IDProductDetails);
        public Task<bool> CreateAsync(ProductDetailsCreateVM request);
        public Task<bool> CreateSingle(ProductDetailsSingleCreateVM request);
        public Task<bool> RemoveAsync(Guid ID, string IDUserDelete);
        public Task<bool> UpdateAsync(Guid ID, ProductDetailsUpdateVM request);
        IQueryable<ProductDetailsVM> Search(List<SearchCondition> conditions);
    }
}
