using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ViewModels.Catalog.Carts
{
    public class ShowCartResult
    {
        public Guid Id { get; set; }
        public List<CartDetailVm> ListCartDetail { get; set; }
        public decimal GrandTotal { get; set; }
        
    }
}
