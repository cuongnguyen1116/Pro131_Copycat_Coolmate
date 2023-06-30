using shop.Data.Enums;

namespace shop.Data.Entities;

public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Status Status { get; set; }
    public Guid? ParentId { get; set; }
    public virtual ICollection<ProductInCategory> ProductInCategories { get; set; }
}
