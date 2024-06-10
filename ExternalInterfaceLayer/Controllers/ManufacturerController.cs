using BusinessLogicLayer.Services.Interface;
using BusinessLogicLayer.Viewmodels.Brand;
using BusinessLogicLayer.Viewmodels.Manufacturer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExternalInterfaceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturerService _IManufacturerService;

        public ManufacturerController(IManufacturerService IManufacturerService)
        {
            _IManufacturerService = IManufacturerService;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var obj = await _IManufacturerService.GetAllAsync();
            return Ok(obj);
        }
        [HttpGet]
        [Route("GetAllActive")]
        public async Task<IActionResult> GetAllActive()
        {
            var obj = await _IManufacturerService.GetAllActiveAsync();
            return Ok(obj);
        }
        [HttpGet]
        [Route("GetByID/{ID}")]
        public async Task<IActionResult> GetByID(Guid ID)
        {
            var obj = await _IManufacturerService.GetByIDAsync(ID);
            if (obj == null)
            {
                return NotFound();
            }
            return Ok(obj);
        }
        [HttpPost]
        [Route("ManufacturerCreate")]
        public async Task<IActionResult> Create(ManufacturerCreateVM request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _IManufacturerService.CreateAsync(request);
            if (obj)
            {
                return Ok(new { status = "Success", message = "Successfully." });
            }
            return BadRequest("Failed to create Manufacturer");
        }
        [HttpPut]
        [Route("ManufacturerUpdate/{ID}")]
        public async Task<IActionResult> Update(Guid ID, ManufacturerUpdateVM request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _IManufacturerService.UpdateAsync(ID, request);
            if (obj)
            {
                return Ok(new { status = "Success", message = "Successfully." });
            }
            return BadRequest("Failed to update Manufacturer");
        }
        [HttpDelete("ManufacturerRemove/{ID}/{IDUserDelete}")]
        public async Task<IActionResult> Remove(Guid ID, string IDUserDelete)
        {
            var obj = await _IManufacturerService.RemoveAsync(ID, IDUserDelete);
            if (obj)
            {
                return Ok(new { status = "Success", message = "Successfully." });
            }
            return NotFound();
        }
    }
}
