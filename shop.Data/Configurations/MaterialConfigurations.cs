using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shop.Data.Entities;

namespace shop.Data.Configurations;

public class MaterialConfigurations : IEntityTypeConfiguration<Material>
{
    void IEntityTypeConfiguration<Material>.Configure(EntityTypeBuilder<Material> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(128).IsRequired();
    }
}
