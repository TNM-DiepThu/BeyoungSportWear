using BusinessLogicLayer.Services.Interface;
using BusinessLogicLayer.Viewmodels.CartProductDetails;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExternalInterfaceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartProductDetailsController : ControllerBase
    {
        private readonly ICartProductDetailsService _ICartProductDetailsService;

        public CartProductDetailsController(ICartProductDetailsService ICartProductDetailsService)
        {
            _ICartProductDetailsService = ICartProductDetailsService;
        }

        [HttpPost]
        [Route("AddToCart")]
        public async Task<IActionResult> AddAsync([FromBody] CartProductDetailsCreateVM request)
        {
            if (request == null) return BadRequest();
            var result = await _ICartProductDetailsService.CreateAsync(request);

            return Ok(result);
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            var objCollection = await _ICartProductDetailsService.GetAllAsync();

            return Ok(objCollection);
        }

        [HttpGet]
        [Route("GetAllActive")]
        public async Task<IActionResult> GetAllActiveAsync()
        {
            var objCollection = await _ICartProductDetailsService.GetAllActiveAsync();

            return Ok(objCollection);
        }

        [HttpGet]
        [Route("{IDCart}/{IDProductDetails}")]
        public async Task<IActionResult> GetByIdAsync(Guid IDCart, Guid? IDProductDetails)
        {
            var objVM = await _ICartProductDetailsService.GetByIDAsync(IDCart, IDProductDetails);

            return Ok(objVM);
        }

        [HttpDelete]
        [Route("{IDCart}/{IDProductDetails}")]
        public async Task<IActionResult> RemoveAsync(Guid IDCart, Guid? IDProductDetails)
        {
            var objDelete = await _ICartProductDetailsService.GetByIDAsync(IDCart, IDProductDetails);
            if (objDelete == null) return NotFound();

            var result = await _ICartProductDetailsService.RemoveAsync(IDCart, IDProductDetails);

            return Ok(result);
        }

        [HttpPut]
        [Route("{IDCart}/{IDProductDetails}")]
        public async Task<IActionResult> UpdateAsync(Guid IDCart, Guid? IDProductDetails, [FromBody] CartProductDetailsUpdateVM request)
        {
            if (request == null) return BadRequest();
            var result = await _ICartProductDetailsService.UpdateAsync(IDCart, IDProductDetails, request);

            return Ok(result);
        }

        [HttpGet]
        [Route("GetAllByCartIDAsync/{ID_Cart}")]
        public async Task<IActionResult> GetAllByCartIDAsync(Guid ID_Cart)
        {
            var objVM = await _ICartProductDetailsService.GetAllByCartIDAsync(ID_Cart);

            return Ok(objVM);
        }
    }
}
