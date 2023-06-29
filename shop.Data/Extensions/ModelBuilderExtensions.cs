using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using shop.Data.Entities;
using shop.Data.Enums;

namespace shop.Data.Extensions;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder builder)
    {
        // category
        var categoryId1 = new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c");
        var categoryId2 = new Guid("d8eb1629-a276-4667-8da2-0926fc66de0c");
        builder.Entity<Category>().HasData(
           new Category()
           {
               Id = categoryId1,
               Name = "Áo thun"
           },
            new Category()
            {
                Id = categoryId2,
                Name = "Áo polo"
            });

        // product
        var productId1 = new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9");
        var productId2 = new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844");
        builder.Entity<Product>().HasData(
            new Product
            {
                Id = productId1,
                Name = "Gym Powerfit",
                Status = Status.Active
            },
            new Product
            {
                Id = productId2,
                Name = "Cotton Summer Coolwaves",
                Status = Status.Active
            });

        // color
        var colorId1 = new Guid("b8457fc8-60a5-43a1-9e4a-e4855c86524f");
        var colorId2 = new Guid("c22c0a96-b3fc-4223-8cca-b9046732bb89");
        var colorId3 = new Guid("46894c70-1d26-4a20-993b-8d2198913585");
        builder.Entity<Color>().HasData(
            new Color
            {
                Id = colorId1,
                Name = "Đen",
            },
            new Color
            {
                Id = colorId2,
                Name = "Trắng",
            },
            new Color
            {
                Id = colorId3,
                Name = "Xám",
            });

        // material
        var materialId1 = new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4");
        var materialId2 = new Guid("5cd1370c-dd94-4038-b33c-49a27aad25ab");
        var materialId3 = new Guid("99df0e16-bab3-4d8a-8916-72e4a03e99e4");
        var materialId4 = new Guid("093e72f7-4bae-448c-b009-b6acf0fe9120");
        builder.Entity<Material>().HasData(
            new Material
            {
                Id = materialId1,
                Name = "Vải Cotton"
            },
            new Material
            {
                Id = materialId2,
                Name = "Vải Excool"
            },
            new Material
            {
                Id = materialId3,
                Name = "Vải Polyester tính năng"
            },
            new Material
            {
                Id = materialId4,
                Name = "Vải Recycle"
            });

        // size
        var sizeId1 = new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7");
        var sizeId2 = new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85");
        var sizeId3 = new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba");
        var sizeId4 = new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751");
        var sizeId5 = new Guid("f6a1a967-7487-463b-9d7b-09aebf15d304");
        var sizeId6 = new Guid("aa66fbee-a9d6-4bb5-8ed8-b329d394221f");
        builder.Entity<Size>().HasData(
            new Size
            {
                Id = sizeId1,
                Name = "S"
            },
            new Size
            {
                Id = sizeId2,
                Name = "M"
            },
            new Size
            {
                Id = sizeId3,
                Name = "L"
            },
            new Size
            {
                Id = sizeId4,
                Name = "XL",
            },
            new Size
            {
                Id = sizeId5,
                Name = "XXL"
            },
            new Size
            {
                Id = sizeId6,
                Name = "XXXL"
            });


        // product detail
        var productDetailId1 = new Guid("fb684bf0-020f-4607-8e79-b3aa9bd005a5");
        var productDetailId2 = new Guid("0a3dcb7c-884d-4a05-a5dd-a1d5df404dff");
        var productDetailId3 = new Guid("231e0060-c281-4c8d-b5c2-791edfa5a680");
        var productDetailId4 = new Guid("aa06827c-df06-4a43-94d2-75bba02d9da6");
        builder.Entity<ProductDetail>().HasData(
            new ProductDetail
            {
                Id = productDetailId1,
                ProductId = productId1,
                Stock = 50,
                Price = 199000,
                OriginalPrice = 150000,
                CreatedDate = DateTime.Now
            },
            new ProductDetail
            {
                Id = productDetailId2,
                ProductId = productId2,
                Stock = 50,
                Price = 299000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now
            });

        // bảng trung gian
        builder.Entity<ProductInCategory>().HasData(
            new ProductInCategory
            {
                ProductDetailId = productDetailId1,
                CategoryId = categoryId1
            },
            new ProductInCategory
            {
                ProductDetailId = productDetailId2,
                CategoryId = categoryId2
            });

        builder.Entity<ProductColor>().HasData(
            new ProductColor
            {
                ProductDetailId = productDetailId1,
                ColorId = colorId1,
                Status = Status.Active
            },
            new ProductColor
            {
                ProductDetailId = productDetailId1,
                ColorId = colorId2,
                Status = Status.Active
            },
            new ProductColor
            {
                ProductDetailId = productDetailId2,
                ColorId = colorId3,
                Status = Status.Active
            });

        builder.Entity<ProductMaterial>().HasData(
            new ProductMaterial
            {
                ProductDetailId = productDetailId1,
                MaterialId = materialId1,
                Status = Status.Active
            },
            new ProductMaterial
            {
                ProductDetailId = productDetailId2,
                MaterialId = materialId2,
                Status = Status.Active
            });

        builder.Entity<ProductSize>().HasData(
            new ProductSize
            {
                ProductDetailId = productDetailId1,
                SizeId = sizeId1,
                Status = Status.Active
            }, new ProductSize
            {
                ProductDetailId = productDetailId1,
                SizeId = sizeId2,
                Status = Status.Active
            }, new ProductSize
            {
                ProductDetailId = productDetailId1,
                SizeId = sizeId3,
                Status = Status.Active
            }, new ProductSize
            {
                ProductDetailId = productDetailId1,
                SizeId = sizeId4,
                Status = Status.Active
            }, new ProductSize
            {
                ProductDetailId = productDetailId1,
                SizeId = sizeId5,
                Status = Status.Active
            }, new ProductSize
            {
                ProductDetailId = productDetailId1,
                SizeId = sizeId6,
                Status = Status.Active
            }, new ProductSize
            {
                ProductDetailId = productDetailId2,
                SizeId = sizeId2,
                Status = Status.Active
            }, new ProductSize
            {
                ProductDetailId = productDetailId2,
                SizeId = sizeId3,
                Status = Status.Active
            }, new ProductSize
            {
                ProductDetailId = productDetailId2,
                SizeId = sizeId4,
                Status = Status.Active
            });


        // role
        var roleId1 = new Guid("1090dcdd-b383-417b-9523-d73f0373fbb0");
        var roleId2 = new Guid("4a1c9012-a602-46a9-8eba-05e85149fd81");
        var roleId3 = new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d");
        builder.Entity<AppRole>().HasData(
            new AppRole
            {
                Id = roleId1,
                Name = "admin",
                Description = "Administrator role"
            },
            new AppRole
            {
                Id = roleId2,
                Name = "employee",
                Description = "Employee role"
            },
            new AppRole
            {
                Id = roleId3,
                Name = "customer",
                Description = "Customer role"
            });


        var hasher = new PasswordHasher<AppUser>();
        // user
        var userId1 = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
        var userId2 = new Guid("c2ec6dd4-8170-4b6d-acf4-33d52a128789");
        var userId3 = new Guid("3b294e1f-c3f7-4f71-9be6-11c614fbdce5");
        builder.Entity<AppUser>().HasData(
            new AppUser
            {
                Id = userId1,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "cuongnguyenpm1116@gmail.com",
                NormalizedEmail = "cuongnguyenpm1116@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "@bc19xyZ"),
                SecurityStamp = string.Empty,
                FirstName = "Cuong",
                LastName = "Nguyen Phuc Minh",
                DoB = new DateTime(2003, 11, 16)
            },
            new AppUser
            {
                Id = userId2,
                UserName = "kimhoc1",
                NormalizedUserName = "kimhoc1",
                Email = "hq37na@gmail.com",
                NormalizedEmail = "hq37na@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "@bc19xyZ"),
                SecurityStamp = string.Empty,
                FirstName = "Hoc",
                LastName = "Nguyen Kim",
                DoB = new DateTime(2003, 07, 19)
            },
            new AppUser
            {
                Id = userId3,
                UserName = "lmaohieu1",
                NormalizedUserName = "lmaohieu1",
                Email = "lusdeer@gmail.com",
                NormalizedEmail = "lusdeer@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "@bc19xyZ"),
                SecurityStamp = string.Empty,
                FirstName = "Hieu",
                LastName = "Le Minh",
                DoB = new DateTime(2003, 03, 18)
            });

        builder.Entity<IdentityUserRole<Guid>>().HasData(
            new IdentityUserRole<Guid>
            {
                RoleId = roleId1,
                UserId = userId1
            },
            new IdentityUserRole<Guid>
            {
                RoleId = roleId2,
                UserId = userId2
            },
            new IdentityUserRole<Guid>
            {
                RoleId = roleId3,
                UserId = userId3
            });

    }
}
