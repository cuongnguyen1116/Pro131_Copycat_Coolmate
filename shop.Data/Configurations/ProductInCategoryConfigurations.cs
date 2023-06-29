using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shop.Data.Entities;

namespace shop.Data.Configurations;

public class ProductInCategoryConfigurations : IEntityTypeConfiguration<ProductInCategory>
{
    public void Configure(EntityTypeBuilder<ProductInCategory> builder)
    {
        builder.HasKey(x => new { x.ProductDetailId, x.CategoryId });
        builder.HasOne(x => x.ProductDetail).WithMany().HasForeignKey(x => x.ProductDetailId);
        builder.HasOne(x => x.Category).WithMany().HasForeignKey(x => x.CategoryId);
    }
}
