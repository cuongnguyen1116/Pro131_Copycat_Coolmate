using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shop.Data.Migrations;

public partial class sizeSortorder : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<int>(
            name: "SortOrder",
            table: "Sizes",
            type: "int",
            nullable: false,
            defaultValue: 0);

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

        migrationBuilder.UpdateData(
            table: "ProductDetails",
            keyColumn: "Id",
            keyValue: new Guid("0a3dcb7c-884d-4a05-a5dd-a1d5df404dff"),
            column: "CreatedDate",
            value: new DateTime(2023, 6, 30, 14, 30, 47, 442, DateTimeKind.Local).AddTicks(1309));

        migrationBuilder.UpdateData(
            table: "ProductDetails",
            keyColumn: "Id",
            keyValue: new Guid("231e0060-c281-4c8d-b5c2-791edfa5a680"),
            column: "CreatedDate",
            value: new DateTime(2023, 6, 30, 14, 30, 47, 442, DateTimeKind.Local).AddTicks(1311));

        migrationBuilder.UpdateData(
            table: "ProductDetails",
            keyColumn: "Id",
            keyValue: new Guid("aa06827c-df06-4a43-94d2-75bba02d9da6"),
            column: "CreatedDate",
            value: new DateTime(2023, 6, 30, 14, 30, 47, 442, DateTimeKind.Local).AddTicks(1312));

        migrationBuilder.UpdateData(
            table: "ProductDetails",
            keyColumn: "Id",
            keyValue: new Guid("fb684bf0-020f-4607-8e79-b3aa9bd005a5"),
            column: "CreatedDate",
            value: new DateTime(2023, 6, 30, 14, 30, 47, 442, DateTimeKind.Local).AddTicks(1292));

        migrationBuilder.UpdateData(
            table: "Sizes",
            keyColumn: "Id",
            keyValue: new Guid("190d7f43-6bde-4d74-a58b-e50b22b35751"),
            column: "SortOrder",
            value: 4);

        migrationBuilder.UpdateData(
            table: "Sizes",
            keyColumn: "Id",
            keyValue: new Guid("3cb61050-1fe6-4f5c-94a2-4db93e69c7ba"),
            column: "SortOrder",
            value: 3);

        migrationBuilder.UpdateData(
            table: "Sizes",
            keyColumn: "Id",
            keyValue: new Guid("573566fb-4e8c-4dad-bb2c-b2d9a597d9f7"),
            column: "SortOrder",
            value: 1);

        migrationBuilder.UpdateData(
            table: "Sizes",
            keyColumn: "Id",
            keyValue: new Guid("966f5bf6-a0a7-4d88-a700-728eb8e32c85"),
            column: "SortOrder",
            value: 2);

        migrationBuilder.UpdateData(
            table: "Sizes",
            keyColumn: "Id",
            keyValue: new Guid("aa66fbee-a9d6-4bb5-8ed8-b329d394221f"),
            column: "SortOrder",
            value: 6);

        migrationBuilder.UpdateData(
            table: "Sizes",
            keyColumn: "Id",
            keyValue: new Guid("f6a1a967-7487-463b-9d7b-09aebf15d304"),
            column: "SortOrder",
            value: 5);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "SortOrder",
            table: "Sizes");

        migrationBuilder.UpdateData(
            table: "AppRoles",
            keyColumn: "Id",
            keyValue: new Guid("1090dcdd-b383-417b-9523-d73f0373fbb0"),
            column: "ConcurrencyStamp",
            value: "5e79a726-37df-4d7d-92c4-f7c648a73929");

        migrationBuilder.UpdateData(
            table: "AppRoles",
            keyColumn: "Id",
            keyValue: new Guid("4a1c9012-a602-46a9-8eba-05e85149fd81"),
            column: "ConcurrencyStamp",
            value: "4ea215d3-735f-4ba6-9069-717405c46ca2");

        migrationBuilder.UpdateData(
            table: "AppRoles",
            keyColumn: "Id",
            keyValue: new Guid("66d310d2-f7e1-4aab-8003-4370144e3f8d"),
            column: "ConcurrencyStamp",
            value: "3de0894f-0671-4371-8f13-e3b0c6f4adac");

        migrationBuilder.UpdateData(
            table: "AppUsers",
            keyColumn: "Id",
            keyValue: new Guid("3b294e1f-c3f7-4f71-9be6-11c614fbdce5"),
            columns: new[] { "ConcurrencyStamp", "PasswordHash" },
            values: new object[] { "bfa42845-ba7f-49c2-af9b-866ea78fc80d", "AQAAAAEAACcQAAAAEIN/AxWyhiC3ndrM85YTvRVfHgD3qZOWSUjBMbHSCFbgwjo9bs8SIWFzuLdXFpiEEQ==" });

        migrationBuilder.UpdateData(
            table: "AppUsers",
            keyColumn: "Id",
            keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
            columns: new[] { "ConcurrencyStamp", "PasswordHash" },
            values: new object[] { "434b8f3e-08c5-41d5-a871-3d9041a61857", "AQAAAAEAACcQAAAAEGL0cXAyy6ATFpJArRJGi+IYV1PeDlimjo0eXROs/NvD2G1UbEOyMiuo0Rg/uHzvbA==" });

        migrationBuilder.UpdateData(
            table: "AppUsers",
            keyColumn: "Id",
            keyValue: new Guid("c2ec6dd4-8170-4b6d-acf4-33d52a128789"),
            columns: new[] { "ConcurrencyStamp", "PasswordHash" },
            values: new object[] { "816757f1-8716-4331-8fb6-571472970af1", "AQAAAAEAACcQAAAAEIueg1exQLNA3SOTrMjG976lTH83BXFZwzqjRcKZve88j6RuaZ17/C2Tjnl4i+GmAQ==" });

        migrationBuilder.UpdateData(
            table: "ProductDetails",
            keyColumn: "Id",
            keyValue: new Guid("0a3dcb7c-884d-4a05-a5dd-a1d5df404dff"),
            column: "CreatedDate",
            value: new DateTime(2023, 6, 30, 14, 23, 52, 410, DateTimeKind.Local).AddTicks(9693));

        migrationBuilder.UpdateData(
            table: "ProductDetails",
            keyColumn: "Id",
            keyValue: new Guid("231e0060-c281-4c8d-b5c2-791edfa5a680"),
            column: "CreatedDate",
            value: new DateTime(2023, 6, 30, 14, 23, 52, 410, DateTimeKind.Local).AddTicks(9695));

        migrationBuilder.UpdateData(
            table: "ProductDetails",
            keyColumn: "Id",
            keyValue: new Guid("aa06827c-df06-4a43-94d2-75bba02d9da6"),
            column: "CreatedDate",
            value: new DateTime(2023, 6, 30, 14, 23, 52, 410, DateTimeKind.Local).AddTicks(9696));

        migrationBuilder.UpdateData(
            table: "ProductDetails",
            keyColumn: "Id",
            keyValue: new Guid("fb684bf0-020f-4607-8e79-b3aa9bd005a5"),
            column: "CreatedDate",
            value: new DateTime(2023, 6, 30, 14, 23, 52, 410, DateTimeKind.Local).AddTicks(9681));
    }
}
