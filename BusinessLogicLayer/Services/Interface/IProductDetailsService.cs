
using BusinessLogicLayer.Viewmodels.Options;
using BusinessLogicLayer.Viewmodels.ProductDetails;

namespace BusinessLogicLayer.Services.Interface
{
    public interface IProductDetailsService
    {
        public Task<List<ProductDetailsVM>> GetAllAsync();
        public Task<List<ProductDetailsVM>> GetAllActiveAsync();
        public Task<ProductDetailsVM> GetByIDAsync(Guid ID);
        public Task<List<OptionsVM>> GetOptionProductDetailsByIDAsync(Guid IDProductDetails);
        public Task<bool> CreateAsync(ProductDetailsCreateVM request);
        public Task<bool> RemoveAsync(Guid ID, string IDUserDelete);
        public Task<bool> UpdateAsync(Guid ID, ProductDetailsUpdateVM request);
    }
}
