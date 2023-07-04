using Microsoft.AspNetCore.Mvc;
using shop.ApiIntegration.Orders;
using shop.Data.Enums;

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

        public async Task<IActionResult> GetOrdersByStatus(OrderStatus status)
        {
            var data = await _orderApiClient.GetOrdersByStatus(status);
            return View("GetAll", data);
        }

        public async Task<IActionResult> GetOrderDetails(Guid id)
        {
            var data = await _orderApiClient.GetOrderDetails(id);
            return View(data);
        }

        public async Task<IActionResult> ConfirmOrder(Guid id)
        {
            var response = await _orderApiClient.ConfirmOrder(id);
            if (response) return RedirectToAction("GetAll", "Order");
            return View();
        }

        public async Task<IActionResult> CompleteOrder(Guid id)
        {
            var response = await _orderApiClient.CompleteOrder(id);
            if (response) return RedirectToAction("GetAll", "Order");
            return View();
        }
        public async Task<IActionResult> CancelOrder(Guid id)
        {
            var response = await _orderApiClient.CancelOrder(id);
            if (response) return RedirectToAction("GetAll", "Order");
            return View();
        }
    }
}
