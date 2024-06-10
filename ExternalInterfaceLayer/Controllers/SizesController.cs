using BusinessLogicLayer.Services.Interface;
using BusinessLogicLayer.Viewmodels.Sizes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExternalInterfaceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizesController : ControllerBase
    {
        private readonly ISizeService _ISizesService;

        public SizesController(ISizeService ISizesService)
        {
            _ISizesService = ISizesService;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var materials = await _ISizesService.GetAllAsync();
            return Ok(materials);
        }
        [HttpGet]
        [Route("GetAllActive")]
        public async Task<IActionResult> GetAllActive()
        {
            var materials = await _ISizesService.GetAllActiveAsync();
            return Ok(materials);
        }
        [HttpGet]
        [Route("GetByID/{ID}")]
        public async Task<IActionResult> GetByID(Guid ID)
        {
            var material = await _ISizesService.GetByIDAsync(ID);
            if (material == null)
            {
                return NotFound();
            }
            return Ok(material);
        }
        [HttpPost]
        [Route("SizesCreate")]
        public async Task<IActionResult> Create(SizeCreateVM request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var success = await _ISizesService.CreateAsync(request);
            if (success)
            {
                return Ok(new { status = "Success", message = "Successfully." });
            }
            return BadRequest("Failed to create Sizes");
        }
        [HttpPut]
        [Route("SizesUpdate/{ID}")]
        public async Task<IActionResult> Update(Guid ID, SizeUpdateVM request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var success = await _ISizesService.UpdateAsync(ID, request);
            if (success)
            {
                return Ok(new { status = "Success", message = "Successfully." });
            }
            return BadRequest("Failed to update Sizes");
        }
        [HttpDelete("SizeRemove/{ID}/{IDUserDelete}")]
        public async Task<IActionResult> Remove(Guid ID, string IDUserDelete)
        {
            var success = await _ISizesService.RemoveAsync(ID, IDUserDelete);
            if (success)
            {
                return Ok(new { status = "Success", message = "Successfully." });
            }
            return NotFound();
        }
    }
}
