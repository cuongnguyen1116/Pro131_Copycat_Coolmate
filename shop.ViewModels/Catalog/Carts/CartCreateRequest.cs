using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ViewModels.Catalog.Carts
{
    public class CartCreateRequest
    {
        //public Guid productdetailId { get; set; }
        public Guid UserId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Guid colorId { get; set; }
        public Guid sizeId { get; set; }

    }
}
// từ product id colorid sizeid -> tìm productdetail -> thêm giỏ hàng

// viewmodel kết hợp của product và product detail