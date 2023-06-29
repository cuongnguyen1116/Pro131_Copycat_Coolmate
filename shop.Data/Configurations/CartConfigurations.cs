using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shop.Data.Entities;

namespace shop.Data.Configurations;

public class CartConfigurations : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        builder.HasKey(x => x.UserId);
        builder.Property(x => x.Description).HasMaxLength(256).IsRequired();
    }
}
