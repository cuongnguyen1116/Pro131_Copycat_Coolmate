using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Data.Entities
{
    public class Cart
    {
        public Guid UserId { get; set; }
        public string Description { get; set; }

        public virtual User? User { get; set; }
        public ICollection<CartDetail>? CartDetails { get; set; }
    }
}
