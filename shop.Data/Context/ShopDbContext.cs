using Microsoft.EntityFrameworkCore;
using shop.Data.Configurations;
using shop.Data.Entities;
using shop.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace shop.Data.Context
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<User> Users { get; set; }

        public ShopDbContext()
        {
        }

        public ShopDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CartConfigurations());
            modelBuilder.ApplyConfiguration(new CartDetailConfigurations());
            modelBuilder.ApplyConfiguration(new ColorConfigurations());
            modelBuilder.ApplyConfiguration(new MaterialConfigurations());
            modelBuilder.ApplyConfiguration(new OrderConfigurations());
            modelBuilder.ApplyConfiguration(new OrderDetailConfigurations());
            modelBuilder.ApplyConfiguration(new ProductConfigurations());
            modelBuilder.ApplyConfiguration(new ProductDetailConfigurations());
            modelBuilder.ApplyConfiguration(new ProductImageConfigurations());
            modelBuilder.ApplyConfiguration(new RoleConfigurations());
            modelBuilder.ApplyConfiguration(new SizeConfigurations());
            modelBuilder.ApplyConfiguration(new UserConfigurations());

            modelBuilder.Entity<User>()
                .HasOne(a => a.Cart)
                .WithOne(b => b.User)
                .HasForeignKey<Cart>(b => b.UserId);

            modelBuilder.Seed();
        }
    }
}
