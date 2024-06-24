using BusinessLogicLayer.Viewmodels.ViewKH;
using DataAccessLayer.Entity;


namespace BusinessLogicLayer.Services.Interface
{
    public interface ICartServieceM
    {
        public Task<bool> CreatCart(CartMVM p);
        public Task<List<GetCartDetailVM>> GetAll();
        public Task<List<GetCartDetailVM>> GetAllProductDetails(Guid id);
        Task<bool> UpdateCartItemQuantity(Guid id, int quantity);
        Task<bool> RemoveCartItem(Guid id);

    }
}
