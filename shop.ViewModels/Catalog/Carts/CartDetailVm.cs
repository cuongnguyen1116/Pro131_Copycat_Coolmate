using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ViewModels.Catalog.Carts
{
    public class CartDetailVm
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string ImagePath { get; set; }
        public string SizeName { get; set; }
        public string ColorName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal SubTotal { get; set; }
    }
}
