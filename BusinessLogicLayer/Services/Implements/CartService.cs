using AutoMapper;
using BusinessLogicLayer.Services.Interface;
using BusinessLogicLayer.Viewmodels.Cart;
using BusinessLogicLayer.Viewmodels.Sizes;
using DataAccessLayer.Application;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Implements
{
    public class CartService : ICartService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDBContext _dbcontext;
        private readonly IMapper _mapper;
        public CartService(ApplicationDBContext ApplicationDBContext, UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _dbcontext = ApplicationDBContext;
            _mapper = mapper;
            _userManager = userManager;
        }
        public async Task<bool> CreateAsync(CartCreateVM request)
        {
            var iduser = await _userManager.FindByIdAsync(request.IDUser);
            if (iduser != null)
            {
                if (request != null)
                {
                    var Obj = new Cart()
                    {
                        ID = Guid.NewGuid(),

                        Description = request.Description,
                        Status = 1,
                        CreateBy = request.CreateBy,
                        CreateDate = DateTime.Now,

                    };
                    await _dbcontext.Cart.AddRangeAsync(Obj);
                    await _dbcontext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            return false;

        }

        public async Task<List<CartVM>> GetAllActiveAsync()
        {
            var Obj = await _dbcontext.Cart.Where(b => b.Status == 1).ToListAsync();
            return _mapper.Map<List<CartVM>>(Obj);
        }

        public async Task<List<CartVM>> GetAllAsync()
        {
            var Obj = await _dbcontext.Cart.ToListAsync();
            return _mapper.Map<List<CartVM>>(Obj);
        }

        public async Task<CartVM> GetByIDAsync(Guid ID)
        {
            var Obj = await _dbcontext.Cart.FindAsync(ID);
            return _mapper.Map<CartVM>(Obj);
        }

        public Task<bool> RemoveAsync(Guid ID, string IDUserDelete)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Guid ID, CartUpdateVM request)
        {
            throw new NotImplementedException();
        }
    }
}
