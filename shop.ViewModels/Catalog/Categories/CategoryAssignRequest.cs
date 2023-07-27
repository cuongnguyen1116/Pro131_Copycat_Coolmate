using shop.ViewModels.Common;

namespace shop.ViewModels.Catalog.Categories;

public class CategoryAssignRequest
{
    public Guid Id { get; set; }
    public List<SelectItem> Categories { get; set; } = new List<SelectItem>();
}
