﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shop.Data.Migrations
{
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PromotionCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiscountPercent = table.Column<int>(type: "int", nullable: true),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
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
                    OrderStatus = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
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
                    IsFeatured = table.Column<bool>(type: "bit", nullable: true),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartDetails", x => x.Id);
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
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
                    { new Guid("1090dcdd-b383-417b-9523-d73f0373fbb0"), "29d9f4b5-8de5-491f-b4d7-4216bc43187f", "Administrator role", "admin", "ADMIN" },
                    { new Guid("4a1c9012-a602-46a9-8eba-05e85149fd81"), "592809ef-6c23-479c-a6ab-b671e56b7024", "Employee role", "employee", "EMPLOYEE" },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), "4d2ec197-40bf-498e-bede-69d9f3d906b6", "Customer role", "customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("3b294e1f-c3f7-4f71-9be6-11c614fbdce5") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("513b6e27-9ec8-4339-8cd2-ce42a2c6a01e") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("598ded7d-1f81-43a9-861c-21a026294eb1") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("66c7e036-0cbd-4350-9afe-5e1e0c959bcf") },
                    { new Guid("1090dcdd-b383-417b-9523-d73f0373fbb0"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("7ee56101-aff6-4d71-8112-e118ada30353") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("873c3aed-38c2-41ef-b03a-4e142dae542c") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("8db920d7-5115-432c-a9ad-3039dfed3244") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("a72558d6-0e2f-463f-9ce9-c7a232b7eb89") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7") },
                    { new Guid("4a1c9012-a602-46a9-8eba-05e85149fd81"), new Guid("c2ec6dd4-8170-4b6d-acf4-33d52a128789") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("c7378d1c-47f6-4cc5-b800-281023b6699a") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5") }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f"), 0, "e044a031-18d4-4236-b62d-1ad5ede04403", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "jennifer.smith@example.com", true, "Jennifer", "Smith", false, null, "JENNIFER.SMITH@EXAMPLE.COM", "beautysmithlady159", "AQAAAAEAACcQAAAAEHkjm3RvD38BKcYvPv6tg+3yQYQWWX7bZ5EZSTt2u15kRJNqUZIGA7sDEPuZ+ByFJQ==", "0987654321", false, "", false, "beautysmithlady159" },
                    { new Guid("3b294e1f-c3f7-4f71-9be6-11c614fbdce5"), 0, "d01a0b96-338b-4c77-b6db-72d066dde20a", new DateTime(2003, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "lusdeer@gmail.com", true, "Hieu", "Le Minh", false, null, "lusdeer@gmail.com", "lmaohieu1", "AQAAAAEAACcQAAAAEA9z4aTK4S2Dp7YUiB9ADiU84wsKQ/pXUtS7UmEkUmMhXSfldMxn3lOGbLAhvIZ3iQ==", "0987654321", false, "", false, "lmaohieu1" },
                    { new Guid("513b6e27-9ec8-4339-8cd2-ce42a2c6a01e"), 0, "1433d39a-848e-463a-8900-49e91fc8fb59", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "taylorswift109@gmail.com", true, "Thúy", "Loan", false, null, "TAYLORSWIFT109@gmail.com", "taylorswift109", "AQAAAAEAACcQAAAAEIsobJEv99gfuSwNrQ70fBCu9K4O5VHOdYpn+A2Ag4L35f5Z/zeRXuNMqQQ6b5iCMA==", "0987654321", false, "", false, "taylorswift109" },
                    { new Guid("598ded7d-1f81-43a9-861c-21a026294eb1"), 0, "f672e09c-5262-4c14-9253-40693c0a593c", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "miley987@gmail.com", true, "Robyn", "Fenty", false, null, "MILEY987@gmail.com", "miley987", "AQAAAAEAACcQAAAAEFJh/bteFrhLeMUUZ91gUWoquXMZjwSIHMwdAAhaO8YKy3qCVs4R3eYEN+6Y2qLA5g==", "0987654321", false, "", false, "miley987" },
                    { new Guid("66c7e036-0cbd-4350-9afe-5e1e0c959bcf"), 0, "1ab21a6e-5666-4d52-ab02-35f9738f6825", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "jennifer.smith@example.com", true, "Billie", "Jean", false, null, "JENNIFER.SMITH@EXAMPLE.COM", "notmylover199", "AQAAAAEAACcQAAAAEAI0j+TLubx4IpcsrDOVSM6Ej5At8zuKS7GN2pRPbM2/NIHFWvAX1xObn4cOQrlVXg==", "0987654321", false, "", false, "notmylover199" },
                    { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "a62b76b5-8569-4c4e-b9a2-8b74d8387e41", new DateTime(2003, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "cuongnguyenpm1116@gmail.com", true, "Cuong", "Nguyen Phuc Minh", false, null, "cuongnguyenpm1116@gmail.com", "admin", "AQAAAAEAACcQAAAAEKCQW6MmjzWlKq+uQRsvbD9HjddZXyO10XBZeDegydHyxLlGA469rghFyqwDdEmsvw==", "0987654321", false, "", false, "admin" },
                    { new Guid("7ee56101-aff6-4d71-8112-e118ada30353"), 0, "b01dc42e-d3d7-4106-aa2b-1d7db82e1ad8", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "michealthoangmong@gmail.com", true, "Michael", "Jackson", false, null, "MICHAELTHOANGMONG1@GMAIL.COM", "michaelthoangmong1", "AQAAAAEAACcQAAAAEFM2NJ/nJN0l/3y7xElr9u2SMBd3X5WM/kzENPRHhVoDJ/ZAmqVeXanNdLR9gpfPKg==", "0987654321", false, "", false, "michaelthoangmong1" },
                    { new Guid("873c3aed-38c2-41ef-b03a-4e142dae542c"), 0, "a6fbc9c6-76e3-494d-b2c0-2e90a5d27ba2", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "camila119@gmail.com", true, "Karla Camila", " Cabello Estrabao", false, null, "CAMILA119@gmail.com", "camila119", "AQAAAAEAACcQAAAAEFqeym04sorAX03c/nEhQq/PsYPI3/r71fzikMfWlUHKDpAh73jHpwp5u37NIx3oHw==", "0987654321", false, "", false, "camila119" },
                    { new Guid("8db920d7-5115-432c-a9ad-3039dfed3244"), 0, "42e68d71-dfc0-4870-a6dd-0f935e9cbace", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "grande145@gmail.com", true, "Ariana", "Grande", false, null, "GRANDE145@gmail.com", "grande145", "AQAAAAEAACcQAAAAEKBVMXbZfmkN4qkF91j2ELHTvLA/rFJtItQa+Ea5gkHuDJeMyEujYBYeKYwSMVvllg==", "0987654321", false, "", false, "grande145" },
                    { new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2"), 0, "874a5c75-9a15-4a0e-9b70-3624634bda3b", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", true, "John", "Doe", false, null, "JOHN.DOE@EXAMPLE.COM", "doesnot90", "AQAAAAEAACcQAAAAEO1NQYF/jQINsTniIGguAvyhBgDPyPr2La62yjC+QwxnQaYYGIW/Rt2wv9pVyDCjNg==", "0987654321", false, "", false, "doesnot90" },
                    { new Guid("a72558d6-0e2f-463f-9ce9-c7a232b7eb89"), 0, "79e51f0d-ff80-4ebc-8334-b321e43718ff", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "drake123@gmail.com", true, "Aubrey", "Drake Graham", false, null, "DRAKE123@gmail.com", "drake123", "AQAAAAEAACcQAAAAEGoiscSfldg/6m8PxjjToSTj1L2yMivsOWGk3uknk8yKcVehqLO6AtVA4bQKd7UwQg==", "0987654321", false, "", false, "drake123" },
                    { new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7"), 0, "d34d3083-7349-4175-ac1e-1651ba3fdef5", new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.doe@example.com", true, "Jane", "Doe", false, null, "JANE.DOE@EXAMPLE.COM", "janenotlost123", "AQAAAAEAACcQAAAAEEUyiP8ENDygz1/9yjF7TDhZ2jnwNYfrjrKDVcONX2mVSRmoMLJGj24wfoWabYlcuQ==", "0987654321", false, "", false, "janenotlost123" },
                    { new Guid("c2ec6dd4-8170-4b6d-acf4-33d52a128789"), 0, "0bd27ee4-1be3-4c3f-9e59-f007104fa718", new DateTime(2003, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "hq37na@gmail.com", true, "Hoc", "Nguyen Kim", false, null, "hq37na@gmail.com", "kimhoc1", "AQAAAAEAACcQAAAAEIbHD5CBTuB0LSGZX1mWFeikld950ddLQCorYpjBXBHDaTFzle95Mk1tUfIxwUy/4Q==", "0987654321", false, "", false, "kimhoc1" },
                    { new Guid("c7378d1c-47f6-4cc5-b800-281023b6699a"), 0, "4d378064-fffd-45b7-aa46-a314e92c6102", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "michealthoangmong@gmail.com", true, "Michael", "Jackson", false, null, "MICHAELTHOANGMONG1@GMAIL.COM", "michaelthoangmong1", "AQAAAAEAACcQAAAAENSZb+d538dMlv0pBAcxn6JHJY/cgH6Fd5f/m5RCaRObIvSMd2yI1VFviMwa4LDspg==", "0987654321", false, "", false, "michaelthoangmong1" },
                    { new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5"), 0, "4130d35b-b3db-4401-9694-086f47e0286b", new DateTime(1998, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob.smith@example.com", true, "Bob", "Smith", false, null, "BOB.SMITH@EXAMPLE.COM", "bobthebuilder98", "AQAAAAEAACcQAAAAEMH8wEiRF1lQHILM/DloGD+6kgnAMWovROGM4+ROf1FTLVbxVs8BnikHf9ZSBggMjA==", "0987654321", false, "", false, "bobthebuilder98" }
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
                    { new Guid("a556951b-68bd-42d2-b7b3-a765ca19edf8"), "Xanh dương" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
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
                    { new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"), "Là sản phẩm của sự hợp tác giữa Coolmate và Disney - đơn vị sở hữu bản quyền Marvel\r\nChất liệu 100% Cotton mềm mại\r\nĐịnh lượng vải 245gsm dày dặn\r\nPhù hợp với: đi làm, đi chơi, mặc ở nhà\r\nKiểu dáng: Regular\r\nTự hào sản xuất tại Việt Nam", " Áo thun Marvel logo Spider-Man" },
                    { new Guid("1975818f-1d1d-4df8-8477-0afaf9687945"), "Sản phẩm Care & Share hợp tác với cầu thủ nữ ĐTQG Việt Nam Huỳnh Như\r\n10% Doanh thu từ mỗi sản phẩm bán ra sẽ được quyên góp vào Quỹ Care & Share\r\nChất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nTự hào sản xuất tại Việt Nam", "Care & Share The Moments - Bản lĩnh" },
                    { new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), "Chất liệu: 86% Poly + 14% Spandex. Co giãn 4 chiều mang lại sự thoải mái để bạn vận động hết mình. Thiết kế công thái học, cải tiến giữ các đường may không bị mài mòn và tăng độ bền. Chất liệu thấm mồ hôi và khô nhanh, thoáng khí mang lại khả năng khô thoáng vượt trội. Form áo: Slim fit. Người mẫu: 180cm - 80kg, mặc áo size XL. Tự hào sản xuất tại Việt Nam", "Gym Powerfit" },
                    { new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8"), "Chất liệu: 95% Cotton Compact - 5% Spandex\r\nPhù hợp với: mặc ở nhà, đi làm, đi chơi\r\nKiểu dáng: Regular Fit dáng suông\r\nTự hào sản xuất tại Việt Nam Xem nhà máy >\r\nNgười mẫu: 184 cm, 73 kg, mặc size 2XL", "Compact phiên bản Premium" },
                    { new Guid("217cc99e-4586-4fc2-9e87-66ba1061426f"), "Là sản phẩm của sự hợp tác giữa Coolmate và Disney - đơn vị sở hữu bản quyền Marvel\r\nChất liệu 100% Cotton mềm mại\r\nĐịnh lượng vải 245gsm dày dặn\r\nPhù hợp với: đi làm, đi chơi, mặc ở nhà\r\nKiểu dáng: Regular\r\nTự hào sản xuất tại Việt Nam", "Áo thun Marvel Captain America" },
                    { new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474"), "Đây là sản phẩm thuộc Clean Vietnam Collection\r\nChất liệu: 80% Cotton - 20% Recycle Polyester,co giãn 4 chiều\r\nKiểu dáng: regularfit dáng suông\r\nPhù hợp với: đi chơi, đi làm, ở nhà\r\nTự hào sản xuất tại Việt Nam\r\nMục tiêu dự án đến 2023 sẽ tái chế được 500.000 chai nhựa thành sợi và sản xuất thành sản phẩm tốt về công năng", "Clean Vietnam" },
                    { new Guid("3241c204-eb4a-4f41-a214-c77a74577db4"), "Là sản phẩm của sự hợp tác giữa Coolmate và Disney - đơn vị sở hữu bản quyền Marvel\r\nChất liệu 100% Cotton mềm mại\r\nĐịnh lượng vải 245gsm dày dặn\r\nPhù hợp với: đi làm, đi chơi, mặc ở nhà\r\nKiểu dáng: Regular\r\nTự hào sản xuất tại Việt Nam", "Áo thun Marvel Big Logo Hulk" },
                    { new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), "Chất liệu: 95% Cotton Compact - 5% Spandex\r\nPhù hợp với: mặc ở nhà, đi làm, đi chơi\r\nKiểu dáng: Regular Fit dáng suông\r\nTự hào sản xuất tại Việt Nam Xem nhà máy >\r\nNgười mẫu: 184 cm, 73 kg, mặc size 2XL", "Áo thun nam Cotton Compact" },
                    { new Guid("42eea6d0-d14a-4d9e-850f-5f340311bde3"), "Chất liệu: 97% Polyester Quick-Dry + 3% Spandex. Xử lý hoàn thiện vải: Quick-Dry + Wicking + Stretch. Công nghệ Chafe-Free may Seamless hạn chế tối đa ma sát trong quá trình vận động. Định lượng vải 110gsm siêu nhẹ. Được nghiên cứu và phát triển phù hợp dựa trên các Runner chuyên nghiệp. Tự hào sản xuất tại Việt Nam", "Essential Fast & Free Run" },
                    { new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256"), "Chất liệu: 95% Polyester Quick-Dry + 5% Spandex. Xử lý hoàn thiện vải: Quick-Dry + Wicking + Stretch. Công nghệ Chafe-Free hạn chế tối đa ma sát trong quá trình vận động từ các đường may may Seamless. Định lượng vải 100gsm siêu nhẹ. Được phát triển và kiểm nghiệm bởi các VĐV Marathon. Tự hào sản xuất tại Việt Nam", "Quick Dry in Graphic R1" },
                    { new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc"), "Chất liệu: 100% Polyester\r\nXử lý hoàn thiện vải: Quick-Dry và Wicking\r\nDệt kiểu Mesh, thoáng khí\r\nPhù hợp với: chơi thể thao, mặc ở nhà\r\nKiểu dáng: Regular fit dáng suông\r\nNgười mẫu: 175 cm - 75 kg, mặc size XL", "Áo thun thể thao nam ProMax-S1" },
                    { new Guid("a8edbd5b-dd2b-42d1-84b4-013e867d0f88"), "Chất liệu: 95% Polyester Quick-Dry + 5% Spandex\r\nXử lý hoàn thiện vải: Quick-Dry + Wicking + Stretch\r\nCông nghệ Chafe-Free hạn chế tối đa ma sát trong quá trình vận động từ các đường may may Seamless\r\nĐịnh lượng vải 100gsm siêu nhẹ\r\nĐược phát triển và kiểm nghiệm bởi các VĐV Marathon\r\nTự hào sản xuất tại Việt Nam", "Advanced Fast & Free Run" },
                    { new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5"), "Sản phẩm trong Bộ sưu tập Summer\r\nChất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nHình in PET bền bỉ, không lo bong tróc, thoải mái giặt máy\r\nTự hào sản xuất tại Việt Nam", "Summer Coolwaves Graphic" },
                    { new Guid("b208c071-8450-4999-9cc4-1bf37d7f9294"), "Là sản phẩm của sự hợp tác giữa Coolmate và Disney - đơn vị sở hữu bản quyền Marvel\r\nChất liệu 100% Cotton mềm mại\r\nĐịnh lượng vải 245gsm dày dặn\r\nPhù hợp với: đi làm, đi chơi, mặc ở nhà\r\nKiểu dáng: Regular\r\nTự hào sản xuất tại Việt Nam", "Áo thun Marvel Thor Mjolnir" },
                    { new Guid("b6f2feb6-8373-43c0-8db3-f5d6e664062c"), "Chất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nTự hào sản xuất tại Việt Nam", "Coolmate Basics 200gsm" }
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
                table: "Carts",
                columns: new[] { "UserId", "Description" },
                values: new object[,]
                {
                    { new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f"), "4" },
                    { new Guid("513b6e27-9ec8-4339-8cd2-ce42a2c6a01e"), "8" },
                    { new Guid("598ded7d-1f81-43a9-861c-21a026294eb1"), "11" },
                    { new Guid("66c7e036-0cbd-4350-9afe-5e1e0c959bcf"), "5" },
                    { new Guid("7ee56101-aff6-4d71-8112-e118ada30353"), "6" },
                    { new Guid("873c3aed-38c2-41ef-b03a-4e142dae542c"), "10" },
                    { new Guid("8db920d7-5115-432c-a9ad-3039dfed3244"), "9" },
                    { new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2"), "1" },
                    { new Guid("a72558d6-0e2f-463f-9ce9-c7a232b7eb89"), "12" },
                    { new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7"), "2" },
                    { new Guid("c7378d1c-47f6-4cc5-b800-281023b6699a"), "7" },
                    { new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5"), "3" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompletedDate", "ConfirmedDate", "CreatedDate", "OrderCode", "OrderStatus", "PaidDate", "ShipAddress", "ShipDate", "ShipName", "ShipPhoneNumber", "Total", "UserId" },
                values: new object[,]
                {
                    { new Guid("0da98ae9-3b88-453c-af1b-b5e7fa1a0b25"), new DateTime(2023, 8, 13, 22, 54, 13, 529, DateTimeKind.Local).AddTicks(7045), null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "230801WktWctiKr8vNEi", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 340000m, new Guid("7ee56101-aff6-4d71-8112-e118ada30353") },
                    { new Guid("1e347471-5095-4e8d-9753-e33c1eb551f0"), new DateTime(2023, 8, 13, 22, 54, 13, 529, DateTimeKind.Local).AddTicks(7045), null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "230801SXEgJCBEeHL7d1", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 1570000m, new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5") },
                    { new Guid("25610f9a-ecf7-4202-a6ab-dcbe86c20bb8"), null, null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "230707hIlOvA0CTr0i7f", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 949000m, new Guid("873c3aed-38c2-41ef-b03a-4e142dae542c") },
                    { new Guid("2b621949-1c0a-48f0-874f-3f01f7300ce8"), new DateTime(2023, 8, 13, 22, 54, 13, 529, DateTimeKind.Local).AddTicks(7045), null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "230707FYufCS6av9hB9Q", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 919000m, new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7") },
                    { new Guid("36d18042-c5cd-4d8e-a3da-f083ced04457"), new DateTime(2023, 8, 13, 22, 54, 13, 529, DateTimeKind.Local).AddTicks(7045), null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "230801iiuE7NDZigm9Zc", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 360000m, new Guid("873c3aed-38c2-41ef-b03a-4e142dae542c") },
                    { new Guid("41e0267d-90e0-4429-b3c6-c1eb650bc680"), null, null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "230707LZwAHJX5VmjwWx", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 1298000m, new Guid("a72558d6-0e2f-463f-9ce9-c7a232b7eb89") },
                    { new Guid("4b9659a7-4b0b-4935-8f9d-b7c7f22d9f50"), new DateTime(2023, 8, 13, 22, 54, 13, 529, DateTimeKind.Local).AddTicks(7045), null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "230801VIWgz33iG8yapt", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 300000m, new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7") },
                    { new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"), null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "230703PmyoqNWHK3LZe3", 1, null, "1010 Oak Dr.", null, "Alice", "0123456789", 2250000m, new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7") },
                    { new Guid("504a9755-2870-45ef-8766-df4f603f175e"), new DateTime(2023, 8, 13, 22, 54, 13, 529, DateTimeKind.Local).AddTicks(7045), null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "230801sYy2TamPTiUl52", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 360000m, new Guid("a72558d6-0e2f-463f-9ce9-c7a232b7eb89") },
                    { new Guid("5f312584-d47e-4e8b-bc9c-584657befbf6"), null, null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "230707FYufCS6av9hB9Q", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 1400000m, new Guid("598ded7d-1f81-43a9-861c-21a026294eb1") },
                    { new Guid("636e4f56-0470-4b8a-b13b-58faac1cffb3"), new DateTime(2023, 8, 13, 22, 54, 13, 529, DateTimeKind.Local).AddTicks(7045), null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "230801G0F0PyhkHPp5OS", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 360000m, new Guid("598ded7d-1f81-43a9-861c-21a026294eb1") },
                    { new Guid("7ab228bb-55a0-4b43-ae24-c93488420591"), new DateTime(2023, 8, 13, 22, 54, 13, 529, DateTimeKind.Local).AddTicks(7045), null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "2308018XIRfv5jmzXhiM", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 330000m, new Guid("8db920d7-5115-432c-a9ad-3039dfed3244") },
                    { new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab"), null, null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "23070306w3xM7UGUxRrW", 1, null, "1111 Pine Ln.", null, "Alice", "0123456789", 2250000m, new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5") },
                    { new Guid("8fd4f3f5-4f1a-4f23-a2b0-1dbf8e9d7a9c"), null, null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "230703dkb7wDTr8wQ2rR", 1, null, "123 Main St.", null, "Alice", "0123456789", 1200000m, new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f") },
                    { new Guid("9eef26cf-0fa7-4f11-9a34-25b8d98bf61e"), new DateTime(2023, 8, 13, 22, 54, 13, 529, DateTimeKind.Local).AddTicks(7045), null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "230801CNrbpk8h3XReKq", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 360000m, new Guid("513b6e27-9ec8-4339-8cd2-ce42a2c6a01e") },
                    { new Guid("a60b3fd4-40a0-4f4e-8f5b-6e5a9a3d63e6"), null, null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "230703kTwGUuaOxZ5sC1", 1, null, "456 Elm St.", null, "0987654321", "0987654321", 1200000m, new Guid("66c7e036-0cbd-4350-9afe-5e1e0c959bcf") },
                    { new Guid("a9b47112-adc2-44d6-bec1-1c4d51d6b1a6"), new DateTime(2023, 8, 13, 22, 54, 13, 529, DateTimeKind.Local).AddTicks(7045), null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "230801hQxR49OV9jeFFe", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 309000m, new Guid("66c7e036-0cbd-4350-9afe-5e1e0c959bcf") },
                    { new Guid("b7683f6d-2bf4-4edb-971f-1b4d017244fd"), null, null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "230707yM2UVPAfwmGRxX", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 2100000m, new Guid("8db920d7-5115-432c-a9ad-3039dfed3244") },
                    { new Guid("c9e9de6f-0e6f-4b3e-9f6c-3f8f3a0e6a1d"), null, null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "230703P1u8nabxMakypB", 1, null, "789 Maple Ave.", null, "0987654321", "0987654321", 1200000m, new Guid("7ee56101-aff6-4d71-8112-e118ada30353") },
                    { new Guid("d4af834f-e04d-4130-9023-8eb9b5e88b94"), new DateTime(2023, 8, 13, 22, 54, 13, 529, DateTimeKind.Local).AddTicks(7045), null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "2308018XIRfv5jmzXhiM", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 350000m, new Guid("c7378d1c-47f6-4cc5-b800-281023b6699a") },
                    { new Guid("db2522f0-fdd5-45f3-9f5b-cdf1320e14b8"), new DateTime(2023, 8, 13, 22, 54, 13, 529, DateTimeKind.Local).AddTicks(7045), null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "230801o0pnBzrpz8Fbym", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 330000m, new Guid("7ee56101-aff6-4d71-8112-e118ada30353") },
                    { new Guid("db5e550b-3ff7-4efa-a27e-270970d5b396"), new DateTime(2023, 8, 13, 22, 54, 13, 529, DateTimeKind.Local).AddTicks(7045), null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "230801Qozs4uGrAuVq8E", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 350000m, new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f") },
                    { new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"), null, null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "230707Tu7QJBJH2oY0Hd", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 2480000m, new Guid("c7378d1c-47f6-4cc5-b800-281023b6699a") },
                    { new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"), null, null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "230703DDKbiC3SyDB9pN", 1, null, "123 Main St.", null, "Alice", "0123456789", 2500000m, new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2") },
                    { new Guid("fba2e1cb-2d69-40b1-acdf-46c3ea2f8840"), null, null, new DateTime(2023, 8, 13, 22, 34, 13, 529, DateTimeKind.Local).AddTicks(7045), "230703i5B6qeJ2IbxBVu", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 680000m, new Guid("513b6e27-9ec8-4339-8cd2-ce42a2c6a01e") }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "Id", "ColorId", "CreatedDate", "IsFeatured", "MaterialId", "OriginalPrice", "Price", "ProductId", "SizeId", "Status", "Stock" },
                values: new object[,]
                {
                    { new Guid("0976ba79-d822-408a-86cb-e05045db09ed"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5361), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 300000m, new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), new Guid("f6a1a967-7487-463b-9d7b-09aebf15d304"), 0, 50 },
                    { new Guid("0b3f534f-6dad-4543-804d-a6fce2a4674c"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5374), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("42eea6d0-d14a-4d9e-850f-5f340311bde3"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("0f673bb8-f743-42f8-ba9e-50c6e7bd2b9b"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5434), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 350000m, new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc"), new Guid("f6a1a967-7487-463b-9d7b-09aebf15d304"), 0, 50 },
                    { new Guid("111f1d26-a7e8-429c-a7b9-21427cf975fc"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5436), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 360000m, new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc"), new Guid("aa66fbee-a9d6-4bb5-8ed8-b329d394221f"), 0, 50 },
                    { new Guid("17ddc867-2a86-4a23-9ee0-a60ae4d238dc"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5413), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 350000m, new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5"), new Guid("f6a1a967-7487-463b-9d7b-09aebf15d304"), 0, 50 }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "Id", "ColorId", "CreatedDate", "IsFeatured", "MaterialId", "OriginalPrice", "Price", "ProductId", "SizeId", "Status", "Stock" },
                values: new object[,]
                {
                    { new Guid("180b5870-f77b-4ae6-b4ff-231b27a9bc51"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5364), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 310000m, new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("186dd464-1acc-46c0-98e5-80724ef9a7a0"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5419), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 340000m, new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("18cd05cb-f995-4b13-9fa4-a9e1f1c43862"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5359), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 290000m, new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("1ed004a7-ac94-4c57-b871-564543bc8b38"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5401), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 320000m, new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("1faa9efb-c6c0-4e5e-888c-0010dede6497"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5442), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 320000m, new Guid("b208c071-8450-4999-9cc4-1bf37d7f9294"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("25f1829c-ad64-4e8f-9c8b-e8bf53592304"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5412), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 340000m, new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("280ab97b-e8f8-461c-83b1-178161bdd11d"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5433), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 340000m, new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("28c12878-b191-4d42-974a-7b823de70a06"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5356), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 260000m, new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("2fecd681-ba9f-4ef9-8ce4-8315328dce20"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5410), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 330000m, new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5344), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 150000m, 210000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("37cb83db-2428-4fbb-a8da-fc4554f71729"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5421), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 350000m, new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"), new Guid("f6a1a967-7487-463b-9d7b-09aebf15d304"), 0, 50 },
                    { new Guid("3a1f9be1-c963-4789-8cbc-a935f94e6ef7"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5408), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 310000m, new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("423f83df-dc6c-4b41-aa09-2fe30e841aa6"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5358), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 280000m, new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("42fd8c77-f1ea-4827-a8ba-cfa758d9525e"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5417), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 320000m, new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("524b7e19-cc28-4a7b-aa53-bb6de7b0e1ea"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5367), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 330000m, new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("53f989a8-c813-4667-8a5b-d57b016329a2"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5385), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 320000m, new Guid("b6f2feb6-8373-43c0-8db3-f5d6e664062c"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("59d46d45-02e7-46a6-baca-426683257859"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5369), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 350000m, new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256"), new Guid("f6a1a967-7487-463b-9d7b-09aebf15d304"), 0, 50 },
                    { new Guid("62b387f6-b535-4dfe-a310-76899ee9dec1"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5370), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 360000m, new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256"), new Guid("aa66fbee-a9d6-4bb5-8ed8-b329d394221f"), 0, 50 },
                    { new Guid("64a31f58-96a0-40d4-a3b5-cebb464f9708"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5407), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 360000m, new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8"), new Guid("aa66fbee-a9d6-4bb5-8ed8-b329d394221f"), 0, 50 },
                    { new Guid("6a008d16-196e-40fe-ada5-2acf339fbede"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5362), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 310000m, new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), new Guid("aa66fbee-a9d6-4bb5-8ed8-b329d394221f"), 0, 50 },
                    { new Guid("6b58ba80-86df-4671-a17b-17a65dd4f7b2"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5441), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 310000m, new Guid("b208c071-8450-4999-9cc4-1bf37d7f9294"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("6dd2eb52-3aff-4208-ae75-fe7186aafb16"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5375), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("42eea6d0-d14a-4d9e-850f-5f340311bde3"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("702c91f1-6fd7-4ed8-b8fd-ec4d9b49005f"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5390), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 350000m, new Guid("b6f2feb6-8373-43c0-8db3-f5d6e664062c"), new Guid("f6a1a967-7487-463b-9d7b-09aebf15d304"), 0, 50 },
                    { new Guid("79369e3d-570a-4f1d-8722-9a2daa52ae46"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5380), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 310000m, new Guid("b6f2feb6-8373-43c0-8db3-f5d6e664062c"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("81434550-b237-420d-a407-ea8db1301136"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5397), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 350000m, new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474"), new Guid("f6a1a967-7487-463b-9d7b-09aebf15d304"), 0, 50 },
                    { new Guid("84cf39b1-d8d1-4538-9467-62b7dc41aaae"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5373), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("42eea6d0-d14a-4d9e-850f-5f340311bde3"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("85b4ff3f-1fa0-4597-9177-feece10892b7"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5387), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 340000m, new Guid("b6f2feb6-8373-43c0-8db3-f5d6e664062c"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("90508eca-a616-4b65-9114-aacb1a23ef6f"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5371), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("42eea6d0-d14a-4d9e-850f-5f340311bde3"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("9610c212-5a16-4a70-8703-6bc7f1224be0"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5354), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 250000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("aa66fbee-a9d6-4bb5-8ed8-b329d394221f"), 0, 50 },
                    { new Guid("9902bd0d-729a-49c9-b190-4991f5cf6ccd"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5430), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 320000m, new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("9a6ccc00-6b1c-40c5-be61-eb71323c9151"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5331), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 150000m, 200000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("9edbd50b-02a5-48d0-9acd-6394385185f2"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5405), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 350000m, new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8"), new Guid("f6a1a967-7487-463b-9d7b-09aebf15d304"), 0, 50 },
                    { new Guid("a3be12fa-6696-46b9-a270-b56860f10cc9"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5431), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 330000m, new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("a6188eb6-6679-4b1c-917b-083878b3182e"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5416), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 310000m, new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("a648500a-ee4e-4fa6-ac8d-272670b4fece"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5391), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 360000m, new Guid("b6f2feb6-8373-43c0-8db3-f5d6e664062c"), new Guid("aa66fbee-a9d6-4bb5-8ed8-b329d394221f"), 0, 50 },
                    { new Guid("a6767d22-3ea0-4a00-ad31-9dce1d67184e"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5357), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 270000m, new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("a7e56ca4-bf8e-4cf0-9d07-e95a275b869a"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5404), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 340000m, new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("acb2aea8-07e1-4b38-96bb-5be8ed7ad5cd"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5396), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 340000m, new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("af828b6f-1e3a-4668-af79-925e039fed0a"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5393), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 320000m, new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("b5978ede-0f5d-4732-9c27-0097c9f27029"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5377), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("42eea6d0-d14a-4d9e-850f-5f340311bde3"), new Guid("f6a1a967-7487-463b-9d7b-09aebf15d304"), 0, 50 },
                    { new Guid("b799297f-d21e-4280-8df9-a3c6788c806e"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5349), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 150000m, 220000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("c078a922-9d8e-44d3-a0d4-02aff2ff02a0"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5365), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 320000m, new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "Id", "ColorId", "CreatedDate", "IsFeatured", "MaterialId", "OriginalPrice", "Price", "ProductId", "SizeId", "Status", "Stock" },
                values: new object[,]
                {
                    { new Guid("c455cb74-947f-43f5-8396-52701206a747"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5395), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 330000m, new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("c4ad16dd-57c2-4d70-8c40-a156cf208314"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5400), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 310000m, new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("c7d3c45e-7c7e-431d-967c-a7346c06e123"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5427), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 360000m, new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"), new Guid("aa66fbee-a9d6-4bb5-8ed8-b329d394221f"), 0, 50 },
                    { new Guid("cbbdbb20-a323-440c-b4ef-7494704a0ebe"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5386), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 330000m, new Guid("b6f2feb6-8373-43c0-8db3-f5d6e664062c"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("cc1a10ec-0b47-4308-8876-6c7523da99b3"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5409), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 320000m, new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("cf3450f2-6b36-4797-a249-8285fd6069de"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5403), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 330000m, new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("d34df8f4-7796-4743-8769-04a005d0eefd"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5399), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 360000m, new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474"), new Guid("aa66fbee-a9d6-4bb5-8ed8-b329d394221f"), 0, 50 },
                    { new Guid("dfab5d49-4286-40f7-befc-89dd54baa9c5"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5429), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 310000m, new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("e3acb616-dd2c-44ee-93f0-754c68503b38"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5351), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 150000m, 230000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("e8d5e782-9027-4d0b-886f-43b9b1821647"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5392), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 310000m, new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("e9627388-f53b-4600-9db6-30b5c6061a2b"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5378), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("42eea6d0-d14a-4d9e-850f-5f340311bde3"), new Guid("aa66fbee-a9d6-4bb5-8ed8-b329d394221f"), 0, 50 },
                    { new Guid("eac0583e-715f-4e1a-a793-42ac142256fb"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5414), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 360000m, new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5"), new Guid("aa66fbee-a9d6-4bb5-8ed8-b329d394221f"), 0, 50 },
                    { new Guid("ed8c924a-e97e-4063-986d-27e1c76d0db6"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5368), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 340000m, new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5353), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 240000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("f6a1a967-7487-463b-9d7b-09aebf15d304"), 0, 50 },
                    { new Guid("f5ef450e-5ee9-4525-abde-c404039cd7bc"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 8, 13, 22, 34, 13, 503, DateTimeKind.Local).AddTicks(5418), null, new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 330000m, new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Caption", "ImagePath", "IsDefault", "ProductId", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("027e3184-5cca-436d-a3dc-8d96ac8436cf"), "ThumbnailImage", "/user-content/Ao_thun_Marvel_logo_Spiderman18.jpg", true, new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"), 1 },
                    { new Guid("09c8ba6f-e443-4013-8f85-ee327a2809b1"), "Image", "/user-content/Ao_thun_Gym_Powerfit-den-1.webp", false, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), 2 },
                    { new Guid("1620bd77-a5aa-43fc-a6e5-224b85cd276b"), "ThumbnailImage", "/user-content/Ao_thun_Marvel_Big_Logo_Hulk16.jpg", true, new Guid("3241c204-eb4a-4f41-a214-c77a74577db4"), 1 },
                    { new Guid("176c72e0-3242-4a30-976b-2754badf5345"), "image", "/user-content/ban_linh_trang_chi_tiet_2.jpg", false, new Guid("b208c071-8450-4999-9cc4-1bf37d7f9294"), 2 },
                    { new Guid("215765c3-da42-4e6d-8a56-3a655aced106"), "image", "/user-content/Ao_thun_Gym_Powerfit-den-6.webp", false, new Guid("3241c204-eb4a-4f41-a214-c77a74577db4"), 2 },
                    { new Guid("30dbbd7b-1a9e-4c97-9b13-7b322374936b"), "image", "/user-content/Ao_thun_Marvel_Captain_America011.jpg", false, new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8"), 2 },
                    { new Guid("311f107f-544f-4c67-9195-a2e220a76ff7"), "ThumbnailImage", "/user-content/Ao_thun_Gym_Powerfit-den-3.webp", true, new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8"), 1 },
                    { new Guid("389516c7-bb09-4889-a01b-9ffb56a7d105"), "ThumbnailImage", "/user-content/Ao_thun_Marvel_Captain_America-6.jpg", true, new Guid("217cc99e-4586-4fc2-9e87-66ba1061426f"), 1 },
                    { new Guid("5936551b-8520-4b63-92fd-0fd8a19dd1f3"), "ThumbnailImage", "/user-content/ban_linh_trang_1.jpg", true, new Guid("1975818f-1d1d-4df8-8477-0afaf9687945"), 1 },
                    { new Guid("5a60998a-a665-4d47-88ac-8c084254949c"), "image", "/user-content/ATS.RN.EF.TI.S3D_essential.jpg", false, new Guid("a8edbd5b-dd2b-42d1-84b4-013e867d0f88"), 2 },
                    { new Guid("5f28acd7-5b28-4eff-8470-aa00b479b032"), "ThumbnailImage", "/user-content/tee-navy-1.jpg", true, new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), 1 },
                    { new Guid("69872c02-390d-4e06-a171-1c07fc74f7b2"), "ThumbnailImage", "/user-content/Ao_thun_Gym_Powerfit-den-3.webp", true, new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256"), 1 },
                    { new Guid("72b72d01-8144-4382-a56b-4d445b56c040"), "image", "/user-content/Ao_thun_Marvel_logo_Spiderman18.jpg", false, new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc"), 2 },
                    { new Guid("7b5a9da0-9270-43e7-9a29-b23ceb0fc345"), "image", "/user-content/Ao_thun_Marvel_logo_Spiderman1.jpg", false, new Guid("b6f2feb6-8373-43c0-8db3-f5d6e664062c"), 2 },
                    { new Guid("89c445bd-fd4d-40a1-8129-2613e62ce612"), "ThumbnailImage", "/user-content/_CMM2689.jpg", true, new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc"), 1 },
                    { new Guid("8dc8adce-ae13-4098-a88f-9d212a84bee5"), "lmao", "/user-content/Ao_thun_Marvel_logo_Spiderman18.jpg", false, new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256"), 2 },
                    { new Guid("98f5bafe-936c-4512-a379-9a8b53fa3c9f"), "ThumbnailImage", "/user-content/_CMM0423.jpg", true, new Guid("b208c071-8450-4999-9cc4-1bf37d7f9294"), 1 },
                    { new Guid("9c0bab1c-7e3b-4fb9-b0a9-d209253db752"), "image", "/user-content/Ao_thun_Marvel_Big_Logo_Hulk15.jpg", false, new Guid("1975818f-1d1d-4df8-8477-0afaf9687945"), 2 },
                    { new Guid("9d2b5026-adb0-4306-9b29-1a7d99a51d2a"), "ThumbnailImage", "/user-content/Ao_thun_Gym_Powerfit-den-3.webp", true, new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474"), 1 },
                    { new Guid("9dd02bd4-364a-49a2-94a2-d07e9ce72d8d"), "ThumbnailImage", "/user-content/Ao_thun_Gym_Powerfit-den-3.webp", true, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), 1 },
                    { new Guid("a4710f56-6a96-49c0-90c9-dac289b8bbc2"), "image", "/user-content/Ao_thun_Marvel_Big_Logo_Hulk16.jpg", false, new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474"), 2 },
                    { new Guid("ae2f26c5-cc35-4607-8676-c7f876dcfa2d"), "image", "/user-content/Ao_thun_Marvel_Captain_America013.jpg", false, new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"), 2 },
                    { new Guid("b0c90cab-a051-41da-9802-ab83af74c2a6"), "ThumbnailImage", "/user-content/Ao_thun_Gym_Powerfit-den-3.webp", true, new Guid("42eea6d0-d14a-4d9e-850f-5f340311bde3"), 1 },
                    { new Guid("d2c58945-c066-44f1-8246-96d6938b3606"), "image", "/user-content/Ao_thun_Cotton_Summer_Coolwaves-23-7.jpg", false, new Guid("217cc99e-4586-4fc2-9e87-66ba1061426f"), 2 },
                    { new Guid("d8251322-9a9f-4580-ba70-69f8e78320e2"), "ThumbnailImage", "/user-content/Ao_thun_Gym_Powerfit-den-3.webp", true, new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5"), 1 },
                    { new Guid("d88d96cb-1d98-4462-83fb-2d5af8b97141"), "Image", "/user-content/tee-navy-2.jpg", false, new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), 2 },
                    { new Guid("d9726055-fcdb-43d7-8155-2035646d36be"), "image", "/user-content/Ao_thun_Marvel_Captain_America-6.jpg", false, new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5"), 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Caption", "ImagePath", "IsDefault", "ProductId", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("e11c3fe7-a75e-4065-bc48-ff43446d3dce"), "ThumbnailImage", "/user-content/23-Ao_thun_Cotton_Summer_Coolwaves_Graphic_-_Cay_dua4.jpg", true, new Guid("a8edbd5b-dd2b-42d1-84b4-013e867d0f88"), 1 },
                    { new Guid("e276a5f2-ac33-4d19-8001-b915bb85cbd1"), "ThumbnailImage", "/user-content/Ao_thun_Gym_Powerfit-den-3.webp", true, new Guid("b6f2feb6-8373-43c0-8db3-f5d6e664062c"), 1 },
                    { new Guid("fbe934b1-cb4f-4605-9bc8-8bb518bca047"), "image", "/user-content/coaoo4.jpg", false, new Guid("42eea6d0-d14a-4d9e-850f-5f340311bde3"), 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d") },
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("1975818f-1d1d-4df8-8477-0afaf9687945") },
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9") },
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8") },
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("217cc99e-4586-4fc2-9e87-66ba1061426f") },
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474") },
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("3241c204-eb4a-4f41-a214-c77a74577db4") },
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844") },
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("42eea6d0-d14a-4d9e-850f-5f340311bde3") },
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256") },
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc") },
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("a8edbd5b-dd2b-42d1-84b4-013e867d0f88") },
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5") },
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("b208c071-8450-4999-9cc4-1bf37d7f9294") },
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("b6f2feb6-8373-43c0-8db3-f5d6e664062c") }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "OrderId", "Price", "ProductDetailId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("01031bc1-c8a5-40bb-af00-859dbcc2e3c5"), new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab"), 240000m, new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"), 5 },
                    { new Guid("23acf045-fc21-4c47-b826-55d8b4602ac1"), new Guid("41e0267d-90e0-4429-b3c6-c1eb650bc680"), 309000m, new Guid("0b3f534f-6dad-4543-804d-a6fce2a4674c"), 1 },
                    { new Guid("28dd891a-f482-4d04-a2bf-fb4fc14f6ae5"), new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab"), 210000m, new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45"), 5 },
                    { new Guid("2a31ca13-b55a-4075-8090-281a96d480ac"), new Guid("1e347471-5095-4e8d-9753-e33c1eb551f0"), 360000m, new Guid("64a31f58-96a0-40d4-a3b5-cebb464f9708"), 1 },
                    { new Guid("3273381f-e5da-43f0-ac8a-dc7f9135e736"), new Guid("504a9755-2870-45ef-8766-df4f603f175e"), 360000m, new Guid("d34df8f4-7796-4743-8769-04a005d0eefd"), 1 },
                    { new Guid("3601d71e-12ba-4ee1-821c-6f47a1ad44cf"), new Guid("636e4f56-0470-4b8a-b13b-58faac1cffb3"), 360000m, new Guid("d34df8f4-7796-4743-8769-04a005d0eefd"), 1 },
                    { new Guid("3c97b5da-3011-458d-b1ab-f5c65ea5c357"), new Guid("9eef26cf-0fa7-4f11-9a34-25b8d98bf61e"), 360000m, new Guid("c7d3c45e-7c7e-431d-967c-a7346c06e123"), 1 },
                    { new Guid("49445c27-3876-449d-a8ba-9d741c318180"), new Guid("b7683f6d-2bf4-4edb-971f-1b4d017244fd"), 360000m, new Guid("a648500a-ee4e-4fa6-ac8d-272670b4fece"), 4 },
                    { new Guid("57378975-9ed6-4db4-8cb8-6ccd3989981a"), new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"), 330000m, new Guid("2fecd681-ba9f-4ef9-8ce4-8315328dce20"), 4 },
                    { new Guid("5ca22d20-49a8-496d-9a9b-d17c84416f51"), new Guid("5f312584-d47e-4e8b-bc9c-584657befbf6"), 360000m, new Guid("111f1d26-a7e8-429c-a7b9-21427cf975fc"), 3 },
                    { new Guid("5d8d7ad4-7c00-45eb-ad0f-26a813eecad5"), new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"), 290000m, new Guid("18cd05cb-f995-4b13-9fa4-a9e1f1c43862"), 4 },
                    { new Guid("5e26280e-7302-48bc-b26e-33a37bd3aa25"), new Guid("c9e9de6f-0e6f-4b3e-9f6c-3f8f3a0e6a1d"), 240000m, new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"), 5 },
                    { new Guid("616cb6cf-ea92-4796-b6b6-8d4723258110"), new Guid("41e0267d-90e0-4429-b3c6-c1eb650bc680"), 340000m, new Guid("280ab97b-e8f8-461c-83b1-178161bdd11d"), 2 },
                    { new Guid("61b0273e-d46a-42f5-9c92-d38c3a0453ad"), new Guid("0da98ae9-3b88-453c-af1b-b5e7fa1a0b25"), 340000m, new Guid("ed8c924a-e97e-4063-986d-27e1c76d0db6"), 1 },
                    { new Guid("61e38a08-7ab8-40c6-81e7-e2a516dbf0ce"), new Guid("4b9659a7-4b0b-4935-8f9d-b7c7f22d9f50"), 300000m, new Guid("0976ba79-d822-408a-86cb-e05045db09ed"), 1 },
                    { new Guid("6b06cec7-7f7d-40ae-94ec-5ac25aec1aa7"), new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"), 220000m, new Guid("b799297f-d21e-4280-8df9-a3c6788c806e"), 5 },
                    { new Guid("6b1a25ac-d66a-4171-a142-3d0d425ef71b"), new Guid("41e0267d-90e0-4429-b3c6-c1eb650bc680"), 309000m, new Guid("e9627388-f53b-4600-9db6-30b5c6061a2b"), 1 },
                    { new Guid("75004318-d084-4fe6-b007-8688c7a48eb2"), new Guid("25610f9a-ecf7-4202-a6ab-dcbe86c20bb8"), 320000m, new Guid("af828b6f-1e3a-4668-af79-925e039fed0a"), 2 },
                    { new Guid("87f2f4e9-0c7d-420e-98ac-5038673d0f39"), new Guid("8fd4f3f5-4f1a-4f23-a2b0-1dbf8e9d7a9c"), 240000m, new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"), 5 },
                    { new Guid("87f330fa-7f07-4b4d-bd71-c962426bca62"), new Guid("a60b3fd4-40a0-4f4e-8f5b-6e5a9a3d63e6"), 240000m, new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"), 5 },
                    { new Guid("8ef548a5-1379-4314-93ab-90cf3255bcfa"), new Guid("2b621949-1c0a-48f0-874f-3f01f7300ce8"), 310000m, new Guid("a6188eb6-6679-4b1c-917b-083878b3182e"), 2 },
                    { new Guid("9adf9023-59ca-4013-a49d-6f3fa310e67e"), new Guid("25610f9a-ecf7-4202-a6ab-dcbe86c20bb8"), 309000m, new Guid("b5978ede-0f5d-4732-9c27-0097c9f27029"), 1 },
                    { new Guid("9e154e8d-d8bf-45ea-9d8f-822285bcb3f0"), new Guid("36d18042-c5cd-4d8e-a3da-f083ced04457"), 360000m, new Guid("d34df8f4-7796-4743-8769-04a005d0eefd"), 1 },
                    { new Guid("9ecd85a1-9790-423f-8e1a-fea50164a749"), new Guid("1e347471-5095-4e8d-9753-e33c1eb551f0"), 280000m, new Guid("423f83df-dc6c-4b41-aa09-2fe30e841aa6"), 2 },
                    { new Guid("a7c511fc-b188-4a2a-abf6-ea649eb04e4d"), new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"), 210000m, new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45"), 5 },
                    { new Guid("a97c34ec-67bd-47e5-8c00-48f94e6332cf"), new Guid("7ab228bb-55a0-4b43-ae24-c93488420591"), 330000m, new Guid("cf3450f2-6b36-4797-a249-8285fd6069de"), 1 },
                    { new Guid("aafe7fe1-a73a-4943-ad8b-dbe1050844ad"), new Guid("5f312584-d47e-4e8b-bc9c-584657befbf6"), 320000m, new Guid("1faa9efb-c6c0-4e5e-888c-0010dede6497"), 1 },
                    { new Guid("beba2311-a1af-4420-a254-8da4624f98b6"), new Guid("db5e550b-3ff7-4efa-a27e-270970d5b396"), 350000m, new Guid("17ddc867-2a86-4a23-9ee0-a60ae4d238dc"), 1 },
                    { new Guid("c355f853-984c-4975-942b-2d368cf1f2a9"), new Guid("b7683f6d-2bf4-4edb-971f-1b4d017244fd"), 330000m, new Guid("524b7e19-cc28-4a7b-aa53-bb6de7b0e1ea"), 2 },
                    { new Guid("c83e2f11-a184-4409-83f8-44e45ed81a9b"), new Guid("db2522f0-fdd5-45f3-9f5b-cdf1320e14b8"), 330000m, new Guid("cf3450f2-6b36-4797-a249-8285fd6069de"), 1 },
                    { new Guid("cc67d86b-ef7c-4864-bc5e-2aca0e1f36ad"), new Guid("d4af834f-e04d-4130-9023-8eb9b5e88b94"), 350000m, new Guid("9edbd50b-02a5-48d0-9acd-6394385185f2"), 1 },
                    { new Guid("d62d41e6-657c-4778-8555-e84a88bcc90f"), new Guid("1e347471-5095-4e8d-9753-e33c1eb551f0"), 300000m, new Guid("0976ba79-d822-408a-86cb-e05045db09ed"), 1 },
                    { new Guid("db3f2553-ca63-489e-9d16-b5439b3080c4"), new Guid("a9b47112-adc2-44d6-bec1-1c4d51d6b1a6"), 309000m, new Guid("e9627388-f53b-4600-9db6-30b5c6061a2b"), 1 },
                    { new Guid("e8775943-84b2-49d5-9f39-f5fe268fa3ab"), new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"), 230000m, new Guid("e3acb616-dd2c-44ee-93f0-754c68503b38"), 5 },
                    { new Guid("ea3ee695-a55a-48fb-9e48-be694b837b19"), new Guid("1e347471-5095-4e8d-9753-e33c1eb551f0"), 350000m, new Guid("81434550-b237-420d-a407-ea8db1301136"), 1 },
                    { new Guid("f978d123-22e2-49ad-b313-86cca345e17d"), new Guid("2b621949-1c0a-48f0-874f-3f01f7300ce8"), 309000m, new Guid("e9627388-f53b-4600-9db6-30b5c6061a2b"), 1 },
                    { new Guid("fbee63d7-5bff-4830-aef3-ae8bd9c592c4"), new Guid("fba2e1cb-2d69-40b1-acdf-46c3ea2f8840"), 340000m, new Guid("a7e56ca4-bf8e-4cf0-9d07-e95a275b869a"), 2 },
                    { new Guid("fce74626-1ee7-4a93-85e7-eaf69bfdb982"), new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"), 200000m, new Guid("9a6ccc00-6b1c-40c5-be61-eb71323c9151"), 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_ProductDetailId",
                table: "CartDetails",
                column: "ProductDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_UserId",
                table: "CartDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

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