using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaShopSolution.Data.Migrations
{
    public partial class image4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "2575df01-fd4c-43c8-b8db-64a28a6a883f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c458ee68-6ce8-47f1-801a-3a209e523efc", "AQAAAAEAACcQAAAAEEnnJwGp7o1qHFZkN83riIbzgGfzCORZSr3FwOsxpsg0CTO7QQLeGfIwoEkKvn8uDA==" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5630), "/images/wano.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5632), "/images/white shirt.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5635), "/images/military police.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 41, 10, 647, DateTimeKind.Local).AddTicks(5547));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "376f9e2f-5555-4158-b259-1ef760277524");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a4307c9-6114-4b1e-bca2-1d274af1f909", "AQAAAAEAACcQAAAAECL69LrxlZ1IE1Z7Wh0oUnN+370zqVV0w2++yYcGxCPB2fqMra+OsgEO7DLL2POB6Q==" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3756), "/images/wano.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3758), "/images/white shirt.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3760), "/images/militarypolice.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3663));
        }
    }
}
