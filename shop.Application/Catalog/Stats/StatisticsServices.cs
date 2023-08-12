﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shop.Data.Context;
using shop.Data.Enums;
using shop.ViewModels.Catalog.Stats;
using System.Data;

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
    public async Task<Order30Days> GetOrderByDate()
    {
        var startDate = DateTime.Now.AddDays(-30);
        //xác định khoảng thời gian bắt đầu và kết thúc của tháng hiện tại bằng cách sử dụng DateTime.Now và phương thức AddDays(-30) để lấy thời gian 30 ngày trước đó.
        var endDate = DateTime.Now;

        // Lấy ra danh sách các đơn hàng có trạng thái là "Completed" và ngày hoàn thành nằm trong khoảng thời gian của tháng hiện tại
        var completedOrders = await _context.Orders
            .Where(o => o.OrderStatus == OrderStatus.Completed && o.CompletedDate.HasValue && o.CompletedDate.Value >= startDate && o.CompletedDate.Value <= endDate)
            .ToListAsync();

        // Tính số lượng các đơn hàng có trạng thái là "Completed" trong tháng hiện tại
        int completedOrderCount = completedOrders.Count;
        decimal totalMoney = completedOrders.Sum(muney => muney.Total);
        var orderStat = new Order30Days()
        {
            CompletedOrderCount = completedOrderCount,
            TotalMoney = totalMoney,
        };
        return orderStat;
    }
    public async Task<List<MostSaleProduct>> GetMostSaleProduct()
    {

        // Bước 1: Lấy ra danh sách ProductDetailId từ các hoá đơn hoàn tất (completed) trong orderdetails
        var completedOrderProductDetailIds = await _context.OrderDetails
            .Where(od => od.Order.OrderStatus == OrderStatus.Completed)
            .Select(od => od.ProductDetailId)
            .ToListAsync();

        // Bước 2: Tính tổng số lượng bán chạy của mỗi ProductDetailId
        var bestSellingProductQuantities = _context.OrderDetails
            .Where(od => completedOrderProductDetailIds.Contains(od.ProductDetailId))
            .GroupBy(od => od.ProductDetailId)
            .Select(g => new
            {
                ProductDetailId = g.Key,
                TotalQuantitySold = g.Sum(od => od.Quantity)
            });

        // Bước 3: Lấy ra 5 sản phẩm có tổng số lượng bán chạy lớn nhất
        var bestSellingProductsData = await _context.ProductDetails // truy vấn vào bảng productdetails
            .Where(pd => completedOrderProductDetailIds.Contains(pd.Id)) // tìm id giống với danh sách đã lấy ra từ bước 1
            .Join(
                bestSellingProductQuantities,
                pd => pd.Id,
                bs => bs.ProductDetailId,
                (pd, bs) => new MostSaleProduct //kết nối productdetails với orderdetails
                {
                    ProductId = pd.Product.Id,
                    ProductName = pd.Product.Name,
                    TotalQuantitySold = bs.TotalQuantitySold //lấy ra 3 trường thuộc tính
                })
            .GroupBy(p => new { p.ProductId, p.ProductName }) //nhóm danh sách theo productid và productname 
            .Select(g => new MostSaleProduct
            {
                ProductId = g.Key.ProductId,
                ProductName = g.Key.ProductName,
                TotalQuantitySold = g.Sum(p => p.TotalQuantitySold) // tính tổng số lượng bán chạy của từng sản phẩm từ nhóm các sản phẩm trong bước trước và trả về một danh sách các đối tượng MostProductStatistic với thông tin về ProductId, ProductName và TotalQuantitySold
            })
            .OrderByDescending(p => p.TotalQuantitySold)
            .Take(5) // Lấy ra 5 sản phẩm đầu tiên (có tổng số lượng bán chạy lớn nhất)
            .ToListAsync();


        return bestSellingProductsData;
    }
    public async Task<List<CustomerMostBuy>> CustomerMostBuy()
    {
        var query = from u in _context.AppUsers
                    join o in _context.Orders on u.Id equals o.UserId
                    join od in _context.OrderDetails on o.Id equals od.OrderId // hực hiện truy vấn để lấy thông tin từ các bảng AppUsers, Orders và OrderDetails. Cụ thể là lấy UserId, UserName, OrderId và Quantity của OrderDetail
                    where o.OrderStatus == OrderStatus.Completed // lấy những đơn hàng có trạng thái OrderStatus là Completed
                    select new
                    {
                        UserId = u.Id,
                        UserName = u.UserName,
                        OrderId = o.Id,
                        Quantity = od.Quantity
                    };

        var groupedQuery = from uod in query
                           group uod by new { uod.UserId, uod.UserName } into userGroup // thực hiện phép GroupBy theo UserId và UserName.
                           select new
                           {
                               UserId = userGroup.Key.UserId,
                               UserName = userGroup.Key.UserName,
                               TotalOrders = userGroup.Select(x => x.OrderId).Distinct().Count(),//Distinct() được sử dụng để loại bỏ các phần tử trùng lặp trong một tập hợp (collection) dữ liệu, Distinct() được sử dụng để loại bỏ các phần tử trùng lặp trong một tập hợp (collection) dữ liệu
                               TotalProducts = userGroup.Sum(x => x.Quantity)
                           };

        var result = groupedQuery.AsEnumerable()
                                 .Select(x => new CustomerMostBuy //chuyển kết quả từ groupedQuery thành danh sách đối tượng UserWithTotalOrder
                                 {
                                     UserId = x.UserId,
                                     UserName = x.UserName,
                                     TotalOrders = x.TotalOrders,
                                     TotalProducts = x.TotalProducts
                                 })
                                 .ToList();
        //sử dụng AsEnumerable() để chuyển kết quả sang dạng IEnumerable, sau đó sử dụng Select() để tạo các đối tượng UserWithTotalOrder từ kết quả và cuối cùng chuyển đổi sang danh sách bằng phương thức ToList().
        return result;
    }

    public DataTable GetSaleStatistic(StatsVm statsVm)
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
    public DataTable GetCustomerMostBuy(List<CustomerMostBuy> CustomerMostBuy)
    {
        DataTable dt = new()
        {
            TableName = "CustomerMostBuy"
        };

        dt.Columns.Add("UserId", typeof(string));
        dt.Columns.Add("UserName", typeof(string));
        dt.Columns.Add("TotalOrders", typeof(int));
        dt.Columns.Add("TotalProducts", typeof(int));
        // Thêm dữ liệu vào DataTable từ danh sách userWithTotalOrders
        foreach (var item in CustomerMostBuy)
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

    public DataTable GetMostSaleProduct(List<MostSaleProduct> MostSaleProduct)
    {
        DataTable dt = new()
        {
            TableName = "MostSoldProduct"
        };

        dt.Columns.Add("Id", typeof(string));
        dt.Columns.Add("ProductName", typeof(string));
        dt.Columns.Add("TotalQuantitySold", typeof(int));
        // Thêm dữ liệu vào DataTable từ danh sách bestSellingProductsData
        foreach (var productStatistic in MostSaleProduct)
        {
            DataRow row = dt.NewRow();
            row["Id"] = productStatistic.ProductId;
            row["ProductName"] = productStatistic.ProductName;
            row["TotalQuantitySold"] = productStatistic.TotalQuantitySold;
            dt.Rows.Add(row);
        }
        return dt;

    }

    public DataTable GetRevenue(Order30Days orderStatistics)
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
}

