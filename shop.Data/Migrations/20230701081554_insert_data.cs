using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shop.Data.Migrations
{
    public partial class insert_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("46894c70-1d26-4a20-993b-8d2198913585"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("0a3dcb7c-884d-4a05-a5dd-a1d5df404dff"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("231e0060-c281-4c8d-b5c2-791edfa5a680"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("aa06827c-df06-4a43-94d2-75bba02d9da6"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("fb684bf0-020f-4607-8e79-b3aa9bd005a5"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("b8457fc8-60a5-43a1-9e4a-e4855c86524f"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("c22c0a96-b3fc-4223-8cca-b9046732bb89"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductDetailId" });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1090dcdd-b383-417b-9523-d73f0373fbb0"),
                column: "ConcurrencyStamp",
                value: "36603601-2406-4d72-b5e2-c476ba351752");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4a1c9012-a602-46a9-8eba-05e85149fd81"),
                column: "ConcurrencyStamp",
                value: "3900e0b7-b5a5-4612-b868-b5c05581a3f5");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"),
                column: "ConcurrencyStamp",
                value: "7f0a81da-b31c-4357-bfa5-2c8d3b32e6d1");

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7") },
                    { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5") }
                });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b294e1f-c3f7-4f71-9be6-11c614fbdce5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a8a5315-a829-4fb2-9602-66f925df0063", "AQAAAAEAACcQAAAAEJ6Mc2AuysGjmnrx0nQvdfLgUji0dxznmxlSf8/cLu97/umlM5rYvGHP4nQ3HL7DOg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6f928d12-01e1-4fe7-8eab-7ce870876167", "AQAAAAEAACcQAAAAECvswjTd+ndXrFT3gtSGnFiiR6sjhAeO2b7zbggHmNBe+LGjSQH9STjaawUeiUDfeQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c2ec6dd4-8170-4b6d-acf4-33d52a128789"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "78eb94e2-8bb0-4869-b8ff-66b280551ce4", "AQAAAAEAACcQAAAAEAENkLoCw4/Is6Cs6S1U2vK0h1Oz3T66o9I4WapVfbokqe1hmAaE7DzqRCHa/pCVOg==" });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f"), 0, "0081d847-0880-40cf-bf48-0c174aa815ff", new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "jennifer.smith@example.com", true, "Jennifer", "Smith", false, null, "JENNIFER.SMITH@EXAMPLE.COM", "JENNIFER.SMITH", "AQAAAAEAACcQAAAAEElw5BgHM4j6oTyu+EfU81TE46o+BGimrDXEueLHwqrMq0OQoXkf59yvnRpquFVOrA==", null, false, "", false, "jennifer.smith" },
                    { new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2"), 0, "6c692863-93c8-4d07-b339-5e28408163de", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", true, "John", "Doe", false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE", "AQAAAAEAACcQAAAAEODy94hC0T95SPSw/JzfX2PkMtxAnxFAMiGUBVg6ByHHL3mwHhIppV+eiFGFfg8WBw==", null, false, "", false, "john.doe" },
                    { new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7"), 0, "bac56924-dc24-4dc1-8260-61c31a54f8f4", new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.doe@example.com", true, "Jane", "Doe", false, null, "JANE.DOE@EXAMPLE.COM", "JANE.DOE", "AQAAAAEAACcQAAAAELpFmVkyDPPHTwsNUn5LNRuUWHxF3LtYLL8olb+bz15ALL9B2PxxELrimQb8mLz5qw==", null, false, "", false, "jane.doe" },
                    { new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5"), 0, "7f233810-b224-4c7b-8cde-b496754ef509", new DateTime(1985, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob.smith@example.com", true, "Bob", "Smith", false, null, "BOB.SMITH@EXAMPLE.COM", "BOB.SMITH", "AQAAAAEAACcQAAAAEI7TUGaruyrHG9LB+QeLnV/Tt7FlsSBZ09/BYJCRPaf4dd2+grI4eZ7tbzEXdfCPfg==", null, false, "", false, "bob.smith" }
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
                table: "Orders",
                columns: new[] { "Id", "CompletedDate", "CreatedDate", "OrderStatus", "PaidDate", "ShipAddress", "ShipDate", "ShipName", "ShipPhoneNumber", "UserId" },
                values: new object[] { new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"), null, new DateTime(2023, 7, 1, 15, 15, 52, 971, DateTimeKind.Local).AddTicks(8125), 2, new DateTime(2023, 7, 1, 15, 15, 52, 971, DateTimeKind.Local).AddTicks(8125), "1010 Oak Dr.", new DateTime(2023, 7, 2, 15, 15, 52, 971, DateTimeKind.Local).AddTicks(8125), "Alice", "0123456789", new Guid("c2ec6dd4-8170-4b6d-acf4-33d52a128789") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompletedDate", "CreatedDate", "PaidDate", "ShipAddress", "ShipDate", "ShipName", "ShipPhoneNumber", "UserId" },
                values: new object[] { new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab"), null, new DateTime(2023, 7, 1, 15, 15, 52, 971, DateTimeKind.Local).AddTicks(8125), null, "1111 Pine Ln.", null, "Alice", "0123456789", new Guid("3b294e1f-c3f7-4f71-9be6-11c614fbdce5") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompletedDate", "CreatedDate", "OrderStatus", "PaidDate", "ShipAddress", "ShipDate", "ShipName", "ShipPhoneNumber", "UserId" },
                values: new object[] { new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"), new DateTime(2023, 7, 5, 15, 15, 52, 971, DateTimeKind.Local).AddTicks(8125), new DateTime(2023, 7, 1, 15, 15, 52, 971, DateTimeKind.Local).AddTicks(8125), 3, new DateTime(2023, 7, 1, 15, 15, 52, 971, DateTimeKind.Local).AddTicks(8125), "123 Main St.", new DateTime(2023, 7, 2, 15, 15, 52, 971, DateTimeKind.Local).AddTicks(8125), "Alice", "0123456789", new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompletedDate", "CreatedDate", "OrderStatus", "PaidDate", "ShipAddress", "ShipDate", "ShipName", "ShipPhoneNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("8fd4f3f5-4f1a-4f23-a2b0-1dbf8e9d7a9c"), new DateTime(2023, 7, 5, 15, 15, 52, 971, DateTimeKind.Local).AddTicks(8125), new DateTime(2023, 7, 1, 15, 15, 52, 971, DateTimeKind.Local).AddTicks(8125), 3, new DateTime(2023, 7, 1, 15, 15, 52, 971, DateTimeKind.Local).AddTicks(8125), "123 Main St.", new DateTime(2023, 7, 2, 15, 15, 52, 971, DateTimeKind.Local).AddTicks(8125), "Alice", "0123456789", new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2") },
                    { new Guid("a60b3fd4-40a0-4f4e-8f5b-6e5a9a3d63e6"), new DateTime(2023, 7, 5, 15, 15, 52, 971, DateTimeKind.Local).AddTicks(8125), new DateTime(2023, 7, 1, 15, 15, 52, 971, DateTimeKind.Local).AddTicks(8125), 3, new DateTime(2023, 7, 1, 15, 15, 52, 971, DateTimeKind.Local).AddTicks(8125), "789 Maple Ave.", new DateTime(2023, 7, 2, 15, 15, 52, 971, DateTimeKind.Local).AddTicks(8125), "0987654321", "0987654321", new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7") },
                    { new Guid("c9e9de6f-0e6f-4b3e-9f6c-3f8f3a0e6a1d"), new DateTime(2023, 7, 5, 15, 15, 52, 971, DateTimeKind.Local).AddTicks(8125), new DateTime(2023, 7, 1, 15, 15, 52, 971, DateTimeKind.Local).AddTicks(8125), 3, new DateTime(2023, 7, 1, 15, 15, 52, 971, DateTimeKind.Local).AddTicks(8125), "1212 Cedar Blvd.", new DateTime(2023, 7, 2, 15, 15, 52, 971, DateTimeKind.Local).AddTicks(8125), "Charlie", "0987654321", new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CompletedDate", "CreatedDate", "PaidDate", "ShipAddress", "ShipDate", "ShipName", "ShipPhoneNumber", "UserId" },
                values: new object[] { new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"), null, new DateTime(2023, 7, 1, 15, 15, 52, 971, DateTimeKind.Local).AddTicks(8125), null, "456 Elm St.", null, "0987654321", "0987654321", new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f") });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "Id", "ColorId", "CreatedDate", "MaterialId", "OriginalPrice", "Price", "ProductId", "SizeId", "Status", "Stock" },
                values: new object[,]
                {
                    { new Guid("0976ba79-d822-408a-86cb-e05045db09ed"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 1, 15, 15, 52, 955, DateTimeKind.Local).AddTicks(4333), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 299000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("f6a1a967-7487-463b-9d7b-09aebf15d304"), 0, 50 },
                    { new Guid("18cd05cb-f995-4b13-9fa4-a9e1f1c43862"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 1, 15, 15, 52, 955, DateTimeKind.Local).AddTicks(4331), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 299000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("28c12878-b191-4d42-974a-7b823de70a06"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 1, 15, 15, 52, 955, DateTimeKind.Local).AddTicks(4325), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 299000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 7, 1, 15, 15, 52, 955, DateTimeKind.Local).AddTicks(4312), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 150000m, 199000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("423f83df-dc6c-4b41-aa09-2fe30e841aa6"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 1, 15, 15, 52, 955, DateTimeKind.Local).AddTicks(4329), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 299000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("6a008d16-196e-40fe-ada5-2acf339fbede"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 1, 15, 15, 52, 955, DateTimeKind.Local).AddTicks(4339), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 299000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("aa66fbee-a9d6-4bb5-8ed8-b329d394221f"), 0, 50 },
                    { new Guid("9610c212-5a16-4a70-8703-6bc7f1224be0"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 7, 1, 15, 15, 52, 955, DateTimeKind.Local).AddTicks(4322), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 299000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("aa66fbee-a9d6-4bb5-8ed8-b329d394221f"), 0, 50 },
                    { new Guid("9a6ccc00-6b1c-40c5-be61-eb71323c9151"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 7, 1, 15, 15, 52, 955, DateTimeKind.Local).AddTicks(4294), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 150000m, 199000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("a6767d22-3ea0-4a00-ad31-9dce1d67184e"), new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"), new DateTime(2023, 7, 1, 15, 15, 52, 955, DateTimeKind.Local).AddTicks(4327), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 299000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("b799297f-d21e-4280-8df9-a3c6788c806e"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 7, 1, 15, 15, 52, 955, DateTimeKind.Local).AddTicks(4315), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 150000m, 199000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"), 0, 50 },
                    { new Guid("e3acb616-dd2c-44ee-93f0-754c68503b38"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 7, 1, 15, 15, 52, 955, DateTimeKind.Local).AddTicks(4318), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 299000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"), new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"), new DateTime(2023, 7, 1, 15, 15, 52, 955, DateTimeKind.Local).AddTicks(4320), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 200000m, 299000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("f6a1a967-7487-463b-9d7b-09aebf15d304"), 0, 50 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductDetailId", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"), new Guid("b799297f-d21e-4280-8df9-a3c6788c806e"), 995000m, 5 },
                    { new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"), new Guid("e3acb616-dd2c-44ee-93f0-754c68503b38"), 995000m, 5 },
                    { new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"), new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45"), 995000m, 5 },
                    { new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"), new Guid("9a6ccc00-6b1c-40c5-be61-eb71323c9151"), 995000m, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductDetailId",
                table: "OrderDetails",
                column: "ProductDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_ProductDetailId",
                table: "OrderDetails");

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"), new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5") });

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("070139ef-2c91-4261-af8b-c07d2a5932b3"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("5b28789c-e43f-4e10-b447-6290d4130c66"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("7f60198e-4f05-4cc5-8418-cffe41c392d4"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("97e83440-0351-4d34-9964-30aa65dd9cd5"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("a556951b-68bd-42d2-b7b3-a765ca19edf8"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("b9ed9a3a-0098-4575-93bc-d4beda3a0c0f"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("e481bd9d-e38c-4a2b-8194-30c0f6adc380"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("ee96d4a7-f5b8-4b83-b8bc-8b6d4c110e98"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"), new Guid("b799297f-d21e-4280-8df9-a3c6788c806e") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"), new Guid("e3acb616-dd2c-44ee-93f0-754c68503b38") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"), new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"), new Guid("9a6ccc00-6b1c-40c5-be61-eb71323c9151") });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8fd4f3f5-4f1a-4f23-a2b0-1dbf8e9d7a9c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a60b3fd4-40a0-4f4e-8f5b-6e5a9a3d63e6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c9e9de6f-0e6f-4b3e-9f6c-3f8f3a0e6a1d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("0976ba79-d822-408a-86cb-e05045db09ed"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("18cd05cb-f995-4b13-9fa4-a9e1f1c43862"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("28c12878-b191-4d42-974a-7b823de70a06"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("423f83df-dc6c-4b41-aa09-2fe30e841aa6"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("6a008d16-196e-40fe-ada5-2acf339fbede"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9610c212-5a16-4a70-8703-6bc7f1224be0"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a6767d22-3ea0-4a00-ad31-9dce1d67184e"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("24f04c0b-34c3-428c-8767-0bb98da225e0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9a6ccc00-6b1c-40c5-be61-eb71323c9151"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("b799297f-d21e-4280-8df9-a3c6788c806e"));

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("e3acb616-dd2c-44ee-93f0-754c68503b38"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("87513ccc-798f-485a-8206-0522f1d8b0ad"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                columns: new[] { "ProductDetailId", "OrderId" });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1090dcdd-b383-417b-9523-d73f0373fbb0"),
                column: "ConcurrencyStamp",
                value: "d0495817-ae4c-4e4e-884b-09d0be05ba06");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4a1c9012-a602-46a9-8eba-05e85149fd81"),
                column: "ConcurrencyStamp",
                value: "f082f729-5c75-411c-8e97-f0a65b2f3e8a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"),
                column: "ConcurrencyStamp",
                value: "3f6c4486-e697-4243-815a-2c8daf8da726");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b294e1f-c3f7-4f71-9be6-11c614fbdce5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a6a6e261-7c1c-4b25-b1b4-e750bc4d8f48", "AQAAAAEAACcQAAAAEJ/ws0MDJIApWOM/8G8NiV0mWxxF5V92UIC6DLnx0e2bKuvbmfRTglwWO/iJntfsmw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "601ba688-e206-4b50-ad66-f656b4511814", "AQAAAAEAACcQAAAAECEjSuKJL3mqBNW9k/fxRifIdqXGJPlcOUPhudKZOaSXTNvTPaOTDzbfycvxZxy7Bw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c2ec6dd4-8170-4b6d-acf4-33d52a128789"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a87b627-6419-4b6f-b8e0-77f47140ddfa", "AQAAAAEAACcQAAAAEFI/7wnmvlPGEEX8ZoInuJCEys8Dno1R1jRIjfnQtFkCWZblV+zPYYJRVLr7Gy9+VA==" });

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
                table: "ProductDetails",
                columns: new[] { "Id", "ColorId", "CreatedDate", "MaterialId", "OriginalPrice", "Price", "ProductId", "SizeId", "Status", "Stock" },
                values: new object[,]
                {
                    { new Guid("0a3dcb7c-884d-4a05-a5dd-a1d5df404dff"), new Guid("b8457fc8-60a5-43a1-9e4a-e4855c86524f"), new DateTime(2023, 6, 30, 14, 30, 47, 442, DateTimeKind.Local).AddTicks(1309), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 150000m, 199000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"), 0, 50 },
                    { new Guid("231e0060-c281-4c8d-b5c2-791edfa5a680"), new Guid("b8457fc8-60a5-43a1-9e4a-e4855c86524f"), new DateTime(2023, 6, 30, 14, 30, 47, 442, DateTimeKind.Local).AddTicks(1311), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 150000m, 199000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"), 0, 50 },
                    { new Guid("aa06827c-df06-4a43-94d2-75bba02d9da6"), new Guid("c22c0a96-b3fc-4223-8cca-b9046732bb89"), new DateTime(2023, 6, 30, 14, 30, 47, 442, DateTimeKind.Local).AddTicks(1312), new Guid("5cd1370c-dd94-4038-b33c-49a27aad25ab"), 200000m, 299000m, new Guid("3b997d7b-e67a-4b00-8e4a-043ce70b2844"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 },
                    { new Guid("fb684bf0-020f-4607-8e79-b3aa9bd005a5"), new Guid("b8457fc8-60a5-43a1-9e4a-e4855c86524f"), new DateTime(2023, 6, 30, 14, 30, 47, 442, DateTimeKind.Local).AddTicks(1292), new Guid("042237d8-ce3e-4f5e-b79d-daad510a1dc4"), 150000m, 199000m, new Guid("1dc01736-d7e2-4c24-94de-00844d5cb1f9"), new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"), 0, 50 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");
        }
    }
}
