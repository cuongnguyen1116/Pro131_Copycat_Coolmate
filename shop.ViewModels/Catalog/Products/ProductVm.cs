using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ViewModels.Catalog.Products;

public class ProductVm
{
    public Guid Id { set; get; }
    public decimal Price { set; get; }
    public decimal OriginalPrice { set; get; }
    public int Stock { set; get; }
    public DateTime CreatedDate { set; get; }
    public string Description { set; get; }
    public string Name { set; get; }
    public string ThumbnailImage { get; set; }
    public string SizeName { set; get; }
    public string MaterialName { get; set; }
    public string ColorName { get; set; }

    public List<string> Categories { get; set; } = new List<string>();
}
