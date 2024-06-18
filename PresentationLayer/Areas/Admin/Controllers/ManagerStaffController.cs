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
        [HttpGet("home/index_staff")]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet("staff/create")]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost("staff/create")]
        public async Task<IActionResult> Create(ColorCreateVM colors)
        {
            string requestURL = "https://localhost:7241/api/Colors/ColorsCreate";
            var httpClient = new HttpClient();
            var response = await httpClient.PostAsJsonAsync(requestURL, colors);
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


        [HttpGet("staff/details/{id}")]
        public async Task<IActionResult> Details(Guid id)
        {
            string requestURL = $"https://localhost:7241/api/Colors/GetByID/{id}";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var colors = JsonConvert.DeserializeObject<Colors>(apiData);
            return View(colors);
        }

        [HttpGet("staff/edit/{id}")]
        public async Task<IActionResult> Edit(Guid id)
        {
            string requestURL = $"https://localhost:7241/api/Colors/GetByID/{id}";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var colors = JsonConvert.DeserializeObject<Colors>(apiData);
            return View(colors);
        }

        [HttpPut("staff/edit/{id}")]
        public async Task<IActionResult> Edit(Guid id, ColorUpdateVM colors)
        {
            string requestURL = $"https://localhost:7241/api/Colors/ColorsUpdate/{id}";
            var httpClient = new HttpClient();
            var response = await httpClient.PostAsJsonAsync(requestURL, colors);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("staff/delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            string requestURL = $"https://localhost:7241/api/Colors/ColorsRemove/{id}";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestURL);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
