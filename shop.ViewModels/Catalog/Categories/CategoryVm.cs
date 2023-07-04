using shop.Data.Enums;

namespace shop.ViewModels.Catalog.Categories;

public class CategoryVm
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid? ParentId { get; set; }
    public Status Status { get; set; }
}
