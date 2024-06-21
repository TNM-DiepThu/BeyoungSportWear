using BusinessLogicLayer.Viewmodels.ViewKH;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;
using System.Diagnostics;

namespace PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
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
        public async Task<IActionResult> ListProduct()
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient();
                var response = await httpClient.GetAsync("https://localhost:7241/api/IViewKH/Get");

                if (response.IsSuccessStatusCode)
                {
                    var products = await response.Content.ReadFromJsonAsync<List<ProductVKH>>();
                    return View(products); // Trả về view với danh sách sản phẩm
                }
                else
                {
                    _logger.LogError($"Failed to retrieve products. Status code: {response.StatusCode}");
                    return StatusCode((int)response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception occurred: {ex.Message}");
                return StatusCode(500); // Trả về lỗi 500 nếu có lỗi xảy ra
            }
        }
        public async Task<IActionResult> Test()
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient();
                var response = await httpClient.GetAsync("https://localhost:7241/api/IViewKH/Get");

                if (response.IsSuccessStatusCode)
                {
                    var products = await response.Content.ReadFromJsonAsync<List<ProductVKH>>();
                    return View(products); // Trả về view với danh sách sản phẩm
                }
                else
                {
                    _logger.LogError($"Failed to retrieve products. Status code: {response.StatusCode}");
                    return StatusCode((int)response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception occurred: {ex.Message}");
                return StatusCode(500); // Trả về lỗi 500 nếu có lỗi xảy ra
            }
        }
        public IActionResult ProductDetail()
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
