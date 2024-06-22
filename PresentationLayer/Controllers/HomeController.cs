using BusinessLogicLayer.Viewmodels.ViewKH;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PresentationLayer.Models;
using System.Diagnostics;
using System.Net.Http;

namespace PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly HttpClient _httpClient;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory,HttpClient httpClient)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
            _httpClient = httpClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AboutView()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public async Task<IActionResult> ListProduct(int a = 0)
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient();
                var apiUrl = $"https://localhost:7241/api/IViewKH/GetNameUp)/{a}";
                var response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {

                    var products = await response.Content.ReadFromJsonAsync<List<ProductVKH>>();
                    return View(products);
                }
                else
                {
                    _logger.LogError($"Không lấy được danh sách sản phẩm. Mã trạng thái: {response.StatusCode}");
                    return StatusCode((int)response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception occurred: {ex.Message}");
                return StatusCode(500); // Trả về lỗi 500 nếu có lỗi xảy ra
            }
        }
        public async Task<IActionResult> Test(int a = 0)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var apiUrl = $"https://localhost:7241/api/IViewKH/GetNameUp)/{a}";
            var response = await httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                
                var products = await response.Content.ReadFromJsonAsync<List<ProductVKH>>();
                return View(products); 
            }
            else
            {
                _logger.LogError($"Không lấy được danh sách sản phẩm. Mã trạng thái: {response.StatusCode}");
                return StatusCode((int)response.StatusCode);
            }
        }
        public async Task<IActionResult> ProductDetail(Guid id)
        {
            var apiUrl = $"https://localhost:7241/api/IViewKH/GetProDetail/{id}";
            var response = await _httpClient.GetAsync(apiUrl);

            if (!response.IsSuccessStatusCode)
            {
                return NotFound(new { Message = "Product not found." });
            }

            var jsonString = await response.Content.ReadAsStringAsync();
            var productDetail = JsonConvert.DeserializeObject<ProDetailKH>(jsonString);

            return View(productDetail);
            
        }
        public async Task<IActionResult> GetAllNameUp() 
        {
            return View();
        }  
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
