using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    public class HomeController : Controller
    {
        [HttpGet("home/login")]
        public async Task<IActionResult> Login()
        {
            return View();
        }
        [HttpGet("home/index")]
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
