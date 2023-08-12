using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ViewModels.Catalog.Products;

public class ShowDetailResult
{
    public Guid ProductId { get; set; }
    public string ProductName { get; set; }
    public List<ProductDetailVm> ListProductDetails { get; set; }
    public List<string> ListImagePaths { get; set; }
    public IDictionary<Guid, string>? AvailableColors { get; set; }
    public IDictionary<Guid, string>? AvailableMaterials { get; set; }
    public IDictionary<Guid, string>? AvailableSizes { get; set; }
}
