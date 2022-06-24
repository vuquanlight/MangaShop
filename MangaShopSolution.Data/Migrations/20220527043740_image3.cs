using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaShopSolution.Data.Migrations
{
    public partial class image3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3741), "/images/choper.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Caption", "DateCreated", "FileSize", "ImagePath", "IsDefault", "ProductId", "SortOrder" },
                values: new object[,]
                {
                    { 2, null, new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3744), 0L, "/images/kid.jpg", true, 2, 0 },
                    { 3, null, new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3745), 0L, "/images/aokiji.jpeg", true, 3, 0 },
                    { 4, null, new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3747), 0L, "/images/akainu.jpg", true, 4, 0 },
                    { 5, null, new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3748), 0L, "/images/kizaru.jpg", true, 5, 0 },
                    { 6, null, new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3749), 0L, "/images/sengoku.jpg", true, 6, 0 },
                    { 7, null, new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3750), 0L, "/images/ace.jpg", true, 7, 0 },
                    { 8, null, new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3751), 0L, "/images/nami.jpg", true, 8, 0 },
                    { 9, null, new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3752), 0L, "/images/robin.jpg", true, 9, 0 },
                    { 10, null, new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3753), 0L, "/images/luffy.jpg", true, 10, 0 },
                    { 11, null, new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3754), 0L, "/images/zoro.jpg", true, 11, 0 },
                    { 12, null, new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3755), 0L, "/images/mihawk.jpg", true, 12, 0 },
                    { 13, null, new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3756), 0L, "/images/wano.jpg", true, 13, 0 },
                    { 14, null, new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3757), 0L, "/images/shira.jpg", true, 14, 0 },
                    { 15, null, new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3758), 0L, "/images/white shirt.jpg", true, 15, 0 },
                    { 16, null, new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3759), 0L, "/images/garrison reginment.jpg", true, 16, 0 },
                    { 17, null, new DateTime(2022, 5, 27, 11, 37, 39, 969, DateTimeKind.Local).AddTicks(3760), 0L, "/images/militarypolice.png", true, 17, 0 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "3c451330-0c52-4d34-8fd9-87d4e6ceedd0");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a979ac10-7172-43de-a7fb-3e96f2c5fd8e", "AQAAAAEAACcQAAAAELY4rXtfTYmSAV8X8iCenQgbhiAPdaA2hOoXV8WRWNcSA5Rm6N0gFRSaZINn+LdJDQ==" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2022, 5, 27, 10, 36, 53, 306, DateTimeKind.Local).AddTicks(2770), "/images/eyegigabyte.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 10, 36, 53, 306, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 10, 36, 53, 306, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 10, 36, 53, 306, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 10, 36, 53, 306, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 10, 36, 53, 306, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 10, 36, 53, 306, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 10, 36, 53, 306, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 10, 36, 53, 306, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 10, 36, 53, 306, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 10, 36, 53, 306, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 10, 36, 53, 306, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 10, 36, 53, 306, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 10, 36, 53, 306, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 10, 36, 53, 306, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 10, 36, 53, 306, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 10, 36, 53, 306, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 10, 36, 53, 306, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 10, 36, 53, 306, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 10, 36, 53, 306, DateTimeKind.Local).AddTicks(2702));
        }
    }
}
