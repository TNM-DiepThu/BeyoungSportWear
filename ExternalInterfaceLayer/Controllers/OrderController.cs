using BusinessLogicLayer.Services.Interface;
using BusinessLogicLayer.Viewmodels.Order;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExternalInterfaceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService IOrderService)
        {
            _orderService = IOrderService;
        }
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> AddAsync([FromBody] OrderCreateVM request)
        {
            if (request == null) return BadRequest();
            var result = await _orderService.CreateAsync(request);
            if (result)
            {
                return Ok(new { status = "Success", message = "Successfully." });
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("GetOrderDetailsByID/{ID_Order}")]
        public async Task<IActionResult> GetOrderDetailsByID(Guid ID_Order)
        {
            var order = await _orderService.GetOrderDetailsVMByIDAsync(ID_Order);
            if (order == null) return NotFound();
            return Ok(order);
        }
        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAllAsync()
        {
            var objCollection = await _orderService.GetAllAsync();

            return Ok(objCollection);
        }
        [HttpGet]
        [Route("allactive")]
        public async Task<IActionResult> GetAllActiveAsync()
        {
            var objCollection = await _orderService.GetAllActiveAsync();

            return Ok(objCollection);
        }
        [HttpGet("customer/{ID_User}")]
        public async Task<IActionResult> GetByCustomerID(string ID_User)
        {
            var orders = await _orderService.GetByCustomerIDAsync(ID_User);
            if (orders == null) return NotFound();
            return Ok(orders);
        }
    }
}
