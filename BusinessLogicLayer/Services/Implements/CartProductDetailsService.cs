using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessLogicLayer.Services.Interface;
using BusinessLogicLayer.Viewmodels.Cart;
using BusinessLogicLayer.Viewmodels.CartProductDetails;
using DataAccessLayer.Application;
using DataAccessLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Implements
{
    public class CartProductDetailsService : ICartProductDetailsService
    {
        private readonly ApplicationDBContext _dbcontext;
        private readonly IMapper _mapper;
        public CartProductDetailsService(ApplicationDBContext ApplicationDBContext, IMapper mapper)
        {
            _dbcontext = ApplicationDBContext;
            _mapper = mapper;
        }
        public async Task<bool> CreateAsync(CartProductDetailsCreateVM request)
        {
            var productdetails = await _dbcontext.ProductDetails.FirstOrDefaultAsync(c => c.ID == request.IDProductDetails);
            var cart = await _dbcontext.Cart.FirstOrDefaultAsync(c => c.ID == request.IDCart);
            if (productdetails == null)
            {
                var cartproductdetails = new CartProductDetails
                {
                    IDCart = cart.ID,
                    IDProductDetails = productdetails.ID,
                    CreateBy = request.CreateBy,
                    CreateDate = DateTime.Now,
                    Status = 1
                };
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<CartProductDetailsVM>> GetAllActiveAsync()
        {
            var Obj = await _dbcontext.CartProductDetails
                         .Where(c => c.Status == 1)
                         .ProjectTo<CartProductDetailsVM>(_mapper.ConfigurationProvider)
                         .ToListAsync();

            return Obj;
        }

        public async Task<List<CartProductDetailsVM>> GetAllAsync()
        {
            var Obj = await _dbcontext.CartProductDetails
                         .ProjectTo<CartProductDetailsVM>(_mapper.ConfigurationProvider)
                         .ToListAsync();

            return Obj;
        }

        public Task<List<CartProductDetailsVM>> GetAllByCartIDAsync(Guid IDCart)
        {
            throw new NotImplementedException();
        }
     
        public async Task<CartProductDetailsVM> GetByIDAsync(Guid IDCart, Guid? IDProductDetails)
        {
            var Obj = await _dbcontext.CartProductDetails
                          .Where(c => c.IDCart == IDCart && c.IDProductDetails == IDProductDetails)
                          .FirstOrDefaultAsync();

            if (Obj == null)
            {
                return null; 
            }

            var ObjVm = _mapper.Map<CartProductDetailsVM>(Obj);
            return ObjVm;
        }

        public async Task<bool> RemoveAsync(Guid IDCart, Guid? IDProductDetails)
        {
            try
            {
                var cartItem = await _dbcontext.CartProductDetails
                    .FirstOrDefaultAsync(c => c.IDProductDetails == IDCart && c.IDProductDetails == IDProductDetails);

                if (cartItem != null)
                {
                    _dbcontext.CartProductDetails.Remove(cartItem);
                    await _dbcontext.SaveChangesAsync(); 

                    return true;
                }
                else
                {
                    return false; 
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Task<bool> UpdateAsync(Guid IDCart, Guid? IDProductDetails, CartProductDetailsUpdateVM request)
        {
            throw new NotImplementedException();
        }
    }
}
