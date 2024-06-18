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
using BusinessLogicLayer.Viewmodels.Material;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin")]
    public class MaterialsController : Controller
    {
        [HttpGet("material/index")]
        public async Task<IActionResult> Index()
        {
            string requestURL = "https://localhost:7241/api/Material/GetAll";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var colors = JsonConvert.DeserializeObject<List<Material>>(apiData);
            return View(colors);
        }
        [HttpGet("material/create")]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost("material/create")]
        public async Task<IActionResult> Create(MaterialCreateVM material)
        {
            string requestURL = "https://localhost:7241/api/Material/MaterialCreate";
            var httpClient = new HttpClient();
            var response = await httpClient.PostAsJsonAsync(requestURL, material);
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


        [HttpGet("material/details/{id}")]
        public async Task<IActionResult> Details(Guid id)
        {
            string requestURL = $"https://localhost:7241/api/Material/GetByID/{id}";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var material = JsonConvert.DeserializeObject<Material>(apiData);
            return View(material);
        }

        [HttpGet("material/edit/{ID}")]
        public async Task<IActionResult> Edit(Guid ID)
        {
            string requestURL = $"https://localhost:7241/api/Material/GetByID/{ID}";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var material = JsonConvert.DeserializeObject<Material>(apiData);
            return View(material);
        }

        [HttpPost("material/edit/{ID}")]
        public async Task<IActionResult> Edit(Guid ID, MaterialUpdateVM colors)
        {
            string requestURL = $"https://localhost:7241/api/Material/MaterialUpdate/{ID}";
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

        [HttpDelete("material/delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            string requestURL = $"https://localhost:7241/api/Material/MaterialRemove/{id}";
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
