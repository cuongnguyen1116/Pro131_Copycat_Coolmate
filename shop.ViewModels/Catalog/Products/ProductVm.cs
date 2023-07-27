using shop.Data.Enums;

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
    public Status Status { get; set; }
    public List<string> Images { get; set; } = new List<string>();

}
