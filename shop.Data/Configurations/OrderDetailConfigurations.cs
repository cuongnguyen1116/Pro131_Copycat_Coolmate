using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shop.Data.Entities;
using shop.Data.Enums;

namespace shop.Data.Configurations;

public class OrderDetailConfigurations : IEntityTypeConfiguration<OrderDetail>
{
    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {
        builder.HasKey(x => new { x.OrderId, x.ProductDetailId });

        builder.Property(x => x.Quantity).IsRequired();

        builder.Property(x => x.Price).IsRequired();

        builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        //builder.HasOne(x => x.ProductDetail).WithMany(x => x.OrderDetails).HasForeignKey(x => x.ProductDetailId);
        //builder.HasOne(x => x.Order).WithMany(x => x.OrderDetails).HasForeignKey(x => x.OrderId);

    }
}
