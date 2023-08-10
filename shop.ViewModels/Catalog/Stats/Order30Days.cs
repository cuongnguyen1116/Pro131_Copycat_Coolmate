using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ViewModels.Catalog.Stats
{
    public class Order30Days
    {
        public int CompletedOrderCount { get; set; }
        public decimal TotalMoney { get; set; }
    }
}
