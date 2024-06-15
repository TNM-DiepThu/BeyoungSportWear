using BusinessLogicLayer.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ManagerProductDetailsController : Controller
    {
        //private readonly IProductService _IProductService;
        //public ManagerProductDetailsController(IProductService IProductService)
        //{
        //    _IProductService = IProductService;
        //}
        [HttpGet("home/index_productdetails")]
        public async Task<IActionResult> Index()
        {
            return View();
        }
        [HttpGet("managercreate_order_productdetails")]
        public async Task<IActionResult> Create()
        {
            ViewBag.ID = Guid.NewGuid();

            return View();
        }
    }
}
