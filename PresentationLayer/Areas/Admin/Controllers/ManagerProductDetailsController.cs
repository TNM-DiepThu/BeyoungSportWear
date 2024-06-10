using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("admin")]

    public class ManagerProductDetailsController : Controller
    {
        [HttpGet("home/index_productdetails")]
        public async Task<IActionResult> Index()
        {
            return View();
        }
        [HttpGet("create_productdetails")]
        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}
