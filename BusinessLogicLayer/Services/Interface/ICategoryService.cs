using BusinessLogicLayer.Viewmodels.Category;

namespace BusinessLogicLayer.Services.Interface
{
    public interface ICategoryService
    {
        public Task<List<CategoryVM>> GetAllAsync();
        public Task<List<CategoryVM>> GetAllActiveAsync();
        public Task<CategoryVM> GetByIDAsync(Guid ID);
        public Task<bool> CreateAsync(CategoryCreateVM request);
        public Task<bool> RemoveAsync(Guid ID, string IDUserDelete);
        public Task<bool> UpdateAsync(Guid ID, CategoryUpdateVM request);
    }
}
