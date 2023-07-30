using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using shop.ApiIntegration.Orders;
using shop.Data.Enums;
using shop.ViewModels.Catalog.Orders;

namespace shop.AdminApp.Controllers;

[Authorize(Policy = "AdminOrManager")]
public class OrderController : Controller
{
    private static List<Guid> selectedOrderIds = new();
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
        List<OrderDetailVm> orderDetails = await _orderApiClient.GetOrderDetails(id);
        // Lấy dữ liệu của orderDetails từ nguồn nào đó, ví dụ như database

        // Trả về dữ liệu dạng JSON
        return new JsonResult(orderDetails);
    }

    //public async Task<IActionResult> GetOrderDetails(Guid id)
    //{
    //    var data = await _orderApiClient.GetOrderDetails(id);
    //    return View(data);
    //}

    [HttpPost]
    public async Task<IActionResult> ProcessSelectedOrders(List<Guid> orderIds)
    {
        selectedOrderIds = orderIds;
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> ConfirmAllOrder()
    {
        var response = await _orderApiClient.ConfirmAllOrder();
        if (response.IsSuccessed)
        {
            TempData["result"] = response.Message;
            return RedirectToAction("GetOrdersPaging", "Order");
        }
        return View();
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
