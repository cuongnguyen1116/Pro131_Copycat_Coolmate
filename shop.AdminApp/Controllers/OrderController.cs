using Microsoft.AspNetCore.Mvc;
using shop.ApiIntegration.Orders;
using shop.Data.Enums;
using shop.ViewModels.Catalog.Orders;

namespace shop.AdminApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderApiClient _orderApiClient;

        public OrderController(IOrderApiClient orderApiClient)
        {
            _orderApiClient = orderApiClient;
        }

        public async Task<IActionResult> GetOrdersPaging(string? keyword, OrderStatus status, int pageIndex = 1, int pageSize = 10)
        {
            var request = new OrderPagingRequest
            {
                KeyWord = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize,
                Status = status
            };

            var data = await _orderApiClient.GetOrdersPaging(request);
            ViewBag.Keyword = keyword;
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(data);
        }

        public async Task<IActionResult> GetOrderDetails(Guid id)
        {
            var data = await _orderApiClient.GetOrderDetails(id);
            return View(data);
        }

        public async Task<IActionResult> ConfirmOrder(Guid id)
        {
            var response = await _orderApiClient.ConfirmOrder(id);
            if (response.IsSuccessed)
            {
                TempData["result"] = response.Message;
                return RedirectToAction("GetOrdersPaging", "Order");
            }
            return View();
        }

        public async Task<IActionResult> GetOrderToShipper(Guid id)
        {
            var response = await _orderApiClient.GetOrderToShipper(id);
            if (response.IsSuccessed)
            {
                TempData["result"] = response.Message;
                return RedirectToAction("GetOrdersPaging", "Order");
            }
            return View();
        }

        public async Task<IActionResult> CompleteOrder(Guid id)
        {
            var response = await _orderApiClient.CompleteOrder(id);
            if (response.IsSuccessed)
            {
                TempData["result"] = response.Message;
                return RedirectToAction("GetOrdersPaging", "Order");
            }
            return View();
        }
        public async Task<IActionResult> CancelOrder(Guid id)
        {
            var response = await _orderApiClient.CancelOrder(id);
            if (response.IsSuccessed)
            {
                TempData["result"] = response.Message;
                return RedirectToAction("GetOrdersPaging", "Order");
            }
            return View();
        }
    }
}
