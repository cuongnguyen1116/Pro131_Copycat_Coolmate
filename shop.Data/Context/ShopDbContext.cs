using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using shop.Data.Configurations;
using shop.Data.Entities;
using shop.Data.Extensions;

namespace shop.Data.Context;

public class ShopDbContext : IdentityDbContext<AppUser, AppRole, Guid>
{
    public DbSet<AppRole> AppRoles { get; set; }
    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartDetail> CartDetails { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<Material> Materials { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductDetail> ProductDetails { get; set; }
    public DbSet<ProductInCategory> ProductInCategories { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }
    public DbSet<Size> Sizes { get; set; }
    public DbSet<ProductColor> ProductColors { get; set; }
    public DbSet<ProductMaterial> ProductMaterials { get; set; }
    public DbSet<ProductSize> ProductSizes { get; set; }
    public DbSet<Promotion> Promotions { get; set; }

    public ShopDbContext()
    {
    }

    public ShopDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AppRoleConfigurations());
        modelBuilder.ApplyConfiguration(new AppUserConfigurations());
        modelBuilder.ApplyConfiguration(new CategoryConfigurations());
        modelBuilder.ApplyConfiguration(new CartConfigurations());
        modelBuilder.ApplyConfiguration(new CartDetailConfigurations());
        modelBuilder.ApplyConfiguration(new ColorConfigurations());
        modelBuilder.ApplyConfiguration(new MaterialConfigurations());
        modelBuilder.ApplyConfiguration(new OrderConfigurations());
        modelBuilder.ApplyConfiguration(new OrderDetailConfigurations());
        modelBuilder.ApplyConfiguration(new ProductConfigurations());
        modelBuilder.ApplyConfiguration(new ProductDetailConfigurations());
        modelBuilder.ApplyConfiguration(new ProductImageConfigurations());
        modelBuilder.ApplyConfiguration(new ProductColorConfigurations());
        modelBuilder.ApplyConfiguration(new ProductSizeConfigurations());
        modelBuilder.ApplyConfiguration(new ProductMaterialConfigurations());
        modelBuilder.ApplyConfiguration(new ProductInCategoryConfigurations());
        modelBuilder.ApplyConfiguration(new PromotionConfigurations());
        modelBuilder.ApplyConfiguration(new SizeConfigurations());

        modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
        modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
        modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

        modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
        modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

        modelBuilder.Entity<AppUser>()
            .HasOne(a => a.Cart)
            .WithOne(b => b.User)
            .HasForeignKey<Cart>(b => b.UserId);

        modelBuilder.Seed();
    }
}
