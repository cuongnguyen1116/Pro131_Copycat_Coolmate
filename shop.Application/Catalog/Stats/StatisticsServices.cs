using Microsoft.EntityFrameworkCore;
using shop.Data.Context;
using shop.Data.Enums;
using shop.ViewModels.Catalog.Stats;

namespace shop.Application.Catalog.Stats
{
    public class StatisticsServices : BaseServices, IStatisticsServices
    {
        public StatisticsServices(ShopDbContext context) : base(context)
        {
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

            var listProductIds = await _context.Products.Select(x => x.Id).ToListAsync();

            var outOfStockDictionary = CheckProductsOutOfStock(listProductIds);

            int outOfStockProductCount = 0;

            foreach (var item in outOfStockDictionary)
            {
                if (item.Value == false) outOfStockProductCount++;
            }

            var statsVm = new StatsVm
            {
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
    }
}
