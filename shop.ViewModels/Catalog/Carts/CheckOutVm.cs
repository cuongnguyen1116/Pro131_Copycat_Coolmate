using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ViewModels.Catalog.Carts
{
    public class CheckOutVm
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public decimal GrandTotal { get; set; }
        public int ProductCount { get; set; }
    }
}
