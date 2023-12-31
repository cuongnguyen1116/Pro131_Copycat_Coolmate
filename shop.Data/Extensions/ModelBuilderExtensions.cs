﻿using Microsoft.AspNetCore.Identity;
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
        var productId3 = new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256");
        var productId4 = new Guid("42eea6d0-d14a-4d9e-850f-5f340311bde3");
        var productId5 = new Guid("b6f2feb6-8373-43c0-8db3-f5d6e664062c");
        var productId6 = new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474");
        var productId7 = new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8");
        var productId8 = new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5");
        var productId9 = new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d");
        var productId10 = new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc");
        var productId11 = new Guid("b208c071-8450-4999-9cc4-1bf37d7f9294");
        var productId12 = new Guid("3241c204-eb4a-4f41-a214-c77a74577db4");
        var productId13 = new Guid("1975818f-1d1d-4df8-8477-0afaf9687945");
        var productId14 = new Guid("a8edbd5b-dd2b-42d1-84b4-013e867d0f88");
        var productId15 = new Guid("217cc99e-4586-4fc2-9e87-66ba1061426f");
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
                Name = "Summer Coolwaves",
                Description = "Sản phẩm trong Bộ sưu tập Summer. Chất liệu: 100% Cotton mềm mại. Định lượng vải: 200gsm, dày dặn. Dáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà. Hình in PET bền bỉ, không lo bong tróc, thoải mái giặt máy. Tự hào sản xuất tại Việt Nam",
                Status = Status.Active
            },
            new Product
            {
                Id = productId3,
                Name = "Quick Dry in Graphic R1",
                Description = "Chất liệu: 95% Polyester Quick-Dry + 5% Spandex. Xử lý hoàn thiện vải: Quick-Dry + Wicking + Stretch. Công nghệ Chafe-Free hạn chế tối đa ma sát trong quá trình vận động từ các đường may may Seamless. Định lượng vải 100gsm siêu nhẹ. Được phát triển và kiểm nghiệm bởi các VĐV Marathon. Tự hào sản xuất tại Việt Nam",
                Status = Status.Active
            },
            new Product
            {
                Id = productId4,
                Name = "Essential Fast & Free Run",
                Description = "Chất liệu: 97% Polyester Quick-Dry + 3% Spandex. Xử lý hoàn thiện vải: Quick-Dry + Wicking + Stretch. Công nghệ Chafe-Free may Seamless hạn chế tối đa ma sát trong quá trình vận động. Định lượng vải 110gsm siêu nhẹ. Được nghiên cứu và phát triển phù hợp dựa trên các Runner chuyên nghiệp. Tự hào sản xuất tại Việt Nam",
                Status = Status.Active
            },
            new Product
            {
                Id = productId5,
                Name = "Coolmate Basics 200gsm",
                Description = "Chất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nTự hào sản xuất tại Việt Nam",
                Status = Status.Active
            },
            new Product
            {
                Id = productId6,
                Name = "Clean Vietnam",
                Description = "Đây là sản phẩm thuộc Clean Vietnam Collection\r\nChất liệu: 80% Cotton - 20% Recycle Polyester,co giãn 4 chiều\r\nKiểu dáng: regularfit dáng suông\r\nPhù hợp với: đi chơi, đi làm, ở nhà\r\nTự hào sản xuất tại Việt Nam\r\nMục tiêu dự án đến 2023 sẽ tái chế được 500.000 chai nhựa thành sợi và sản xuất thành sản phẩm tốt về công năng",
                Status = Status.Active
            },
            new Product
            {
                Id = productId7,
                Name = "Compact phiên bản Premium",
                Description = "Chất liệu: 95% Cotton Compact - 5% Spandex\r\nPhù hợp với: mặc ở nhà, đi làm, đi chơi\r\nKiểu dáng: Regular Fit dáng suông\r\nTự hào sản xuất tại Việt Nam Xem nhà máy >\r\nNgười mẫu: 184 cm, 73 kg, mặc size 2XL",
                Status = Status.Active
            },
            new Product
            {
                Id = productId8,
                Name = "Summer Coolwaves Graphic",
                Description = "Sản phẩm trong Bộ sưu tập Summer\r\nChất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nHình in PET bền bỉ, không lo bong tróc, thoải mái giặt máy\r\nTự hào sản xuất tại Việt Nam",
                Status = Status.Active
            },
            new Product
            {
                Id = productId9,
                Name = "Summer Coolwaves Graphic - Cây dừa",
                Description = "Sản phẩm trong Bộ sưu tập Summer\r\nChất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nHình in PET bền bỉ, không lo bong tróc, thoải mái giặt máy\r\nTự hào sản xuất tại Việt Nam",
                Status = Status.Active
            },
            new Product
            {
                Id = productId10,
                Name = "Care &Share Tuổi thơ dữ dội - Bắn bi",
                Description = "10% Doanh thu từ mỗi sản phẩm sẽ được quyên góp vào Quỹ Care & Share\r\nChất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nTự hào sản xuất tại Việt Nam",
                Status = Status.Active
            },
            new Product
            {
                Id = productId11,
                Name = "Care &Share Tuổi thơ dữ dội - Pattern tranh",
                Description = "10% Doanh thu từ mỗi sản phẩm sẽ được quyên góp vào Quỹ Care & Share\r\nChất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nTự hào sản xuất tại Việt Nam",
                Status = Status.Active
            },
            new Product
            {
                Id = productId12,
                Name = "Care &Share Tuổi thơ dữ dội - Tắm mưa",
                Description = "10% Doanh thu từ mỗi sản phẩm sẽ được quyên góp vào Quỹ Care & Share\r\nChất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nTự hào sản xuất tại Việt Nam",
                Status = Status.Active
            },
            new Product
            {
                Id = productId13,
                Name = "Care & Share The Moments - Bản lĩnh",
                Description = "Sản phẩm Care & Share hợp tác với cầu thủ nữ ĐTQG Việt Nam Huỳnh Như\r\n10% Doanh thu từ mỗi sản phẩm bán ra sẽ được quyên góp vào Quỹ Care & Share\r\nChất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nTự hào sản xuất tại Việt Nam",
                Status = Status.Active
            },
            new Product
            {
                Id = productId14,
                Name = "Advanced Fast & Free Run",
                Description = "Chất liệu: 95% Polyester Quick-Dry + 5% Spandex\r\nXử lý hoàn thiện vải: Quick-Dry + Wicking + Stretch\r\nCông nghệ Chafe-Free hạn chế tối đa ma sát trong quá trình vận động từ các đường may may Seamless\r\nĐịnh lượng vải 100gsm siêu nhẹ\r\nĐược phát triển và kiểm nghiệm bởi các VĐV Marathon\r\nTự hào sản xuất tại Việt Nam",
                Status = Status.Active
            },
            new Product
            {
                Id = productId15,
                Name = "Care &Share Tuổi thơ dữ dội - Bấm chuông",
                Description = "10% Doanh thu từ mỗi sản phẩm sẽ được quyên góp vào Quỹ Care & Share\r\nChất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nTự hào sản xuất tại Việt Nam",
                Status = Status.Active
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
                CategoryId = categoryId1
            },
            new ProductInCategory
            {
                ProductId = productId3,
                CategoryId = categoryId1
            },
            new ProductInCategory
            {
                ProductId = productId4,
                CategoryId = categoryId1
            },
            new ProductInCategory
            {
                ProductId = productId5,
                CategoryId = categoryId1
            },
            new ProductInCategory
            {
                ProductId = productId6,
                CategoryId = categoryId1
            },
            new ProductInCategory
            {
                ProductId = productId7,
                CategoryId = categoryId1
            },
            new ProductInCategory
            {
                ProductId = productId8,
                CategoryId = categoryId1
            },
            new ProductInCategory
            {
                ProductId = productId9,
                CategoryId = categoryId1
            },
            new ProductInCategory
            {
                ProductId = productId10,
                CategoryId = categoryId1
            },
            new ProductInCategory
            {
                ProductId = productId11,
                CategoryId = categoryId1
            },
            new ProductInCategory
            {
                ProductId = productId12,
                CategoryId = categoryId1
            },
            new ProductInCategory
            {
                ProductId = productId13,
                CategoryId = categoryId1
            },
            new ProductInCategory
            {
                ProductId = productId14,
                CategoryId = categoryId1
            },
            new ProductInCategory
            {
                ProductId = productId15,
                CategoryId = categoryId1
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
        var productDetailID13 = new Guid("180b5870-f77b-4ae6-b4ff-231b27a9bc51");
        var productDetailID14 = new Guid("c078a922-9d8e-44d3-a0d4-02aff2ff02a0");
        var productDetailID15 = new Guid("524b7e19-cc28-4a7b-aa53-bb6de7b0e1ea");
        var productDetailID16 = new Guid("ed8c924a-e97e-4063-986d-27e1c76d0db6");
        var productDetailID17 = new Guid("59d46d45-02e7-46a6-baca-426683257859");
        var productDetailID18 = new Guid("62b387f6-b535-4dfe-a310-76899ee9dec1");
        var productDetailID19 = new Guid("90508eca-a616-4b65-9114-aacb1a23ef6f");
        var productDetailID20 = new Guid("84cf39b1-d8d1-4538-9467-62b7dc41aaae");
        var productDetailID21 = new Guid("0b3f534f-6dad-4543-804d-a6fce2a4674c");
        var productDetailID22 = new Guid("6dd2eb52-3aff-4208-ae75-fe7186aafb16");
        var productDetailID23 = new Guid("b5978ede-0f5d-4732-9c27-0097c9f27029");
        var productDetailID24 = new Guid("e9627388-f53b-4600-9db6-30b5c6061a2b");
        var productDetailID25 = new Guid("79369e3d-570a-4f1d-8722-9a2daa52ae46");
        var productDetailID26 = new Guid("53f989a8-c813-4667-8a5b-d57b016329a2");
        var productDetailID27 = new Guid("cbbdbb20-a323-440c-b4ef-7494704a0ebe");
        var productDetailID28 = new Guid("85b4ff3f-1fa0-4597-9177-feece10892b7");
        var productDetailID29 = new Guid("702c91f1-6fd7-4ed8-b8fd-ec4d9b49005f");
        var productDetailID30 = new Guid("a648500a-ee4e-4fa6-ac8d-272670b4fece");
        var productDetailID31 = new Guid("e8d5e782-9027-4d0b-886f-43b9b1821647");
        var productDetailID32 = new Guid("af828b6f-1e3a-4668-af79-925e039fed0a");
        var productDetailID33 = new Guid("c455cb74-947f-43f5-8396-52701206a747");
        var productDetailID34 = new Guid("acb2aea8-07e1-4b38-96bb-5be8ed7ad5cd");
        var productDetailID35 = new Guid("81434550-b237-420d-a407-ea8db1301136");
        var productDetailID36 = new Guid("d34df8f4-7796-4743-8769-04a005d0eefd");
        var productDetailID37 = new Guid("c4ad16dd-57c2-4d70-8c40-a156cf208314");
        var productDetailID38 = new Guid("1ed004a7-ac94-4c57-b871-564543bc8b38");
        var productDetailID39 = new Guid("cf3450f2-6b36-4797-a249-8285fd6069de");
        var productDetailID40 = new Guid("a7e56ca4-bf8e-4cf0-9d07-e95a275b869a");
        var productDetailID41 = new Guid("9edbd50b-02a5-48d0-9acd-6394385185f2");
        var productDetailID42 = new Guid("64a31f58-96a0-40d4-a3b5-cebb464f9708");
        var productDetailID43 = new Guid("3a1f9be1-c963-4789-8cbc-a935f94e6ef7");
        var productDetailID44 = new Guid("cc1a10ec-0b47-4308-8876-6c7523da99b3");
        var productDetailID45 = new Guid("2fecd681-ba9f-4ef9-8ce4-8315328dce20");
        var productDetailID46 = new Guid("25f1829c-ad64-4e8f-9c8b-e8bf53592304");
        var productDetailID47 = new Guid("17ddc867-2a86-4a23-9ee0-a60ae4d238dc");
        var productDetailID48 = new Guid("eac0583e-715f-4e1a-a793-42ac142256fb");
        var productDetailID49 = new Guid("a6188eb6-6679-4b1c-917b-083878b3182e");
        var productDetailID50 = new Guid("42fd8c77-f1ea-4827-a8ba-cfa758d9525e");
        var productDetailID51 = new Guid("f5ef450e-5ee9-4525-abde-c404039cd7bc");
        var productDetailID52 = new Guid("186dd464-1acc-46c0-98e5-80724ef9a7a0");
        var productDetailID53 = new Guid("37cb83db-2428-4fbb-a8da-fc4554f71729");
        var productDetailID54 = new Guid("c7d3c45e-7c7e-431d-967c-a7346c06e123");
        var productDetailID55 = new Guid("dfab5d49-4286-40f7-befc-89dd54baa9c5");
        var productDetailID56 = new Guid("9902bd0d-729a-49c9-b190-4991f5cf6ccd");
        var productDetailID57 = new Guid("a3be12fa-6696-46b9-a270-b56860f10cc9");
        var productDetailID58 = new Guid("280ab97b-e8f8-461c-83b1-178161bdd11d");
        var productDetailID59 = new Guid("0f673bb8-f743-42f8-ba9e-50c6e7bd2b9b");
        var productDetailID60 = new Guid("111f1d26-a7e8-429c-a7b9-21427cf975fc");
        var productDetailID61 = new Guid("6b58ba80-86df-4671-a17b-17a65dd4f7b2");
        var productDetailID62 = new Guid("1faa9efb-c6c0-4e5e-888c-0010dede6497");
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
                Price = 209000,
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
                Price = 219000,
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
                Price = 229000,
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
                Price = 239000,
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
                Price = 249000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId2,
                SizeId = sizeId6
            }, new ProductDetail
            {
                Id = productDetailId7,
                ProductId = productId2,
                Stock = 50,
                Price = 259000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId1
            }, new ProductDetail
            {
                Id = productDetailId8,
                ProductId = productId2,
                Stock = 50,
                Price = 269000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId2
            }, new ProductDetail
            {
                Id = productDetailId9,
                ProductId = productId2,
                Stock = 50,
                Price = 279000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId3
            }, new ProductDetail
            {
                Id = productDetailId10,
                ProductId = productId2,
                Stock = 50,
                Price = 289000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId4
            }, new ProductDetail
            {
                Id = productDetailId11,
                ProductId = productId2,
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
                ProductId = productId2,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId6
            }, new ProductDetail
            {
                Id = productDetailID13,
                ProductId = productId3,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId1
            }, new ProductDetail
            {
                Id = productDetailID14,
                ProductId = productId3,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId2
            }, new ProductDetail
            {
                Id = productDetailID15,
                ProductId = productId3,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId3
            }, new ProductDetail
            {
                Id = productDetailID16,
                ProductId = productId3,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId4
            }, new ProductDetail
            {
                Id = productDetailID17,
                ProductId = productId4,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId1
            }, new ProductDetail
            {
                Id = productDetailID18,
                ProductId = productId4,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId2
            }, new ProductDetail
            {
                Id = productDetailID19,
                ProductId = productId4,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId3
            }, new ProductDetail
            {
                Id = productDetailID20,
                ProductId = productId4,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId4
            }, new ProductDetail
            {
                Id = productDetailID21,
                ProductId = productId5,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId1
            }, new ProductDetail
            {
                Id = productDetailID22,
                ProductId = productId5,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId2
            }, new ProductDetail
            {
                Id = productDetailID23,
                ProductId = productId5,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId3
            }, new ProductDetail
            {
                Id = productDetailID24,
                ProductId = productId5,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId4
            }, new ProductDetail
            {
                Id = productDetailID25,
                ProductId = productId6,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId1
            }, new ProductDetail
            {
                Id = productDetailID26,
                ProductId = productId6,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId2
            }, new ProductDetail
            {
                Id = productDetailID27,
                ProductId = productId6,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId3
            }, new ProductDetail
            {
                Id = productDetailID28,
                ProductId = productId6,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId4
            }, new ProductDetail
            {
                Id = productDetailID29,
                ProductId = productId7,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId1
            }, new ProductDetail
            {
                Id = productDetailID30,
                ProductId = productId7,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId2
            }, new ProductDetail
            {
                Id = productDetailID31,
                ProductId = productId7,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId3
            }, new ProductDetail
            {
                Id = productDetailID32,
                ProductId = productId7,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId4
            }, new ProductDetail
            {
                Id = productDetailID33,
                ProductId = productId8,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId1
            }, new ProductDetail
            {
                Id = productDetailID34,
                ProductId = productId8,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId2
            }, new ProductDetail
            {
                Id = productDetailID35,
                ProductId = productId8,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId3
            }, new ProductDetail
            {
                Id = productDetailID36,
                ProductId = productId8,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId4
            }, new ProductDetail
            {
                Id = productDetailID37,
                ProductId = productId9,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId1
            }, new ProductDetail
            {
                Id = productDetailID38,
                ProductId = productId9,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId2
            }, new ProductDetail
            {
                Id = productDetailID39,
                ProductId = productId9,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId3
            }, new ProductDetail
            {
                Id = productDetailID40,
                ProductId = productId9,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId4
            }, new ProductDetail
            {
                Id = productDetailID41,
                ProductId = productId9,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId5
            }, new ProductDetail
            {
                Id = productDetailID42,
                ProductId = productId9,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId6
            }, new ProductDetail
            {
                Id = productDetailID43,
                ProductId = productId10,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId1
            }, new ProductDetail
            {
                Id = productDetailID44,
                ProductId = productId10,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId2
            }, new ProductDetail
            {
                Id = productDetailID45,
                ProductId = productId10,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId3
            }, new ProductDetail
            {
                Id = productDetailID46,
                ProductId = productId10,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId4
            }, new ProductDetail
            {
                Id = productDetailID47,
                ProductId = productId11,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId1
            }, new ProductDetail
            {
                Id = productDetailID48,
                ProductId = productId11,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId2
            }, new ProductDetail
            {
                Id = productDetailID49,
                ProductId = productId12,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId1
            }, new ProductDetail
            {
                Id = productDetailID50,
                ProductId = productId12,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId2
            }, new ProductDetail
            {
                Id = productDetailID51,
                ProductId = productId12,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId3
            }, new ProductDetail
            {
                Id = productDetailID52,
                ProductId = productId12,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId4
            }, new ProductDetail
            {
                Id = productDetailID53,
                ProductId = productId13,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId1
            }, new ProductDetail
            {
                Id = productDetailID54,
                ProductId = productId13,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId2
            }, new ProductDetail
            {
                Id = productDetailID55,
                ProductId = productId13,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId1
            }, new ProductDetail
            {
                Id = productDetailID56,
                ProductId = productId13,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId2
            }, new ProductDetail
            {
                Id = productDetailID57,
                ProductId = productId14,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId1
            }, new ProductDetail
            {
                Id = productDetailID58,
                ProductId = productId14,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId2
            }, new ProductDetail
            {
                Id = productDetailID59,
                ProductId = productId15,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId1
            }, new ProductDetail
            {
                Id = productDetailID60,
                ProductId = productId15,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId2
            }, new ProductDetail
            {
                Id = productDetailID61,
                ProductId = productId15,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId3
            }, new ProductDetail
            {
                Id = productDetailID62,
                ProductId = productId15,
                Stock = 50,
                Price = 309000,
                OriginalPrice = 200000,
                CreatedDate = DateTime.Now,
                MaterialId = materialId1,
                ColorId = colorId1,
                SizeId = sizeId4
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
                NormalizedName = "ADMIN",
                Description = "Administrator role"
            },
            new AppRole
            {
                Id = roleId2,
                Name = "employee",
                NormalizedName="EMPLOYEE",
                Description = "Employee role"
            },
            new AppRole
            {
                Id = roleId3,
                Name = "customer",
                NormalizedName = "CUSTOMER",
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
        var userId8 = new Guid("66c7e036-0cbd-4350-9afe-5e1e0c959bcf");
        var userId9 = new Guid("7ee56101-aff6-4d71-8112-e118ada30353");
        var userId10 = new Guid("c7378d1c-47f6-4cc5-b800-281023b6699a");
        var userId11 = new Guid("513b6e27-9ec8-4339-8cd2-ce42a2c6a01e");
        var userId12 = new Guid("8db920d7-5115-432c-a9ad-3039dfed3244");
        var userId13 = new Guid("873c3aed-38c2-41ef-b03a-4e142dae542c");
        var userId14 = new Guid("598ded7d-1f81-43a9-861c-21a026294eb1");
        var userId15 = new Guid("a72558d6-0e2f-463f-9ce9-c7a232b7eb89");

        var user1 = new AppUser
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
            PhoneNumber = "0987654321",
            LastName = "Nguyen Phuc Minh",
            DoB = new DateTime(2003, 11, 16)
        };

        var user2 = new AppUser
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
            PhoneNumber = "0987654321",
            DoB = new DateTime(2003, 07, 19)
        };

        var user3 = new AppUser
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
            PhoneNumber = "0987654321",
            LastName = "Le Minh",
            DoB = new DateTime(2003, 03, 18)
        };

        var user4 = new AppUser
        {
            Id = userId4,
            UserName = "doesnot90",
            NormalizedUserName = "doesnot90",
            Email = "john.doe@example.com",
            NormalizedEmail = "JOHN.DOE@EXAMPLE.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "@bc19xyZ"),
            SecurityStamp = string.Empty,
            FirstName = "John",
            LastName = "Doe",
            PhoneNumber = "0987654321",
            DoB = new DateTime(1990, 01, 01)
        };

        var user5 = new AppUser
        {
            Id = userId5,
            UserName = "janenotlost123",
            NormalizedUserName = "janenotlost123",
            Email = "jane.doe@example.com",
            NormalizedEmail = "JANE.DOE@EXAMPLE.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "@bc19xyZ"),
            SecurityStamp = string.Empty,
            FirstName = "Jane",
            LastName = "Doe",
            PhoneNumber = "0987654321",
            DoB = new DateTime(1995, 05, 05)
        };

        var user6 = new AppUser
        {
            Id = userId6,
            UserName = "bobthebuilder98",
            NormalizedUserName = "bobthebuilder98",
            Email = "bob.smith@example.com",
            NormalizedEmail = "BOB.SMITH@EXAMPLE.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "@bc19xyZ"),
            SecurityStamp = string.Empty,
            FirstName = "Bob",
            LastName = "Smith",
            PhoneNumber = "0987654321",
            DoB = new DateTime(1998, 12, 31)
        };

        var user7 = new AppUser
        {
            Id = userId7,
            UserName = "beautysmithlady159",
            NormalizedUserName = "beautysmithlady159",
            Email = "jennifer.smith@example.com",
            NormalizedEmail = "JENNIFER.SMITH@EXAMPLE.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "@bc19xyZ"),
            SecurityStamp = string.Empty,
            FirstName = "Jennifer",
            LastName = "Smith",
            PhoneNumber = "0987654321",
            DoB = new DateTime(1988, 10, 15)
        };

        var user8 = new AppUser
        {
            Id = userId8,
            UserName = "notmylover199",
            NormalizedUserName = "notmylover199",
            Email = "jennifer.smith@example.com",
            NormalizedEmail = "JENNIFER.SMITH@EXAMPLE.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "@bc19xyZ"),
            SecurityStamp = string.Empty,
            FirstName = "Billie",
            PhoneNumber = "0987654321",
            LastName = "Jean",
            DoB = new DateTime(1988, 10, 15)
        };

        var user9 = new AppUser
        {
            Id = userId9,
            UserName = "michaelthoangmong1",
            NormalizedUserName = "michaelthoangmong1",
            Email = "michealthoangmong@gmail.com",
            NormalizedEmail = "MICHAELTHOANGMONG1@GMAIL.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "@bc19xyZ"),
            SecurityStamp = string.Empty,
            FirstName = "Michael",
            PhoneNumber = "0987654321",
            LastName = "Jackson",
            DoB = new DateTime(1988, 10, 15)
        };

        var user10 = new AppUser
        {
            Id = userId10,
            UserName = "michaelthoangmong1",
            NormalizedUserName = "michaelthoangmong1",
            Email = "michealthoangmong@gmail.com",
            NormalizedEmail = "MICHAELTHOANGMONG1@GMAIL.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "@bc19xyZ"),
            SecurityStamp = string.Empty,
            FirstName = "Michael",
            PhoneNumber = "0987654321",
            LastName = "Jackson",
            DoB = new DateTime(1988, 10, 15)
        };

        var user11 = new AppUser
        {
            Id = userId11,
            UserName = "taylorswift109",
            NormalizedUserName = "taylorswift109",
            Email = "taylorswift109@gmail.com",
            NormalizedEmail = "TAYLORSWIFT109@gmail.com",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "@bc19xyZ"),
            SecurityStamp = string.Empty,
            FirstName = "Thúy",
            LastName = "Loan",
            PhoneNumber = "0987654321",
            DoB = new DateTime(1988, 10, 15)
        };

        var user12 = new AppUser
        {
            Id = userId12,
            UserName = "grande145",
            NormalizedUserName = "grande145",
            Email = "grande145@gmail.com",
            NormalizedEmail = "GRANDE145@gmail.com",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "@bc19xyZ"),
            SecurityStamp = string.Empty,
            FirstName = "Ariana",
            PhoneNumber = "0987654321",
            LastName = "Grande",
            DoB = new DateTime(1988, 10, 15)
        };

        var user13 = new AppUser
        {
            Id = userId13,
            UserName = "camila119",
            NormalizedUserName = "camila119",
            Email = "camila119@gmail.com",
            NormalizedEmail = "CAMILA119@gmail.com",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "@bc19xyZ"),
            SecurityStamp = string.Empty,
            FirstName = "Karla Camila",
            PhoneNumber = "0987654321",
            LastName = " Cabello Estrabao",
            DoB = new DateTime(1988, 10, 15)
        };

        var user14 = new AppUser
        {
            Id = userId14,
            UserName = "miley987",
            NormalizedUserName = "miley987",
            Email = "miley987@gmail.com",
            NormalizedEmail = "MILEY987@gmail.com",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "@bc19xyZ"),
            SecurityStamp = string.Empty,
            FirstName = "Robyn",
            PhoneNumber = "0987654321",
            LastName = "Fenty",
            DoB = new DateTime(1988, 10, 15)
        };

        var user15 = new AppUser
        {
            Id = userId15,
            UserName = "drake123",
            NormalizedUserName = "drake123",
            Email = "drake123@gmail.com",
            NormalizedEmail = "DRAKE123@gmail.com",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "@bc19xyZ"),
            SecurityStamp = string.Empty,
            PhoneNumber = "0987654321",
            FirstName = "Aubrey",
            LastName = "Drake Graham",
            DoB = new DateTime(1988, 10, 15)
        };

        builder.Entity<AppUser>().HasData(user1, user2, user3, user4, user5, user6, user7, user8, user9, user10, user11, user12, user13, user14, user15);
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
            },
            new IdentityUserRole<Guid>
            {
                RoleId = roleId3,
                UserId = userId5
            },
            new IdentityUserRole<Guid>
            {
                RoleId = roleId3,
                UserId = userId6
            }, new IdentityUserRole<Guid>
            {
                RoleId = roleId3,
                UserId = userId7
            }, new IdentityUserRole<Guid>
            {
                RoleId = roleId3,
                UserId = userId8
            }, new IdentityUserRole<Guid>
            {
                RoleId = roleId3,
                UserId = userId9
            }, new IdentityUserRole<Guid>
            {
                RoleId = roleId3,
                UserId = userId10
            }, new IdentityUserRole<Guid>
            {
                RoleId = roleId3,
                UserId = userId11
            }, new IdentityUserRole<Guid>
            {
                RoleId = roleId3,
                UserId = userId12
            }, new IdentityUserRole<Guid>
            {
                RoleId = roleId3,
                UserId = userId13
            }, new IdentityUserRole<Guid>
            {
                RoleId = roleId3,
                UserId = userId14
            },
            new IdentityUserRole<Guid>
            {
                RoleId = roleId3,
                UserId = userId15
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
        var orderId8 = new Guid("fba2e1cb-2d69-40b1-acdf-46c3ea2f8840");
        var orderId9 = new Guid("b7683f6d-2bf4-4edb-971f-1b4d017244fd");
        var orderId10 = new Guid("25610f9a-ecf7-4202-a6ab-dcbe86c20bb8");
        var orderId11 = new Guid("5f312584-d47e-4e8b-bc9c-584657befbf6");
        var orderId12 = new Guid("41e0267d-90e0-4429-b3c6-c1eb650bc680");

        DateTime createdDate = DateTime.Now;

        var order1 = new Order
        {
            Id = orderId1,
            UserId = userId4,
            OrderCode = "230703DDKbiC3SyDB9pN",
            CreatedDate = createdDate,
            PaidDate = null,
            ShipDate = null,
            CompletedDate = null,
            ShipName = "Alice",
            ShipPhoneNumber = "0123456789",
            ShipAddress = "123 Main St.",
            Total = 1000000,
            OrderStatus = OrderStatus.Pending
        };

        var order2 = new Order
        {
            Id = orderId2,
            UserId = userId5,
            OrderCode = "230703PmyoqNWHK3LZe3",
            CreatedDate = createdDate,
            ConfirmedDate = createdDate,
            PaidDate = null,
            ShipDate = null,
            CompletedDate = null,
            ShipName = "Alice",
            ShipPhoneNumber = "0123456789",
            ShipAddress = "1010 Oak Dr.",
            Total = 2000000,
            OrderStatus = OrderStatus.Pending

        };

        var order3 = new Order
        {
            Id = orderId3,
            UserId = userId6,
            OrderCode = "23070306w3xM7UGUxRrW",
            CreatedDate = createdDate,
            PaidDate = null,
            ShipDate = null,
            CompletedDate = null,
            ShipName = "Alice",
            ShipPhoneNumber = "0123456789",
            ShipAddress = "1111 Pine Ln.",
            Total = 3000000,
            OrderStatus = OrderStatus.Pending
        };

        var order4 = new Order
        {
            Id = orderId4,
            UserId = userId7,
            OrderCode = "230703dkb7wDTr8wQ2rR",
            CreatedDate = createdDate,
            PaidDate = null,
            ShipDate = null,
            CompletedDate = null,
            ShipName = "Alice",
            ShipPhoneNumber = "0123456789",
            ShipAddress = "123 Main St.",
            Total = 290000,
            OrderStatus = OrderStatus.Pending
        };

        var order5 = new Order
        {
            Id = orderId5,
            UserId = userId8,
            OrderCode = "230703kTwGUuaOxZ5sC1",
            CreatedDate = createdDate,
            ShipName = "0987654321",
            ShipPhoneNumber = "0987654321",
            ShipAddress = "456 Elm St.",
            Total = 275000,
            OrderStatus = OrderStatus.Pending
        };

        var order6 = new Order
        {
            Id = orderId6,
            UserId = userId9,
            OrderCode = "230703P1u8nabxMakypB",
            CreatedDate = createdDate,
            ShipName = "0987654321",
            ShipPhoneNumber = "0987654321",
            ShipAddress = "789 Maple Ave.",
            Total = 129000,
            OrderStatus = OrderStatus.Pending
        };

        var order7 = new Order
        {
            Id = orderId7,
            UserId = userId10,
            OrderCode = "230707Tu7QJBJH2oY0Hd",
            CreatedDate = createdDate,
            ShipName = "Charlie",
            ShipPhoneNumber = "0987654321",
            ShipAddress = "1212 Cedar Blvd.",
            Total = 232000,
            OrderStatus = OrderStatus.Pending
        };

        var order8 = new Order
        {
            Id = orderId8,
            UserId = userId11,
            OrderCode = "230703i5B6qeJ2IbxBVu",
            CreatedDate = createdDate,
            ShipName = "Charlie",
            ShipPhoneNumber = "0987654321",
            ShipAddress = "1212 Cedar Blvd.",
            Total = 232000,
            OrderStatus = OrderStatus.Pending
        };

        var order9 = new Order
        {
            Id = orderId9,
            UserId = userId12,
            OrderCode = "230707yM2UVPAfwmGRxX",
            CreatedDate = createdDate,
            ShipName = "Charlie",
            ShipPhoneNumber = "0987654321",
            ShipAddress = "1212 Cedar Blvd.",
            Total = 232000,
            OrderStatus = OrderStatus.Pending
        };

        var order10 = new Order
        {
            Id = orderId10,
            UserId = userId13,
            OrderCode = "230707hIlOvA0CTr0i7f",
            CreatedDate = createdDate,
            ShipName = "Charlie",
            ShipPhoneNumber = "0987654321",
            ShipAddress = "1212 Cedar Blvd.",
            Total = 232000,
            OrderStatus = OrderStatus.Pending
        };

        var order11 = new Order
        {
            Id = orderId11,
            UserId = userId14,
            OrderCode = "230707FYufCS6av9hB9Q",
            CreatedDate = createdDate,
            ShipName = "Charlie",
            ShipPhoneNumber = "0987654321",
            ShipAddress = "1212 Cedar Blvd.",
            Total = 232000,
            OrderStatus = OrderStatus.Pending
        };

        var order12 = new Order
        {
            Id = orderId12,
            UserId = userId15,
            OrderCode = "230707LZwAHJX5VmjwWx",
            CreatedDate = createdDate,
            ShipName = "Charlie",
            ShipPhoneNumber = "0987654321",
            ShipAddress = "1212 Cedar Blvd.",
            Total = 232000,
            OrderStatus = OrderStatus.Pending
        };

        builder.Entity<Order>().HasData(order1, order2, order3, order4, order5, order6, order7, order8, order9, order10, order11, order12);
        #endregion

        #region order detail
        var orderDetail1 = new OrderDetail
        {
            OrderId = orderId1,
            ProductDetailId = productDetailId1,
            Quantity = 5,
            Price = 199000,
            Status = Status.Active
        };

        var orderDetail2 = new OrderDetail
        {
            OrderId = orderId1,
            ProductDetailId = productDetailId2,
            Quantity = 5,
            Price = 209000,
            Status = Status.Active
        };
        var orderDetail3 = new OrderDetail
        {
            OrderId = orderId2,
            ProductDetailId = productDetailId3,
            Quantity = 5,
            Price = 219000,
            Status = Status.Active
        };
        var orderDetail4 = new OrderDetail
        {
            OrderId = orderId2,
            ProductDetailId = productDetailId4,
            Quantity = 5,
            Price = 229000,
            Status = Status.Active
        };
        var orderDetail5 = new OrderDetail
        {
            OrderId = orderId3,
            ProductDetailId = productDetailId5,
            Quantity = 5,
            Price = 239000,
            Status = Status.Active
        };
        var orderDetail6 = new OrderDetail
        {
            OrderId = orderId3,
            ProductDetailId = productDetailId2,
            Quantity = 5,
            Price = 209000,
            Status = Status.Active
        };
        var orderDetail7 = new OrderDetail
        {
            OrderId = orderId4,
            ProductDetailId = productDetailId5,
            Quantity = 5,
            Price = 239000,
            Status = Status.Active
        };
        var orderDetail8 = new OrderDetail
        {
            OrderId = orderId5,
            ProductDetailId = productDetailId5,
            Quantity = 5,
            Price = 239000,
            Status = Status.Active
        };
        var orderDetail9 = new OrderDetail
        {
            OrderId = orderId6,
            ProductDetailId = productDetailId5,
            Quantity = 5,
            Price = 239000,
            Status = Status.Active
        };
        var orderDetail10 = new OrderDetail
        {
            OrderId = orderId7,
            ProductDetailId = productDetailId10,
            Quantity = 4,
            Price = 289000,
            Status = Status.Active
        };
        var orderDetail11 = new OrderDetail
        {
            OrderId = orderId7,
            ProductDetailId = productDetailID45,
            Quantity = 4,
            Price = 289000,
            Status = Status.Active
        };
        var orderDetail12 = new OrderDetail
        {
            OrderId = orderId8,
            ProductDetailId = productDetailID40,
            Quantity = 4,
            Price = 289000,
            Status = Status.Active
        };
        var orderDetail13 = new OrderDetail
        {
            OrderId = orderId9,
            ProductDetailId = productDetailID30,
            Quantity = 4,
            Price = 289000,
            Status = Status.Active
        };
        var orderDetail14 = new OrderDetail
        {
            OrderId = orderId9,
            ProductDetailId = productDetailID15,
            Quantity = 4,
            Price = 289000,
            Status = Status.Active
        };
        var orderDetail15 = new OrderDetail
        {
            OrderId = orderId10,
            ProductDetailId = productDetailID23,
            Quantity = 4,
            Price = 289000,
            Status = Status.Active
        };
        var orderDetail16 = new OrderDetail
        {
            OrderId = orderId10,
            ProductDetailId = productDetailID32,
            Quantity = 4,
            Price = 289000,
            Status = Status.Active
        };
        var orderDetail17 = new OrderDetail
        {
            OrderId = orderId11,
            ProductDetailId = productDetailID60,
            Quantity = 4,
            Price = 289000,
            Status = Status.Active
        };
        var orderDetail18 = new OrderDetail
        {
            OrderId = orderId11,
            ProductDetailId = productDetailID62,
            Quantity = 4,
            Price = 289000,
            Status = Status.Active
        };
        var orderDetail19 = new OrderDetail
        {
            OrderId = orderId12,
            ProductDetailId = productDetailID58,
            Quantity = 4,
            Price = 289000,
            Status = Status.Active
        };
        var orderDetail20 = new OrderDetail
        {
            OrderId = orderId12,
            ProductDetailId = productDetailID21,
            Quantity = 4,
            Price = 289000,
            Status = Status.Active
        };
        var orderDetail21 = new OrderDetail
        {
            OrderId = orderId12,
            ProductDetailId = productDetailID24,
            Quantity = 4,
            Price = 289000,
            Status = Status.Active
        };

        builder.Entity<OrderDetail>().HasData(orderDetail1, orderDetail2, orderDetail3, orderDetail4, orderDetail5, orderDetail6, orderDetail7, orderDetail8, orderDetail9, orderDetail10, orderDetail11, orderDetail12, orderDetail13, orderDetail14, orderDetail15, orderDetail16, orderDetail17, orderDetail18, orderDetail19, orderDetail20, orderDetail21);
        #endregion
    }
}
