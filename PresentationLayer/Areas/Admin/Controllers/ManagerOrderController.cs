using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("admin")]

    public class ManagerOrderController : Controller
    {
        [HttpGet("home/index_order")]

        public async Task<IActionResult> Index()
        {
            return View();
        }
        [HttpGet("managercreate_order")]
        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}
