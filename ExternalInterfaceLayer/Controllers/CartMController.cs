using BusinessLogicLayer.Services.Implements;
using BusinessLogicLayer.Services.Interface;
using BusinessLogicLayer.Viewmodels.ViewKH;
using Microsoft.AspNetCore.Mvc;

namespace ExternalInterfaceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartMController : ControllerBase
    {
        private readonly ICartServieceM _cart;
        private readonly ICartService _ICartService;
        public CartMController(ICartServieceM cartServieceM, ICartService iCartService)
        {
            _cart = cartServieceM;
            _ICartService = iCartService;
        }
        [HttpPost]
        [Route("AddToCart")]
        public async Task<IActionResult> CreateCart([FromBody] CartMVM cartVM)
        {
            try
            {
                var result = await _cart.CreatCart(cartVM);
                if (result)
                {
                    return Ok(new { message = "Cart created successfully." });
                }
                else
                {
                    return StatusCode(500, "An error occurred while creating the cart.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("GetAllCart")]
        public async Task<IActionResult> GetAll()
        {
            var classifies = await _ICartService.GetAllAsync();
            return Ok(classifies);
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllCartDetail()
        {
            var get = _cart.GetAll();
            return Ok(get);
        }

        [HttpGet]
        [Route("GetCart/{id}")]
        public async Task<IActionResult> GetAllCart(Guid id)
        {
            var cartDetails = await _cart.GetAllProductDetails(id);

            if (cartDetails == null || !cartDetails.Any())
            {
                return NotFound();
            }

            return Ok(cartDetails);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, int quantity)
        {

            var reponse = await _cart.UpdateCartItemQuantity(id,quantity );
            return Ok(reponse);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<IActionResult> Del(Guid id)
        {
            var reponse = await _cart.RemoveCartItem(id);
            return Ok(reponse);
        }
    }
}
