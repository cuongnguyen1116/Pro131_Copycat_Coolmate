using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ViewModels.Catalog.Stats
{
    public class UserWithTotalOrder
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public int TotalOrders { get; set; }
        public int TotalProducts { get; set; }
    }
}
