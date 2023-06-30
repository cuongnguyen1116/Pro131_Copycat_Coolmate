using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shop.Data.Migrations;

public partial class Initial : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "AppRoleClaims",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "AppRoles",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AppRoles", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "AppUserClaims",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AppUserClaims", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "AppUserLogins",
            columns: table => new
            {
                UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
            });

        migrationBuilder.CreateTable(
            name: "AppUserRoles",
            columns: table => new
            {
                UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
            });

        migrationBuilder.CreateTable(
            name: "AppUsers",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                FirstName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                DoB = table.Column<DateTime>(type: "datetime2", nullable: false),
                UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                AccessFailedCount = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AppUsers", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "AppUserTokens",
            columns: table => new
            {
                UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
            });

        migrationBuilder.CreateTable(
            name: "Categories",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Categories", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Colors",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Colors", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Materials",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Materials", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Products",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Products", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Promotions",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                ApplyForAll = table.Column<bool>(type: "bit", nullable: false),
                DiscountPercent = table.Column<int>(type: "int", nullable: true),
                DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                Status = table.Column<int>(type: "int", nullable: false),
                Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Promotions", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Sizes",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Sizes", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Carts",
            columns: table => new
            {
                UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Carts", x => x.UserId);
                table.ForeignKey(
                    name: "FK_Carts_AppUsers_UserId",
                    column: x => x.UserId,
                    principalTable: "AppUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "Orders",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                PaidDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                ShipDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                CompletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                ShipName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                ShipAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                ShipPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                OrderStatus = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Orders", x => x.Id);
                table.ForeignKey(
                    name: "FK_Orders_AppUsers_UserId",
                    column: x => x.UserId,
                    principalTable: "AppUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "ProductInCategories",
            columns: table => new
            {
                ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                CategoryId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                ProductId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_ProductInCategories", x => new { x.ProductId, x.CategoryId });
                table.ForeignKey(
                    name: "FK_ProductInCategories_Categories_CategoryId",
                    column: x => x.CategoryId,
                    principalTable: "Categories",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_ProductInCategories_Categories_CategoryId1",
                    column: x => x.CategoryId1,
                    principalTable: "Categories",
                    principalColumn: "Id");
                table.ForeignKey(
                    name: "FK_ProductInCategories_Products_ProductId",
                    column: x => x.ProductId,
                    principalTable: "Products",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_ProductInCategories_Products_ProductId1",
                    column: x => x.ProductId1,
                    principalTable: "Products",
                    principalColumn: "Id");
            });

        migrationBuilder.CreateTable(
            name: "ProductDetails",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                ColorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                MaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                SizeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Stock = table.Column<int>(type: "int", nullable: false),
                Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                Status = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_ProductDetails", x => x.Id);
                table.ForeignKey(
                    name: "FK_ProductDetails_Colors_ColorId",
                    column: x => x.ColorId,
                    principalTable: "Colors",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_ProductDetails_Materials_MaterialId",
                    column: x => x.MaterialId,
                    principalTable: "Materials",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_ProductDetails_Products_ProductId",
                    column: x => x.ProductId,
                    principalTable: "Products",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_ProductDetails_Sizes_SizeId",
                    column: x => x.SizeId,
                    principalTable: "Sizes",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "CartDetails",
            columns: table => new
            {
                UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                ProductDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Quantity = table.Column<int>(type: "int", nullable: false),
                Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_CartDetails", x => new { x.ProductDetailId, x.UserId });
                table.ForeignKey(
                    name: "FK_CartDetails_Carts_UserId",
                    column: x => x.UserId,
                    principalTable: "Carts",
                    principalColumn: "UserId",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_CartDetails_ProductDetails_ProductDetailId",
                    column: x => x.ProductDetailId,
                    principalTable: "ProductDetails",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "OrderDetails",
            columns: table => new
            {
                OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                ProductDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Quantity = table.Column<int>(type: "int", nullable: false),
                Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_OrderDetails", x => new { x.ProductDetailId, x.OrderId });
                table.ForeignKey(
                    name: "FK_OrderDetails_Orders_OrderId",
                    column: x => x.OrderId,
                    principalTable: "Orders",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_OrderDetails_ProductDetails_ProductDetailId",
                    column: x => x.ProductDetailId,
                    principalTable: "ProductDetails",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "ProductImages",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                ProductDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Caption = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                IsDefault = table.Column<bool>(type: "bit", nullable: false),
                SortOrder = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_ProductImages", x => x.Id);
                table.ForeignKey(
                    name: "FK_ProductImages_ProductDetails_ProductDetailId",
                    column: x => x.ProductDetailId,
                    principalTable: "ProductDetails",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.InsertData(
            table: "AppRoles",
            columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
            values: new object[,]
            {
                { new Guid("1090dcdd-b383-417b-9523-d73f0373fbb0"), "5e79a726-37df-4d7d-92c4-f7c648a73929", "Administrator role", "admin", null },
                { new Guid("4a1c9012-a602-46a9-8eba-05e85149fd81"), "4ea215d3-735f-4ba6-9069-717405c46ca2", "Employee role", "employee", null },
                { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), "3de0894f-0671-4371-8f13-e3b0c6f4adac", "Customer role", "customer", null }
            });

        migrationBuilder.InsertData(
            table: "AppUserRoles",
            columns: new[] { "RoleId", "UserId" },
            values: new object[,]
            {
                { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("3b294e1f-c3f7-4f71-9be6-11c614fbdce5") },
                { new Guid("1090dcdd-b383-417b-9523-d73f0373fbb0"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                { new Guid("4a1c9012-a602-46a9-8eba-05e85149fd81"), new Guid("c2ec6dd4-8170-4b6d-acf4-33d52a128789") }
            });

        migrationBuilder.InsertData(
            table: "AppUsers",
            columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
            values: new object[,]
            {
                { new Guid("3b294e1f-c3f7-4f71-9be6-11c614fbdce5"), 0, "bfa42845-ba7f-49c2-af9b-866ea78fc80d", new DateTime(2003, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "lusdeer@gmail.com", true, "Hieu", "Le Minh", false, null, "lusdeer@gmail.com", "lmaohieu1", "AQAAAAEAACcQAAAAEIN/AxWyhiC3ndrM85YTvRVfHgD3qZOWSUjBMbHSCFbgwjo9bs8SIWFzuLdXFpiEEQ==", null, false, "", false, "lmaohieu1" },
                { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "434b8f3e-08c5-41d5-a871-3d9041a61857", new DateTime(2003, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "cuongnguyenpm1116@gmail.com", true, "Cuong", "Nguyen Phuc Minh", false, null, "cuongnguyenpm1116@gmail.com", "admin", "AQAAAAEAACcQAAAAEGL0cXAyy6ATFpJArRJGi+IYV1PeDlimjo0eXROs/NvD2G1UbEOyMiuo0Rg/uHzvbA==", null, false, "", false, "admin" },
                { new Guid("c2ec6dd4-8170-4b6d-acf4-33d52a128789"), 0, "816757f1-8716-4331-8fb6-571472970af1", new DateTime(2003, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "hq37na@gmail.com", true, "Hoc", "Nguyen Kim", false, null, "hq37na@gmail.com", "kimhoc1", "AQAAAAEAACcQAAAAEIueg1exQLNA3SOTrMjG976lTH83BXFZwzqjRcKZve88j6RuaZ17/C2Tjnl4i+GmAQ==", null, false, "", false, "kimhoc1" }
            });

        migrationBuilder.InsertData(
            table: "Categories",
            columns: new[] { "Id", "Name", "ParentId" },
            values: new object[,]
            {
                { new Guid("d8eb1629-a276-4667-8da2-0926fc66de0c"), "Áo polo", null },
                { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), "Áo thun", null }
            });

        migrationBuilder.InsertData(
            table: "Colors",
            columns: new[] { "Id", "Name" },
            values: new object[,]
            {
                { new Guid("46894c70-1d26-4a20-993b-8d2198913585"), "Xám" },
                { new Guid("b8457fc8-60a5-43a1-9e4a-e4855c86524f"), "Đen" },
                { new Guid("c22c0a96-b3fc-4223-8cca-b9046732bb89"), "Trắng" }
            });

        migrationBuilder.InsertData(
            table: "Materials",
            columns: new[] { "Id", "Name" },
            values: new object[,]
            {
                { new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), "Vải Cotton" },
                { new Guid("093e72f7-4bae-448c-b009-b6acf0fe9120"), "Vải Recycle" },
                { new Guid("5cd1370c-dd94-4038-b33c-49a27aad25ab"), "Vải Excool" },
                { new Guid("99df0e16-bab3-4d8a-8916-72e4a03e99e4"), "Vải Polyester tính năng" }
            });

        migrationBuilder.InsertData(
            table: "Products",
            columns: new[] { "Id", "Description", "Name" },
            values: new object[,]
            {
                { new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), "Chất liệu: 86% Poly + 14% Spandex. Co giãn 4 chiều mang lại sự thoải mái để bạn vận động hết mình. Thiết kế công thái học, cải tiến giữ các đường may không bị mài mòn và tăng độ bền. Chất liệu thấm mồ hôi và khô nhanh, thoáng khí mang lại khả năng khô thoáng vượt trội. Form áo: Slim fit. Người mẫu: 180cm - 80kg, mặc áo size XL. Tự hào sản xuất tại Việt Nam", "Gym Powerfit" },
                { new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), "Sản phẩm trong Bộ sưu tập Summer. Chất liệu: 100% Cotton mềm mại. Định lượng vải: 200gsm, dày dặn. Dáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà. Hình in PET bền bỉ, không lo bong tróc, thoải mái giặt máy. Tự hào sản xuất tại Việt Nam", "Cotton Summer Coolwaves" }
            });

        migrationBuilder.InsertData(
            table: "Sizes",
            columns: new[] { "Id", "Name" },
            values: new object[,]
            {
                { new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), "XL" },
                { new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), "L" },
                { new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), "S" },
                { new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), "M" },
                { new Guid("aa66fbee-a9d6-4bb5-8ed8-b329d394221f"), "XXXL" },
                { new Guid("f6a1a967-7487-463b-9d7b-09aebf15d304"), "XXL" }
            });

        migrationBuilder.InsertData(
            table: "ProductDetails",
            columns: new[] { "Id", "ColorId", "CreatedDate", "MaterialId", "OriginalPrice", "Price", "ProductId", "SizeId", "Status", "Stock" },
            values: new object[,]
            {
                { new Guid("0a3dcb7c-884d-4a05-a5dd-a1d5df404dff"), new Guid("b8457fc8-60a5-43a1-9e4a-e4855c86524f"), new DateTime(2023, 6, 30, 14, 23, 52, 410, DateTimeKind.Local).AddTicks(9693), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 150000m, 199000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                { new Guid("231e0060-c281-4c8d-b5c2-791edfa5a680"), new Guid("b8457fc8-60a5-43a1-9e4a-e4855c86524f"), new DateTime(2023, 6, 30, 14, 23, 52, 410, DateTimeKind.Local).AddTicks(9695), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 150000m, 199000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                { new Guid("aa06827c-df06-4a43-94d2-75bba02d9da6"), new Guid("c22c0a96-b3fc-4223-8cca-b9046732bb89"), new DateTime(2023, 6, 30, 14, 23, 52, 410, DateTimeKind.Local).AddTicks(9696), new Guid("5cd1370c-dd94-4038-b33c-49a27aad25ab"), 200000m, 299000m, new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                { new Guid("fb684bf0-020f-4607-8e79-b3aa9bd005a5"), new Guid("b8457fc8-60a5-43a1-9e4a-e4855c86524f"), new DateTime(2023, 6, 30, 14, 23, 52, 410, DateTimeKind.Local).AddTicks(9681), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 150000m, 199000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 }
            });

        migrationBuilder.InsertData(
            table: "ProductInCategories",
            columns: new[] { "CategoryId", "ProductId", "CategoryId1", "ProductId1" },
            values: new object[,]
            {
                { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), null, null },
                { new Guid("d8eb1629-a276-4667-8da2-0926fc66de0c"), new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), null, null }
            });

        migrationBuilder.CreateIndex(
            name: "IX_CartDetails_UserId",
            table: "CartDetails",
            column: "UserId");

        migrationBuilder.CreateIndex(
            name: "IX_OrderDetails_OrderId",
            table: "OrderDetails",
            column: "OrderId");

        migrationBuilder.CreateIndex(
            name: "IX_Orders_UserId",
            table: "Orders",
            column: "UserId");

        migrationBuilder.CreateIndex(
            name: "IX_ProductDetails_ColorId",
            table: "ProductDetails",
            column: "ColorId");

        migrationBuilder.CreateIndex(
            name: "IX_ProductDetails_MaterialId",
            table: "ProductDetails",
            column: "MaterialId");

        migrationBuilder.CreateIndex(
            name: "IX_ProductDetails_ProductId",
            table: "ProductDetails",
            column: "ProductId");

        migrationBuilder.CreateIndex(
            name: "IX_ProductDetails_SizeId",
            table: "ProductDetails",
            column: "SizeId");

        migrationBuilder.CreateIndex(
            name: "IX_ProductImages_ProductDetailId",
            table: "ProductImages",
            column: "ProductDetailId");

        migrationBuilder.CreateIndex(
            name: "IX_ProductInCategories_CategoryId",
            table: "ProductInCategories",
            column: "CategoryId");

        migrationBuilder.CreateIndex(
            name: "IX_ProductInCategories_CategoryId1",
            table: "ProductInCategories",
            column: "CategoryId1");

        migrationBuilder.CreateIndex(
            name: "IX_ProductInCategories_ProductId1",
            table: "ProductInCategories",
            column: "ProductId1");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "AppRoleClaims");

        migrationBuilder.DropTable(
            name: "AppRoles");

        migrationBuilder.DropTable(
            name: "AppUserClaims");

        migrationBuilder.DropTable(
            name: "AppUserLogins");

        migrationBuilder.DropTable(
            name: "AppUserRoles");

        migrationBuilder.DropTable(
            name: "AppUserTokens");

        migrationBuilder.DropTable(
            name: "CartDetails");

        migrationBuilder.DropTable(
            name: "OrderDetails");

        migrationBuilder.DropTable(
            name: "ProductImages");

        migrationBuilder.DropTable(
            name: "ProductInCategories");

        migrationBuilder.DropTable(
            name: "Promotions");

        migrationBuilder.DropTable(
            name: "Carts");

        migrationBuilder.DropTable(
            name: "Orders");

        migrationBuilder.DropTable(
            name: "ProductDetails");

        migrationBuilder.DropTable(
            name: "Categories");

        migrationBuilder.DropTable(
            name: "AppUsers");

        migrationBuilder.DropTable(
            name: "Colors");

        migrationBuilder.DropTable(
            name: "Materials");

        migrationBuilder.DropTable(
            name: "Products");

        migrationBuilder.DropTable(
            name: "Sizes");
    }
}
