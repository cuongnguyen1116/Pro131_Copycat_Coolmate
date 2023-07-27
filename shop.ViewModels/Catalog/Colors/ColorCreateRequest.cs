using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ViewModels.Catalog.Colors
{
    public class ColorCreateRequest
    {
        public Guid? ColorId { get; set; }
        public string? Name { get; set; }
    }
}
