using BusinessLogicLayer.Services.Interface;
using BusinessLogicLayer.Viewmodels.Address;
using BusinessLogicLayer.Viewmodels.ApplicationUser;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text;

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
                return NotFound(); // Trả về mã lỗi 404 nếu không tìm thấy người dùng
            }

            return Ok(user); // Trả về dữ liệu người dùng dưới dạng JSON
        }
        [HttpGet]
        [Route("GetAllInformationUserAsync")]
        public async Task<IActionResult> GetAllInformationUserAsync()
        {
            var objCollection = await _IUserService.GetAllInformationAsync();

            return Ok(objCollection);
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
                role = response.Roles.FirstOrDefault() // Sử dụng Roles từ phản hồi
            });
        }
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody]RegisterUser registerUser, string role)
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
        [HttpGet("get-province")]
        public async Task<IActionResult> GetProvince()
        {
            string requestURL = "https://dev-online-gateway.ghn.vn/shiip/public-api/master-data/province";
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("token", "55a7ce93-3111-11ef-8e53-0a00184fe694");
            var response = await httpClient.GetAsync(requestURL);
            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                return Ok(responseData);
            }
            else
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                // Log the error message or inspect it for further details
                return BadRequest($"Server returned error: {errorMessage}");
            }
        }
        [HttpGet("get-district")]
        public async Task<IActionResult> GetDistrict(int provinceID)
        {
            string requestURL = $"https://dev-online-gateway.ghn.vn/shiip/public-api/master-data/district?province_id={provinceID}";
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("token", "55a7ce93-3111-11ef-8e53-0a00184fe694");
            var response = await httpClient.GetAsync(requestURL);
            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                return Ok(responseData);
            }
            else
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                // Log the error message or inspect it for further details
                return BadRequest($"Server returned error: {errorMessage}");
            }
        }
        [HttpGet("get-ward")]
        public async Task<IActionResult> GetWard(int districtID)
        {
            string requestURL = $"https://dev-online-gateway.ghn.vn/shiip/public-api/master-data/ward?district_id={districtID}";
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("token", "55a7ce93-3111-11ef-8e53-0a00184fe694");
            var response = await httpClient.GetAsync(requestURL);
            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                return Ok(responseData);
            }
            else
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                // Log the error message or inspect it for further details
                return BadRequest($"Server returned error: {errorMessage}");
            }
        }

        [HttpGet]
        [Route("get-password")]
        public async Task<string> GenerateRandomPassword(int length)
        {
            length = 10;
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            while (0 < length--)
            {
                password.Append(validChars[random.Next(validChars.Length)]);
            }

            return password.ToString();
        }
    }
}
