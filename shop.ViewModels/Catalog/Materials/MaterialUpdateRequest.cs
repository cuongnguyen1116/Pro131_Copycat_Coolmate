using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ViewModels.Catalog.Materials
{
    public class MaterialUpdateRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
