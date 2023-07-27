using ClosedXML.Excel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing;
using OfficeOpenXml;
using shop.Application.Common.StoreFile;
using shop.Application.System.Users;
using shop.Data.Context;
using shop.Data.Enums;
using shop.ViewModels.Catalog.Stats;
using System.Data;
using System.IO;

namespace shop.Application.Catalog.Stats;

public class StatisticsServices : BaseServices, IStatisticsServices
{
    private readonly IHostingEnvironment _hostingEnvironment;
    public StatisticsServices(ShopDbContext context, IHostingEnvironment hostingEnvironment) : base(context)
    {
        _hostingEnvironment = hostingEnvironment;
    }

    public async Task<StatsVm> GetStatistics()
    {
        var orders = await _context.Orders
                    .GroupBy(o => o.OrderStatus)
                    .Select(g => new
                    {
                        OrderStatus = g.Key,
                        Count = g.Count()
                    })
                    .ToListAsync();

        decimal revenue = await _context.Orders
            .Where(o => o.OrderStatus == OrderStatus.Completed)
            .SelectMany(o => o.OrderDetails)
            .SumAsync(od => od.Price * od.Quantity);

        var stopSellingProductCount = await _context.Products.Where(x => x.Status == Status.Inactive).CountAsync();

        var outOfStockDictionary = CheckProductsOutOfStock(await _context.Products.Select(x => x.Id).ToListAsync());

        int outOfStockProductCount = 0;

        foreach (var item in outOfStockDictionary)
        {
            if (item.Value == true) outOfStockProductCount++;
        }

        var statsVm = new StatsVm
        {
            StopSellingProductCount = stopSellingProductCount,
            OutOfStockProductCount = outOfStockProductCount,
            Revenue = revenue,
            PendingOrderCount = orders.FirstOrDefault(s => s.OrderStatus == OrderStatus.Pending)?.Count ?? 0,
            AwaitingShipmentOrderCount = orders.FirstOrDefault(s => s.OrderStatus == OrderStatus.AwaitingShipment)?.Count ?? 0,
            AwaitingPickupOrderCount = orders.FirstOrDefault(s => s.OrderStatus == OrderStatus.AWaitingPickup)?.Count ?? 0,
            CompletedOrderCount = orders.FirstOrDefault(s => s.OrderStatus == OrderStatus.Completed)?.Count ?? 0,
            CancelledOrderCount = orders.FirstOrDefault(s => s.OrderStatus == OrderStatus.Cancelled)?.Count ?? 0
        };

        return statsVm;
    }

    public Dictionary<Guid, bool> CheckProductsOutOfStock(List<Guid> productIds)
    {
        var result = new Dictionary<Guid, bool>();

        var groupedProductDetails = _context.ProductDetails
            .AsEnumerable() // Chuyển sang thực thi trên client-side
            .GroupBy(pd => pd.ProductId)
            .ToDictionary(g => g.Key, g => g.Sum(pd => pd.Stock));

        foreach (Guid productId in productIds)
        {
            bool isOutOfStock = !groupedProductDetails.ContainsKey(productId) || groupedProductDetails[productId] == 0;
            result.Add(productId, isOutOfStock);
        }

        return result;
    }
    public DataTable GetData()
    {
        DataTable dt = new DataTable();
        dt.TableName = "User";
        dt.Columns.Add("Id",typeof(string));
        dt.Columns.Add("FirstName", typeof(string));
        dt.Columns.Add("LastName", typeof(string));
        dt.Columns.Add("Email",typeof(string));
        dt.Columns.Add("PhoneNumber",typeof(string));
        dt.Columns.Add("Dob",typeof(string));
        var users = _context.Users.ToList();
        if (users.Count>0)
        {
            users.ForEach(item =>
            {
                dt.Rows.Add(item.Id, item.FirstName,item.LastName,item.Email,item.PhoneNumber,item.DoB);
            });
        }
        return dt;

    }
    //public async Task<bool> ExportToExcel()
    //{

    //    var data = GetData();
    //    using(XLWorkbook wb = new XLWorkbook())
    //    {
    //        var sheet1 = wb.AddWorksheet(data, "User");
    //        using(MemoryStream ms = new MemoryStream())
    //        {
    //            wb.SaveAs(ms);
    //            ms.Position = 0;
    //            //File(ms.ToArray(),"application/vnd.openxmlformats-officedocument.spreadsheerml.sheet","User.xlsx");
    //            File.WriteAllBytes("User.xlsx", ms.ToArray());
    //            //return ms;
    //        }
    //    }
    //    return true;
        

    //}
}
