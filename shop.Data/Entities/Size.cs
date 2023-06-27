using shop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Data.Entities
{
    public class Size
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
        public ICollection<ProductDetail>? ProductDetails { get; set; }
    }
}
