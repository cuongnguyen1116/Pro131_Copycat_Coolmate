using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shop.Data.Migrations
{
    public partial class add_exampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("d8eb1629-a276-4667-8da2-0926fc66de0c"), new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844") });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1090dcdd-b383-417b-9523-d73f0373fbb0"),
                column: "ConcurrencyStamp",
                value: "fa8293e7-798a-488b-9595-30e5d01f3eba");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4a1c9012-a602-46a9-8eba-05e85149fd81"),
                column: "ConcurrencyStamp",
                value: "81038b6a-abc3-4dba-8a78-3962ba783f40");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"),
                column: "ConcurrencyStamp",
                value: "d0f51bfa-4ab6-4d4d-9950-1613ce764e28");

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("513b6e27-9ec8-4339-8cd2-ce42a2c6a01e") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("598ded7d-1f81-43a9-861c-21a026294eb1") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("66c7e036-0cbd-4350-9afe-5e1e0c959bcf") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("7ee56101-aff6-4d71-8112-e118ada30353") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("873c3aed-38c2-41ef-b03a-4e142dae542c") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("8db920d7-5115-432c-a9ad-3039dfed3244") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("a72558d6-0e2f-463f-9ce9-c7a232b7eb89") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("c7378d1c-47f6-4cc5-b800-281023b6699a") }
                });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "6802bcc0-195a-4d31-85b8-479ea3e3c71f", "beautysmithlady159", "AQAAAAEAACcQAAAAEBsGDBOIOJW7JG0AizamlYh+If1LeK8ZdP7ySBbiQQFZEd9T6wAAqbXQfRiG5x8zuQ==", "beautysmithlady159" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b294e1f-c3f7-4f71-9be6-11c614fbdce5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3eab8127-8b34-4c4a-b75f-fdf292fcd2ae", "AQAAAAEAACcQAAAAEGDiielGlSjy28KtSeZiqezdq3iRSWUjlNZDclIZon9RRBuEk3cBo9I3T6uUuGrvZQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7eea4cfb-c143-403e-8d95-683ed52b176e", "AQAAAAEAACcQAAAAEPlHnaSkbW1M/cC5N3P3VtFFCFt6UOO4HilJS0dkHv7pLF+UyTuC3lJMnrIVhENAHA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "da16c43a-8017-46be-9fef-31ce30e74360", "doesnot90", "AQAAAAEAACcQAAAAEEMVtIMqO13xjpWjdsr2f4UypX95PjNLT/x9pigJ/kavrYB+eIUd3NRZfgpWM+TB4g==", "doesnot90" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "9ba07dd0-0f04-42d5-88d9-485e1bad6f3b", "janenotlost123", "AQAAAAEAACcQAAAAEKnAzjHPJFRfinc9jF21zOMOoE13CVMExeKu6W19P/13IE3MibNo64q3loJ+XNssAA==", "janenotlost123" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c2ec6dd4-8170-4b6d-acf4-33d52a128789"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "479b3aaf-e952-4889-8614-aa104f6e8e17", "AQAAAAEAACcQAAAAEDVN/Y5nJIsyWme0op4P1B5XR2P//GE55hmQK8B8qhx77/yLs5TG0n7D+d36gnCiow==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5"),
                columns: new[] { "ConcurrencyStamp", "DoB", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "ef29f3dc-7633-4525-b6e8-ea6f8b632796", new DateTime(1998, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "bobthebuilder98", "AQAAAAEAACcQAAAAEAAO+MWHg3bEEctIHJaBQR1XvFQ40sc2D8cIxXW1v6zk20nOfvN2U3DEu27SC1IoYg==", "bobthebuilder98" });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("513b6e27-9ec8-4339-8cd2-ce42a2c6a01e"), 0, "8cc451d1-2370-4fac-bb34-bf618cca39c0", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "taylorswift109@gmail.com", true, "Thúy", "Loan", false, null, "TAYLORSWIFT109@gmail.com", "taylorswift109", "AQAAAAEAACcQAAAAEJX5FDrHmXrI5dhBIzh75cvzFtiD7U4fySk6pQj6l5rRjw34NQbNVSOvzlWaEjcDMQ==", null, false, "", false, "taylorswift109" },
                    { new Guid("598ded7d-1f81-43a9-861c-21a026294eb1"), 0, "1b6a99ed-0ae0-4b41-900c-2b78e8017744", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "miley987@gmail.com", true, "Robyn", "Fenty", false, null, "MILEY987@gmail.com", "miley987", "AQAAAAEAACcQAAAAEDXu7YAUOqmWijt74mSHwCsaT9AINbgO7/58sfc4c54/ocltJ0lt743HXdmTOXEGCw==", null, false, "", false, "miley987" },
                    { new Guid("66c7e036-0cbd-4350-9afe-5e1e0c959bcf"), 0, "bb3435e5-9021-4a75-9add-4777e6095646", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "jennifer.smith@example.com", true, "Billie", "Jean", false, null, "JENNIFER.SMITH@EXAMPLE.COM", "notmylover199", "AQAAAAEAACcQAAAAEA8qs/O8gY8nU24rXgTlGuXs39+ZdpaxmnjIu2eeMjhaey40i1tQeLzSyDezC0eOzg==", null, false, "", false, "notmylover199" },
                    { new Guid("7ee56101-aff6-4d71-8112-e118ada30353"), 0, "db2497f2-9162-4995-bb5e-ef643f6da167", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "michealthoangmong@gmail.com", true, "Michael", "Jackson", false, null, "MICHAELTHOANGMONG1@GMAIL.COM", "michaelthoangmong1", "AQAAAAEAACcQAAAAEKG84w8HHZVA2azZbRL1Kn44pggS+eFzIWBtAG5EylOoMHDpWJuQSHkO1q9byuvs4w==", null, false, "", false, "michaelthoangmong1" },
                    { new Guid("873c3aed-38c2-41ef-b03a-4e142dae542c"), 0, "2cc90c8e-bfdf-4271-9868-0c66772c2433", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "camila119@gmail.com", true, "Karla Camila", " Cabello Estrabao", false, null, "CAMILA119@gmail.com", "camila119", "AQAAAAEAACcQAAAAEPxc7AGxS8OMU4cyLvSCAbiP0Pu6of4agWm5BMPHiJmuSp9mAR/Ip4zq1lDcInS3JQ==", null, false, "", false, "camila119" },
                    { new Guid("8db920d7-5115-432c-a9ad-3039dfed3244"), 0, "90a1cbb5-b732-43f0-b778-8f45959c5892", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "grande145@gmail.com", true, "Ariana", "Grande", false, null, "GRANDE145@gmail.com", "grande145", "AQAAAAEAACcQAAAAELXKrEy70/Ysz5DBgO0/mYEsmPX/SUUKWTchSDaKDTM+U/GZGo9BHIafRMLPxVoVKQ==", null, false, "", false, "grande145" },
                    { new Guid("a72558d6-0e2f-463f-9ce9-c7a232b7eb89"), 0, "bf8f0f93-13d6-4ad8-a2e0-242146a1260c", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "drake123@gmail.com", true, "Aubrey", "Drake Graham", false, null, "DRAKE123@gmail.com", "drake123", "AQAAAAEAACcQAAAAEGVw6J8j90DB3CD5e6/yakayRmvC4DU4TwHlvESKLNhiXUSlFdOkLlM3bsWn7Z6hog==", null, false, "", false, "drake123" },
                    { new Guid("c7378d1c-47f6-4cc5-b800-281023b6699a"), 0, "4ce74699-50d6-46e6-8cbb-973c732cd94e", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "michealthoangmong@gmail.com", true, "Michael", "Jackson", false, null, "MICHAELTHOANGMONG1@GMAIL.COM", "michaelthoangmong1", "AQAAAAEAACcQAAAAEKCGRHkLvzERqitVBoSSKlj9QTOiI9lzMLarHLle6ikb57TaZXQo0to8xbN1ddOCMQ==", null, false, "", false, "michaelthoangmong1" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"),
                columns: new[] { "ConfirmedDate", "CreatedDate", "OrderStatus" },
                values: new object[] { new DateTime(2023, 7, 8, 8, 52, 24, 51, DateTimeKind.Local).AddTicks(783), new DateTime(2023, 7, 8, 8, 52, 24, 51, DateTimeKind.Local).AddTicks(783), 0 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab"),
                columns: new[] { "ConfirmedDate", "CreatedDate", "OrderStatus" },
                values: new object[] { null, new DateTime(2023, 7, 8, 8, 52, 24, 51, DateTimeKind.Local).AddTicks(783), 0 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8fd4f3f5-4f1a-4f23-a2b0-1dbf8e9d7a9c"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 8, 52, 24, 51, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 8, 52, 24, 51, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("0976ba79-d822-408a-86cb-e05045db09ed"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("18cd05cb-f995-4b13-9fa4-a9e1f1c43862"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("28c12878-b191-4d42-974a-7b823de70a06"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("423f83df-dc6c-4b41-aa09-2fe30e841aa6"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("6a008d16-196e-40fe-ada5-2acf339fbede"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9610c212-5a16-4a70-8703-6bc7f1224be0"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9a6ccc00-6b1c-40c5-be61-eb71323c9151"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a6767d22-3ea0-4a00-ad31-9dce1d67184e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("b799297f-d21e-4280-8df9-a3c6788c806e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("e3acb616-dd2c-44ee-93f0-754c68503b38"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"),
                column: "Name",
                value: "Summer Coolwaves");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"), "Sản phẩm trong Bộ sưu tập Summer\r\nChất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nHình in PET bền bỉ, không lo bong tróc, thoải mái giặt máy\r\nTự hào sản xuất tại Việt Nam", "Summer Coolwaves Graphic - Cây dừa" },
                    { new Guid("1975818f-1d1d-4df8-8477-0afaf9687945"), "Sản phẩm Care & Share hợp tác với cầu thủ nữ ĐTQG Việt Nam Huỳnh Như\r\n10% Doanh thu từ mỗi sản phẩm bán ra sẽ được quyên góp vào Quỹ Care & Share\r\nChất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nTự hào sản xuất tại Việt Nam", "Care & Share The Moments - Bản lĩnh" },
                    { new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8"), "Chất liệu: 95% Cotton Compact - 5% Spandex\r\nPhù hợp với: mặc ở nhà, đi làm, đi chơi\r\nKiểu dáng: Regular Fit dáng suông\r\nTự hào sản xuất tại Việt Nam Xem nhà máy >\r\nNgười mẫu: 184 cm, 73 kg, mặc size 2XL", "Compact phiên bản Premium" },
                    { new Guid("217cc99e-4586-4fc2-9e87-66ba1061426f"), "10% Doanh thu từ mỗi sản phẩm sẽ được quyên góp vào Quỹ Care & Share\r\nChất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nTự hào sản xuất tại Việt Nam", "Care &Share Tuổi thơ dữ dội - Bấm chuông" },
                    { new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474"), "Đây là sản phẩm thuộc Clean Vietnam Collection\r\nChất liệu: 80% Cotton - 20% Recycle Polyester,co giãn 4 chiều\r\nKiểu dáng: regularfit dáng suông\r\nPhù hợp với: đi chơi, đi làm, ở nhà\r\nTự hào sản xuất tại Việt Nam\r\nMục tiêu dự án đến 2023 sẽ tái chế được 500.000 chai nhựa thành sợi và sản xuất thành sản phẩm tốt về công năng", "Clean Vietnam" },
                    { new Guid("3241c204-eb4a-4f41-a214-c77a74577db4"), "10% Doanh thu từ mỗi sản phẩm sẽ được quyên góp vào Quỹ Care & Share\r\nChất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nTự hào sản xuất tại Việt Nam", "Care &Share Tuổi thơ dữ dội - Tắm mưa" },
                    { new Guid("42eea6d0-d14a-4d9e-850f-5f340311bde3"), "Chất liệu: 97% Polyester Quick-Dry + 3% Spandex. Xử lý hoàn thiện vải: Quick-Dry + Wicking + Stretch. Công nghệ Chafe-Free may Seamless hạn chế tối đa ma sát trong quá trình vận động. Định lượng vải 110gsm siêu nhẹ. Được nghiên cứu và phát triển phù hợp dựa trên các Runner chuyên nghiệp. Tự hào sản xuất tại Việt Nam", "Essential Fast & Free Run" },
                    { new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256"), "Chất liệu: 95% Polyester Quick-Dry + 5% Spandex. Xử lý hoàn thiện vải: Quick-Dry + Wicking + Stretch. Công nghệ Chafe-Free hạn chế tối đa ma sát trong quá trình vận động từ các đường may may Seamless. Định lượng vải 100gsm siêu nhẹ. Được phát triển và kiểm nghiệm bởi các VĐV Marathon. Tự hào sản xuất tại Việt Nam", "Quick Dry in Graphic R1" },
                    { new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc"), "10% Doanh thu từ mỗi sản phẩm sẽ được quyên góp vào Quỹ Care & Share\r\nChất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nTự hào sản xuất tại Việt Nam", "Care &Share Tuổi thơ dữ dội - Bắn bi" },
                    { new Guid("a8edbd5b-dd2b-42d1-84b4-013e867d0f88"), "Chất liệu: 95% Polyester Quick-Dry + 5% Spandex\r\nXử lý hoàn thiện vải: Quick-Dry + Wicking + Stretch\r\nCông nghệ Chafe-Free hạn chế tối đa ma sát trong quá trình vận động từ các đường may may Seamless\r\nĐịnh lượng vải 100gsm siêu nhẹ\r\nĐược phát triển và kiểm nghiệm bởi các VĐV Marathon\r\nTự hào sản xuất tại Việt Nam", "Advanced Fast & Free Run" },
                    { new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5"), "Sản phẩm trong Bộ sưu tập Summer\r\nChất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nHình in PET bền bỉ, không lo bong tróc, thoải mái giặt máy\r\nTự hào sản xuất tại Việt Nam", "Summer Coolwaves Graphic" },
                    { new Guid("b208c071-8450-4999-9cc4-1bf37d7f9294"), "10% Doanh thu từ mỗi sản phẩm sẽ được quyên góp vào Quỹ Care & Share\r\nChất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nTự hào sản xuất tại Việt Nam", "Care &Share Tuổi thơ dữ dội - Pattern tranh" },
                    { new Guid("b6f2feb6-8373-43c0-8db3-f5d6e664062c"), "Chất liệu: 100% Cotton mềm mại\r\nĐịnh lượng vải: 200gsm, dày dặn\r\nDáng áo vừa vặn, phù hợp với đi chơi, đi làm và ở nhà\r\nTự hào sản xuất tại Việt Nam", "Coolmate Basics 200gsm" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a60b3fd4-40a0-4f4e-8f5b-6e5a9a3d63e6"),
                columns: new[] { "CompletedDate", "CreatedDate", "OrderStatus", "PaidDate", "ShipDate", "UserId" },
                values: new object[] { null, new DateTime(2023, 7, 8, 8, 52, 24, 51, DateTimeKind.Local).AddTicks(783), 0, null, null, new Guid("66c7e036-0cbd-4350-9afe-5e1e0c959bcf") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c9e9de6f-0e6f-4b3e-9f6c-3f8f3a0e6a1d"),
                columns: new[] { "CompletedDate", "CreatedDate", "OrderStatus", "PaidDate", "ShipDate", "UserId" },
                values: new object[] { null, new DateTime(2023, 7, 8, 8, 52, 24, 51, DateTimeKind.Local).AddTicks(783), 0, null, null, new Guid("7ee56101-aff6-4d71-8112-e118ada30353") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"),
                columns: new[] { "CompletedDate", "CreatedDate", "OrderCode", "OrderStatus", "PaidDate", "ShipDate", "UserId" },
                values: new object[] { null, new DateTime(2023, 7, 8, 8, 52, 24, 51, DateTimeKind.Local).AddTicks(783), "230707Tu7QJBJH2oY0Hd", 0, null, null, new Guid("c7378d1c-47f6-4cc5-b800-281023b6699a") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompletedDate", "ConfirmedDate", "CreatedDate", "OrderCode", "PaidDate", "ShipAddress", "ShipDate", "ShipName", "ShipPhoneNumber", "Total", "UserId" },
                values: new object[,]
                {
                    { new Guid("25610f9a-ecf7-4202-a6ab-dcbe86c20bb8"), null, null, new DateTime(2023, 7, 8, 8, 52, 24, 51, DateTimeKind.Local).AddTicks(783), "230707hIlOvA0CTr0i7f", null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 232000m, new Guid("873c3aed-38c2-41ef-b03a-4e142dae542c") },
                    { new Guid("41e0267d-90e0-4429-b3c6-c1eb650bc680"), null, null, new DateTime(2023, 7, 8, 8, 52, 24, 51, DateTimeKind.Local).AddTicks(783), "230707LZwAHJX5VmjwWx", null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 232000m, new Guid("a72558d6-0e2f-463f-9ce9-c7a232b7eb89") },
                    { new Guid("5f312584-d47e-4e8b-bc9c-584657befbf6"), null, null, new DateTime(2023, 7, 8, 8, 52, 24, 51, DateTimeKind.Local).AddTicks(783), "230707FYufCS6av9hB9Q", null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 232000m, new Guid("598ded7d-1f81-43a9-861c-21a026294eb1") },
                    { new Guid("b7683f6d-2bf4-4edb-971f-1b4d017244fd"), null, null, new DateTime(2023, 7, 8, 8, 52, 24, 51, DateTimeKind.Local).AddTicks(783), "230707yM2UVPAfwmGRxX", null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 232000m, new Guid("8db920d7-5115-432c-a9ad-3039dfed3244") },
                    { new Guid("fba2e1cb-2d69-40b1-acdf-46c3ea2f8840"), null, null, new DateTime(2023, 7, 8, 8, 52, 24, 51, DateTimeKind.Local).AddTicks(783), "230703i5B6qeJ2IbxBVu", null, "1212 Cedar Blvd.", null, "Charlie", "0987654321", 232000m, new Guid("513b6e27-9ec8-4339-8cd2-ce42a2c6a01e") }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "Id", "ColorId", "CreatedDate", "MaterialId", "OriginalPrice", "Price", "ProductId", "SizeId", "Status", "Stock" },
                values: new object[,]
                {
                    { new Guid("0b3f534f-6dad-4543-804d-a6fce2a4674c"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7288), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("b6f2feb6-8373-43c0-8db3-f5d6e664062c"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("0f673bb8-f743-42f8-ba9e-50c6e7bd2b9b"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7360), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("217cc99e-4586-4fc2-9e87-66ba1061426f"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("111f1d26-a7e8-429c-a7b9-21427cf975fc"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7362), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("217cc99e-4586-4fc2-9e87-66ba1061426f"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("17ddc867-2a86-4a23-9ee0-a60ae4d238dc"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7335), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("b208c071-8450-4999-9cc4-1bf37d7f9294"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("180b5870-f77b-4ae6-b4ff-231b27a9bc51"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7274), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("186dd464-1acc-46c0-98e5-80724ef9a7a0"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7349), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("3241c204-eb4a-4f41-a214-c77a74577db4"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("1ed004a7-ac94-4c57-b871-564543bc8b38"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7318), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("1faa9efb-c6c0-4e5e-888c-0010dede6497"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7365), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("217cc99e-4586-4fc2-9e87-66ba1061426f"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("25f1829c-ad64-4e8f-9c8b-e8bf53592304"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7333), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("280ab97b-e8f8-461c-83b1-178161bdd11d"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7358), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("a8edbd5b-dd2b-42d1-84b4-013e867d0f88"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("2fecd681-ba9f-4ef9-8ce4-8315328dce20"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7332), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("37cb83db-2428-4fbb-a8da-fc4554f71729"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7350), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("1975818f-1d1d-4df8-8477-0afaf9687945"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("3a1f9be1-c963-4789-8cbc-a935f94e6ef7"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7329), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("42fd8c77-f1ea-4827-a8ba-cfa758d9525e"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7341), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("3241c204-eb4a-4f41-a214-c77a74577db4"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("524b7e19-cc28-4a7b-aa53-bb6de7b0e1ea"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7279), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("53f989a8-c813-4667-8a5b-d57b016329a2"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7295), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("59d46d45-02e7-46a6-baca-426683257859"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7282), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("42eea6d0-d14a-4d9e-850f-5f340311bde3"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("62b387f6-b535-4dfe-a310-76899ee9dec1"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7283), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("42eea6d0-d14a-4d9e-850f-5f340311bde3"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("64a31f58-96a0-40d4-a3b5-cebb464f9708"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7328), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"), new Guid("aa66fbee-a9d6-4bb5-8ed8-b329d394221f"), 0, 50 },
                    { new Guid("6b58ba80-86df-4671-a17b-17a65dd4f7b2"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7363), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("217cc99e-4586-4fc2-9e87-66ba1061426f"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("6dd2eb52-3aff-4208-ae75-fe7186aafb16"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7290), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("b6f2feb6-8373-43c0-8db3-f5d6e664062c"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("702c91f1-6fd7-4ed8-b8fd-ec4d9b49005f"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7300), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("79369e3d-570a-4f1d-8722-9a2daa52ae46"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7294), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("81434550-b237-420d-a407-ea8db1301136"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7310), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("84cf39b1-d8d1-4538-9467-62b7dc41aaae"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7287), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("42eea6d0-d14a-4d9e-850f-5f340311bde3"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("85b4ff3f-1fa0-4597-9177-feece10892b7"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7299), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("90508eca-a616-4b65-9114-aacb1a23ef6f"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7285), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("42eea6d0-d14a-4d9e-850f-5f340311bde3"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("9902bd0d-729a-49c9-b190-4991f5cf6ccd"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7354), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("1975818f-1d1d-4df8-8477-0afaf9687945"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("9edbd50b-02a5-48d0-9acd-6394385185f2"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7326), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"), new Guid("f6a1a967-7487-463b-9d7b-09aebf15d304"), 0, 50 },
                    { new Guid("a3be12fa-6696-46b9-a270-b56860f10cc9"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7357), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("a8edbd5b-dd2b-42d1-84b4-013e867d0f88"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("a6188eb6-6679-4b1c-917b-083878b3182e"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7338), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("3241c204-eb4a-4f41-a214-c77a74577db4"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("a648500a-ee4e-4fa6-ac8d-272670b4fece"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7302), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("a7e56ca4-bf8e-4cf0-9d07-e95a275b869a"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7324), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("acb2aea8-07e1-4b38-96bb-5be8ed7ad5cd"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7309), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "Id", "ColorId", "CreatedDate", "MaterialId", "OriginalPrice", "Price", "ProductId", "SizeId", "Status", "Stock" },
                values: new object[,]
                {
                    { new Guid("af828b6f-1e3a-4668-af79-925e039fed0a"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7305), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("b5978ede-0f5d-4732-9c27-0097c9f27029"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7291), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("b6f2feb6-8373-43c0-8db3-f5d6e664062c"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("c078a922-9d8e-44d3-a0d4-02aff2ff02a0"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7275), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("c455cb74-947f-43f5-8396-52701206a747"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7307), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("c4ad16dd-57c2-4d70-8c40-a156cf208314"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7313), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("c7d3c45e-7c7e-431d-967c-a7346c06e123"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7351), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("1975818f-1d1d-4df8-8477-0afaf9687945"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("cbbdbb20-a323-440c-b4ef-7494704a0ebe"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7296), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("cc1a10ec-0b47-4308-8876-6c7523da99b3"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7331), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("cf3450f2-6b36-4797-a249-8285fd6069de"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7322), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("d34df8f4-7796-4743-8769-04a005d0eefd"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7312), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("dfab5d49-4286-40f7-befc-89dd54baa9c5"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7353), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("1975818f-1d1d-4df8-8477-0afaf9687945"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("e8d5e782-9027-4d0b-886f-43b9b1821647"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7304), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("e9627388-f53b-4600-9db6-30b5c6061a2b"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7292), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("b6f2feb6-8373-43c0-8db3-f5d6e664062c"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("eac0583e-715f-4e1a-a793-42ac142256fb"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7336), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("b208c071-8450-4999-9cc4-1bf37d7f9294"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("ed8c924a-e97e-4063-986d-27e1c76d0db6"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7281), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("f5ef450e-5ee9-4525-abde-c404039cd7bc"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 8, 8, 52, 24, 29, DateTimeKind.Local).AddTicks(7347), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 309000m, new Guid("3241c204-eb4a-4f41-a214-c77a74577db4"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d") },
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("1975818f-1d1d-4df8-8477-0afaf9687945") },
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8") },
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("217cc99e-4586-4fc2-9e87-66ba1061426f") },
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474") },
                    { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("3241c204-eb4a-4f41-a214-c77a74577db4") },
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
                columns: new[] { "OrderId", "ProductDetailId", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("25610f9a-ecf7-4202-a6ab-dcbe86c20bb8"), new Guid("af828b6f-1e3a-4668-af79-925e039fed0a"), 289000m, 4 },
                    { new Guid("25610f9a-ecf7-4202-a6ab-dcbe86c20bb8"), new Guid("b5978ede-0f5d-4732-9c27-0097c9f27029"), 289000m, 4 },
                    { new Guid("41e0267d-90e0-4429-b3c6-c1eb650bc680"), new Guid("0b3f534f-6dad-4543-804d-a6fce2a4674c"), 289000m, 4 },
                    { new Guid("41e0267d-90e0-4429-b3c6-c1eb650bc680"), new Guid("280ab97b-e8f8-461c-83b1-178161bdd11d"), 289000m, 4 },
                    { new Guid("41e0267d-90e0-4429-b3c6-c1eb650bc680"), new Guid("e9627388-f53b-4600-9db6-30b5c6061a2b"), 289000m, 4 },
                    { new Guid("5f312584-d47e-4e8b-bc9c-584657befbf6"), new Guid("111f1d26-a7e8-429c-a7b9-21427cf975fc"), 289000m, 4 },
                    { new Guid("5f312584-d47e-4e8b-bc9c-584657befbf6"), new Guid("1faa9efb-c6c0-4e5e-888c-0010dede6497"), 289000m, 4 },
                    { new Guid("b7683f6d-2bf4-4edb-971f-1b4d017244fd"), new Guid("524b7e19-cc28-4a7b-aa53-bb6de7b0e1ea"), 289000m, 4 },
                    { new Guid("b7683f6d-2bf4-4edb-971f-1b4d017244fd"), new Guid("a648500a-ee4e-4fa6-ac8d-272670b4fece"), 289000m, 4 },
                    { new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"), new Guid("2fecd681-ba9f-4ef9-8ce4-8315328dce20"), 289000m, 4 },
                    { new Guid("fba2e1cb-2d69-40b1-acdf-46c3ea2f8840"), new Guid("a7e56ca4-bf8e-4cf0-9d07-e95a275b869a"), 289000m, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("513b6e27-9ec8-4339-8cd2-ce42a2c6a01e") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("598ded7d-1f81-43a9-861c-21a026294eb1") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("66c7e036-0cbd-4350-9afe-5e1e0c959bcf") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("7ee56101-aff6-4d71-8112-e118ada30353") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("873c3aed-38c2-41ef-b03a-4e142dae542c") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("8db920d7-5115-432c-a9ad-3039dfed3244") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("a72558d6-0e2f-463f-9ce9-c7a232b7eb89") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("c7378d1c-47f6-4cc5-b800-281023b6699a") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("66c7e036-0cbd-4350-9afe-5e1e0c959bcf"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ee56101-aff6-4d71-8112-e118ada30353"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c7378d1c-47f6-4cc5-b800-281023b6699a"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("25610f9a-ecf7-4202-a6ab-dcbe86c20bb8"), new Guid("af828b6f-1e3a-4668-af79-925e039fed0a") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("25610f9a-ecf7-4202-a6ab-dcbe86c20bb8"), new Guid("b5978ede-0f5d-4732-9c27-0097c9f27029") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("41e0267d-90e0-4429-b3c6-c1eb650bc680"), new Guid("0b3f534f-6dad-4543-804d-a6fce2a4674c") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("41e0267d-90e0-4429-b3c6-c1eb650bc680"), new Guid("280ab97b-e8f8-461c-83b1-178161bdd11d") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("41e0267d-90e0-4429-b3c6-c1eb650bc680"), new Guid("e9627388-f53b-4600-9db6-30b5c6061a2b") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("5f312584-d47e-4e8b-bc9c-584657befbf6"), new Guid("111f1d26-a7e8-429c-a7b9-21427cf975fc") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("5f312584-d47e-4e8b-bc9c-584657befbf6"), new Guid("1faa9efb-c6c0-4e5e-888c-0010dede6497") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("b7683f6d-2bf4-4edb-971f-1b4d017244fd"), new Guid("524b7e19-cc28-4a7b-aa53-bb6de7b0e1ea") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("b7683f6d-2bf4-4edb-971f-1b4d017244fd"), new Guid("a648500a-ee4e-4fa6-ac8d-272670b4fece") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"), new Guid("2fecd681-ba9f-4ef9-8ce4-8315328dce20") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("fba2e1cb-2d69-40b1-acdf-46c3ea2f8840"), new Guid("a7e56ca4-bf8e-4cf0-9d07-e95a275b869a") });

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("0f673bb8-f743-42f8-ba9e-50c6e7bd2b9b"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("17ddc867-2a86-4a23-9ee0-a60ae4d238dc"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("180b5870-f77b-4ae6-b4ff-231b27a9bc51"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("186dd464-1acc-46c0-98e5-80724ef9a7a0"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("1ed004a7-ac94-4c57-b871-564543bc8b38"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("25f1829c-ad64-4e8f-9c8b-e8bf53592304"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("37cb83db-2428-4fbb-a8da-fc4554f71729"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("3a1f9be1-c963-4789-8cbc-a935f94e6ef7"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("42fd8c77-f1ea-4827-a8ba-cfa758d9525e"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("53f989a8-c813-4667-8a5b-d57b016329a2"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("59d46d45-02e7-46a6-baca-426683257859"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("62b387f6-b535-4dfe-a310-76899ee9dec1"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("64a31f58-96a0-40d4-a3b5-cebb464f9708"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("6b58ba80-86df-4671-a17b-17a65dd4f7b2"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("6dd2eb52-3aff-4208-ae75-fe7186aafb16"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("702c91f1-6fd7-4ed8-b8fd-ec4d9b49005f"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("79369e3d-570a-4f1d-8722-9a2daa52ae46"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("81434550-b237-420d-a407-ea8db1301136"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("84cf39b1-d8d1-4538-9467-62b7dc41aaae"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("85b4ff3f-1fa0-4597-9177-feece10892b7"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("90508eca-a616-4b65-9114-aacb1a23ef6f"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9902bd0d-729a-49c9-b190-4991f5cf6ccd"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9edbd50b-02a5-48d0-9acd-6394385185f2"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a3be12fa-6696-46b9-a270-b56860f10cc9"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a6188eb6-6679-4b1c-917b-083878b3182e"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("acb2aea8-07e1-4b38-96bb-5be8ed7ad5cd"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("c078a922-9d8e-44d3-a0d4-02aff2ff02a0"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("c455cb74-947f-43f5-8396-52701206a747"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("c4ad16dd-57c2-4d70-8c40-a156cf208314"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("c7d3c45e-7c7e-431d-967c-a7346c06e123"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("cbbdbb20-a323-440c-b4ef-7494704a0ebe"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("cc1a10ec-0b47-4308-8876-6c7523da99b3"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("cf3450f2-6b36-4797-a249-8285fd6069de"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("d34df8f4-7796-4743-8769-04a005d0eefd"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("dfab5d49-4286-40f7-befc-89dd54baa9c5"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("e8d5e782-9027-4d0b-886f-43b9b1821647"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("eac0583e-715f-4e1a-a793-42ac142256fb"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("ed8c924a-e97e-4063-986d-27e1c76d0db6"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("f5ef450e-5ee9-4525-abde-c404039cd7bc"));

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d") });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("1975818f-1d1d-4df8-8477-0afaf9687945") });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8") });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("217cc99e-4586-4fc2-9e87-66ba1061426f") });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474") });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("3241c204-eb4a-4f41-a214-c77a74577db4") });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844") });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("42eea6d0-d14a-4d9e-850f-5f340311bde3") });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256") });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc") });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("a8edbd5b-dd2b-42d1-84b4-013e867d0f88") });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5") });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("b208c071-8450-4999-9cc4-1bf37d7f9294") });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { new Guid("e785507b-109e-4c6e-b2f1-87a792896e3c"), new Guid("b6f2feb6-8373-43c0-8db3-f5d6e664062c") });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("25610f9a-ecf7-4202-a6ab-dcbe86c20bb8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("41e0267d-90e0-4429-b3c6-c1eb650bc680"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5f312584-d47e-4e8b-bc9c-584657befbf6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b7683f6d-2bf4-4edb-971f-1b4d017244fd"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fba2e1cb-2d69-40b1-acdf-46c3ea2f8840"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("0b3f534f-6dad-4543-804d-a6fce2a4674c"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("111f1d26-a7e8-429c-a7b9-21427cf975fc"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("1faa9efb-c6c0-4e5e-888c-0010dede6497"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("280ab97b-e8f8-461c-83b1-178161bdd11d"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("2fecd681-ba9f-4ef9-8ce4-8315328dce20"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("524b7e19-cc28-4a7b-aa53-bb6de7b0e1ea"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a648500a-ee4e-4fa6-ac8d-272670b4fece"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a7e56ca4-bf8e-4cf0-9d07-e95a275b869a"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("af828b6f-1e3a-4668-af79-925e039fed0a"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("b5978ede-0f5d-4732-9c27-0097c9f27029"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("e9627388-f53b-4600-9db6-30b5c6061a2b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1975818f-1d1d-4df8-8477-0afaf9687945"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24c78a1f-d3e6-4eaf-8629-e8b5dfb39474"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3241c204-eb4a-4f41-a214-c77a74577db4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("42eea6d0-d14a-4d9e-850f-5f340311bde3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab0b03fb-0d49-4ef5-ac72-141380d9a9a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b208c071-8450-4999-9cc4-1bf37d7f9294"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("513b6e27-9ec8-4339-8cd2-ce42a2c6a01e"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("598ded7d-1f81-43a9-861c-21a026294eb1"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("873c3aed-38c2-41ef-b03a-4e142dae542c"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8db920d7-5115-432c-a9ad-3039dfed3244"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a72558d6-0e2f-463f-9ce9-c7a232b7eb89"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f8c84e8-ef1a-4e2b-b397-8172b2fc8a3d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f5c3825-dfec-49ef-b824-d01b425a97a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("217cc99e-4586-4fc2-9e87-66ba1061426f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("470f5c7e-a94a-4f1a-930c-bda7d4f73256"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4fdf6b6b-2f7c-465b-a371-852e4b23d0dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a8edbd5b-dd2b-42d1-84b4-013e867d0f88"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6f2feb6-8373-43c0-8db3-f5d6e664062c"));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1090dcdd-b383-417b-9523-d73f0373fbb0"),
                column: "ConcurrencyStamp",
                value: "ac448337-1a0d-4376-a5f8-3948f35735ba");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4a1c9012-a602-46a9-8eba-05e85149fd81"),
                column: "ConcurrencyStamp",
                value: "c3534895-0384-4971-87c8-0e8f055a04f1");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"),
                column: "ConcurrencyStamp",
                value: "887af4b0-47ab-4f18-b71a-2699167bed5a");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "ef622e89-e1f5-4aa2-9c7f-a59f5b64e793", "JENNIFER.SMITH", "AQAAAAEAACcQAAAAEM661YfVE+Riw4xO493sigXhxEEdX2jaHKJdYziKFAZf9VGX3DGVDmwKugS3zQzOeg==", "jennifer.smith" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b294e1f-c3f7-4f71-9be6-11c614fbdce5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4bc47e31-4a5d-4811-928e-c8ecbd464bb9", "AQAAAAEAACcQAAAAEGrCYrlacjhWc62SY+NLePJtB/97N3SJcaCUqxiX0eOxAetghq+WG+bJ0BqT0E1ivQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bbc89dcd-a1d4-44f1-8125-0fb2d35ba235", "AQAAAAEAACcQAAAAEDx7NHABNZKR5nUalwjVK05qPDn6ROiqhkYgYl+TWZbEfEgqN6p2zTvdi/xMmJBPqw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "fbfeccd8-6eab-4802-9abe-3bd859843ced", "JOHN.DOE", "AQAAAAEAACcQAAAAEA2cS5ioEQyqxZ8zbgzeK7DleVfys7lpwFdHtzRkhJJAX9o/A854pgJJHm4iRZmGbA==", "john.doe" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "1c7788e4-9f4b-46c2-9127-1124b3310187", "JANE.DOE", "AQAAAAEAACcQAAAAEFKXUq4DRJuJlkYnNuuf2CRSZ+JzwJ6eRNJenxg7gZc81CtYS3QwBlgbGZNpDHwcow==", "jane.doe" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c2ec6dd4-8170-4b6d-acf4-33d52a128789"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "72bd5520-5a3d-463a-bbfc-e0cf70a8bfcc", "AQAAAAEAACcQAAAAECjzR4fN20WVT/tmss0ogg79M+3oTqj3pZ8sTUZLtcKTtDnYLwnZzdind7bTXvKF8Q==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5"),
                columns: new[] { "ConcurrencyStamp", "DoB", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "961d4d76-e514-488c-b576-ada5202d34f5", new DateTime(1985, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "BOB.SMITH", "AQAAAAEAACcQAAAAEAy6AJ6x3b1EoPpZIZNtpzW6ULQWs71JJWxGzogqKvyMevFXfbrqNWez73z8UkFygA==", "bob.smith" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"),
                columns: new[] { "ConfirmedDate", "CreatedDate", "OrderStatus" },
                values: new object[] { new DateTime(2023, 7, 4, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), new DateTime(2023, 7, 3, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab"),
                columns: new[] { "ConfirmedDate", "CreatedDate", "OrderStatus" },
                values: new object[] { new DateTime(2023, 7, 4, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), new DateTime(2023, 7, 3, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8fd4f3f5-4f1a-4f23-a2b0-1dbf8e9d7a9c"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a60b3fd4-40a0-4f4e-8f5b-6e5a9a3d63e6"),
                columns: new[] { "CompletedDate", "CreatedDate", "OrderStatus", "PaidDate", "ShipDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 8, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), new DateTime(2023, 7, 3, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), 3, new DateTime(2023, 7, 5, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), new DateTime(2023, 7, 7, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c9e9de6f-0e6f-4b3e-9f6c-3f8f3a0e6a1d"),
                columns: new[] { "CompletedDate", "CreatedDate", "OrderStatus", "PaidDate", "ShipDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 8, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), new DateTime(2023, 7, 3, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), 3, new DateTime(2023, 7, 5, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), new DateTime(2023, 7, 7, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"),
                columns: new[] { "CompletedDate", "CreatedDate", "OrderCode", "OrderStatus", "PaidDate", "ShipDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 8, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), new DateTime(2023, 7, 3, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), "230703i5B6qeJ2IbxBVu", 3, new DateTime(2023, 7, 5, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), new DateTime(2023, 7, 7, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961), new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 1, 1, 31, 4, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("0976ba79-d822-408a-86cb-e05045db09ed"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("18cd05cb-f995-4b13-9fa4-a9e1f1c43862"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("28c12878-b191-4d42-974a-7b823de70a06"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("423f83df-dc6c-4b41-aa09-2fe30e841aa6"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("6a008d16-196e-40fe-ada5-2acf339fbede"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9610c212-5a16-4a70-8703-6bc7f1224be0"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9a6ccc00-6b1c-40c5-be61-eb71323c9151"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a6767d22-3ea0-4a00-ad31-9dce1d67184e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("b799297f-d21e-4280-8df9-a3c6788c806e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("e3acb616-dd2c-44ee-93f0-754c68503b38"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 8, 1, 1, 30, 990, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { new Guid("d8eb1629-a276-4667-8da2-0926fc66de0c"), new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"),
                column: "Name",
                value: "Cotton Summer Coolwaves");
        }
    }
}
