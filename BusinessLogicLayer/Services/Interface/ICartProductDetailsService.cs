using BusinessLogicLayer.Viewmodels.CartProductDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Interface
{
    public interface ICartProductDetailsService
    {
        public Task<List<CartProductDetailsVM>> GetAllAsync();
        public Task<List<CartProductDetailsVM>> GetAllActiveAsync();
        public Task<CartProductDetailsVM> GetByIDAsync(Guid IDCart, Guid? IDProductDetails);
        public Task<bool> CreateAsync(CartProductDetailsCreateVM request);
        public Task<bool> RemoveAsync(Guid IDCart, Guid? IDProductDetails);
        public Task<bool> UpdateAsync(Guid IDCart, Guid? IDProductDetails, CartProductDetailsUpdateVM request);
        public Task<List<CartProductDetailsVM>> GetAllByCartIDAsync(Guid IDCart);
    }
}
