using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Application;
using DataAccessLayer.Entity;
using BusinessLogicLayer.Viewmodels.Material;
using Newtonsoft.Json;
using BusinessLogicLayer.Viewmodels.Manufacturer;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin")]
    public class ManufacturersController : Controller
    {
        [HttpGet("manufacturer/index")]
        public async Task<IActionResult> Index()
        {
            string requestURL = "https://localhost:7241/api/Manufacturer/GetAll";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var colors = JsonConvert.DeserializeObject<List<Manufacturer>>(apiData);
            return View(colors);
        }
        [HttpGet("manufacturer/create")]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost("manufacturer/create")]
        public async Task<IActionResult> Create(ManufacturerCreateVM manufacturer)
        {
            string requestURL = "https://localhost:7241/api/Manufacturer/ManufacturerCreate";
            var httpClient = new HttpClient();
            var response = await httpClient.PostAsJsonAsync(requestURL, manufacturer);
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


        [HttpGet("manufacturer/details/{id}")]
        public async Task<IActionResult> Details(Guid id)
        {
            string requestURL = $"https://localhost:7241/api/Manufacturer/GetByID/{id}";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var material = JsonConvert.DeserializeObject<Manufacturer>(apiData);
            return View(material);
        }

        [HttpGet("manufacturer/edit/{ID}")]
        public async Task<IActionResult> Edit(Guid ID)
        {
            string requestURL = $"https://localhost:7241/api/Manufacturer/GetByID/{ID}";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var material = JsonConvert.DeserializeObject<Material>(apiData);
            return View(material);
        }

        [HttpPost("manufacturer/edit/{ID}")]
        public async Task<IActionResult> Edit(Guid ID, ManufacturerUpdateVM manufacturer)
        {
            string requestURL = $"https://localhost:7241/api/Manufacturer/ManufacturerUpdate/{ID}";
            var httpClient = new HttpClient();

            var response = await httpClient.PutAsJsonAsync(requestURL, manufacturer);
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

        [HttpDelete("manufacturer/delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            string requestURL = $"https://localhost:7241/api/Manufacturer/ManufacturerRemove/{id}";
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
