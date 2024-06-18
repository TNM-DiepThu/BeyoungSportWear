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
using BusinessLogicLayer.Viewmodels.Brand;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin")]
    public class BrandsController : Controller
    {
        [HttpGet("brand/index")]
        public async Task<IActionResult> Index()
        {
            string requestURL = "https://localhost:7241/api/Brand/GetAll";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var brands = JsonConvert.DeserializeObject<List<Brand>>(apiData);
            return View(brands);
        }
        [HttpGet("brand/create")]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost("brand/create")]
        public async Task<IActionResult> Create(BrandCreateVM brand)
        {
            string requestURL = "https://localhost:7241/api/Brand/BrandCreate";
            var httpClient = new HttpClient();
            var response = await httpClient.PostAsJsonAsync(requestURL, brand);
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


        [HttpGet("brand/details/{id}")]
        public async Task<IActionResult> Details(Guid id)
        {
            string requestURL = $"https://localhost:7241/api/Brand/GetByID/{id}";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var brand = JsonConvert.DeserializeObject<Brand>(apiData);
            return View(brand);
        }

        [HttpGet("brand/edit/{ID}")]
        public async Task<IActionResult> Edit(Guid ID)
        {
            string requestURL = $"https://localhost:7241/api/Brand/GetByID/{ID}";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var brand = JsonConvert.DeserializeObject<Brand>(apiData);
            return View(brand);
        }

        [HttpPost("brand/edit/{ID}")]
        public async Task<IActionResult> Edit(Guid ID, BrandUpdateVM brand)
        {
            string requestURL = $"https://localhost:7241/api/Brand/BrandUpdate/{ID}";
            var httpClient = new HttpClient();

            var response = await httpClient.PutAsJsonAsync(requestURL, brand);
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

        [HttpDelete("brand/delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            string requestURL = $"https://localhost:7241/api/Brand/BrandRemove/{id}";
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
