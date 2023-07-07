using Microsoft.AspNetCore.Mvc;
using shop.Application.Catalog.Orders;
using shop.Data.Enums;

namespace shop.BackEndApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderServices _orderServices;

        public OrdersController(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }

        [HttpGet("get-orders-by-status/{status}")]
        public async Task<IActionResult> GetOrdersByStatus(OrderStatus status)
        {
            var list = await _orderServices.GetOrdersByStatus(status);
            return Ok(list);
        }

        [HttpGet("get-order-details/{id}")]
        public async Task<IActionResult> GetOrderDetails(Guid id)
        {
            var list = await _orderServices.GetOrderDetails(id);
            return Ok(list);
        }

        [HttpGet("confirm-order/{id}")]
        public async Task<IActionResult> ConfirmOrder(Guid id)
        {
            var response = await _orderServices.ConfirmOrder(id);
            if (response.IsSuccessed) return Ok(response);
            return BadRequest(response.ResultObj);
        }

        [HttpGet("get-order-to-shipper/{id}")]
        public async Task<IActionResult> GetOrderToShipper(Guid id)
        {
            var response = await _orderServices.GetOrderToShipper(id);
            if (response.IsSuccessed) return Ok(response);
            return BadRequest(response.ResultObj);
        }

        [HttpGet("complete-order/{id}")]
        public async Task<IActionResult> CompleteOrder(Guid id)
        {
            var response = await _orderServices.CompleteOrder(id);
            if (response.IsSuccessed) return Ok(response);
            return BadRequest(response.ResultObj);
        }

        [HttpGet("cancel-order/{id}")]
        public async Task<IActionResult> CancelOrder(Guid id)
        {
            var response = await _orderServices.CancelOrder(id);
            if (response.IsSuccessed) return Ok(response);
            return BadRequest(response.ResultObj);
        }
    }
}
