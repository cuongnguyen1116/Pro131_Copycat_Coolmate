using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shop.Data.Migrations
{
    public partial class orderTotalPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

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
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"),
                columns: new[] { "CreatedDate", "PaidDate", "ShipDate", "Total" },
                values: new object[] { new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 4, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), 2000000m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab"),
                columns: new[] { "CreatedDate", "Total" },
                values: new object[] { new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), 3000000m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8fd4f3f5-4f1a-4f23-a2b0-1dbf8e9d7a9c"),
                columns: new[] { "CompletedDate", "CreatedDate", "PaidDate", "ShipDate", "Total" },
                values: new object[] { new DateTime(2023, 7, 7, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 4, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), 290000m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a60b3fd4-40a0-4f4e-8f5b-6e5a9a3d63e6"),
                columns: new[] { "CompletedDate", "CreatedDate", "PaidDate", "ShipDate", "Total" },
                values: new object[] { new DateTime(2023, 7, 7, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 4, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), 129000m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c9e9de6f-0e6f-4b3e-9f6c-3f8f3a0e6a1d"),
                columns: new[] { "CompletedDate", "CreatedDate", "PaidDate", "ShipDate", "Total" },
                values: new object[] { new DateTime(2023, 7, 7, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 4, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), 232000m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"),
                columns: new[] { "CreatedDate", "Total" },
                values: new object[] { new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), 275000m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"),
                columns: new[] { "CompletedDate", "CreatedDate", "PaidDate", "ShipDate", "Total" },
                values: new object[] { new DateTime(2023, 7, 7, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 3, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 7, 4, 9, 48, 53, 878, DateTimeKind.Local).AddTicks(7100), 1000000m });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1090dcdd-b383-417b-9523-d73f0373fbb0"),
                column: "ConcurrencyStamp",
                value: "eb87083c-b8dc-464f-9643-2569f635ebca");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4a1c9012-a602-46a9-8eba-05e85149fd81"),
                column: "ConcurrencyStamp",
                value: "f702d136-7778-4870-8021-564a91c5dcc2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"),
                column: "ConcurrencyStamp",
                value: "1881e873-8e7e-4254-bf32-1cf0db50a473");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2f00b6e3-2583-4b5f-a92f-9d8f2b8d4d7f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0b8263d-b3eb-4062-8856-f045022083c2", "AQAAAAEAACcQAAAAEJpu0Ycub/myIndl7+u0XoR8ERZ8bKWtYcF2w/MLqPRPeYK4GKZ27U/wXKdKZ1xkOw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b294e1f-c3f7-4f71-9be6-11c614fbdce5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd5c7108-3833-42db-877f-9e3db046cf18", "AQAAAAEAACcQAAAAEGld3kgvve7ufSCwHOl9XZt7J5mYRGXHqmA/zOP/dJMEtUoa3VgIqPSA8lUClcKmYw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d25179e0-bfe5-4e85-8012-f3e3da283835", "AQAAAAEAACcQAAAAEOs4AXwvDHL0Uxn9HgvpWO090ZW8p6MkfLWXn6ljwuSeCf6I/75Zx3bXXHz+fRM0MQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2d98f29-7a98-4d0d-ba21-aa1d88c4e5c2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "76d8047d-cec2-4b7f-9fad-211425c98253", "AQAAAAEAACcQAAAAEKAirGt9QKRbLxeFgdAqUzuoK4+r2DzB7Hq5mtTVfzRHRakh2k1LONcdtVsSHTaHMQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6c75c5f-9d1b-4a0d-9c6d-3e7d3ce2a2a7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f7fa00d2-752d-44c5-bf4c-7a0ddde42a2b", "AQAAAAEAACcQAAAAEM0Th+jriKeMcyL+FiJgxcUpIllVW1Dkvh71GCyaGfZWtQ3IrHuEZWkUWuU4lxq3AA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c2ec6dd4-8170-4b6d-acf4-33d52a128789"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b6d88009-ae8f-40fe-85b6-1a74fa5eb043", "AQAAAAEAACcQAAAAEPXZ68n4MhvLT+Pu9Ch3womw/3KA9OAphXgp6ZdoDCoHzU6AQO5OFVxH8Q6/74n6Lw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e3e4e9f8-cd6d-4299-9d8f-fb5e8ef6d0d5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d4be4b1d-6fd7-4b3c-a0e2-b7d90d5e6f7c", "AQAAAAEAACcQAAAAEGBvhmfm3EkhlVJVD5yhCxeZ1ozTM12yjtNCOlKIMQeuIl1gPEvL6gTh7w0/5Vompw==" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4f31c9cd-6fdf-4d3a-9d8b-6f1d3d5c1c24"),
                columns: new[] { "CreatedDate", "PaidDate", "ShipDate" },
                values: new object[] { new DateTime(2023, 7, 2, 17, 53, 16, 974, DateTimeKind.Local).AddTicks(8068), new DateTime(2023, 7, 2, 17, 53, 16, 974, DateTimeKind.Local).AddTicks(8068), new DateTime(2023, 7, 3, 17, 53, 16, 974, DateTimeKind.Local).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7afa0b0b-1c0d-4bd4-a1e8-9f1a38a5e5ab"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 2, 17, 53, 16, 974, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8fd4f3f5-4f1a-4f23-a2b0-1dbf8e9d7a9c"),
                columns: new[] { "CompletedDate", "CreatedDate", "PaidDate", "ShipDate" },
                values: new object[] { new DateTime(2023, 7, 6, 17, 53, 16, 974, DateTimeKind.Local).AddTicks(8068), new DateTime(2023, 7, 2, 17, 53, 16, 974, DateTimeKind.Local).AddTicks(8068), new DateTime(2023, 7, 2, 17, 53, 16, 974, DateTimeKind.Local).AddTicks(8068), new DateTime(2023, 7, 3, 17, 53, 16, 974, DateTimeKind.Local).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a60b3fd4-40a0-4f4e-8f5b-6e5a9a3d63e6"),
                columns: new[] { "CompletedDate", "CreatedDate", "PaidDate", "ShipDate" },
                values: new object[] { new DateTime(2023, 7, 6, 17, 53, 16, 974, DateTimeKind.Local).AddTicks(8068), new DateTime(2023, 7, 2, 17, 53, 16, 974, DateTimeKind.Local).AddTicks(8068), new DateTime(2023, 7, 2, 17, 53, 16, 974, DateTimeKind.Local).AddTicks(8068), new DateTime(2023, 7, 3, 17, 53, 16, 974, DateTimeKind.Local).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c9e9de6f-0e6f-4b3e-9f6c-3f8f3a0e6a1d"),
                columns: new[] { "CompletedDate", "CreatedDate", "PaidDate", "ShipDate" },
                values: new object[] { new DateTime(2023, 7, 6, 17, 53, 16, 974, DateTimeKind.Local).AddTicks(8068), new DateTime(2023, 7, 2, 17, 53, 16, 974, DateTimeKind.Local).AddTicks(8068), new DateTime(2023, 7, 2, 17, 53, 16, 974, DateTimeKind.Local).AddTicks(8068), new DateTime(2023, 7, 3, 17, 53, 16, 974, DateTimeKind.Local).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e9e8d2a6-0d6c-4e28-9e9c-3d2dd6b3c5af"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 2, 17, 53, 16, 974, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f602aed4-37de-446c-8b4d-d5e407a4bf33"),
                columns: new[] { "CompletedDate", "CreatedDate", "PaidDate", "ShipDate" },
                values: new object[] { new DateTime(2023, 7, 6, 17, 53, 16, 974, DateTimeKind.Local).AddTicks(8068), new DateTime(2023, 7, 2, 17, 53, 16, 974, DateTimeKind.Local).AddTicks(8068), new DateTime(2023, 7, 2, 17, 53, 16, 974, DateTimeKind.Local).AddTicks(8068), new DateTime(2023, 7, 3, 17, 53, 16, 974, DateTimeKind.Local).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("0976ba79-d822-408a-86cb-e05045db09ed"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 2, 17, 53, 16, 963, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("18cd05cb-f995-4b13-9fa4-a9e1f1c43862"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 2, 17, 53, 16, 963, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("28c12878-b191-4d42-974a-7b823de70a06"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 2, 17, 53, 16, 963, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("3643727e-d49c-45f5-bfae-9cd4fbcebb45"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 2, 17, 53, 16, 963, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("423f83df-dc6c-4b41-aa09-2fe30e841aa6"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 2, 17, 53, 16, 963, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("6a008d16-196e-40fe-ada5-2acf339fbede"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 2, 17, 53, 16, 963, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9610c212-5a16-4a70-8703-6bc7f1224be0"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 2, 17, 53, 16, 963, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("9a6ccc00-6b1c-40c5-be61-eb71323c9151"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 2, 17, 53, 16, 963, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("a6767d22-3ea0-4a00-ad31-9dce1d67184e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 2, 17, 53, 16, 963, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("b799297f-d21e-4280-8df9-a3c6788c806e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 2, 17, 53, 16, 963, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("e3acb616-dd2c-44ee-93f0-754c68503b38"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 2, 17, 53, 16, 963, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: new Guid("f1e33f26-6797-43ae-83c5-dabb932a880e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 2, 17, 53, 16, 963, DateTimeKind.Local).AddTicks(2523));
        }
    }
}
