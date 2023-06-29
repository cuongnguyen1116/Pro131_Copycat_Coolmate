using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shop.Data.Entities;
using shop.Data.Enums;

namespace shop.Data.Configurations;

public class ProductMaterialConfigurations : IEntityTypeConfiguration<ProductMaterial>
{
    public void Configure(EntityTypeBuilder<ProductMaterial> builder)
    {
        builder.HasKey(x => new { x.ProductDetailId, x.MaterialId });
        builder.HasOne(x => x.ProductDetail).WithMany().HasForeignKey(x => x.ProductDetailId);
        builder.HasOne(x => x.Material).WithMany().HasForeignKey(x => x.MaterialId);
        builder.Property(x => x.Status).HasDefaultValue(Status.Active);
    }
}
