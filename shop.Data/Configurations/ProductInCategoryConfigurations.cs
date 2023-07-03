using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shop.Data.Entities;

namespace shop.Data.Configurations;

public class ProductInCategoryConfigurations : IEntityTypeConfiguration<ProductInCategory>
{
    public void Configure(EntityTypeBuilder<ProductInCategory> builder)
    {
        builder.HasKey(x => new { x.ProductId, x.CategoryId });

        builder.HasOne(x => x.Product).WithMany(x=>x.ProductInCategories).HasForeignKey(x => x.ProductId);

        builder.HasOne(x => x.Category).WithMany(x=>x.ProductInCategories).HasForeignKey(x => x.CategoryId);
    }
}
