using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("admin")]

    public class ManagerStaffController : Controller
    {
        [HttpGet("home/index_staff")]
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
