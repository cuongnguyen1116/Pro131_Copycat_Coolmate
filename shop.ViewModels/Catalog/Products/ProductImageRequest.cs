using Microsoft.AspNetCore.Http;

namespace shop.ViewModels.Catalog.Products;

public class ProductImageRequest
{
    public Guid? Id { get; set; }
    public Guid ProductId { get; set; }
    public string Caption { get; set; }

    public bool IsDefault { get; set; }

    public int SortOrder { get; set; }

    public IFormFile ImageFile { get; set; }
}
