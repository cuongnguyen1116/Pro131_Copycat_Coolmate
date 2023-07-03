using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shop.Data.Migrations
{
    public partial class addexampledata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1090dcdd-b383-417b-9523-d73f0373fbb0"),
                column: "ConcurrencyStamp",
                value: "f385e595-9bd1-4b7c-a175-135e62074b1b");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4a1c9012-a602-46a9-8eba-05e85149fd81"),
                column: "ConcurrencyStamp",
                value: "10ccbfd2-eaf3-4c75-ad85-49ee0a67088d");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"),
                column: "ConcurrencyStamp",
                value: "8ea06f2a-ca5c-4bf3-8ec8-48d3bfafb3b9");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5e6b24b0-6b54-4700-8a06-dff508590666", "AQAAAAEAACcQAAAAEKMGdEZJEvDoFOXcyBIxXMaQtCsbIYved5+nMExz8EZRfKYvFoR92/dppOUWkbjokw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b294e1f-c3f7-4f71-9be6-11c614fbdce5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "536fdefe-cb39-45cd-90bc-fb6045cb97c4", "AQAAAAEAACcQAAAAEACiswXRNohrmlL6wJhbIZPlz7eW2XgF2sQ73WYO511/+jjVvminxd0SBvXnCWcIWA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "356bac3f-e509-4603-904d-ef5b5751267f", "AQAAAAEAACcQAAAAEKExXa7z7Jz0A0agCv+hcuUKe+9qMLBHv/dJuQEjN5vf8gTNf/t7N6UDFVtVEBTsAQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "92bc4adc-dcc3-46ba-b52c-93efaee9c5b6", "AQAAAAEAACcQAAAAEHlBr0si8ZOEbSj+N8eU79SgsZpNNwMa8Bp0dD2r2AHOcr7WX+CpuQ2BbwMBTFaRZQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6877d533-2fb9-452b-a140-c8e480092235", "AQAAAAEAACcQAAAAEPQAIejR9BBfChCRpN5T8QrmyQWGkZNoZB7kC8fBH8mgC5HuJp7o+0oDcU2xablHCQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c2ec6dd4-8170-4b6d-acf4-33d52a128789"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "946d69df-ea01-4fce-b299-fa6f0da3d799", "AQAAAAEAACcQAAAAEErUtZ6wNBD0eoQ9204G3NZGl48xVhb9q263uUcJu54pSUfsfXlvz4njOtzSuTT91Q==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c5cf2bcc-882c-4d8a-86e4-96939b72fc51", "AQAAAAEAACcQAAAAEHaWyXhUKlhKQQ2HDyJGhsH3MqiH4J2QuWe1WRNEXdeM52+KcG49JpurpIQwcM7yMA==" });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"), new Guid("b799297f-d21e-4280-8df9-a3c6788c806e") },
                column: "Price",
                value: 199000m);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"), new Guid("e3acb616-dd2c-44ee-93f0-754c68503b38") },
                column: "Price",
                value: 199000m);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"), new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45") },
                column: "Price",
                value: 199000m);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"), new Guid("9a6ccc00-6b1c-40c5-be61-eb71323c9151") },
                column: "Price",
                value: 199000m);

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductDetailId", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab"), new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"), 199000m, 5 },
                    { new Guid("8fd4f3f5-4f1a-4f23-a2b0-1dbf8e9d7a9c"), new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"), 290000m, 5 },
                    { new Guid("a60b3fd4-40a0-4f4e-8f5b-6e5a9a3d63e6"), new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45"), 290000m, 5 },
                    { new Guid("c9e9de6f-0e6f-4b3e-9f6c-3f8f3a0e6a1d"), new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"), 290000m, 5 },
                    { new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"), new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"), 290000m, 5 }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"),
                columns: new[] { "CreatedDate", "PaidDate", "ShipDate" },
                values: new object[] { new DateTime(2023, 6, 26, 11, 17, 51, 539, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 6, 26, 11, 17, 51, 539, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 6, 30, 11, 17, 51, 539, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 26, 11, 17, 51, 539, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8fd4f3f5-4f1a-4f23-a2b0-1dbf8e9d7a9c"),
                columns: new[] { "CompletedDate", "CreatedDate", "PaidDate", "ShipDate" },
                values: new object[] { new DateTime(2023, 7, 3, 11, 17, 51, 539, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 6, 26, 11, 17, 51, 539, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 6, 26, 11, 17, 51, 539, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 6, 30, 11, 17, 51, 539, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a60b3fd4-40a0-4f4e-8f5b-6e5a9a3d63e6"),
                columns: new[] { "CompletedDate", "CreatedDate", "PaidDate", "ShipDate" },
                values: new object[] { new DateTime(2023, 7, 3, 11, 17, 51, 539, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 6, 26, 11, 17, 51, 539, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 6, 26, 11, 17, 51, 539, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 6, 30, 11, 17, 51, 539, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c9e9de6f-0e6f-4b3e-9f6c-3f8f3a0e6a1d"),
                columns: new[] { "CompletedDate", "CreatedDate", "PaidDate", "ShipDate" },
                values: new object[] { new DateTime(2023, 7, 3, 11, 17, 51, 539, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 6, 26, 11, 17, 51, 539, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 6, 26, 11, 17, 51, 539, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 6, 30, 11, 17, 51, 539, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 26, 11, 17, 51, 539, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"),
                columns: new[] { "CompletedDate", "CreatedDate", "PaidDate", "ShipDate" },
                values: new object[] { new DateTime(2023, 7, 3, 11, 17, 51, 539, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 6, 26, 11, 17, 51, 539, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 6, 26, 11, 17, 51, 539, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 6, 30, 11, 17, 51, 539, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("0976ba79-d822-408a-86cb-e05045db09ed"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 11, 17, 51, 529, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("18cd05cb-f995-4b13-9fa4-a9e1f1c43862"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 11, 17, 51, 529, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("28c12878-b191-4d42-974a-7b823de70a06"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 11, 17, 51, 529, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 11, 17, 51, 529, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("423f83df-dc6c-4b41-aa09-2fe30e841aa6"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 11, 17, 51, 529, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("6a008d16-196e-40fe-ada5-2acf339fbede"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 11, 17, 51, 529, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9610c212-5a16-4a70-8703-6bc7f1224be0"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 11, 17, 51, 529, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9a6ccc00-6b1c-40c5-be61-eb71323c9151"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 11, 17, 51, 529, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a6767d22-3ea0-4a00-ad31-9dce1d67184e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 11, 17, 51, 529, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("b799297f-d21e-4280-8df9-a3c6788c806e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 11, 17, 51, 529, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("e3acb616-dd2c-44ee-93f0-754c68503b38"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 11, 17, 51, 529, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 11, 17, 51, 529, DateTimeKind.Local).AddTicks(3579));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab"), new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("8fd4f3f5-4f1a-4f23-a2b0-1dbf8e9d7a9c"), new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("a60b3fd4-40a0-4f4e-8f5b-6e5a9a3d63e6"), new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("c9e9de6f-0e6f-4b3e-9f6c-3f8f3a0e6a1d"), new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e") });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"), new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e") });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1090dcdd-b383-417b-9523-d73f0373fbb0"),
                column: "ConcurrencyStamp",
                value: "f8d02ae4-7073-41be-9491-5638ea7468e6");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4a1c9012-a602-46a9-8eba-05e85149fd81"),
                column: "ConcurrencyStamp",
                value: "4d98bcdb-8179-416a-b1b8-d2206be7aa8e");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"),
                column: "ConcurrencyStamp",
                value: "8efa2239-78c9-4f58-91ca-336c635aea19");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cc82af07-a5de-42f1-bd91-9e85d6196659", "AQAAAAEAACcQAAAAEFjlAaUfRBnqYM9/45DvHL08hyK3e6yik6I25F9z6+dFOalh+GF8CwwHf2a3FWMVZw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b294e1f-c3f7-4f71-9be6-11c614fbdce5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9a552c5e-b526-4174-9e38-68916da4c859", "AQAAAAEAACcQAAAAEP0vKz7HVfyCp7pSTxytTomQF4rCmzf0EwxsYV7JOJFHt6nwu/NfeDGnKJmaRNfbOg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "55abf44d-1772-46bb-ab91-a566bb7486ef", "AQAAAAEAACcQAAAAEFDlqtyhm9PJz3ocFtiRi2tc6N5Vmr2r1RUDlUcZzJW/OBLG3qF2hs8ZlRL9tnqJuA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0b9d854e-ac3e-4ccb-9868-8f5c4dd3442b", "AQAAAAEAACcQAAAAEFvDbV7TYnUQV4amLcd7wh5i97Dold4kEPwvleOVFwf87/dMjByj54J8degxK7wEKw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1f731b7c-1794-45fb-98e9-ef21e7ad21bd", "AQAAAAEAACcQAAAAECB8kZqQAsbQFgjBXQcnzkXsqAc/V3YHSSJzRw9ahgHyUWuUD/C1N6dTccxzKLREgA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c2ec6dd4-8170-4b6d-acf4-33d52a128789"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "464f02ee-8991-4646-990e-f36ba8e02276", "AQAAAAEAACcQAAAAEPUQuyYkGnR4dTDFEZYTAA0puAXpP4C9P3MslHyV9Q5tBu+e55BEzlmSPvgZjsxYaw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f302e78-6f24-4dc6-8497-dceaf044c9d5", "AQAAAAEAACcQAAAAENn4bZLKGvsUlYCchDH/LFKs3zjclZfJ8g5fhWN+0sdVFKVMCt5VS4nEtJ1qtXlesg==" });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"), new Guid("b799297f-d21e-4280-8df9-a3c6788c806e") },
                column: "Price",
                value: 995000m);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"), new Guid("e3acb616-dd2c-44ee-93f0-754c68503b38") },
                column: "Price",
                value: 995000m);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"), new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45") },
                column: "Price",
                value: 995000m);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductDetailId" },
                keyValues: new object[] { new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"), new Guid("9a6ccc00-6b1c-40c5-be61-eb71323c9151") },
                column: "Price",
                value: 995000m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"),
                columns: new[] { "CreatedDate", "PaidDate", "ShipDate" },
                values: new object[] { new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 4, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8fd4f3f5-4f1a-4f23-a2b0-1dbf8e9d7a9c"),
                columns: new[] { "CompletedDate", "CreatedDate", "PaidDate", "ShipDate" },
                values: new object[] { new DateTime(2023, 7, 7, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 4, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a60b3fd4-40a0-4f4e-8f5b-6e5a9a3d63e6"),
                columns: new[] { "CompletedDate", "CreatedDate", "PaidDate", "ShipDate" },
                values: new object[] { new DateTime(2023, 7, 7, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 4, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c9e9de6f-0e6f-4b3e-9f6c-3f8f3a0e6a1d"),
                columns: new[] { "CompletedDate", "CreatedDate", "PaidDate", "ShipDate" },
                values: new object[] { new DateTime(2023, 7, 7, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 4, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"),
                columns: new[] { "CompletedDate", "CreatedDate", "PaidDate", "ShipDate" },
                values: new object[] { new DateTime(2023, 7, 7, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 4, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("0976ba79-d822-408a-86cb-e05045db09ed"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 9, 48, 53, 869, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("18cd05cb-f995-4b13-9fa4-a9e1f1c43862"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 9, 48, 53, 869, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("28c12878-b191-4d42-974a-7b823de70a06"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 9, 48, 53, 869, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 9, 48, 53, 869, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("423f83df-dc6c-4b41-aa09-2fe30e841aa6"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 9, 48, 53, 869, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("6a008d16-196e-40fe-ada5-2acf339fbede"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 9, 48, 53, 869, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9610c212-5a16-4a70-8703-6bc7f1224be0"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 9, 48, 53, 869, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9a6ccc00-6b1c-40c5-be61-eb71323c9151"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 9, 48, 53, 869, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a6767d22-3ea0-4a00-ad31-9dce1d67184e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 9, 48, 53, 869, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("b799297f-d21e-4280-8df9-a3c6788c806e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 9, 48, 53, 869, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("e3acb616-dd2c-44ee-93f0-754c68503b38"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 9, 48, 53, 869, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 3, 9, 48, 53, 869, DateTimeKind.Local).AddTicks(2102));
        }
    }
}
