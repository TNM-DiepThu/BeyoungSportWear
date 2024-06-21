using BusinessLogicLayer.Services.Implements;
using BusinessLogicLayer.Services.Interface;
using BusinessLogicLayer.Viewmodels.ApplicationUser;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExternalInterfaceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IViewKHController : ControllerBase
    {
        private readonly IApplicationUserService _IUserService;
        private readonly IViewKHServiece _viewKHServiece;
        public IViewKHController(IApplicationUserService userService, IViewKHServiece viewKHServiece)
        {
            _IUserService = userService;
            _viewKHServiece = viewKHServiece;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] UserLoginModel model)
        {
            var response = await _IUserService.Login(model);

            if (!response.IsSuccess)
            {
                return Unauthorized(response.Message);
            }

            return Ok(new
            {
                token = response.Token,
                role = response.Roles.FirstOrDefault() // Sử dụng Roles từ phản hồi
            });
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> GetAll()
        {
            var products = await _viewKHServiece.GetAll();
            return Ok(products);
        }

        [HttpGet("GetProDetail/{id}")]
        public async Task<IActionResult> GetProDetail(Guid id)
        {
            try
            {
                var productDetail = await _viewKHServiece.GetProDetail(id);
                return Ok(productDetail);
            }
            catch (Exception ex)
            {
                return NotFound(new { Message = ex.Message });
            }
        }
    }
}
