using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("admin")]

    public class SalesAtTheCounterController : Controller
    {
        [HttpGet("home/SalesAtTheCounter")]

        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
