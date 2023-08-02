using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shop.Data.Migrations
{
    public partial class add_isfeaturedforproductdetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "ProductDetails",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1090dcdd-b383-417b-9523-d73f0373fbb0"),
                column: "ConcurrencyStamp",
                value: "6c9c115a-174d-4667-a85b-542b459885ca");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4a1c9012-a602-46a9-8eba-05e85149fd81"),
                column: "ConcurrencyStamp",
                value: "b40a9fa9-c67c-4da8-99b2-b50e03e0e50f");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"),
                column: "ConcurrencyStamp",
                value: "ead31584-e3eb-4011-a2f5-29d1a5975c55");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7b6c871f-5b16-4735-86dd-5d86f9d8f73b", "AQAAAAEAACcQAAAAEHO01stXZ5Sr8Lip0tSwqhV7mXUAEHgZPFdH+9guu/QvWzPSwg4vu+lez4NBaSeeKA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b294e1f-c3f7-4f71-9be6-11c614fbdce5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cfe28b10-0c8d-41d2-a655-c1dbfe90c6e1", "AQAAAAEAACcQAAAAEGAq2oPsA/RH129nJWCtY9qZzVvTG4ebKJAQbiLPojRYTuDPv6gd5SImHbviulz+tA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("513b6e27-9ec8-4339-8cd2-ce42a2c6a01e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cedd6587-6ec1-4343-9694-07c2c723f420", "AQAAAAEAACcQAAAAEIAYz4UGOLL4rsFssdXM1w2mdK0GL00zQcY6fXU6qaWXmlT1XWiDXfK+53c7RigGuA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("598ded7d-1f81-43a9-861c-21a026294eb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fef7bb8b-748f-480b-a277-86e3e9d63308", "AQAAAAEAACcQAAAAECaSQ4tozEOiVo6j91RcAsJ+7ynbKk9bEFAdOhJzT8p7xxwgnNcHuv94wlLeX/6xRw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("66c7e036-0cbd-4350-9afe-5e1e0c959bcf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5071c3dc-1323-4bf4-bd41-bbb60d1dd4db", "AQAAAAEAACcQAAAAEJNtkFfEzsAlfIncH1uNZFu8imeCR3mIHqK1549yGIIXRRdC7k0KFWkvBe3/lbOpWw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d312b275-26b9-46fb-8a1b-07d29c05cbe1", "AQAAAAEAACcQAAAAEMHJidNT/f3jfaQ6npwaufozLs1hRxWPh6GMqUk71eqxYbgIaLgZRagXHNZXB04VOQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ee56101-aff6-4d71-8112-e118ada30353"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0bd7df5-34cb-4d22-a11d-cab40fd2bf26", "AQAAAAEAACcQAAAAEC091UZqZz0YWi5+cSxHaCKqUSu2/Il+amJySt7uYhUQP9uaRBtD7HD4uYWyTxH12g==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("873c3aed-38c2-41ef-b03a-4e142dae542c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "65267f78-77f3-42f2-9f26-48f2a14bd01d", "AQAAAAEAACcQAAAAEFzDmYDUVq8Ps3KlkLukMZHYlQA6yVNw7yKA+cOgKotlmnJCOxrVnaTPpozE4IFI0w==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8db920d7-5115-432c-a9ad-3039dfed3244"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "84183558-9db1-48ac-9c0a-4689870a193a", "AQAAAAEAACcQAAAAEI90t5RUBsqRcOoEjR9jTo7nf5FL7mgDwokJm60MvMyIP+8arfFYcnW5tX6/P7E6WA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6c8c033c-b32e-4562-9d12-680fd2157e11", "AQAAAAEAACcQAAAAEJ28bx/Ydo7vLnmgEcrPkgF8XYFRhcW70wzDO1ISkVKBYAwC98KRR6XPaOA37FeXDQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a72558d6-0e2f-463f-9ce9-c7a232b7eb89"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ecae7ff7-2303-493f-8119-9fc44390b378", "AQAAAAEAACcQAAAAEBrrOMYSaFqcRKyd+nFAJbAB0YLuC25l+JhxBwXPS+cWhvysnF3UoaaWooIU9+cCsg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bedc7f0a-f259-41fa-9e45-bc3e5438c3ed", "AQAAAAEAACcQAAAAECPI9//fUj320shRBODytq9ItUvigYscTSAHT1Q/DIxbPY5Cu0sgDLwwVmzlWqdlQA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c2ec6dd4-8170-4b6d-acf4-33d52a128789"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "beb2064d-e84e-4966-ae13-9b5977fff68b", "AQAAAAEAACcQAAAAEDir+vxi6NLke762MgZ/DrKuqmJO+TAQMerFcwVajp6NaSejZYZt7FJ1iaQ90filpQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c7378d1c-47f6-4cc5-b800-281023b6699a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fdeeb934-bcf1-46af-a8c4-5174415afc6c", "AQAAAAEAACcQAAAAEEWmz6wLXQzjOcfzvICOOMVR3jC++kGG8xIcwX+/HFLyZe9tg2Fexu7hO2fTcpfTxg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f166680a-fef4-4313-b66c-2fa193a4da80", "AQAAAAEAACcQAAAAEMVYvgD8u1kG7UP8il4NtszmpxnG/lfXVhl+4oLdcP0j89hOXX4u+I7Df6WpMd9vkg==" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("25610f9a-ecf7-4202-a6ab-dcbe86c20bb8"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 763, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("41e0267d-90e0-4429-b3c6-c1eb650bc680"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 763, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"),
                columns: new[] { "ConfirmedDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 7, 30, 8, 45, 42, 763, DateTimeKind.Local).AddTicks(911), new DateTime(2023, 7, 30, 8, 45, 42, 763, DateTimeKind.Local).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5f312584-d47e-4e8b-bc9c-584657befbf6"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 763, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 763, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8fd4f3f5-4f1a-4f23-a2b0-1dbf8e9d7a9c"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 763, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a60b3fd4-40a0-4f4e-8f5b-6e5a9a3d63e6"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 763, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b7683f6d-2bf4-4edb-971f-1b4d017244fd"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 763, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c9e9de6f-0e6f-4b3e-9f6c-3f8f3a0e6a1d"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 763, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 763, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 763, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fba2e1cb-2d69-40b1-acdf-46c3ea2f8840"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 763, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("0976ba79-d822-408a-86cb-e05045db09ed"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("0b3f534f-6dad-4543-804d-a6fce2a4674c"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("0f673bb8-f743-42f8-ba9e-50c6e7bd2b9b"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("111f1d26-a7e8-429c-a7b9-21427cf975fc"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("17ddc867-2a86-4a23-9ee0-a60ae4d238dc"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("180b5870-f77b-4ae6-b4ff-231b27a9bc51"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("186dd464-1acc-46c0-98e5-80724ef9a7a0"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("18cd05cb-f995-4b13-9fa4-a9e1f1c43862"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("1ed004a7-ac94-4c57-b871-564543bc8b38"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("1faa9efb-c6c0-4e5e-888c-0010dede6497"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("25f1829c-ad64-4e8f-9c8b-e8bf53592304"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("280ab97b-e8f8-461c-83b1-178161bdd11d"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("28c12878-b191-4d42-974a-7b823de70a06"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("2fecd681-ba9f-4ef9-8ce4-8315328dce20"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("37cb83db-2428-4fbb-a8da-fc4554f71729"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("3a1f9be1-c963-4789-8cbc-a935f94e6ef7"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("423f83df-dc6c-4b41-aa09-2fe30e841aa6"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("42fd8c77-f1ea-4827-a8ba-cfa758d9525e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("524b7e19-cc28-4a7b-aa53-bb6de7b0e1ea"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("53f989a8-c813-4667-8a5b-d57b016329a2"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("59d46d45-02e7-46a6-baca-426683257859"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("62b387f6-b535-4dfe-a310-76899ee9dec1"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("64a31f58-96a0-40d4-a3b5-cebb464f9708"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("6a008d16-196e-40fe-ada5-2acf339fbede"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("6b58ba80-86df-4671-a17b-17a65dd4f7b2"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("6dd2eb52-3aff-4208-ae75-fe7186aafb16"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("702c91f1-6fd7-4ed8-b8fd-ec4d9b49005f"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("79369e3d-570a-4f1d-8722-9a2daa52ae46"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("81434550-b237-420d-a407-ea8db1301136"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("84cf39b1-d8d1-4538-9467-62b7dc41aaae"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("85b4ff3f-1fa0-4597-9177-feece10892b7"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("90508eca-a616-4b65-9114-aacb1a23ef6f"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9610c212-5a16-4a70-8703-6bc7f1224be0"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9902bd0d-729a-49c9-b190-4991f5cf6ccd"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9a6ccc00-6b1c-40c5-be61-eb71323c9151"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9edbd50b-02a5-48d0-9acd-6394385185f2"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a3be12fa-6696-46b9-a270-b56860f10cc9"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a6188eb6-6679-4b1c-917b-083878b3182e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a648500a-ee4e-4fa6-ac8d-272670b4fece"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a6767d22-3ea0-4a00-ad31-9dce1d67184e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a7e56ca4-bf8e-4cf0-9d07-e95a275b869a"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("acb2aea8-07e1-4b38-96bb-5be8ed7ad5cd"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("af828b6f-1e3a-4668-af79-925e039fed0a"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("b5978ede-0f5d-4732-9c27-0097c9f27029"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("b799297f-d21e-4280-8df9-a3c6788c806e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("c078a922-9d8e-44d3-a0d4-02aff2ff02a0"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("c455cb74-947f-43f5-8396-52701206a747"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("c4ad16dd-57c2-4d70-8c40-a156cf208314"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("c7d3c45e-7c7e-431d-967c-a7346c06e123"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("cbbdbb20-a323-440c-b4ef-7494704a0ebe"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("cc1a10ec-0b47-4308-8876-6c7523da99b3"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("cf3450f2-6b36-4797-a249-8285fd6069de"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("d34df8f4-7796-4743-8769-04a005d0eefd"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("dfab5d49-4286-40f7-befc-89dd54baa9c5"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("e3acb616-dd2c-44ee-93f0-754c68503b38"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("e8d5e782-9027-4d0b-886f-43b9b1821647"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("e9627388-f53b-4600-9db6-30b5c6061a2b"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("eac0583e-715f-4e1a-a793-42ac142256fb"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("ed8c924a-e97e-4063-986d-27e1c76d0db6"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("f5ef450e-5ee9-4525-abde-c404039cd7bc"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 30, 8, 45, 42, 696, DateTimeKind.Local).AddTicks(2042));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "ProductDetails");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1090dcdd-b383-417b-9523-d73f0373fbb0"),
                column: "ConcurrencyStamp",
                value: "79c2f388-dc5a-4566-afb0-9ad4a9c9ba56");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4a1c9012-a602-46a9-8eba-05e85149fd81"),
                column: "ConcurrencyStamp",
                value: "a9e1d208-ea68-4e1d-b0e3-59cb4f0fef55");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"),
                column: "ConcurrencyStamp",
                value: "cd1371e1-360a-4ee2-ace8-997475d8410c");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "facb0813-0c97-4af8-be43-d0c4ba178318", "AQAAAAEAACcQAAAAEHxNWUIUYlEvNgduT+HUr7LiHB59y17VUzNhc7C7Z43q+exKDD5yBgEG4i7MFnwWzg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b294e1f-c3f7-4f71-9be6-11c614fbdce5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c229fed3-a46a-4af5-8ab4-c7db05d9ac03", "AQAAAAEAACcQAAAAEPlWuMPD2OICZ+6fgkMRSa6QPpUDOq2RmEPpEBzweb+alwrxA3flgOF7qi6Kp4HfyQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("513b6e27-9ec8-4339-8cd2-ce42a2c6a01e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "186e7c4c-94cd-4b11-b7e5-7c45140acb91", "AQAAAAEAACcQAAAAEJTvgqMN2VEgOrOoJ7QqLO/XyePkovJVegTwTcvDoFD1EOT+XNggA2ywY/sQVEvxFA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("598ded7d-1f81-43a9-861c-21a026294eb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dec324aa-6a3f-4a81-98e5-6aa08393c5d9", "AQAAAAEAACcQAAAAEGbm0xKzmSYYJD1dh8eN9L7jbcjY/TqeYUh0dgo1J3DALsmevPASqNOzC+kSOga7Ew==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("66c7e036-0cbd-4350-9afe-5e1e0c959bcf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "24bfe1f1-277e-4c9c-8d29-df57708ab784", "AQAAAAEAACcQAAAAEHKGSI6MOcX06TNIXPaWlDXZm2kRfXXJCwxra5Gkoz3OO0HRFnaE3V1sj04QpfY0gA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dc06fb1f-b54c-42d2-9d47-9b623b30d319", "AQAAAAEAACcQAAAAEHKtjTZr5FfDdcQ3SVRYBRNLdNrCIcAwUAcv+F05Dqt+4Ezb8YvnjcJ8euCrSyrBPQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ee56101-aff6-4d71-8112-e118ada30353"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1cc8e3f6-2e61-4d9c-a9c7-1912f763ac54", "AQAAAAEAACcQAAAAEFP65xeUMybbA4JqbYOiFjhO+0gbWv8xoi9s1Kv+X8lZVSWx0Theykn0nkizzJqNGw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("873c3aed-38c2-41ef-b03a-4e142dae542c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "30d2ea71-aac0-40db-9b7c-4e042ab3828d", "AQAAAAEAACcQAAAAEM5mIsGpMdPEXWjkUAuUbbtYIUAj6W3c5KdNghAuCBE5FvjiraYn82O+umqgbSiX7w==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8db920d7-5115-432c-a9ad-3039dfed3244"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2e5c73d0-59f5-4c44-a5be-51a4296047f1", "AQAAAAEAACcQAAAAELHUfmysZDK1HMjkX2p992kP10NjCWPz9rSCd4lFoUfhdGakwos96hVdO+V+n+l85g==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1d8c9a46-ad76-4b1e-8750-ce6039d86f43", "AQAAAAEAACcQAAAAEMChGCHnXdLGqRSjnXjpRwR3HaPyU4CyxFBvVCxdxdVm91rlF1fxjyDrYuSRzw57yw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a72558d6-0e2f-463f-9ce9-c7a232b7eb89"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "801b448f-f5f9-4dee-9b24-1f0f9409cca4", "AQAAAAEAACcQAAAAEK2qQmCRN+uwZ/ZVktlpOPYdH0djg53duzfUCPoKhPIAbjJP0biwxPtSp5JK+Pwzmw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "685bf32e-0f9a-4bbd-b466-960a78342d87", "AQAAAAEAACcQAAAAENPuRigqkW2zy59qaWZqIfABTehM7PJiAhPJJgLeaYL6IO2ay3N5HPeTGm9oKt5J5A==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c2ec6dd4-8170-4b6d-acf4-33d52a128789"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7f40172d-301c-413a-bc00-d3982d3385bd", "AQAAAAEAACcQAAAAEDJ/14JPUKRDSvP9YmIY3FHtCDdKWeO5yF/3k/r0pxWPWlBj+cN9MFydzsA26rOT1Q==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c7378d1c-47f6-4cc5-b800-281023b6699a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "355995e8-fcaa-40af-9d71-0c8b59a31793", "AQAAAAEAACcQAAAAEB99Obq6G4sLwE26lzlWzS6mZNM5WUyTBMUhoRPgFMDl7NjdM08rGxwYyQC2TOU9+g==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "757cf541-12f3-4075-b170-f7d2b8ba78f7", "AQAAAAEAACcQAAAAEL95hM1eb2Eryc1kDqHk1IIOrwnlYv4MugwJNL16otxj31gFKGRuZKgKKRFZ3UjqmQ==" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("25610f9a-ecf7-4202-a6ab-dcbe86c20bb8"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 313, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("41e0267d-90e0-4429-b3c6-c1eb650bc680"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 313, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"),
                columns: new[] { "ConfirmedDate", "CreatedDate" },
                values: new object[] { new DateTime(2023, 7, 24, 21, 12, 19, 313, DateTimeKind.Local).AddTicks(2540), new DateTime(2023, 7, 24, 21, 12, 19, 313, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5f312584-d47e-4e8b-bc9c-584657befbf6"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 313, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 313, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8fd4f3f5-4f1a-4f23-a2b0-1dbf8e9d7a9c"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 313, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a60b3fd4-40a0-4f4e-8f5b-6e5a9a3d63e6"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 313, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b7683f6d-2bf4-4edb-971f-1b4d017244fd"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 313, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c9e9de6f-0e6f-4b3e-9f6c-3f8f3a0e6a1d"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 313, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 313, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 313, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fba2e1cb-2d69-40b1-acdf-46c3ea2f8840"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 313, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("0976ba79-d822-408a-86cb-e05045db09ed"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("0b3f534f-6dad-4543-804d-a6fce2a4674c"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("0f673bb8-f743-42f8-ba9e-50c6e7bd2b9b"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("111f1d26-a7e8-429c-a7b9-21427cf975fc"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("17ddc867-2a86-4a23-9ee0-a60ae4d238dc"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("180b5870-f77b-4ae6-b4ff-231b27a9bc51"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("186dd464-1acc-46c0-98e5-80724ef9a7a0"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("18cd05cb-f995-4b13-9fa4-a9e1f1c43862"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("1ed004a7-ac94-4c57-b871-564543bc8b38"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("1faa9efb-c6c0-4e5e-888c-0010dede6497"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("25f1829c-ad64-4e8f-9c8b-e8bf53592304"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("280ab97b-e8f8-461c-83b1-178161bdd11d"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("28c12878-b191-4d42-974a-7b823de70a06"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("2fecd681-ba9f-4ef9-8ce4-8315328dce20"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("37cb83db-2428-4fbb-a8da-fc4554f71729"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("3a1f9be1-c963-4789-8cbc-a935f94e6ef7"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("423f83df-dc6c-4b41-aa09-2fe30e841aa6"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("42fd8c77-f1ea-4827-a8ba-cfa758d9525e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("524b7e19-cc28-4a7b-aa53-bb6de7b0e1ea"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("53f989a8-c813-4667-8a5b-d57b016329a2"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("59d46d45-02e7-46a6-baca-426683257859"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("62b387f6-b535-4dfe-a310-76899ee9dec1"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("64a31f58-96a0-40d4-a3b5-cebb464f9708"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("6a008d16-196e-40fe-ada5-2acf339fbede"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("6b58ba80-86df-4671-a17b-17a65dd4f7b2"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("6dd2eb52-3aff-4208-ae75-fe7186aafb16"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("702c91f1-6fd7-4ed8-b8fd-ec4d9b49005f"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("79369e3d-570a-4f1d-8722-9a2daa52ae46"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("81434550-b237-420d-a407-ea8db1301136"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("84cf39b1-d8d1-4538-9467-62b7dc41aaae"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("85b4ff3f-1fa0-4597-9177-feece10892b7"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("90508eca-a616-4b65-9114-aacb1a23ef6f"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9610c212-5a16-4a70-8703-6bc7f1224be0"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9902bd0d-729a-49c9-b190-4991f5cf6ccd"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9a6ccc00-6b1c-40c5-be61-eb71323c9151"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9edbd50b-02a5-48d0-9acd-6394385185f2"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a3be12fa-6696-46b9-a270-b56860f10cc9"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a6188eb6-6679-4b1c-917b-083878b3182e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a648500a-ee4e-4fa6-ac8d-272670b4fece"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a6767d22-3ea0-4a00-ad31-9dce1d67184e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a7e56ca4-bf8e-4cf0-9d07-e95a275b869a"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("acb2aea8-07e1-4b38-96bb-5be8ed7ad5cd"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("af828b6f-1e3a-4668-af79-925e039fed0a"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("b5978ede-0f5d-4732-9c27-0097c9f27029"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("b799297f-d21e-4280-8df9-a3c6788c806e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("c078a922-9d8e-44d3-a0d4-02aff2ff02a0"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("c455cb74-947f-43f5-8396-52701206a747"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("c4ad16dd-57c2-4d70-8c40-a156cf208314"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("c7d3c45e-7c7e-431d-967c-a7346c06e123"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("cbbdbb20-a323-440c-b4ef-7494704a0ebe"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("cc1a10ec-0b47-4308-8876-6c7523da99b3"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("cf3450f2-6b36-4797-a249-8285fd6069de"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("d34df8f4-7796-4743-8769-04a005d0eefd"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("dfab5d49-4286-40f7-befc-89dd54baa9c5"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("e3acb616-dd2c-44ee-93f0-754c68503b38"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("e8d5e782-9027-4d0b-886f-43b9b1821647"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("e9627388-f53b-4600-9db6-30b5c6061a2b"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("eac0583e-715f-4e1a-a793-42ac142256fb"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("ed8c924a-e97e-4063-986d-27e1c76d0db6"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("f5ef450e-5ee9-4525-abde-c404039cd7bc"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 24, 21, 12, 19, 297, DateTimeKind.Local).AddTicks(3625));
        }
    }
}
