using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using shop.Application.Catalog.Stats;
using shop.Data.Context;
using shop.Data.Enums;
using shop.ViewModels.Catalog.Stats;
using System.Collections.Generic;
using System.Data;
using System.Net;
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

    [HttpGet("order-30-days")]
    public async Task<IActionResult> GetOrderStatistics()
    {
        var result = await _statisticsServices.GetOrderByDate();
        return Ok(result);
    }

    [HttpGet("most-sale-product")]
    public async Task<IActionResult> GetGetMostSaleProduct()
    {
        var result = await _statisticsServices.GetMostSaleProduct();
        return Ok(result);
    }

    [HttpGet("customer-most-buy")]
    public async Task<IActionResult> CustomerMostBuy()
    {
        var result = await _statisticsServices.CustomerMostBuy();
        return Ok(result);
    }


    [HttpGet("excelexport-Statistic")]
    public async Task<IActionResult> Exportstatistic()
    {
        var statistic = await _statisticsServices.GetStatistics();
        var data =  _statisticsServices.GetSaleStatistic(statistic);
        using (XLWorkbook wb = new XLWorkbook())
        {
            var sheet1 = wb.AddWorksheet(data, "Statistic");
            using (MemoryStream ms = new MemoryStream())
            {
                wb.SaveAs(ms);
                var contentDisposition = new ContentDisposition
                {
                    FileName = WebUtility.UrlEncode("Statistic.xlsx"),
                    Inline = false
                };
                Response.Headers.Add("Content-Disposition", contentDisposition.ToString());
                return File(ms.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheerml.sheet");

            }
        }

    }
    [HttpGet("excelexport-Revenue")]
    public async Task<IActionResult> ExportRevenue()
    {
        var revenue = await _statisticsServices.GetOrderByDate();
        var data = _statisticsServices.GetRevenue(revenue);
        using (XLWorkbook wb = new XLWorkbook())
        {
            var sheet1 = wb.AddWorksheet(data, "Revenue");
            using (MemoryStream ms = new MemoryStream())
            {
                wb.SaveAs(ms);
                var contentDisposition = new ContentDisposition
                {
                    FileName = WebUtility.UrlEncode("Revenue.xlsx"),
                    Inline = false
                };
                Response.Headers.Add("Content-Disposition", contentDisposition.ToString());
                return File(ms.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheerml.sheet");

            }
        }

    }
    [HttpGet("excelexport-MostSoldProduct")]
    public async Task<IActionResult> ExportMostSoldProduct()
    {
        var bestSellingProduct = await _statisticsServices.GetMostSaleProduct();
        var data = _statisticsServices.GetMostSaleProduct(bestSellingProduct);
        using (XLWorkbook wb = new XLWorkbook())
        {
            var sheet1 = wb.AddWorksheet(data, "MostSaleProduct");
            using (MemoryStream ms = new MemoryStream())
            {
                wb.SaveAs(ms);
                var contentDisposition = new ContentDisposition
                {
                    FileName = WebUtility.UrlEncode("MostSaleProduct.xlsx"),
                    Inline = false
                };
                Response.Headers.Add("Content-Disposition", contentDisposition.ToString());
                return File(ms.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheerml.sheet");

            }
        }

    }
    [HttpGet("excelexport-CustomerMostBuy")]
    public async Task<IActionResult> ExportCustomerMostBuy()
    {
        var userWithTotalOrders = await _statisticsServices.CustomerMostBuy();
        var data = _statisticsServices.GetCustomerMostBuy(userWithTotalOrders);
        using (XLWorkbook wb = new XLWorkbook())
        {
            var sheet1 = wb.AddWorksheet(data, "Customer");
            using (MemoryStream ms = new MemoryStream())
            {
                wb.SaveAs(ms);
                var contentDisposition = new ContentDisposition
                {
                    FileName = WebUtility.UrlEncode("Customer.xlsx"),
                    Inline = false
                };
                Response.Headers.Add("Content-Disposition", contentDisposition.ToString());
                return File(ms.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheerml.sheet");

            }
        }

    }
}
