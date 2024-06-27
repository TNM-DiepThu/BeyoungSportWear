using BusinessLogicLayer.Services.Implements;
using BusinessLogicLayer.Services.Interface;
using BusinessLogicLayer.Viewmodels.ApplicationUser;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExternalInterfaceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private readonly IApplicationUserService _IUserService;
        public ApplicationUserController(IApplicationUserService userService)
        {
            _IUserService = userService;
        }

        [HttpGet("GetInformationUser/{ID}")]
        public async Task<ActionResult<UserDataVM>> GetInformationUser(string ID)
        {
            var user = await _IUserService.GetInformationByID(ID);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }
        [HttpGet]
        [Route("GetAllInformationUserAsync")]
        public async Task<IActionResult> GetAllInformationUserAsync()
        {
            var objCollection = await _IUserService.GetAllInformationAsync();

            return Ok(objCollection);
        }
        [HttpPut]
        [Route("UpdateUser/{ID}")]
        public async Task<IActionResult> UpdateUser( string ID, [FromForm] UserUpdateVM userUpdateVM)
        {
            var result = await _IUserService.UpdateUserAsync(ID, userUpdateVM);
            if (!result)
            {
                return BadRequest("Cập nhật thông tin người dùng thất bại.");
            }
            return Ok("Cập nhật thông tin người dùng thành công.");
        }
        [HttpGet]
        [Route("GetAllActiveInformationUserAsync")]
        public async Task<IActionResult> GetAllActiveInformationUserAsync()
        {
            var objCollection = await _IUserService.GetAllActiveInformationAsync();

            return Ok(objCollection);
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
                role = response.Roles.FirstOrDefault()
            });
        }
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromForm] RegisterUser registerUser, string role)
        {

            var result = await _IUserService.RegisterAsync(registerUser, role);
            if (result.IsSuccess)
            {
                return Ok(new { status = "Success", message = "Successfully." });
            }
            else
            {
                return BadRequest("Có lỗi trong quá trình thực hiện.");
            }
        }
        [HttpDelete("{ID}/{IDUserDelete}")]
        public async Task<IActionResult> Remove(string ID, string IDUserDelete)
        {
            var success = await _IUserService.RemoveAsync(ID, IDUserDelete);
            if (success)
            {
                return NoContent();
            }
            return Ok(new { status = "Success", message = "Successfully." });
        }

        [HttpGet("GetUsersByEmail")]
        public async Task<IActionResult> GetUsersByEmail([FromQuery] string email)
        {
            var users = await _IUserService.GetUsersByEmailAsync(email);
            return Ok(users);
        }
        [HttpGet("GetUsersByPhoneNumber")]
        public async Task<IActionResult> GetUsersByPhoneNumber([FromQuery] string phoneNumber)
        {
            var users = await _IUserService.GetUsersByPhoneNumberAsync(phoneNumber);
            return Ok(users);
        }
        [HttpGet("GetUsersByStatus")]
        public async Task<IActionResult> GetUsersByStatus([FromQuery] int status)
        {
            var users = await _IUserService.GetUsersByStatusAsync(status);
            return Ok(users);
        }
        [HttpGet("GetUsersByName")]
        public async Task<IActionResult> GetUsersByName([FromQuery] string name)
        {
            var users = await _IUserService.GetUsersByNameAsync(name);
            return Ok(users);
        }
    }
}
