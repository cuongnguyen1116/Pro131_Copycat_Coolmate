using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Data.Entities
{
    public class CartDetail
    {
        public Guid UserId { get; set; }
        public Guid ProductDetailId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        
        public virtual Cart? Cart { get; set; }
    }
}
