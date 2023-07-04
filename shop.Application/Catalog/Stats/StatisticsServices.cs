using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using shop.Data.Context;
using shop.ViewModels.Catalog.Stats;
using shop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Application.Catalog.Stats
{
    public class StatisticsServices : BaseServices, IStatisticsServices
    {
        public StatisticsServices(ShopDbContext context) : base(context)
        {
        }

        public async Task<StatsVm> GetStatistics()
        {
            var stats = await _context.Orders
                .Where(x => x.OrderStatus == OrderStatus.Completed && x.CompletedDate >= DateTime.Now.AddDays(-30) && x.CompletedDate <= DateTime.Now)
                .Select(x => new
                {
                    Order = x,
                    OrderDetails = x.OrderDetails.Select(od => new
                    {
                        od.Price,
                        od.Quantity
                    })
                })
                .ToListAsync();

            decimal revenue = stats.Sum(x => x.OrderDetails.Sum(od => od.Price * od.Quantity));
            int count = stats.Count;

            return new StatsVm { Revenue = revenue, OrderCount = count };
        }
    }
}
