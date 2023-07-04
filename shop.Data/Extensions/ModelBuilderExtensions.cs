using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using shop.Data.Entities;
using shop.Data.Enums;

namespace shop.Data.Extensions;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder builder)
    {
        #region category
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
        #endregion

        #region product
        var productId1 = new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9");
        var productId2 = new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844");
        builder.Entity<Product>().HasData(
            new Product
            {
                Id = productId1,
                Name = "Gym Powerfit",
                Description = "Chất liệu: 86% Poly + 14% Spandex. Co giãn 4 chiều mang lại sự thoải mái để bạn vận động hết mình. Thiết kế công thái học, cải tiến giữ các đường may không bị mài mòn và tăng độ bền. Chất liệu thấm mồ hôi và khô nhanh, thoáng khí mang lại khả năng khô thoáng vượt trội. Form áo: Slim fit. Người mẫu: 180cm - 80kg, mặc áo size XL. Tự hào sản xuất tại Việt Nam",
                Status = Status.Active
            },
            new Product
            {
                Id = productId2,
                Name = "Cotton Summer Coolwaves",
                Description = "Sản phẩm trong Bộ sưu tập Summer. Chất liệu: 100% Cotton mềm mại. Định lượng vải: 200gsm, dày dặn. Dáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà. Hình in PET bền bỉ, không lo bong tróc, thoải mái giặt máy. Tự hào sản xuất tại Việt Nam",
                Status = Status.Active
            });
        #endregion

        #region color
        Guid colorId1 = new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0");
        Guid colorId2 = new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad");
        Guid colorId3 = new Guid("070139ef-2c91-4261-af8b-c07d2a5932b3");
        Guid colorId4 = new Guid("5b28789c-e43f-4e10-b447-6290d4130c66");
        Guid colorId5 = new Guid("97e83440-0351-4d34-9964-30aa65dd9cd5");
        Guid colorId6 = new Guid("a556951b-68bd-42d2-b7b3-a765ca19edf8");
        Guid colorId7 = new Guid("e481bd9d-e38c-4a2b-8194-30c0f6adc380");
        Guid colorId8 = new Guid("b9ed9a3a-0098-4575-93bc-d4beda3a0c0f");
        Guid colorId9 = new Guid("ee96d4a7-f5b8-4b83-b8bc-8b6d4c110e98");
        Guid colorId10 = new Guid("7f60198e-4f05-4cc5-8418-cffe41c392d4");

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
            },
            new Color
            {
                Id = colorId4,
                Name = "Đỏ",
            },
             new Color
             {
                 Id = colorId5,
                 Name = "Xanh lá cây",
             },
             new Color
             {
                 Id = colorId6,
                 Name = "Xanh dương",
             }, new Color
             {
                 Id = colorId7,
                 Name = "Vàng",
             },
            new Color
            {
                Id = colorId8,
                Name = "Cam",
            },
            new Color
            {
                Id = colorId9,
                Name = "Hồng",
            },
            new Color
            {
                Id = colorId10,
                Name = "Tím",
            });
        #endregion

        #region material
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
        #endregion

        #region size
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
                Name = "S",
                SortOrder = 1
            },
            new Size
            {
                Id = sizeId2,
                Name = "M",
                SortOrder = 2
            },
            new Size
            {
                Id = sizeId3,
                Name = "L",
                SortOrder = 3
            },
            new Size
            {
                Id = sizeId4,
                Name = "XL",
                SortOrder = 4
            },
            new Size
            {
                Id = sizeId5,
                Name = "XXL",
                SortOrder = 5
            },
            new Size
            {
                Id = sizeId6,
                Name = "XXXL",
                SortOrder = 6
            });
        #endregion

        #region product detail
        var productDetailId1 = new Guid("9a6ccc00-6b1c-40c5-be61-eb71323c9151");
        var productDetailId2 = new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45");
        var productDetailId3 = new Guid("b799297f-d21e-4280-8df9-a3c6788c806e");
        var productDetailId4 = new Guid("e3acb616-dd2c-44ee-93f0-754c68503b38");
        var productDetailId5 = new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e");
        var productDetailId6 = new Guid("9610c212-5a16-4a70-8703-6bc7f1224be0");
        var productDetailId7 = new Guid("28c12878-b191-4d42-974a-7b823de70a06");
        var productDetailId8 = new Guid("a6767d22-3ea0-4a00-ad31-9dce1d67184e");
        var productDetailId9 = new Guid("423f83df-dc6c-4b41-aa09-2fe30e841aa6");
        var productDetailId10 = new Guid("18cd05cb-f995-4b13-9fa4-a9e1f1c43862");
        var productDetailId11 = new Guid("0976ba79-d822-408a-86cb-e05045db09ed");
        var productDetailId12 = new Guid("6a008d16-196e-40fe-ada5-2acf339fbede");
        builder.Entity<ProductDetail>().HasData(
            new ProductDetail
            {
                Id = productDetailId1,
                ProductId = productId1,
                Stock = 50,
                Price = 199000,
                OriginalPrice = 150000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId2,
                SizeId = sizeId1,
            },
            new ProductDetail
            {
                Id = productDetailId2,
                ProductId = productId1,
                Stock = 50,
                Price = 199000,
                OriginalPrice = 150000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId2,
                SizeId = sizeId2,
            }, new ProductDetail
            {
                Id = productDetailId3,
                ProductId = productId1,
                Stock = 50,
                Price = 199000,
                OriginalPrice = 150000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId2,
                SizeId = sizeId3,
            },
            new ProductDetail
            {
                Id = productDetailId4,
                ProductId = productId1,
                Stock = 50,
                Price = 299000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId2,
                SizeId = sizeId4
            },
            new ProductDetail
            {
                Id = productDetailId5,
                ProductId = productId1,
                Stock = 50,
                Price = 299000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId2,
                SizeId = sizeId5
            }, new ProductDetail
            {
                Id = productDetailId6,
                ProductId = productId1,
                Stock = 50,
                Price = 299000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId2,
                SizeId = sizeId6
            }, new ProductDetail
            {
                Id = productDetailId7,
                ProductId = productId1,
                Stock = 50,
                Price = 299000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId1
            }, new ProductDetail
            {
                Id = productDetailId8,
                ProductId = productId1,
                Stock = 50,
                Price = 299000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId2
            }, new ProductDetail
            {
                Id = productDetailId9,
                ProductId = productId1,
                Stock = 50,
                Price = 299000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId3
            }, new ProductDetail
            {
                Id = productDetailId10,
                ProductId = productId1,
                Stock = 50,
                Price = 299000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId4
            }, new ProductDetail
            {
                Id = productDetailId11,
                ProductId = productId1,
                Stock = 50,
                Price = 299000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId5
            }, new ProductDetail
            {
                Id = productDetailId12,
                ProductId = productId1,
                Stock = 50,
                Price = 299000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId6
            });
        #endregion

        #region product in categories
        builder.Entity<ProductInCategory>().HasData(
            new ProductInCategory
            {
                ProductId = productId1,
                CategoryId = categoryId1
            },
            new ProductInCategory
            {
                ProductId = productId2,
                CategoryId = categoryId2
            });
        #endregion

        #region role
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
        #endregion

        #region user
        var hasher = new PasswordHasher<AppUser>();
        // user
        var userId1 = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
        var userId2 = new Guid("c2ec6dd4-8170-4b6d-acf4-33d52a128789");
        var userId3 = new Guid("3b294e1f-c3f7-4f71-9be6-11c614fbdce5");
        var userId4 = new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2");
        var userId5 = new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7");
        var userId6 = new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5");
        var userId7 = new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f");
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
            },
            new AppUser
            {
                Id = userId4,
                UserName = "john.doe",
                NormalizedUserName = "JOHN.DOE",
                Email = "john.doe@example.com",
                NormalizedEmail = "JOHN.DOE@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Password123!"),
                SecurityStamp = string.Empty,
                FirstName = "John",
                LastName = "Doe",
                DoB = new DateTime(1990, 01, 01)
            },
            new AppUser
            {
                Id = userId5,
                UserName = "jane.doe",
                NormalizedUserName = "JANE.DOE",
                Email = "jane.doe@example.com",
                NormalizedEmail = "JANE.DOE@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Password123!"),
                SecurityStamp = string.Empty,
                FirstName = "Jane",
                LastName = "Doe",
                DoB = new DateTime(1995, 05, 05)
            },
            new AppUser
            {
                Id = userId6,
                UserName = "bob.smith",
                NormalizedUserName = "BOB.SMITH",
                Email = "bob.smith@example.com",
                NormalizedEmail = "BOB.SMITH@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Password123!"),
                SecurityStamp = string.Empty,
                FirstName = "Bob",
                LastName = "Smith",
                DoB = new DateTime(1985, 12, 31)
            },
            new AppUser
            {
                Id = userId7,
                UserName = "jennifer.smith",
                NormalizedUserName = "JENNIFER.SMITH",
                Email = "jennifer.smith@example.com",
                NormalizedEmail = "JENNIFER.SMITH@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Password123!"),
                SecurityStamp = string.Empty,
                FirstName = "Jennifer",
                LastName = "Smith",
                DoB = new DateTime(1988, 10, 15)
            });
        #endregion

        #region user roles
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
            },
            new IdentityUserRole<Guid>
            {
                RoleId = roleId3,
                UserId = userId4
            }, new IdentityUserRole<Guid>
            {
                RoleId = roleId3,
                UserId = userId5
            }, new IdentityUserRole<Guid>
            {
                RoleId = roleId3,
                UserId = userId6
            }, new IdentityUserRole<Guid>
            {
                RoleId = roleId3,
                UserId = userId7
            });
        #endregion

        #region order
        var orderId1 = new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33");
        var orderId2 = new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24");
        var orderId3 = new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab");
        var orderId4 = new Guid("8fd4f3f5-4f1a-4f23-a2b0-1dbf8e9d7a9c");
        var orderId5 = new Guid("a60b3fd4-40a0-4f4e-8f5b-6e5a9a3d63e6");
        var orderId6 = new Guid("c9e9de6f-0e6f-4b3e-9f6c-3f8f3a0e6a1d");
        var orderId7 = new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af");

        //DateTime currentTime = DateTime.Now;
        //DateTime shipDate = currentTime.AddDays(1);
        //DateTime completedDate = shipDate.AddDays(3);
        DateTime completedDate = DateTime.Now;
        DateTime shipDate = completedDate.AddDays(-3);
        DateTime currentTime = shipDate.AddDays(-4);

        builder.Entity<Order>().HasData(
            new Order
            {
                Id = orderId1,
                UserId = userId1,
                OrderCode = "230703DDKbiC3SyDB9pN",
                CreatedDate = currentTime,
                PaidDate = currentTime,
                ShipDate = shipDate,
                CompletedDate = completedDate,
                ShipName = "Alice",
                ShipPhoneNumber = "0123456789",
                ShipAddress = "123 Main St.",
                Total = 1000000,
                OrderStatus = OrderStatus.Completed

            },
            new Order
            {
                Id = orderId2,
                UserId = userId2,
                OrderCode = "230703PmyoqNWHK3LZe3",
                CreatedDate = currentTime,
                PaidDate = currentTime,
                ShipDate = shipDate,
                CompletedDate = null,
                ShipName = "Alice",
                ShipPhoneNumber = "0123456789",
                ShipAddress = "1010 Oak Dr.",
                Total = 2000000,
                OrderStatus = OrderStatus.AWaitingPickup

            }, new Order
            {
                Id = orderId3,
                UserId = userId3,
                OrderCode = "23070306w3xM7UGUxRrW",
                CreatedDate = currentTime,
                PaidDate = null,
                ShipDate = null,
                CompletedDate = null,
                ShipName = "Alice",
                ShipPhoneNumber = "0123456789",
                ShipAddress = "1111 Pine Ln.",
                Total = 3000000,
                OrderStatus = OrderStatus.Pending

            }, new Order
            {
                Id = orderId4,
                UserId = userId4,
                OrderCode = "230703dkb7wDTr8wQ2rR",
                CreatedDate = currentTime,
                PaidDate = currentTime,
                ShipDate = shipDate,
                CompletedDate = completedDate,
                ShipName = "Alice",
                ShipPhoneNumber = "0123456789",
                ShipAddress = "123 Main St.",
                Total = 290000,
                OrderStatus = OrderStatus.Completed

            }, new Order
            {
                Id = orderId7,
                UserId = userId7,
                OrderCode = "230703kTwGUuaOxZ5sC1",
                CreatedDate = currentTime,
                PaidDate = null,
                ShipDate = null,
                CompletedDate = null,
                ShipName = "0987654321",
                ShipPhoneNumber = "0987654321",
                ShipAddress = "456 Elm St.",
                Total = 275000,
                OrderStatus = OrderStatus.Pending

            }, new Order
            {
                Id = orderId5,
                UserId = userId5,
                OrderCode = "230703P1u8nabxMakypB",
                CreatedDate = currentTime,
                PaidDate = currentTime,
                ShipDate = shipDate,
                CompletedDate = completedDate,
                ShipName = "0987654321",
                ShipPhoneNumber = "0987654321",
                ShipAddress = "789 Maple Ave.",
                Total = 129000,
                OrderStatus = OrderStatus.Completed

            }, new Order
            {
                Id = orderId6,
                UserId = userId6,
                OrderCode = "230703i5B6qeJ2IbxBVu",
                CreatedDate = currentTime,
                PaidDate = currentTime,
                ShipDate = shipDate,
                CompletedDate = completedDate,
                ShipName = "Charlie",
                ShipPhoneNumber = "0987654321",
                ShipAddress = "1212 Cedar Blvd.",
                Total = 232000,
                OrderStatus = OrderStatus.Completed

            });
        #endregion

        //var orderdetailId1 = new Guid("a9b9e7f3-6fb3-4c7c-8e2d-19f4c7d7d1ba");
        //var orderdetailId2 = new Guid("45b8fada-8d4b-4e8f-944c-0d4d2c4f760a");
        //var orderdetailId3 = new Guid("c5c4c8fa-7db7-4b5d-8e5f-5b8c4c7b618f");
        //var orderdetailId4 = new Guid("f4f4b1d2-fbc7-4c7a-a4b6-8d4d5e6f7a8b");

        #region order detail
        builder.Entity<OrderDetail>().HasData(
            new OrderDetail
            {
                //Id = orderdetailId1,
                OrderId = orderId1,
                ProductDetailId = productDetailId1,
                Quantity = 5,
                Price = 199000,
                Status = Status.Active
            },
            new OrderDetail
            {
                //Id = orderdetailId2,
                OrderId = orderId1,
                ProductDetailId = productDetailId2,
                Quantity = 5,
                Price = 199000,
                Status = Status.Active
            },
            new OrderDetail
            {
                //Id = orderdetailId3,
                OrderId = orderId2,
                ProductDetailId = productDetailId3,
                Quantity = 5,
                Price = 199000,
                Status = Status.Active
            },
            new OrderDetail
            {
                //Id = orderdetailId4,
                OrderId = orderId2,
                ProductDetailId = productDetailId4,
                Quantity = 5,
                Price = 199000,
                Status = Status.Active
            },
            new OrderDetail
            {
                OrderId = orderId4,
                ProductDetailId = productDetailId5,
                Quantity = 5,
                Price = 290000,
                Status = Status.Active
            },
            new OrderDetail
            {
                OrderId = orderId5,
                ProductDetailId = productDetailId2,
                Quantity = 5,
                Price = 290000,
                Status = Status.Active
            }
            ,
            new OrderDetail
            {
                OrderId = orderId6,
                ProductDetailId = productDetailId5,
                Quantity = 5,
                Price = 290000,
                Status = Status.Active
            },
            new OrderDetail
            {
                OrderId = orderId7,
                ProductDetailId = productDetailId5,
                Quantity = 5,
                Price = 290000,
                Status = Status.Active
            },
            new OrderDetail
            {
                OrderId = orderId3,
                ProductDetailId = productDetailId5,
                Quantity = 5,
                Price = 199000,
                Status = Status.Active
            });
        #endregion
    }
}
