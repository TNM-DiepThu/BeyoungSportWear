using BusinessLogicLayer.Viewmodels.Order;
using BusinessLogicLayer.Viewmodels.OrderDetails;
using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Interface
{
    public interface IOrderService
    {
        public Task<List<OrderVM>> GetAllAsync();
        public Task<List<OrderVM>> GetAllActiveAsync();
        public Task<OrderVM> GetByIDAsync(Guid ID);
        public Task<OrderVM> GetByHexCodeAsync(string HexCode);
        public Task<List<OrderDetailsVM>> GetOrderDetailsVMByIDAsync(Guid IDOrder);
        public Task<bool> CreateAsync(OrderCreateVM request);
        public Task<bool> RemoveAsync(Guid ID, string IDUserdelete);
        public Task<bool> UpdateAsync(Guid ID, OrderUpdateVM request);
        public Task<List<OrderVM>> GetByCustomerIDAsync(string IDUser);
    }
}
