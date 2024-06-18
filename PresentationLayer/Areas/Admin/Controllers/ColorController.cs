using BusinessLogicLayer.Viewmodels.Colors;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    public class ColorController : Controller
    {
        [HttpGet("color/index")]
        public async Task<IActionResult> Index()
        {
            string requestURL = "https://localhost:7241/api/Colors/GetAll";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var colors = JsonConvert.DeserializeObject<List<Colors>>(apiData);
            return View(colors);
        }
        [HttpGet("color/create")]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost("color/create")]
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

       
        [HttpGet("color/details/{id}")]
        public async Task<IActionResult> Details(Guid id)
        {
            string requestURL = $"https://localhost:7241/api/Colors/GetByID/{id}";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var colors = JsonConvert.DeserializeObject<Colors>(apiData);
            return View(colors);
        }

        [HttpGet("color/edit/{ID}")]
        public async Task<IActionResult> Edit(Guid ID)
        {
            string requestURL = $"https://localhost:7241/api/Colors/GetByID/{ID}";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var colors = JsonConvert.DeserializeObject<Colors>(apiData);
            return View(colors);
        }

        [HttpPost("color/edit/{ID}")]
        public async Task<IActionResult> Edit(Guid ID, ColorUpdateVM colors)
        {
            string requestURL = $"https://localhost:7241/api/Colors/ColorsUpdate/{ID}";
            var httpClient = new HttpClient();
            
            var response = await httpClient.PutAsJsonAsync(requestURL, colors);
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

        [HttpDelete("color/delete/{id}")]
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
