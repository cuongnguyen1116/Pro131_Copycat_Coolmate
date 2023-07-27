using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shop.Data.Migrations
{
    public partial class Huy_Upload1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ToDate",
                table: "Promotions",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Promotions",
                newName: "PromotionCode");

            migrationBuilder.RenameColumn(
                name: "FromDate",
                table: "Promotions",
                newName: "FinishDate");

            migrationBuilder.RenameColumn(
                name: "ApplyForAll",
                table: "Promotions",
                newName: "PromotionCondition");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1090dcdd-b383-417b-9523-d73f0373fbb0"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "04ea1797-21a9-42f2-9866-43d0c87ba962", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4a1c9012-a602-46a9-8eba-05e85149fd81"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "3b33cd13-9686-40a9-893e-897f00bea898", "EMPLOYEE" });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "795ad6cf-53ce-45fa-9e3d-10091e8b121e", "CUSTOMER" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "19a1c3a0-bed7-478d-970d-82f0b5c2c1ed", "AQAAAAEAACcQAAAAEKd+1xqfEAZK1WlvuUXWRpkTfBiMP9eCBAxe4BrAXl1E747P1M5Wt6ddZQQKNImvxw==", "0987654321" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b294e1f-c3f7-4f71-9be6-11c614fbdce5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "a8ac268d-baa4-4a43-b0d6-25381c54ef99", "AQAAAAEAACcQAAAAEP0Y3ASBHDJkhdIxuc1HqeI98pHCqtwQLOZ4KUYLGdFCZTN35ohjw+eHvwisuP28cw==", "0987654321" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("513b6e27-9ec8-4339-8cd2-ce42a2c6a01e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "993f3955-8ad0-4595-8bf8-bca2a3308bc0", "AQAAAAEAACcQAAAAEJRTivMpgkBmAEoUXsYgViw5SpRLlPNAebqNef2BV03wjOCh+YSc2sxeIWx9utA3Cg==", "0987654321" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("598ded7d-1f81-43a9-861c-21a026294eb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "d3a0fc91-73f2-443c-8f6d-368562afa4c1", "AQAAAAEAACcQAAAAEBgd6HFWyedr1IxIuxIWyLqRpiUaO0KV5Xu9v9+aRvXO2rjbO4ixWKH7lRjKWCWIfw==", "0987654321" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("66c7e036-0cbd-4350-9afe-5e1e0c959bcf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "ffe202d4-319f-4698-be14-5342dbed39f2", "AQAAAAEAACcQAAAAEBHuEhtUDm5jaTTSU4AIBrdfztwsbGYML1Ltv4oYg+yR4+tOVIdWae5p/NhFf/kTLA==", "0987654321" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "fd4085f6-1c7a-40c1-9c9f-e79d62bd52ce", "AQAAAAEAACcQAAAAEDUXQcf0rvIvvykdfguGtuyndovIfL3Ih7Gn0IXY/9Dkfkhzrq4WoR6T7M0UUipIqA==", "0987654321" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ee56101-aff6-4d71-8112-e118ada30353"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "2a11fd28-a4ad-44b6-a16d-60f6ffe44592", "AQAAAAEAACcQAAAAEHW+XapI7hlPwBeQEH8dY2Y5pmyTxi7UGABAKjXD7b/X+GraB37QJ2IDDzARxsRmgA==", "0987654321" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("873c3aed-38c2-41ef-b03a-4e142dae542c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "a780efd2-e559-439a-ab1b-5cd959c456f4", "AQAAAAEAACcQAAAAEM/ZPz+9xZUzoI8C7D38oF6L72T4DAXvIlzab2PWmZVvuHiE7GobTIjssbTqqGX9OA==", "0987654321" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8db920d7-5115-432c-a9ad-3039dfed3244"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "03f496f8-847b-417c-8c1e-fba096577bb2", "AQAAAAEAACcQAAAAEI25pl0avXNK1lhg8a7mndVonkxacCF3pSotnV5nry14wFExzhRiXozNTXykzI2MmQ==", "0987654321" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "5ea528b5-7a32-461e-ba8b-a806fe36a8fd", "AQAAAAEAACcQAAAAEDBvNoNWtJ4IyRErISOrmyiCPyVr4wemhFii0Mr7cdHVutTy1wvQZNNCbhosWNAWxQ==", "0987654321" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a72558d6-0e2f-463f-9ce9-c7a232b7eb89"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "ac6f8ed1-4caa-475a-b3ae-a46e225658c0", "AQAAAAEAACcQAAAAEOVbTBno0r2s0J+oHNcuMtQLXaDNONLHxJqAxEw6OgKLhCeyZQkfb5Wtkac/IvvjDQ==", "0987654321" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "b33d03aa-3016-4800-b5c8-4bb14e944e60", "AQAAAAEAACcQAAAAEPz+s4uHMoFbwRlG6ZuPT0pmFXxcLzJgPiDhqx+q9CgtlNl/RmKZwjvDC75UB8wqxQ==", "0987654321" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c2ec6dd4-8170-4b6d-acf4-33d52a128789"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "fb302e25-e41c-4755-ad0a-c8d8dfc0f71f", "AQAAAAEAACcQAAAAEG9FYQXKaeIU9nueoJfTB+RWEmU1nwbJBSKfXC5hF7oQ/Bx3d47Nr/aCGYNRk/QBbw==", "0987654321" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c7378d1c-47f6-4cc5-b800-281023b6699a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "502bebf3-e455-4a89-81f7-1eb4e3d3ea27", "AQAAAAEAACcQAAAAENpsS4yhUdARfObUmG4MY9rx/p0pAIBXSX0G1LypdFtd67dBVmCKgu/AsrSIGcncWg==", "0987654321" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "a327a7dd-8c29-4dad-aa6e-c9880e8f3ebb", "AQAAAAEAACcQAAAAEPhTjs76NMNfFrOoIiLYQ49VJ/yi5LPLNgtel2oXJu1wfbiZYGm7we2VDpnDTODfnw==", "0987654321" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("25610f9a-ecf7-4202-a6ab-dcbe86c20bb8"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 311, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("41e0267d-90e0-4429-b3c6-c1eb650bc680"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 311, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"),
                columns: new[] { "ConfirmedDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 16, 44, 37, 311, DateTimeKind.Local).AddTicks(1288), new DateTime(2023, 7, 21, 16, 44, 37, 311, DateTimeKind.Local).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5f312584-d47e-4e8b-bc9c-584657befbf6"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 311, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 311, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8fd4f3f5-4f1a-4f23-a2b0-1dbf8e9d7a9c"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 311, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a60b3fd4-40a0-4f4e-8f5b-6e5a9a3d63e6"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 311, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b7683f6d-2bf4-4edb-971f-1b4d017244fd"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 311, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c9e9de6f-0e6f-4b3e-9f6c-3f8f3a0e6a1d"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 311, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 311, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 311, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fba2e1cb-2d69-40b1-acdf-46c3ea2f8840"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 311, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("0976ba79-d822-408a-86cb-e05045db09ed"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("0b3f534f-6dad-4543-804d-a6fce2a4674c"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("0f673bb8-f743-42f8-ba9e-50c6e7bd2b9b"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("111f1d26-a7e8-429c-a7b9-21427cf975fc"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("17ddc867-2a86-4a23-9ee0-a60ae4d238dc"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("180b5870-f77b-4ae6-b4ff-231b27a9bc51"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("186dd464-1acc-46c0-98e5-80724ef9a7a0"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("18cd05cb-f995-4b13-9fa4-a9e1f1c43862"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("1ed004a7-ac94-4c57-b871-564543bc8b38"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("1faa9efb-c6c0-4e5e-888c-0010dede6497"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("25f1829c-ad64-4e8f-9c8b-e8bf53592304"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("280ab97b-e8f8-461c-83b1-178161bdd11d"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("28c12878-b191-4d42-974a-7b823de70a06"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("2fecd681-ba9f-4ef9-8ce4-8315328dce20"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("37cb83db-2428-4fbb-a8da-fc4554f71729"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("3a1f9be1-c963-4789-8cbc-a935f94e6ef7"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("423f83df-dc6c-4b41-aa09-2fe30e841aa6"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("42fd8c77-f1ea-4827-a8ba-cfa758d9525e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("524b7e19-cc28-4a7b-aa53-bb6de7b0e1ea"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("53f989a8-c813-4667-8a5b-d57b016329a2"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("59d46d45-02e7-46a6-baca-426683257859"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("62b387f6-b535-4dfe-a310-76899ee9dec1"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("64a31f58-96a0-40d4-a3b5-cebb464f9708"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("6a008d16-196e-40fe-ada5-2acf339fbede"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("6b58ba80-86df-4671-a17b-17a65dd4f7b2"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("6dd2eb52-3aff-4208-ae75-fe7186aafb16"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("702c91f1-6fd7-4ed8-b8fd-ec4d9b49005f"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("79369e3d-570a-4f1d-8722-9a2daa52ae46"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("81434550-b237-420d-a407-ea8db1301136"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("84cf39b1-d8d1-4538-9467-62b7dc41aaae"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("85b4ff3f-1fa0-4597-9177-feece10892b7"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("90508eca-a616-4b65-9114-aacb1a23ef6f"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9610c212-5a16-4a70-8703-6bc7f1224be0"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9902bd0d-729a-49c9-b190-4991f5cf6ccd"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9a6ccc00-6b1c-40c5-be61-eb71323c9151"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9edbd50b-02a5-48d0-9acd-6394385185f2"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a3be12fa-6696-46b9-a270-b56860f10cc9"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a6188eb6-6679-4b1c-917b-083878b3182e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a648500a-ee4e-4fa6-ac8d-272670b4fece"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a6767d22-3ea0-4a00-ad31-9dce1d67184e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a7e56ca4-bf8e-4cf0-9d07-e95a275b869a"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("acb2aea8-07e1-4b38-96bb-5be8ed7ad5cd"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("af828b6f-1e3a-4668-af79-925e039fed0a"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("b5978ede-0f5d-4732-9c27-0097c9f27029"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("b799297f-d21e-4280-8df9-a3c6788c806e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("c078a922-9d8e-44d3-a0d4-02aff2ff02a0"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("c455cb74-947f-43f5-8396-52701206a747"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("c4ad16dd-57c2-4d70-8c40-a156cf208314"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("c7d3c45e-7c7e-431d-967c-a7346c06e123"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("cbbdbb20-a323-440c-b4ef-7494704a0ebe"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("cc1a10ec-0b47-4308-8876-6c7523da99b3"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("cf3450f2-6b36-4797-a249-8285fd6069de"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("d34df8f4-7796-4743-8769-04a005d0eefd"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("dfab5d49-4286-40f7-befc-89dd54baa9c5"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("e3acb616-dd2c-44ee-93f0-754c68503b38"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("e8d5e782-9027-4d0b-886f-43b9b1821647"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("e9627388-f53b-4600-9db6-30b5c6061a2b"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("eac0583e-715f-4e1a-a793-42ac142256fb"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("ed8c924a-e97e-4063-986d-27e1c76d0db6"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("f5ef450e-5ee9-4525-abde-c404039cd7bc"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 21, 16, 44, 37, 179, DateTimeKind.Local).AddTicks(6948));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Promotions",
                newName: "ToDate");

            migrationBuilder.RenameColumn(
                name: "PromotionCondition",
                table: "Promotions",
                newName: "ApplyForAll");

            migrationBuilder.RenameColumn(
                name: "PromotionCode",
                table: "Promotions",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FinishDate",
                table: "Promotions",
                newName: "FromDate");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1090dcdd-b383-417b-9523-d73f0373fbb0"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "1dc63c7f-0463-4b46-ab38-848696233bbc", null });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4a1c9012-a602-46a9-8eba-05e85149fd81"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "61dfb675-da44-4705-bf6f-889ae61df0b4", null });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "b5accffc-c201-451a-90a4-60c0e8740506", null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "8a90fe50-b24a-448c-9989-4a321391b304", "AQAAAAEAACcQAAAAELSSFHT+qOHEYYFV/Cf+5t+GvV/au9x8Yyr5nscCH3ylixwtU9nXONLFcWo0RI8aUA==", null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b294e1f-c3f7-4f71-9be6-11c614fbdce5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "5cf94e8f-8afb-4a30-a37e-df4feb881025", "AQAAAAEAACcQAAAAEIYMV0U+XMQyX+VzXjvTEVN4YsKusiIwwiWJ9nvg9dvGKNGpTpPSbp9JRW61rYxQWQ==", null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("513b6e27-9ec8-4339-8cd2-ce42a2c6a01e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "76969255-d049-4cf4-92b0-ec7c25b4aab7", "AQAAAAEAACcQAAAAEAdUhQz1fBUK5vMlnIdapJXX5ZsLFVwuUJ+lNWt03AopIf9MV/s9joQQOKq2OdxLIA==", null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("598ded7d-1f81-43a9-861c-21a026294eb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "41bbd7c9-ac2f-415d-9da8-55db14b3ef27", "AQAAAAEAACcQAAAAEH8vVUSx1ysL2DQOjM+0zjM99Hz5MwNB0C2QoonVEDw/PDJabGtpzTm4DXpLbX7z7w==", null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("66c7e036-0cbd-4350-9afe-5e1e0c959bcf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "84a5117c-5554-47ed-a2fd-695af56ec910", "AQAAAAEAACcQAAAAEDtGpWPI8xCEV3zXh97XmNow/lEKp1l/AF9t2HaTCOJ6+KLDFzW31RQMEZ0q5iDArw==", null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "ef14f159-7872-4235-88e2-37411181ddea", "AQAAAAEAACcQAAAAEPyhBYETXKRY0M8WD4ESXWwEM5fblgyIgLyj4DpL22TBWlsCwlvocbPjKLGiYVvLEQ==", null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ee56101-aff6-4d71-8112-e118ada30353"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "7bb38062-9766-452b-b2cc-3c88e12469cd", "AQAAAAEAACcQAAAAECViK90Ik+5x9JnQmVSKYcZfd6QRiZvCk8pc04yZ7P/dR4m+8S6DlgLPb0ABWMi79Q==", null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("873c3aed-38c2-41ef-b03a-4e142dae542c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "b2c713d4-2aa9-4223-9438-28ba5f4d48ff", "AQAAAAEAACcQAAAAEBIKe/IaioP8VSY/CV3XEHbiUuY1dS+Df9KGKjm19OvG5Si4QEdj07bRwjNVpqGAwA==", null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8db920d7-5115-432c-a9ad-3039dfed3244"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "b5fcac0e-a992-4a2b-9159-297442190bec", "AQAAAAEAACcQAAAAEFm/3n/R1BygRc1SdPqt4ikCuxEaGVdVCf14YWIfLLi6HpMKCFnOBNTJWm/0NWP7Ow==", null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "91705a7d-67db-4b2d-ba1f-e0570dd7deaa", "AQAAAAEAACcQAAAAECdf9LLXdvEyUEgS0/iW6wz1evarlWj1/UOqP5j8nxOySHqO0HQWuct/B1geIwapKg==", null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a72558d6-0e2f-463f-9ce9-c7a232b7eb89"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "d045135c-4bfa-41bb-938f-c426fa018dd8", "AQAAAAEAACcQAAAAEEsFhLPPVdyZivG2JhpOQxdybN4yHFELViTPNXQ5Pq9yMV1hN9OEolnIPDbt8jhE5A==", null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "e5417c27-2e89-456b-a964-e5c54cf7f723", "AQAAAAEAACcQAAAAEOcx7bJeiYcECsBTuDfxLwf+AVvE3suZakk7/IYriUL2M0PUES5YmFczzv2gkkNFug==", null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c2ec6dd4-8170-4b6d-acf4-33d52a128789"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "dedbb177-8fae-4f4d-9624-a70116258101", "AQAAAAEAACcQAAAAEO4k0/aXaGuueG3wMPoFYfgWffohTCUAlKjV0KnzSv4pC6MRvVybZefcNU9X8Zzv2Q==", null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c7378d1c-47f6-4cc5-b800-281023b6699a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "9d5ab0c2-870f-413b-a55e-1e94f10aec80", "AQAAAAEAACcQAAAAEMBfYN4Q4CniE//eXikgh+6sH0+UCdgR2/XAzbuXgfpDh75pDAVgBkslHdJA23c/GQ==", null });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "eebdf329-1ef8-40e4-9966-ed3a852499de", "AQAAAAEAACcQAAAAEPqlZT5+1aogUzAFmpv1BCXMk/efc+DHAjGR3OuBlbenNyfNKiijfgl9S3hw/BYSpQ==", null });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("25610f9a-ecf7-4202-a6ab-dcbe86c20bb8"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("41e0267d-90e0-4429-b3c6-c1eb650bc680"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"),
                columns: new[] { "ConfirmedDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476), new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5f312584-d47e-4e8b-bc9c-584657befbf6"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8fd4f3f5-4f1a-4f23-a2b0-1dbf8e9d7a9c"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a60b3fd4-40a0-4f4e-8f5b-6e5a9a3d63e6"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b7683f6d-2bf4-4edb-971f-1b4d017244fd"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c9e9de6f-0e6f-4b3e-9f6c-3f8f3a0e6a1d"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fba2e1cb-2d69-40b1-acdf-46c3ea2f8840"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 651, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("0976ba79-d822-408a-86cb-e05045db09ed"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("0b3f534f-6dad-4543-804d-a6fce2a4674c"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("0f673bb8-f743-42f8-ba9e-50c6e7bd2b9b"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("111f1d26-a7e8-429c-a7b9-21427cf975fc"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("17ddc867-2a86-4a23-9ee0-a60ae4d238dc"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("180b5870-f77b-4ae6-b4ff-231b27a9bc51"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("186dd464-1acc-46c0-98e5-80724ef9a7a0"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("18cd05cb-f995-4b13-9fa4-a9e1f1c43862"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("1ed004a7-ac94-4c57-b871-564543bc8b38"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("1faa9efb-c6c0-4e5e-888c-0010dede6497"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("25f1829c-ad64-4e8f-9c8b-e8bf53592304"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("280ab97b-e8f8-461c-83b1-178161bdd11d"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("28c12878-b191-4d42-974a-7b823de70a06"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("2fecd681-ba9f-4ef9-8ce4-8315328dce20"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("37cb83db-2428-4fbb-a8da-fc4554f71729"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("3a1f9be1-c963-4789-8cbc-a935f94e6ef7"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("423f83df-dc6c-4b41-aa09-2fe30e841aa6"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("42fd8c77-f1ea-4827-a8ba-cfa758d9525e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("524b7e19-cc28-4a7b-aa53-bb6de7b0e1ea"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("53f989a8-c813-4667-8a5b-d57b016329a2"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("59d46d45-02e7-46a6-baca-426683257859"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("62b387f6-b535-4dfe-a310-76899ee9dec1"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("64a31f58-96a0-40d4-a3b5-cebb464f9708"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("6a008d16-196e-40fe-ada5-2acf339fbede"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("6b58ba80-86df-4671-a17b-17a65dd4f7b2"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("6dd2eb52-3aff-4208-ae75-fe7186aafb16"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("702c91f1-6fd7-4ed8-b8fd-ec4d9b49005f"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("79369e3d-570a-4f1d-8722-9a2daa52ae46"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("81434550-b237-420d-a407-ea8db1301136"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("84cf39b1-d8d1-4538-9467-62b7dc41aaae"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("85b4ff3f-1fa0-4597-9177-feece10892b7"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("90508eca-a616-4b65-9114-aacb1a23ef6f"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9610c212-5a16-4a70-8703-6bc7f1224be0"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9902bd0d-729a-49c9-b190-4991f5cf6ccd"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9a6ccc00-6b1c-40c5-be61-eb71323c9151"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9edbd50b-02a5-48d0-9acd-6394385185f2"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a3be12fa-6696-46b9-a270-b56860f10cc9"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a6188eb6-6679-4b1c-917b-083878b3182e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a648500a-ee4e-4fa6-ac8d-272670b4fece"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a6767d22-3ea0-4a00-ad31-9dce1d67184e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a7e56ca4-bf8e-4cf0-9d07-e95a275b869a"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("acb2aea8-07e1-4b38-96bb-5be8ed7ad5cd"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("af828b6f-1e3a-4668-af79-925e039fed0a"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("b5978ede-0f5d-4732-9c27-0097c9f27029"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("b799297f-d21e-4280-8df9-a3c6788c806e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("c078a922-9d8e-44d3-a0d4-02aff2ff02a0"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("c455cb74-947f-43f5-8396-52701206a747"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("c4ad16dd-57c2-4d70-8c40-a156cf208314"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("c7d3c45e-7c7e-431d-967c-a7346c06e123"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("cbbdbb20-a323-440c-b4ef-7494704a0ebe"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("cc1a10ec-0b47-4308-8876-6c7523da99b3"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("cf3450f2-6b36-4797-a249-8285fd6069de"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("d34df8f4-7796-4743-8769-04a005d0eefd"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("dfab5d49-4286-40f7-befc-89dd54baa9c5"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("e3acb616-dd2c-44ee-93f0-754c68503b38"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("e8d5e782-9027-4d0b-886f-43b9b1821647"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("e9627388-f53b-4600-9db6-30b5c6061a2b"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("eac0583e-715f-4e1a-a793-42ac142256fb"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("ed8c924a-e97e-4063-986d-27e1c76d0db6"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("f5ef450e-5ee9-4525-abde-c404039cd7bc"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 14, 2, 20, 633, DateTimeKind.Local).AddTicks(2350));
        }
    }
}
