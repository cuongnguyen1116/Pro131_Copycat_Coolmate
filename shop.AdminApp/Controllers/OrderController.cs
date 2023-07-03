using Microsoft.AspNetCore.Mvc;
using shop.ApiIntegration.Orders;
using shop.Data.Enums;
using shop.Utilities.Constants;

namespace shop.AdminApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderApiClient _orderApiClient;

        public OrderController(IOrderApiClient orderApiClient)
        {
            _orderApiClient = orderApiClient;
        }

        public async Task<IActionResult> GetAll()
        {
            var data = await _orderApiClient.GetAll();
            return View(data);
        }

        public async Task<IActionResult> GetOrderByStatus(OrderStatus status)
        {
            var data = await _orderApiClient.GetOrderByStatus(status);
            return View("GetAll", data);
        }

        public async Task<IActionResult> GetOrderDetails(Guid id)
        {
            var data = await _orderApiClient.GetOrderDetails(id);
            return View(data);
        }
    }
}
