using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using shop.Application.Catalog.Stats;
using shop.Data.Context;
using shop.Data.Enums;
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
    [NonAction]
    public DataTable GetData()
    {
        DataTable dt = new DataTable();
        dt.TableName = "User";
        dt.Columns.Add("Id", typeof(string));
        dt.Columns.Add("FirstName", typeof(string));
        dt.Columns.Add("LastName", typeof(string));
        dt.Columns.Add("Email", typeof(string));
        dt.Columns.Add("PhoneNumber", typeof(string));
        dt.Columns.Add("Dob", typeof(string));
        var users = _shopDbContext.Users.ToList();
        if (users.Count > 0)
        {
            users.ForEach(item =>
            {
                dt.Rows.Add(item.Id, item.FirstName, item.LastName, item.Email, item.PhoneNumber, item.DoB);
            });
        }
        return dt;

    }
    [NonAction]
    public DataTable GetDataFromTurnOver(int? selectedMonth)
    {

        DataTable dt = new DataTable();
        dt.TableName = "Doanh Thu";
        dt.Columns.Add("Month", typeof(int));
        dt.Columns.Add("Sum of turnover", typeof(decimal));

        var turnover = _shopDbContext.Orders.Where(p => p.OrderStatus == OrderStatus.Completed && p.CompletedDate.Value.Month == selectedMonth)
        .ToList();


        if (turnover.Count > 0)
        {
            decimal totalAmount = 0;
            foreach (var item in turnover)
            {
                totalAmount += item.Total;
            }

            turnover.ForEach(item =>
            {
                dt.Rows.Add(selectedMonth, totalAmount);
            });

        }
        return dt;

    }

    [HttpGet("excelexport")]
    public async Task<IActionResult> ExportToExcel(int? selectedDate)
    {
        var data = GetDataFromTurnOver(selectedDate);
        using (XLWorkbook wb = new XLWorkbook())
        {
            var sheet1 = wb.AddWorksheet(data, "Doanh_Thu");
            using (MemoryStream ms = new MemoryStream())
            {
                wb.SaveAs(ms);
                var contentDisposition = new ContentDisposition
                {
                    FileName = "Doanh_Thu.xlsx",
                    Inline = false
                };
                Response.Headers.Add("Content-Disposition", contentDisposition.ToString());
                return File(ms.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheerml.sheet");

            }
        }

    }
}
