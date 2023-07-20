using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ViewModels.Catalog.Materials
{
    public class MaterialCreateRequest
    {
        public Guid? MaterialId { get; set; }
        public string? Name { get; set; }
    }
}
