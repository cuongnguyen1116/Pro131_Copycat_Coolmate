using Microsoft.AspNetCore.Http;
using shop.Data.Enums;

namespace shop.ViewModels.Catalog.Products;

public class ProductRequest
{
    public Guid? Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string? Image { get; set; }
    public Status Status { get; set; }
    public IFormFile ThumbnailImage { get; set; }
    public List<string> Categories { get; set; } = new List<string>();
}
