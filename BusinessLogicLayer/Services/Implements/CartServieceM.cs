using AutoMapper;
using BusinessLogicLayer.Services.Interface;
using BusinessLogicLayer.Viewmodels.ViewKH;
using DataAccessLayer.Application;
using DataAccessLayer.Entity;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogicLayer.Services.Implements
{
    public class CartServieceM : ICartServieceM
    {
        private readonly ApplicationDBContext _dbcontext;
        private readonly IMapper _mapper;
        public CartServieceM(ApplicationDBContext dbContext, IMapper mapper)
        {
            _dbcontext = dbContext;
            _mapper = mapper;
        }

        public async Task<bool> CreatCart(CartMVM p)
        {
            try
            {
                var existingCart = await _dbcontext.Cart
                    .Include(c => c.CartProductDetails)
                    .FirstOrDefaultAsync(c => c.IDUser == p.IDUser);

                if (existingCart != null)
                {

                    foreach (var detailsViewModel in p.CartProductDetails)
                    {
                        var existingProductDetail = existingCart.CartProductDetails
                            .FirstOrDefault(d => d.IDProductDetails == detailsViewModel.IDProductDetails);

                        if (existingProductDetail != null)
                        {

                            existingProductDetail.Quantity += detailsViewModel.Quantity;
                        }
                        else
                        {
                            var cartProductDetail = new CartProductDetails
                            {
                                IDCart = existingCart.ID,
                                IDProductDetails = detailsViewModel.IDProductDetails,
                                Quantity = detailsViewModel.Quantity,
                                CreateBy = "admin",
                                CreateDate = DateTime.Now,
                            };
                            existingCart.CartProductDetails.Add(cartProductDetail);
                        }
                    }

                    _dbcontext.Cart.Update(existingCart);
                }
                else
                {
                    var cart = new Cart
                    {
                        ID = Guid.NewGuid(),
                        Description = p.Description,
                        IDUser = p.IDUser,
                        CreateBy = "admin",
                        CreateDate = DateTime.Now,
                        CartProductDetails = new List<CartProductDetails>()
                    };

                    foreach (var detailsViewModel in p.CartProductDetails)
                    {
                        var cartProductDetail = new CartProductDetails
                        {
                            IDCart = cart.ID,
                            IDProductDetails = detailsViewModel.IDProductDetails,
                            Quantity = detailsViewModel.Quantity,
                            CreateBy = "admin",
                            CreateDate = DateTime.Now,

                        };

                        cart.CartProductDetails.Add(cartProductDetail);
                    }

                    _dbcontext.Cart.Add(cart);
                }

                await _dbcontext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Task<List<GetCartDetailVM>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<List<GetCartDetailVM>> GetAllProductDetails(Guid id)
        {
            var cartDetails = await _dbcontext.Cart
            .Where(cart => cart.ApplicationUsers.Id == id.ToString())
            .SelectMany(cart => cart.CartProductDetails)
            .Select(cartProductDetail => new GetCartDetailVM
            {               
                IdUser = id,
                IDProductDetails = cartProductDetail.IDProductDetails,
                IdCart = cartProductDetail.IDCart,
                Quantity = cartProductDetail.Quantity,
                Name = cartProductDetail.ProductDetails.Products.Name,
                Description = cartProductDetail.ProductDetails.Description,
                Price = cartProductDetail.ProductDetails.Options.FirstOrDefault().CostPrice * cartProductDetail.Quantity,
                Url = cartProductDetail.ProductDetails.Images.FirstOrDefault().Path,
            }
            ) 
            .ToListAsync();

            return cartDetails;
        }

        public async Task<bool> UpdateCartItemQuantity(Guid id, int quantity)
        {
            try
            {
                var cartItem = await _dbcontext.CartProductDetails
            .FirstOrDefaultAsync(p => p.IDProductDetails == id);
                if (cartItem == null)
                    return false;

                cartItem.Quantity = quantity;

                _dbcontext.Update(cartItem);
                await _dbcontext.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public async Task<bool>  RemoveCartItem(Guid id)
        {
            try
            {
                var cartItem = await _dbcontext.CartProductDetails
            .FirstOrDefaultAsync(p => p.IDProductDetails == id);
                if (cartItem == null)
                    return false;

                _dbcontext.Remove(cartItem);
                await _dbcontext.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                return false;
            }
        }
    } 
}
