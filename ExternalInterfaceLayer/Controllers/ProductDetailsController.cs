using BusinessLogicLayer.Services.Implements;
using BusinessLogicLayer.Services.Interface;
using BusinessLogicLayer.Viewmodels.Brand;
using BusinessLogicLayer.Viewmodels.Manufacturer;
using BusinessLogicLayer.Viewmodels.Material;
using BusinessLogicLayer.Viewmodels;
using BusinessLogicLayer.Viewmodels.ProductDetails;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Entity;

namespace ExternalInterfaceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        private readonly IProductDetailsService _IProductDetailsService;

        public ProductDetailsController(IProductDetailsService IProductDetailsService)
        {
            _IProductDetailsService = IProductDetailsService;
        }
        [HttpPost]
        [Route("productdetails_create")]
        public async Task<IActionResult> Create([FromBody] ProductDetailsCreateVM request)
        {
            if (request.ImagePaths == null)
            {
                return BadRequest("No files received from the upload");
            }
            var result = await _IProductDetailsService.CreateAsync(request);
            if (result)
            {
                return Ok(new { status = "Success", message = "Successfully." });
            }
            else
            {
                return BadRequest(new { status = "Error", message = "There was an error uploading the productDetails." });
            }
        }

        [HttpPost]
        [Route("productdetails_createsingle")]
        public async Task<IActionResult> CreateSingle([FromForm] ProductDetailsSingleCreateVM request)
        {
            if (request.ImagePaths == null)
            {
                return BadRequest("No files received from the upload");
            }
            var result = await _IProductDetailsService.CreateSingle(request);
            if (result)
            {
                return Ok(new { status = "Success", message = "Successfully." });
            }
            else
            {
                return BadRequest(new { status = "Error", message = "There was an error uploading the productDetails." });
            }
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var obj = await _IProductDetailsService.GetAllAsync();
            return Ok(obj);
        }

        [HttpGet]
        [Route("GetAllActive")]
        public async Task<IActionResult> GetAllActive()
        {
            var obj = await _IProductDetailsService.GetAllActiveAsync();
            return Ok(obj);
        }

        [HttpGet]
        [Route("GetByID/{ID}")]
        public async Task<IActionResult> GetByID(Guid ID)
        {
            var obj = await _IProductDetailsService.GetByIDAsync(ID);
            if (obj == null)
            {
                return NotFound();
            }
            return Ok(obj);
        }

        [HttpPut]
        [Route("Update/{ID}")]
        public async Task<IActionResult> Update(Guid ID, [FromBody] ProductDetailsUpdateVM request)
        {
            var productdetails = await _IProductDetailsService.GetByIDAsync(ID);

            if (productdetails != null)
            {
                var data = await _IProductDetailsService.UpdateAsync(ID, request);
                return Ok(data);
            }

            return NotFound();
        }

        [HttpDelete("{ID}/{IDUserDelete}")]
        public async Task<IActionResult> Remove(Guid ID, string IDUserDelete)
        {
            var success = await _IProductDetailsService.RemoveAsync(ID, IDUserDelete);
            if (success)
            {
                return Ok();
            }
            return NotFound();
        }
        [HttpPost("search")]
        public ActionResult<IEnumerable<Product>> Search([FromBody] List<SearchCondition> conditions)
        {
            var result = _IProductDetailsService.Search(conditions).ToList();

            if (result.Count == 0)
            {
                return NotFound("No products found matching the search criteria.");
            }

            return Ok(result);
        }
    }
}
