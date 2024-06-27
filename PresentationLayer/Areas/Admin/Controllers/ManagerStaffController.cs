using BusinessLogicLayer.Viewmodels.Address;
using BusinessLogicLayer.Viewmodels.ApplicationUser;
using BusinessLogicLayer.Viewmodels.Colors;
using BusinessLogicLayer.Viewmodels.Manufacturer;
using DataAccessLayer.Entity;
using ExternalInterfaceLayer.Controllers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

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
            string requestURL = "https://localhost:7241/api/ApplicationUser/GetAllInformationUserAsync";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var users = JsonConvert.DeserializeObject<List<ApplicationUser>>(apiData);
            return View(users);
        }

        [HttpGet("home/index_staff/create")]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost("home/index_staff/create")]
        public async Task<IActionResult> Create(RegisterUser registerUser, string role)
        {
            role = "Staff";
            string requestURL = $"https://localhost:7241/api/ApplicationUser/Register?role={role}";
            var httpClient = new HttpClient();
            var response = await httpClient.PostAsJsonAsync(requestURL, registerUser);
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
        private async Task<List<Address>> GetProvincesAsync()
        {
            var response = await _httpclient.GetAsync("/api/AddressApi/provinces");
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Address>>(data);
        }

        private async Task<List<Address>> GetDistrictsAsync(string provinceID)
        {
            var response = await _httpclient.GetAsync($"/api/AddressApi/districts?provinceID={provinceID}");
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Address>>(data);
        }

        private async Task<List<Address>> GetWardsAsync(string districtID)
        {
            var response = await _httpclient.GetAsync($"/api/AddressApi/wards?districtID={districtID}");
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Address>>(data);
        }

        //public static string GenerateRandomPassword(int length)
        //{
        //    const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";
        //    StringBuilder password = new StringBuilder();
        //    Random random = new Random();

        //    while (0 < length--)
        //    {
        //        password.Append(validChars[random.Next(validChars.Length)]);
        //    }

        //    return password.ToString();
        //}
        //Ảnh, họ tên, ngày sinh, giới tính, SĐT, địa chỉ (nhiều) - API - mặc định.
    }
}
