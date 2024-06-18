using BusinessLogicLayer.Services.Implements;
using BusinessLogicLayer.Services.Interface;
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
        [HttpGet("managercreate_productdetails")]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpGet("managerupdate_productdetails/{ID}")]
        public async Task<IActionResult> Update(Guid ID)
        {
            return View();
        }

        [HttpPost("managerupdate_productdetails/{ID}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update()
        {
            return View();
        }
    }
}
