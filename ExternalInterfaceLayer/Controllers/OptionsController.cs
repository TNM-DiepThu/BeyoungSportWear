using BusinessLogicLayer.Services.Interface;
using BusinessLogicLayer.Viewmodels.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace ExternalInterfaceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionsController : ControllerBase
    {
        private readonly IOptionsService _IOptionsService;
        public OptionsController(IOptionsService IOptionsService)
        {
            _IOptionsService = IOptionsService;
        }
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create([FromForm] OptionsCreateVM request)
        {
            if (request.ImageURL == null)
            {
                return BadRequest("No files received from the upload");
            }
            var result = await _IOptionsService.CreateAsync(request);
            if (result)
            {
                return Ok(new { status = "Success", message = "Successfully." });
            }
            else
            {
                return BadRequest(new { status = "Error", message = "There was an error uploading the Options." });
            }
        }
        
        [HttpPost]
        [Route("CreateSingle")]
        public async Task<IActionResult> CreateSingle([FromForm] OptionsCreateSingleVM request)
        {
            if (request.ImageURL == null)
            {
                return BadRequest("No files received from the upload");
            }
            var result = await _IOptionsService.CreateSingle(request);
            if (result)
            {
                return Ok(new { status = "Success", message = "Successfully." });
            }
            else
            {
                return BadRequest(new { status = "Error", message = "There was an error uploading the Options." });
            }
        }
        [HttpPut]
        [Route("update/{ID}")]
        public async Task<IActionResult> UpdateOption(Guid ID, [FromForm] OptionsUpdateVM request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _IOptionsService.UpdateAsync(ID, request);

            if (!result)
            {
                return NotFound("Option not found.");
            }

            return Ok(new { status = "Success", message = "Successfully." });
        }

        [HttpGet]
        [Route("GetProductDetailsByID/{IDOptions}")]
        public async Task<IActionResult> GetProductDetailsByID(Guid IDOptions)
        {
            var variantdata = await _IOptionsService.GetProductDetailsByID(IDOptions);
            return Ok(variantdata);
        }
        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAll()
        {
            var obj = await _IOptionsService.GetAllAsync();
            return Ok(obj);
        }

        [HttpGet]
        [Route("getallactive")]
        public async Task<IActionResult> GetAllActive()
        {
            var obj = await _IOptionsService.GetAllActiveAsync();
            return Ok(obj);
        }

        [HttpGet]
        [Route("GetByID/{ID}")]
        public async Task<IActionResult> GetByID(Guid ID)
        {
            var obj = await _IOptionsService.GetByIDAsync(ID);
            if (obj == null)
            {
                return NotFound();
            }
            return Ok(obj);
        }
    }
}
