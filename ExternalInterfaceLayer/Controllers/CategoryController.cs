using BusinessLogicLayer.Services.Interface;
using BusinessLogicLayer.Viewmodels.Category;
using BusinessLogicLayer.Viewmodels.Material;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExternalInterfaceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _ICategoryService;

        public CategoryController(ICategoryService ICategoryService)
        {
            _ICategoryService = ICategoryService;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var obj = await _ICategoryService.GetAllAsync();
            return Ok(obj);
        }
        [HttpGet]
        [Route("GetAllActive")]
        public async Task<IActionResult> GetAllActive()
        {
            var obj = await _ICategoryService.GetAllActiveAsync();
            return Ok(obj);
        }
        [HttpGet]
        [Route("GetByID/{ID}")]
        public async Task<IActionResult> GetByID(Guid ID)
        {
            var obj = await _ICategoryService.GetByIDAsync(ID);
            if (obj == null)
            {
                return NotFound();
            }
            return Ok(obj);
        }
        [HttpPost]
        [Route("CategoryCreate")]
        public async Task<IActionResult> Create(CategoryCreateVM request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _ICategoryService.CreateAsync(request);
            if (obj)
            {
                return Ok(new { status = "Success", message = "Successfully." });
            }
            return BadRequest("Failed to create");
        }
        [HttpPut]
        [Route("CategoryUpdate/{ID}")]
        public async Task<IActionResult> Update(Guid ID, CategoryUpdateVM request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _ICategoryService.UpdateAsync(ID, request);
            if (obj)
            {
                return Ok("Successful action.");
            }
            return BadRequest("Failed to update");
        }
        [HttpDelete("CategoryRemove/{ID}/{IDUserDelete}")]
        public async Task<IActionResult> Remove(Guid ID, string IDUserDelete)
        {
            var obj = await _ICategoryService.RemoveAsync(ID, IDUserDelete);
            if (obj)
            {
                return Ok(new { status = "Success", message = "Successfully." });
            }
            return NotFound();
        }
    }
}
