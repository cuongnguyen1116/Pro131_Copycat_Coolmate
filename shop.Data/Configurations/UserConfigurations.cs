using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shop.Data.Entities;
using shop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Data.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.FirstName).HasMaxLength(64).IsRequired();
            builder.Property(x=>x.LastName).HasMaxLength(64).IsRequired();
            builder.Property(x => x.DoB).HasColumnType("date").IsRequired();
            builder.Property(x=>x.Email).HasMaxLength(320).IsRequired();
            builder.Property(x=>x.Username).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);

            builder.HasOne(x => x.Role).WithOne().HasForeignKey<User>(x => x.RoleId);
        }
    }
}
