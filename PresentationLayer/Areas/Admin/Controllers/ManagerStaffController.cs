using BusinessLogicLayer.Viewmodels.ApplicationUser;
using BusinessLogicLayer.Viewmodels.Colors;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    public class ManagerStaffController : Controller
    {
        HttpClient _httpclient;
        public ManagerStaffController()
        {
            _httpclient = new HttpClient();
            _httpclient.DefaultRequestHeaders.Add("token", "55a7ce93-3111-11ef-8e53-0a00184fe694");
        }

        [HttpGet("home/index_staff")]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet("home/index_staff/create")]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost("home/index_staff/create")]
        public async Task<IActionResult> Create(RegisterUser user, string role)
        {
            string requestURL = $"https://localhost:7241/api/ApplicationUser/Register?role={role}";
            var httpClient = new HttpClient();
            var response = await httpClient.PostAsJsonAsync(requestURL, user);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                // Log the error message or inspect it for further details
                return BadRequest($"Server returned error: {errorMessage}");
            }
        }

        //Ảnh, họ tên, ngày sinh, giới tính, SĐT, địa chỉ (nhiều) - API - mặc định.
    }
}
