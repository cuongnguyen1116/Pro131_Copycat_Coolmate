using shop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ViewModels.Catalog.Products
{
    public class ProductPropVM
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? Image { get; set; }
        public Status Status { get; set; }
        public string SizeName { set; get; }
        public string MaterialName { get; set; }
        public string ColorName { get; set; }
    }
}
