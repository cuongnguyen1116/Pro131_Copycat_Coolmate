using System;
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
                    { new Guid("1090dcdd-b383-417b-9523-d73f0373fbb0"), "1dc63c7f-0463-4b46-ab38-848696233bbc", "Administrator role", "admin", null },
                    { new Guid("4a1c9012-a602-46a9-8eba-05e85149fd81"), "61dfb675-da44-4705-bf6f-889ae61df0b4", "Employee role", "employee", null },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), "b5accffc-c201-451a-90a4-60c0e8740506", "Customer role", "customer", null }
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
                    { new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f"), 0, "8a90fe50-b24a-448c-9989-4a321391b304", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "jennifer.smith@example.com", true, "Jennifer", "Smith", false, null, "JENNIFER.SMITH@EXAMPLE.COM", "beautysmithlady159", "AQAAAAEAACcQAAAAELSSFHT+qOHEYYFV/Cf+5t+GvV/au9x8Yyr5nscCH3ylixwtU9nXONLFcWo0RI8aUA==", null, false, "", false, "beautysmithlady159" },
                    { new Guid("3b294e1f-c3f7-4f71-9be6-11c614fbdce5"), 0, "5cf94e8f-8afb-4a30-a37e-df4feb881025", new DateTime(2003, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "lusdeer@gmail.com", true, "Hieu", "Le Minh", false, null, "lusdeer@gmail.com", "lmaohieu1", "AQAAAAEAACcQAAAAEIYMV0U+XMQyX+VzXjvTEVN4YsKusiIwwiWJ9nvg9dvGKNGpTpPSbp9JRW61rYxQWQ==", null, false, "", false, "lmaohieu1" },
                    { new Guid("513b6e27-9ec8-4339-8cd2-ce42a2c6a01e"), 0, "76969255-d049-4cf4-92b0-ec7c25b4aab7", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "taylorswift109@gmail.com", true, "Thúy", "Loan", false, null, "TAYLORSWIFT109@gmail.com", "taylorswift109", "AQAAAAEAACcQAAAAEAdUhQz1fBUK5vMlnIdapJXX5ZsLFVwuUJ+lNWt03AopIf9MV/s9joQQOKq2OdxLIA==", null, false, "", false, "taylorswift109" },
                    { new Guid("598ded7d-1f81-43a9-861c-21a026294eb1"), 0, "41bbd7c9-ac2f-415d-9da8-55db14b3ef27", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "miley987@gmail.com", true, "Robyn", "Fenty", false, null, "MILEY987@gmail.com", "miley987", "AQAAAAEAACcQAAAAEH8vVUSx1ysL2DQOjM+0zjM99Hz5MwNB0C2QoonVEDw/PDJabGtpzTm4DXpLbX7z7w==", null, false, "", false, "miley987" },
                    { new Guid("66c7e036-0cbd-4350-9afe-5e1e0c959bcf"), 0, "84a5117c-5554-47ed-a2fd-695af56ec910", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "jennifer.smith@example.com", true, "Billie", "Jean", false, null, "JENNIFER.SMITH@EXAMPLE.COM", "notmylover199", "AQAAAAEAACcQAAAAEDtGpWPI8xCEV3zXh97XmNow/lEKp1l/AF9t2HaTCOJ6+KLDFzW31RQMEZ0q5iDArw==", null, false, "", false, "notmylover199" },
                    { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "ef14f159-7872-4235-88e2-37411181ddea", new DateTime(2003, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "cuongnguyenpm1116@gmail.com", true, "Cuong", "Nguyen Phuc Minh", false, null, "cuongnguyenpm1116@gmail.com", "admin", "AQAAAAEAACcQAAAAEPyhBYETXKRY0M8WD4ESXWwEM5fblgyIgLyj4DpL22TBWlsCwlvocbPjKLGiYVvLEQ==", null, false, "", false, "admin" },
                    { new Guid("7ee56101-aff6-4d71-8112-e118ada30353"), 0, "7bb38062-9766-452b-b2cc-3c88e12469cd", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "michealthoangmong@gmail.com", true, "Michael", "Jackson", false, null, "MICHAELTHOANGMONG1@GMAIL.COM", "michaelthoangmong1", "AQAAAAEAACcQAAAAECViK90Ik+5x9JnQmVSKYcZfd6QRiZvCk8pc04yZ7P/dR4m+8S6DlgLPb0ABWMi79Q==", null, false, "", false, "michaelthoangmong1" },
                    { new Guid("873c3aed-38c2-41ef-b03a-4e142dae542c"), 0, "b2c713d4-2aa9-4223-9438-28ba5f4d48ff", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "camila119@gmail.com", true, "Karla Camila", " Cabello Estrabao", false, null, "CAMILA119@gmail.com", "camila119", "AQAAAAEAACcQAAAAEBIKe/IaioP8VSY/CV3XEHbiUuY1dS+Df9KGKjm19OvG5Si4QEdj07bRwjNVpqGAwA==", null, false, "", false, "camila119" },
                    { new Guid("8db920d7-5115-432c-a9ad-3039dfed3244"), 0, "b5fcac0e-a992-4a2b-9159-297442190bec", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "grande145@gmail.com", true, "Ariana", "Grande", false, null, "GRANDE145@gmail.com", "grande145", "AQAAAAEAACcQAAAAEFm/3n/R1BygRc1SdPqt4ikCuxEaGVdVCf14YWIfLLi6HpMKCFnOBNTJWm/0NWP7Ow==", null, false, "", false, "grande145" },
                    { new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2"), 0, "91705a7d-67db-4b2d-ba1f-e0570dd7deaa", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", true, "John", "Doe", false, null, "JOHN.DOE@EXAMPLE.COM", "doesnot90", "AQAAAAEAACcQAAAAECdf9LLXdvEyUEgS0/iW6wz1evarlWj1/UOqP5j8nxOySHqO0HQWuct/B1geIwapKg==", null, false, "", false, "doesnot90" },
                    { new Guid("a72558d6-0e2f-463f-9ce9-c7a232b7eb89"), 0, "d045135c-4bfa-41bb-938f-c426fa018dd8", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "drake123@gmail.com", true, "Aubrey", "Drake Graham", false, null, "DRAKE123@gmail.com", "drake123", "AQAAAAEAACcQAAAAEEsFhLPPVdyZivG2JhpOQxdybN4yHFELViTPNXQ5Pq9yMV1hN9OEolnIPDbt8jhE5A==", null, false, "", false, "drake123" },
                    { new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7"), 0, "e5417c27-2e89-456b-a964-e5c54cf7f723", new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.doe@example.com", true, "Jane", "Doe", false, null, "JANE.DOE@EXAMPLE.COM", "janenotlost123", "AQAAAAEAACcQAAAAEOcx7bJeiYcECsBTuDfxLwf+AVvE3suZakk7/IYriUL2M0PUES5YmFczzv2gkkNFug==", null, false, "", false, "janenotlost123" },
                    { new Guid("c2ec6dd4-8170-4b6d-acf4-33d52a128789"), 0, "dedbb177-8fae-4f4d-9624-a70116258101", new DateTime(2003, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "hq37na@gmail.com", true, "Hoc", "Nguyen Kim", false, null, "hq37na@gmail.com", "kimhoc1", "AQAAAAEAACcQAAAAEO4k0/aXaGuueG3wMPoFYfgWffohTCUAlKjV0KnzSv4pC6MRvVybZefcNU9X8Zzv2Q==", null, false, "", false, "kimhoc1" },
                    { new Guid("c7378d1c-47f6-4cc5-b800-281023b6699a"), 0, "9d5ab0c2-870f-413b-a55e-1e94f10aec80", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "michealthoangmong@gmail.com", true, "Michael", "Jackson", false, null, "MICHAELTHOANGMONG1@GMAIL.COM", "michaelthoangmong1", "AQAAAAEAACcQAAAAEMBfYN4Q4CniE//eXikgh+6sH0+UCdgR2/XAzbuXgfpDh75pDAVgBkslHdJA23c/GQ==", null, false, "", false, "michaelthoangmong1" },
                    { new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5"), 0, "eebdf329-1ef8-40e4-9966-ed3a852499de", new DateTime(1998, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob.smith@example.com", true, "Bob", "Smith", false, null, "BOB.SMITH@EXAMPLE.COM", "bobthebuilder98", "AQAAAAEAACcQAAAAEPqlZT5+1aogUzAFmpv1BCXMk/efc+DHAjGR3OuBlbenNyfNKiijfgl9S3hw/BYSpQ==", null, false, "", false, "bobthebuilder98" }
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
                    { new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"), "Sản phẩm trong Bộ sưu tập Summer\r\nChất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nHình in PET bền bỉ, không lo bong tróc, thoải mái giặt máy\r\nTự hào sản xuất tại Việt Nam", "Summer Coolwaves Graphic - Cây dừa" },
                    { new Guid("1975818f-1d1d-4df8-8477-0afaf9687945"), "Sản phẩm Care & Share hợp tác với cầu thủ nữ ĐTQG Việt Nam Huỳnh Như\r\n10% Doanh thu từ mỗi sản phẩm bán ra sẽ được quyên góp vào Quỹ Care & Share\r\nChất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nTự hào sản xuất tại Việt Nam", "Care & Share The Moments - Bản lĩnh" },
                    { new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), "Chất liệu: 86% Poly + 14% Spandex. Co giãn 4 chiều mang lại sự thoải mái để bạn vận động hết mình. Thiết kế công thái học, cải tiến giữ các đường may không bị mài mòn và tăng độ bền. Chất liệu thấm mồ hôi và khô nhanh, thoáng khí mang lại khả năng khô thoáng vượt trội. Form áo: Slim fit. Người mẫu: 180cm - 80kg, mặc áo size XL. Tự hào sản xuất tại Việt Nam", "Gym Powerfit" },
                    { new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8"), "Chất liệu: 95% Cotton Compact - 5% Spandex\r\nPhù hợp với: mặc ở nhà, đi làm, đi chơi\r\nKiểu dáng: Regular Fit dáng suông\r\nTự hào sản xuất tại Việt Nam Xem nhà máy >\r\nNgười mẫu: 184 cm, 73 kg, mặc size 2XL", "Compact phiên bản Premium" },
                    { new Guid("217cc99e-4586-4fc2-9e87-66ba1061426f"), "10% Doanh thu từ mỗi sản phẩm sẽ được quyên góp vào Quỹ Care & Share\r\nChất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nTự hào sản xuất tại Việt Nam", "Care &Share Tuổi thơ dữ dội - Bấm chuông" },
                    { new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474"), "Đây là sản phẩm thuộc Clean Vietnam Collection\r\nChất liệu: 80% Cotton - 20% Recycle Polyester,co giãn 4 chiều\r\nKiểu dáng: regularfit dáng suông\r\nPhù hợp với: đi chơi, đi làm, ở nhà\r\nTự hào sản xuất tại Việt Nam\r\nMục tiêu dự án đến 2023 sẽ tái chế được 500.000 chai nhựa thành sợi và sản xuất thành sản phẩm tốt về công năng", "Clean Vietnam" },
                    { new Guid("3241c204-eb4a-4f41-a214-c77a74577db4"), "10% Doanh thu từ mỗi sản phẩm sẽ được quyên góp vào Quỹ Care & Share\r\nChất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nTự hào sản xuất tại Việt Nam", "Care &Share Tuổi thơ dữ dội - Tắm mưa" },
                    { new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), "Sản phẩm trong Bộ sưu tập Summer. Chất liệu: 100% Cotton mềm mại. Định lượng vải: 200gsm, dày dặn. Dáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà. Hình in PET bền bỉ, không lo bong tróc, thoải mái giặt máy. Tự hào sản xuất tại Việt Nam", "Summer Coolwaves" },
                    { new Guid("42eea6d0-d14a-4d9e-850f-5f340311bde3"), "Chất liệu: 97% Polyester Quick-Dry + 3% Spandex. Xử lý hoàn thiện vải: Quick-Dry + Wicking + Stretch. Công nghệ Chafe-Free may Seamless hạn chế tối đa ma sát trong quá trình vận động. Định lượng vải 110gsm siêu nhẹ. Được nghiên cứu và phát triển phù hợp dựa trên các Runner chuyên nghiệp. Tự hào sản xuất tại Việt Nam", "Essential Fast & Free Run" },
                    { new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256"), "Chất liệu: 95% Polyester Quick-Dry + 5% Spandex. Xử lý hoàn thiện vải: Quick-Dry + Wicking + Stretch. Công nghệ Chafe-Free hạn chế tối đa ma sát trong quá trình vận động từ các đường may may Seamless. Định lượng vải 100gsm siêu nhẹ. Được phát triển và kiểm nghiệm bởi các VĐV Marathon. Tự hào sản xuất tại Việt Nam", "Quick Dry in Graphic R1" },
                    { new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc"), "10% Doanh thu từ mỗi sản phẩm sẽ được quyên góp vào Quỹ Care & Share\r\nChất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nTự hào sản xuất tại Việt Nam", "Care &Share Tuổi thơ dữ dội - Bắn bi" },
                    { new Guid("a8edbd5b-dd2b-42d1-84b4-013e867d0f88"), "Chất liệu: 95% Polyester Quick-Dry + 5% Spandex\r\nXử lý hoàn thiện vải: Quick-Dry + Wicking + Stretch\r\nCông nghệ Chafe-Free hạn chế tối đa ma sát trong quá trình vận động từ các đường may may Seamless\r\nĐịnh lượng vải 100gsm siêu nhẹ\r\nĐược phát triển và kiểm nghiệm bởi các VĐV Marathon\r\nTự hào sản xuất tại Việt Nam", "Advanced Fast & Free Run" },
                    { new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5"), "Sản phẩm trong Bộ sưu tập Summer\r\nChất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nHình in PET bền bỉ, không lo bong tróc, thoải mái giặt máy\r\nTự hào sản xuất tại Việt Nam", "Summer Coolwaves Graphic" },
                    { new Guid("b208c071-8450-4999-9cc4-1bf37d7f9294"), "10% Doanh thu từ mỗi sản phẩm sẽ được quyên góp vào Quỹ Care & Share\r\nChất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nTự hào sản xuất tại Việt Nam", "Care &Share Tuổi thơ dữ dội - Pattern tranh" },
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
                table: "Orders",
                columns: new[] { "Id", "CompletedDate", "ConfirmedDate", "CreatedDate", "OrderCode", "OrderStatus", "PaidDate", "ShipAddress", "ShipDate", "ShipName", "ShipPhoneNumber", "Total", "UserId" },
                values: new object[,]
                {
                    { new Guid("25610f9a-ecf7-4202-a6ab-dcbe86c20bb8"), null, null, new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476), "230707hIlOvA0CTr0i7f", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 232000m, new Guid("873c3aed-38c2-41ef-b03a-4e142dae542c") },
                    { new Guid("41e0267d-90e0-4429-b3c6-c1eb650bc680"), null, null, new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476), "230707LZwAHJX5VmjwWx", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 232000m, new Guid("a72558d6-0e2f-463f-9ce9-c7a232b7eb89") },
                    { new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"), null, new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476), new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476), "230703PmyoqNWHK3LZe3", 1, null, "1010 Oak Dr.", null, "Alice", "0123456789", 2000000m, new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7") },
                    { new Guid("5f312584-d47e-4e8b-bc9c-584657befbf6"), null, null, new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476), "230707FYufCS6av9hB9Q", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 232000m, new Guid("598ded7d-1f81-43a9-861c-21a026294eb1") },
                    { new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab"), null, null, new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476), "23070306w3xM7UGUxRrW", 1, null, "1111 Pine Ln.", null, "Alice", "0123456789", 3000000m, new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5") },
                    { new Guid("8fd4f3f5-4f1a-4f23-a2b0-1dbf8e9d7a9c"), null, null, new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476), "230703dkb7wDTr8wQ2rR", 1, null, "123 Main St.", null, "Alice", "0123456789", 290000m, new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f") },
                    { new Guid("a60b3fd4-40a0-4f4e-8f5b-6e5a9a3d63e6"), null, null, new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476), "230703kTwGUuaOxZ5sC1", 1, null, "456 Elm St.", null, "0987654321", "0987654321", 275000m, new Guid("66c7e036-0cbd-4350-9afe-5e1e0c959bcf") },
                    { new Guid("b7683f6d-2bf4-4edb-971f-1b4d017244fd"), null, null, new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476), "230707yM2UVPAfwmGRxX", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 232000m, new Guid("8db920d7-5115-432c-a9ad-3039dfed3244") },
                    { new Guid("c9e9de6f-0e6f-4b3e-9f6c-3f8f3a0e6a1d"), null, null, new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476), "230703P1u8nabxMakypB", 1, null, "789 Maple Ave.", null, "0987654321", "0987654321", 129000m, new Guid("7ee56101-aff6-4d71-8112-e118ada30353") },
                    { new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"), null, null, new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476), "230707Tu7QJBJH2oY0Hd", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 232000m, new Guid("c7378d1c-47f6-4cc5-b800-281023b6699a") },
                    { new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"), null, null, new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476), "230703DDKbiC3SyDB9pN", 1, null, "123 Main St.", null, "Alice", "0123456789", 1000000m, new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2") },
                    { new Guid("fba2e1cb-2d69-40b1-acdf-46c3ea2f8840"), null, null, new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476), "230703i5B6qeJ2IbxBVu", 1, null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 232000m, new Guid("513b6e27-9ec8-4339-8cd2-ce42a2c6a01e") }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "Id", "ColorId", "CreatedDate", "MaterialId", "OriginalPrice", "Price", "ProductId", "SizeId", "Status", "Stock" },
                values: new object[,]
                {
                    { new Guid("0976ba79-d822-408a-86cb-e05045db09ed"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2290), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 299000m, new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), new Guid("f6a1a967-7487-463b-9d7b-09aebf15d304"), 0, 50 },
                    { new Guid("0b3f534f-6dad-4543-804d-a6fce2a4674c"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2304), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("b6f2feb6-8373-43c0-8db3-f5d6e664062c"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("0f673bb8-f743-42f8-ba9e-50c6e7bd2b9b"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2361), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("217cc99e-4586-4fc2-9e87-66ba1061426f"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("111f1d26-a7e8-429c-a7b9-21427cf975fc"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2362), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("217cc99e-4586-4fc2-9e87-66ba1061426f"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("17ddc867-2a86-4a23-9ee0-a60ae4d238dc"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2345), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("b208c071-8450-4999-9cc4-1bf37d7f9294"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("180b5870-f77b-4ae6-b4ff-231b27a9bc51"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2292), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("186dd464-1acc-46c0-98e5-80724ef9a7a0"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2351), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("3241c204-eb4a-4f41-a214-c77a74577db4"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("18cd05cb-f995-4b13-9fa4-a9e1f1c43862"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2288), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 289000m, new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("1ed004a7-ac94-4c57-b871-564543bc8b38"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2331), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("1faa9efb-c6c0-4e5e-888c-0010dede6497"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2369), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("217cc99e-4586-4fc2-9e87-66ba1061426f"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("25f1829c-ad64-4e8f-9c8b-e8bf53592304"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2344), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("280ab97b-e8f8-461c-83b1-178161bdd11d"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2360), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("a8edbd5b-dd2b-42d1-84b4-013e867d0f88"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("28c12878-b191-4d42-974a-7b823de70a06"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2284), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 259000m, new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("2fecd681-ba9f-4ef9-8ce4-8315328dce20"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2342), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2278), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 150000m, 209000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("37cb83db-2428-4fbb-a8da-fc4554f71729"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2353), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("1975818f-1d1d-4df8-8477-0afaf9687945"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("3a1f9be1-c963-4789-8cbc-a935f94e6ef7"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2339), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("423f83df-dc6c-4b41-aa09-2fe30e841aa6"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2287), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 279000m, new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("42fd8c77-f1ea-4827-a8ba-cfa758d9525e"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2349), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("3241c204-eb4a-4f41-a214-c77a74577db4"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("524b7e19-cc28-4a7b-aa53-bb6de7b0e1ea"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2296), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("53f989a8-c813-4667-8a5b-d57b016329a2"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2315), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("59d46d45-02e7-46a6-baca-426683257859"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2299), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("42eea6d0-d14a-4d9e-850f-5f340311bde3"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("62b387f6-b535-4dfe-a310-76899ee9dec1"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2300), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("42eea6d0-d14a-4d9e-850f-5f340311bde3"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("64a31f58-96a0-40d4-a3b5-cebb464f9708"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2337), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"), new Guid("aa66fbee-a9d6-4bb5-8ed8-b329d394221f"), 0, 50 },
                    { new Guid("6a008d16-196e-40fe-ada5-2acf339fbede"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2291), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), new Guid("aa66fbee-a9d6-4bb5-8ed8-b329d394221f"), 0, 50 },
                    { new Guid("6b58ba80-86df-4671-a17b-17a65dd4f7b2"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2367), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("217cc99e-4586-4fc2-9e87-66ba1061426f"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("6dd2eb52-3aff-4208-ae75-fe7186aafb16"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2305), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("b6f2feb6-8373-43c0-8db3-f5d6e664062c"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("702c91f1-6fd7-4ed8-b8fd-ec4d9b49005f"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2319), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("79369e3d-570a-4f1d-8722-9a2daa52ae46"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2313), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("81434550-b237-420d-a407-ea8db1301136"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2328), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "Id", "ColorId", "CreatedDate", "MaterialId", "OriginalPrice", "Price", "ProductId", "SizeId", "Status", "Stock" },
                values: new object[,]
                {
                    { new Guid("84cf39b1-d8d1-4538-9467-62b7dc41aaae"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2303), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("42eea6d0-d14a-4d9e-850f-5f340311bde3"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("85b4ff3f-1fa0-4597-9177-feece10892b7"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2317), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("90508eca-a616-4b65-9114-aacb1a23ef6f"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2301), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("42eea6d0-d14a-4d9e-850f-5f340311bde3"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("9610c212-5a16-4a70-8703-6bc7f1224be0"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2283), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 249000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("aa66fbee-a9d6-4bb5-8ed8-b329d394221f"), 0, 50 },
                    { new Guid("9902bd0d-729a-49c9-b190-4991f5cf6ccd"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2357), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("1975818f-1d1d-4df8-8477-0afaf9687945"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("9a6ccc00-6b1c-40c5-be61-eb71323c9151"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2263), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 150000m, 199000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("9edbd50b-02a5-48d0-9acd-6394385185f2"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2336), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"), new Guid("f6a1a967-7487-463b-9d7b-09aebf15d304"), 0, 50 },
                    { new Guid("a3be12fa-6696-46b9-a270-b56860f10cc9"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2358), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("a8edbd5b-dd2b-42d1-84b4-013e867d0f88"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("a6188eb6-6679-4b1c-917b-083878b3182e"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2347), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("3241c204-eb4a-4f41-a214-c77a74577db4"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("a648500a-ee4e-4fa6-ac8d-272670b4fece"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2320), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("a6767d22-3ea0-4a00-ad31-9dce1d67184e"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2285), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 269000m, new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("a7e56ca4-bf8e-4cf0-9d07-e95a275b869a"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2334), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("acb2aea8-07e1-4b38-96bb-5be8ed7ad5cd"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2326), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("af828b6f-1e3a-4668-af79-925e039fed0a"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2323), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("b5978ede-0f5d-4732-9c27-0097c9f27029"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2306), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("b6f2feb6-8373-43c0-8db3-f5d6e664062c"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("b799297f-d21e-4280-8df9-a3c6788c806e"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2279), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 150000m, 219000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("c078a922-9d8e-44d3-a0d4-02aff2ff02a0"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2294), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("c455cb74-947f-43f5-8396-52701206a747"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2324), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("c4ad16dd-57c2-4d70-8c40-a156cf208314"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2330), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("c7d3c45e-7c7e-431d-967c-a7346c06e123"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2354), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("1975818f-1d1d-4df8-8477-0afaf9687945"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("cbbdbb20-a323-440c-b4ef-7494704a0ebe"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2316), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("cc1a10ec-0b47-4308-8876-6c7523da99b3"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2340), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("cf3450f2-6b36-4797-a249-8285fd6069de"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2333), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("d34df8f4-7796-4743-8769-04a005d0eefd"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2329), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("dfab5d49-4286-40f7-befc-89dd54baa9c5"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2356), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("1975818f-1d1d-4df8-8477-0afaf9687945"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("e3acb616-dd2c-44ee-93f0-754c68503b38"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2280), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 229000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("e8d5e782-9027-4d0b-886f-43b9b1821647"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2321), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("e9627388-f53b-4600-9db6-30b5c6061a2b"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2308), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("b6f2feb6-8373-43c0-8db3-f5d6e664062c"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("eac0583e-715f-4e1a-a793-42ac142256fb"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2346), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("b208c071-8450-4999-9cc4-1bf37d7f9294"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("ed8c924a-e97e-4063-986d-27e1c76d0db6"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2297), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2282), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 239000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("f6a1a967-7487-463b-9d7b-09aebf15d304"), 0, 50 },
                    { new Guid("f5ef450e-5ee9-4525-abde-c404039cd7bc"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2350), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("3241c204-eb4a-4f41-a214-c77a74577db4"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 }
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
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256") }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc") },
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("a8edbd5b-dd2b-42d1-84b4-013e867d0f88") },
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5") },
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("b208c071-8450-4999-9cc4-1bf37d7f9294") },
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("b6f2feb6-8373-43c0-8db3-f5d6e664062c") }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductDetailId", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("25610f9a-ecf7-4202-a6ab-dcbe86c20bb8"), new Guid("af828b6f-1e3a-4668-af79-925e039fed0a"), 289000m, 4 },
                    { new Guid("25610f9a-ecf7-4202-a6ab-dcbe86c20bb8"), new Guid("b5978ede-0f5d-4732-9c27-0097c9f27029"), 289000m, 4 },
                    { new Guid("41e0267d-90e0-4429-b3c6-c1eb650bc680"), new Guid("0b3f534f-6dad-4543-804d-a6fce2a4674c"), 289000m, 4 },
                    { new Guid("41e0267d-90e0-4429-b3c6-c1eb650bc680"), new Guid("280ab97b-e8f8-461c-83b1-178161bdd11d"), 289000m, 4 },
                    { new Guid("41e0267d-90e0-4429-b3c6-c1eb650bc680"), new Guid("e9627388-f53b-4600-9db6-30b5c6061a2b"), 289000m, 4 },
                    { new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"), new Guid("b799297f-d21e-4280-8df9-a3c6788c806e"), 219000m, 5 },
                    { new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"), new Guid("e3acb616-dd2c-44ee-93f0-754c68503b38"), 229000m, 5 },
                    { new Guid("5f312584-d47e-4e8b-bc9c-584657befbf6"), new Guid("111f1d26-a7e8-429c-a7b9-21427cf975fc"), 289000m, 4 },
                    { new Guid("5f312584-d47e-4e8b-bc9c-584657befbf6"), new Guid("1faa9efb-c6c0-4e5e-888c-0010dede6497"), 289000m, 4 },
                    { new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab"), new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45"), 209000m, 5 },
                    { new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab"), new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"), 239000m, 5 },
                    { new Guid("8fd4f3f5-4f1a-4f23-a2b0-1dbf8e9d7a9c"), new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"), 239000m, 5 },
                    { new Guid("a60b3fd4-40a0-4f4e-8f5b-6e5a9a3d63e6"), new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"), 239000m, 5 },
                    { new Guid("b7683f6d-2bf4-4edb-971f-1b4d017244fd"), new Guid("524b7e19-cc28-4a7b-aa53-bb6de7b0e1ea"), 289000m, 4 },
                    { new Guid("b7683f6d-2bf4-4edb-971f-1b4d017244fd"), new Guid("a648500a-ee4e-4fa6-ac8d-272670b4fece"), 289000m, 4 },
                    { new Guid("c9e9de6f-0e6f-4b3e-9f6c-3f8f3a0e6a1d"), new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"), 239000m, 5 },
                    { new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"), new Guid("18cd05cb-f995-4b13-9fa4-a9e1f1c43862"), 289000m, 4 },
                    { new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"), new Guid("2fecd681-ba9f-4ef9-8ce4-8315328dce20"), 289000m, 4 },
                    { new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"), new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45"), 209000m, 5 },
                    { new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"), new Guid("9a6ccc00-6b1c-40c5-be61-eb71323c9151"), 199000m, 5 },
                    { new Guid("fba2e1cb-2d69-40b1-acdf-46c3ea2f8840"), new Guid("a7e56ca4-bf8e-4cf0-9d07-e95a275b869a"), 289000m, 4 }
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
