using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Application;
using DataAccessLayer.Entity;
using BusinessLogicLayer.Viewmodels.Colors;
using Newtonsoft.Json;
using BusinessLogicLayer.Viewmodels.Sizes;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    public class SizeController : Controller
    {
        [HttpGet("size/index")]
        public async Task<IActionResult> Index()
        {
            string requestURL = "https://localhost:7241/api/Sizes/GetAll";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var sizes = JsonConvert.DeserializeObject<List<Sizes>>(apiData);
            return View(sizes);
        }
        [HttpGet("size/create")]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost("size/create")]
        public async Task<IActionResult> Create(SizeCreateVM size)
        {
            string requestURL = "https://localhost:7241/api/Sizes/SizesCreate";
            var httpClient = new HttpClient();
            var response = await httpClient.PostAsJsonAsync(requestURL, size);
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


        [HttpGet("size/details/{id}")]
        public async Task<IActionResult> Details(Guid id)
        {
            string requestURL = $"https://localhost:7241/api/Sizes/GetByID/{id}";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var sizes = JsonConvert.DeserializeObject<Sizes>(apiData);
            return View(sizes);
        }

        [HttpGet("size/edit/{id}")]
        public async Task<IActionResult> Edit(Guid id)
        {
            string requestURL = $"https://localhost:7241/api/Sizes/GetByID/{id}";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var sizes = JsonConvert.DeserializeObject<Sizes>(apiData);
            return View(sizes);
        }

        [HttpPut("size/edit/{id}")]
        public async Task<IActionResult> Edit(Guid id, SizeUpdateVM size)
        {
            string requestURL = $"https://localhost:7241/api/Sizes/SizesUpdate/{id}";
            var httpClient = new HttpClient();
            var response = await httpClient.PostAsJsonAsync(requestURL, size);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("size/delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            string requestURL = $"https://localhost:7241/api/Sizes/SizeRemove/{id}";
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
