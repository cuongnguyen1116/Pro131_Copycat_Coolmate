using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shop.Data.Entities;

namespace shop.Data.Configurations;

public class CartDetailConfigurations : IEntityTypeConfiguration<CartDetail>
{
    public void Configure(EntityTypeBuilder<CartDetail> builder)
    {
        // builder.HasKey(x => x.Id);
        builder.HasKey(x => new { x.ProductDetailId, x.UserId });

        builder.Property(x => x.Quantity).IsRequired();

        builder.Property(x => x.Price).IsRequired();

        builder.HasOne(x => x.Cart).WithMany(x => x.CartDetails).HasForeignKey(x => x.UserId);
        builder.HasOne(x => x.ProductDetail).WithMany(x => x.CartDetails).HasForeignKey(x => x.ProductDetailId);

    }
}
