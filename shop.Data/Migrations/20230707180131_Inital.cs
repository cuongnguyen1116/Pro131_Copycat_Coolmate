using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shop.Data.Migrations
{
    public partial class Inital : Migration
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
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false)
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
                    OrderCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConfirmedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaidDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShipDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShipName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ShipAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInCategories",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                        name: "FK_ProductInCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderId, x.ProductDetailId });
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

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1090dcdd-b383-417b-9523-d73f0373fbb0"), "ac448337-1a0d-4376-a5f8-3948f35735ba", "Administrator role", "admin", null },
                    { new Guid("4a1c9012-a602-46a9-8eba-05e85149fd81"), "c3534895-0384-4971-87c8-0e8f055a04f1", "Employee role", "employee", null },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), "887af4b0-47ab-4f18-b71a-2699167bed5a", "Customer role", "customer", null }
                });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("3b294e1f-c3f7-4f71-9be6-11c614fbdce5") },
                    { new Guid("1090dcdd-b383-417b-9523-d73f0373fbb0"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7") },
                    { new Guid("4a1c9012-a602-46a9-8eba-05e85149fd81"), new Guid("c2ec6dd4-8170-4b6d-acf4-33d52a128789") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5") }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f"), 0, "ef622e89-e1f5-4aa2-9c7f-a59f5b64e793", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "jennifer.smith@example.com", true, "Jennifer", "Smith", false, null, "JENNIFER.SMITH@EXAMPLE.COM", "JENNIFER.SMITH", "AQAAAAEAACcQAAAAEM661YfVE+Riw4xO493sigXhxEEdX2jaHKJdYziKFAZf9VGX3DGVDmwKugS3zQzOeg==", null, false, "", false, "jennifer.smith" },
                    { new Guid("3b294e1f-c3f7-4f71-9be6-11c614fbdce5"), 0, "4bc47e31-4a5d-4811-928e-c8ecbd464bb9", new DateTime(2003, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "lusdeer@gmail.com", true, "Hieu", "Le Minh", false, null, "lusdeer@gmail.com", "lmaohieu1", "AQAAAAEAACcQAAAAEGrCYrlacjhWc62SY+NLePJtB/97N3SJcaCUqxiX0eOxAetghq+WG+bJ0BqT0E1ivQ==", null, false, "", false, "lmaohieu1" },
                    { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "bbc89dcd-a1d4-44f1-8125-0fb2d35ba235", new DateTime(2003, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "cuongnguyenpm1116@gmail.com", true, "Cuong", "Nguyen Phuc Minh", false, null, "cuongnguyenpm1116@gmail.com", "admin", "AQAAAAEAACcQAAAAEDx7NHABNZKR5nUalwjVK05qPDn6ROiqhkYgYl+TWZbEfEgqN6p2zTvdi/xMmJBPqw==", null, false, "", false, "admin" },
                    { new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2"), 0, "fbfeccd8-6eab-4802-9abe-3bd859843ced", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", true, "John", "Doe", false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE", "AQAAAAEAACcQAAAAEA2cS5ioEQyqxZ8zbgzeK7DleVfys7lpwFdHtzRkhJJAX9o/A854pgJJHm4iRZmGbA==", null, false, "", false, "john.doe" },
                    { new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7"), 0, "1c7788e4-9f4b-46c2-9127-1124b3310187", new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.doe@example.com", true, "Jane", "Doe", false, null, "JANE.DOE@EXAMPLE.COM", "JANE.DOE", "AQAAAAEAACcQAAAAEFKXUq4DRJuJlkYnNuuf2CRSZ+JzwJ6eRNJenxg7gZc81CtYS3QwBlgbGZNpDHwcow==", null, false, "", false, "jane.doe" },
                    { new Guid("c2ec6dd4-8170-4b6d-acf4-33d52a128789"), 0, "72bd5520-5a3d-463a-bbfc-e0cf70a8bfcc", new DateTime(2003, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "hq37na@gmail.com", true, "Hoc", "Nguyen Kim", false, null, "hq37na@gmail.com", "kimhoc1", "AQAAAAEAACcQAAAAECjzR4fN20WVT/tmss0ogg79M+3oTqj3pZ8sTUZLtcKTtDnYLwnZzdind7bTXvKF8Q==", null, false, "", false, "kimhoc1" },
                    { new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5"), 0, "961d4d76-e514-488c-b576-ada5202d34f5", new DateTime(1985, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob.smith@example.com", true, "Bob", "Smith", false, null, "BOB.SMITH@EXAMPLE.COM", "BOB.SMITH", "AQAAAAEAACcQAAAAEAy6AJ6x3b1EoPpZIZNtpzW6ULQWs71JJWxGzogqKvyMevFXfbrqNWez73z8UkFygA==", null, false, "", false, "bob.smith" }
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
                    { new Guid("070139ef-2c91-4261-af8b-c07d2a5932b3"), "Xám" },
                    { new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), "Đen" },
                    { new Guid("5b28789c-e43f-4e10-b447-6290d4130c66"), "Đỏ" },
                    { new Guid("7f60198e-4f05-4cc5-8418-cffe41c392d4"), "Tím" },
                    { new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), "Trắng" },
                    { new Guid("97e83440-0351-4d34-9964-30aa65dd9cd5"), "Xanh lá cây" },
                    { new Guid("a556951b-68bd-42d2-b7b3-a765ca19edf8"), "Xanh dương" },
                    { new Guid("b9ed9a3a-0098-4575-93bc-d4beda3a0c0f"), "Cam" },
                    { new Guid("e481bd9d-e38c-4a2b-8194-30c0f6adc380"), "Vàng" },
                    { new Guid("ee96d4a7-f5b8-4b83-b8bc-8b6d4c110e98"), "Hồng" }
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
                columns: new[] { "Id", "Name", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), "XL", 4 },
                    { new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), "L", 3 },
                    { new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), "S", 1 },
                    { new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), "M", 2 },
                    { new Guid("aa66fbee-a9d6-4bb5-8ed8-b329d394221f"), "XXXL", 6 },
                    { new Guid("f6a1a967-7487-463b-9d7b-09aebf15d304"), "XXL", 5 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompletedDate", "ConfirmedDate", "CreatedDate", "OrderCode", "OrderStatus", "PaidDate", "ShipAddress", "ShipDate", "ShipName", "ShipPhoneNumber", "Total", "UserId" },
                values: new object[,]
                {
                    { new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"), null, new DateTime(2023, 7, 4, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), new DateTime(2023, 7, 3, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), "230703PmyoqNWHK3LZe3", 2, null, "1010 Oak Dr.", null, "Alice", "0123456789", 2000000m, new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7") },
                    { new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab"), null, new DateTime(2023, 7, 4, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), new DateTime(2023, 7, 3, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), "23070306w3xM7UGUxRrW", 1, null, "1111 Pine Ln.", null, "Alice", "0123456789", 3000000m, new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompletedDate", "ConfirmedDate", "CreatedDate", "OrderCode", "PaidDate", "ShipAddress", "ShipDate", "ShipName", "ShipPhoneNumber", "Total", "UserId" },
                values: new object[] { new Guid("8fd4f3f5-4f1a-4f23-a2b0-1dbf8e9d7a9c"), null, null, new DateTime(2023, 7, 3, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), "230703dkb7wDTr8wQ2rR", null, "123 Main St.", null, "Alice", "0123456789", 290000m, new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompletedDate", "ConfirmedDate", "CreatedDate", "OrderCode", "OrderStatus", "PaidDate", "ShipAddress", "ShipDate", "ShipName", "ShipPhoneNumber", "Total", "UserId" },
                values: new object[,]
                {
                    { new Guid("a60b3fd4-40a0-4f4e-8f5b-6e5a9a3d63e6"), new DateTime(2023, 7, 8, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), null, new DateTime(2023, 7, 3, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), "230703kTwGUuaOxZ5sC1", 3, new DateTime(2023, 7, 5, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), "456 Elm St.", new DateTime(2023, 7, 7, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), "0987654321", "0987654321", 275000m, new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f") },
                    { new Guid("c9e9de6f-0e6f-4b3e-9f6c-3f8f3a0e6a1d"), new DateTime(2023, 7, 8, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), null, new DateTime(2023, 7, 3, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), "230703P1u8nabxMakypB", 3, new DateTime(2023, 7, 5, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), "789 Maple Ave.", new DateTime(2023, 7, 7, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), "0987654321", "0987654321", 129000m, new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7") },
                    { new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"), new DateTime(2023, 7, 8, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), null, new DateTime(2023, 7, 3, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), "230703i5B6qeJ2IbxBVu", 3, new DateTime(2023, 7, 5, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), "1212 Cedar Blvd.", new DateTime(2023, 7, 7, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), "Charlie", "0987654321", 232000m, new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompletedDate", "ConfirmedDate", "CreatedDate", "OrderCode", "PaidDate", "ShipAddress", "ShipDate", "ShipName", "ShipPhoneNumber", "Total", "UserId" },
                values: new object[] { new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"), null, null, new DateTime(2023, 7, 3, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), "230703DDKbiC3SyDB9pN", null, "123 Main St.", null, "Alice", "0123456789", 1000000m, new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2") });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "Id", "ColorId", "CreatedDate", "MaterialId", "OriginalPrice", "Price", "ProductId", "SizeId", "Status", "Stock" },
                values: new object[,]
                {
                    { new Guid("0976ba79-d822-408a-86cb-e05045db09ed"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8375), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 299000m, new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), new Guid("f6a1a967-7487-463b-9d7b-09aebf15d304"), 0, 50 },
                    { new Guid("18cd05cb-f995-4b13-9fa4-a9e1f1c43862"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8373), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 289000m, new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("28c12878-b191-4d42-974a-7b823de70a06"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8365), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 259000m, new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8354), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 150000m, 209000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("423f83df-dc6c-4b41-aa09-2fe30e841aa6"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8371), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 279000m, new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("6a008d16-196e-40fe-ada5-2acf339fbede"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8377), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), new Guid("aa66fbee-a9d6-4bb5-8ed8-b329d394221f"), 0, 50 },
                    { new Guid("9610c212-5a16-4a70-8703-6bc7f1224be0"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8363), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 249000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("aa66fbee-a9d6-4bb5-8ed8-b329d394221f"), 0, 50 },
                    { new Guid("9a6ccc00-6b1c-40c5-be61-eb71323c9151"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8340), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 150000m, 199000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("a6767d22-3ea0-4a00-ad31-9dce1d67184e"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8368), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 269000m, new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("b799297f-d21e-4280-8df9-a3c6788c806e"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8356), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 150000m, 219000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("e3acb616-dd2c-44ee-93f0-754c68503b38"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8359), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 229000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8361), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 239000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("f6a1a967-7487-463b-9d7b-09aebf15d304"), 0, 50 }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9") },
                    { new Guid("d8eb1629-a276-4667-8da2-0926fc66de0c"), new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844") }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductDetailId", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"), new Guid("b799297f-d21e-4280-8df9-a3c6788c806e"), 219000m, 5 },
                    { new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"), new Guid("e3acb616-dd2c-44ee-93f0-754c68503b38"), 229000m, 5 },
                    { new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab"), new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45"), 209000m, 5 },
                    { new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab"), new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"), 239000m, 5 },
                    { new Guid("8fd4f3f5-4f1a-4f23-a2b0-1dbf8e9d7a9c"), new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"), 239000m, 5 },
                    { new Guid("a60b3fd4-40a0-4f4e-8f5b-6e5a9a3d63e6"), new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"), 239000m, 5 },
                    { new Guid("c9e9de6f-0e6f-4b3e-9f6c-3f8f3a0e6a1d"), new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"), 239000m, 5 },
                    { new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"), new Guid("18cd05cb-f995-4b13-9fa4-a9e1f1c43862"), 289000m, 4 },
                    { new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"), new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45"), 209000m, 5 },
                    { new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"), new Guid("9a6ccc00-6b1c-40c5-be61-eb71323c9151"), 199000m, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_UserId",
                table: "CartDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductDetailId",
                table: "OrderDetails",
                column: "ProductDetailId");

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
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCategories_CategoryId",
                table: "ProductInCategories",
                column: "CategoryId");
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
}
