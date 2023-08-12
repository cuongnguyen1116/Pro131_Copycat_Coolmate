using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using shop.Application.Catalog.Stats;
using shop.Data.Context;
using shop.ViewModels.Catalog.Stats;
using System.Data;
using System.Net.Mime;

namespace shop.BackEndApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StatisticsController : ControllerBase
{
    private readonly IStatisticsServices _statisticsServices;
    private readonly ShopDbContext _shopDbContext;

    public StatisticsController(IStatisticsServices statisticsServices, ShopDbContext shopDbContext)
    {
        _statisticsServices = statisticsServices;
        _shopDbContext = shopDbContext;
    }

    [HttpGet]
    public async Task<IActionResult> GetStatistics()
    {
        var result = await _statisticsServices.GetStatistics();
        return Ok(result);
    }

    [HttpGet("get-order-statistic")]
    public async Task<IActionResult> GetOrderStatistics()
    {
        var result = await _statisticsServices.GetOrderStatisticByDate();
        return Ok(result);
    }

    [HttpGet("get-most-sale-product-statistic")]
    public async Task<IActionResult> GetProductMostSaleStatistic()
    {
        var result = await _statisticsServices.GetProductMostSaleStatistic();
        return Ok(result);
    }

    [HttpGet("get-user-with-total-order-statistic")]
    public async Task<IActionResult> GetUserWithTotalOrder()
    {
        var result = await _statisticsServices.GetCustomerWithTotalOrder();
        return Ok(result);
    }
    [NonAction]
    public DataTable GetStatistic(StatsVm statsVm)
    {
        DataTable dt = new()
        {
            TableName = "Statistic"
        };

        dt.Columns.Add("StopSellingProductCount", typeof(int));
        dt.Columns.Add("OutOfStockProductCount", typeof(int));
        dt.Columns.Add("Revenue", typeof(decimal));
        dt.Columns.Add("PendingOrderCount", typeof(int));
        dt.Columns.Add("AwaitingShipmentOrderCount", typeof(int));
        dt.Columns.Add("AwaitingPickupOrderCount", typeof(int));
        dt.Columns.Add("CompletedOrderCount", typeof(int));
        dt.Columns.Add("CancelledOrderCount", typeof(int));
        // Thêm dữ liệu vào DataTable từ danh sách userWithTotalOrders

        DataRow row = dt.NewRow();
        row["StopSellingProductCount"] = statsVm.StopSellingProductCount;
        row["OutOfStockProductCount"] = statsVm.OutOfStockProductCount;
        row["Revenue"] = statsVm.Revenue;
        row["PendingOrderCount"] = statsVm.PendingOrderCount;
        row["AwaitingShipmentOrderCount"] = statsVm.AwaitingShipmentOrderCount;
        row["AwaitingPickupOrderCount"] = statsVm.AwaitingPickupOrderCount;
        row["CompletedOrderCount"] = statsVm.CompletedOrderCount;
        row["CancelledOrderCount"] = statsVm.CancelledOrderCount;
        dt.Rows.Add(row);// để thêm vào trong datatable

        return dt;

    }

    [NonAction]
    public DataTable GetDataFromMostSoldProduct(List<UserWithTotalOrder> userWithTotalOrders)
    {
        DataTable dt = new()
        {
            TableName = "MostSoldProduct"
        };

        dt.Columns.Add("UserId", typeof(string));
        dt.Columns.Add("UserName", typeof(string));
        dt.Columns.Add("TotalOrders", typeof(int));
        dt.Columns.Add("TotalProducts", typeof(int));
        // Thêm dữ liệu vào DataTable từ danh sách userWithTotalOrders
        foreach (var item in userWithTotalOrders)
        {
            DataRow row = dt.NewRow();
            row["UserId"] = item.UserId;
            row["UserName"] = item.UserName;
            row["TotalOrders"] = item.TotalOrders;
            row["TotalProducts"] = item.TotalProducts;
            dt.Rows.Add(row);// để thêm vào trong datatable
        }
        return dt;

    }

    [NonAction]
    public DataTable GetDataFromMostSoldProduct(List<MostProductStatistic> bestSellingProductsData)
    {
        DataTable dt = new()
        {
            TableName = "MostSoldProduct"
        };

        dt.Columns.Add("Id", typeof(string));
        dt.Columns.Add("ProductName", typeof(string));
        dt.Columns.Add("TotalQuantitySold", typeof(int));
        // Thêm dữ liệu vào DataTable từ danh sách bestSellingProductsData
        foreach (var productStatistic in bestSellingProductsData)
        {
            DataRow row = dt.NewRow();
            row["Id"] = productStatistic.ProductId;
            row["ProductName"] = productStatistic.ProductName;
            row["TotalQuantitySold"] = productStatistic.TotalQuantitySold;
            dt.Rows.Add(row);
        }
        return dt;

    }
    [NonAction]
    public DataTable GetDataFromRevenue(OrderStatistic orderStatistics)
    {

        DataTable dt = new()
        {
            TableName = "Doanh Thu"
        };
        dt.Columns.Add("OrderAmount", typeof(int));
        dt.Columns.Add("Sum of Revenue", typeof(decimal));
        DataRow dr = dt.NewRow();
        dr["OrderAmount"] = orderStatistics.CompletedOrderCount;
        dr["Sum of Revenue"] = orderStatistics.TotalMoney;
        dt.Rows.Add(dr); // Thêm hàng vào bảng
        return dt;

    }

    [HttpGet("excelexport-statistic")]
    public async Task<IActionResult> ExportstatisticToExcel()
    {
        var statistic = await _statisticsServices.GetStatistics();
        var data = GetStatistic(statistic);
        using (XLWorkbook wb = new XLWorkbook())
        {
            var sheet1 = wb.AddWorksheet(data, "Thống kê");
            using (MemoryStream ms = new MemoryStream())
            {
                wb.SaveAs(ms);
                var contentDisposition = new ContentDisposition
                {
                    FileName = "Thống kê.xlsx",
                    Inline = false
                };
                Response.Headers.Add("Content-Disposition", contentDisposition.ToString());
                return File(ms.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheerml.sheet");

            }
        }

    }
    [HttpGet("excelexport-revenue")]
    public async Task<IActionResult> ExportRevenueToExcel()
    {
        var revenue = await _statisticsServices.GetOrderStatisticByDate();
        var data = GetDataFromRevenue(revenue);
        using (XLWorkbook wb = new XLWorkbook())
        {
            var sheet1 = wb.AddWorksheet(data, "Doanh_Thu");
            using (MemoryStream ms = new MemoryStream())
            {
                wb.SaveAs(ms);
                var contentDisposition = new ContentDisposition
                {
                    FileName = "Doanh_thu.xlsx",
                    Inline = false
                };
                Response.Headers.Add("Content-Disposition", contentDisposition.ToString());
                return File(ms.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheerml.sheet");

            }
        }

    }
    [HttpGet("excelexport-MostSoldProduct")]
    public async Task<IActionResult> ExportMostSoldProductToExcel()
    {
        var bestSellingProduct = await _statisticsServices.GetProductMostSaleStatistic();
        var data = GetDataFromMostSoldProduct(bestSellingProduct);
        using (XLWorkbook wb = new XLWorkbook())
        {
            var sheet1 = wb.AddWorksheet(data, "MostSoldProduct");
            using (MemoryStream ms = new MemoryStream())
            {
                wb.SaveAs(ms);
                var contentDisposition = new ContentDisposition
                {
                    FileName = "MostSoldProduct.xlsx",
                    Inline = false
                };
                Response.Headers.Add("Content-Disposition", contentDisposition.ToString());
                return File(ms.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheerml.sheet");

            }
        }

    }
    [HttpGet("excelexport-UserWithTotalOrder")]
    public async Task<IActionResult> ExportUserWithTotalOrder()
    {
        var userWithTotalOrders = await _statisticsServices.GetCustomerWithTotalOrder();
        var data = GetDataFromMostSoldProduct(userWithTotalOrders);
        using (XLWorkbook wb = new XLWorkbook())
        {
            var sheet1 = wb.AddWorksheet(data, "UserWithTotalOrders");
            using (MemoryStream ms = new MemoryStream())
            {
                wb.SaveAs(ms);
                var contentDisposition = new ContentDisposition
                {
                    FileName = "Khach_hang_mua_nhieu_nhat.xlsx",
                    Inline = false
                };
                Response.Headers.Add("Content-Disposition", contentDisposition.ToString());
                return File(ms.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheerml.sheet");

            }
        }

    }
}
