using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class hiendb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f4b80ac-76a6-439f-8383-41bd2b2bcce3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "572e7a96-31b1-47e4-bfe4-4c39cc64093f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cbeee9-955e-4eb6-b2b8-175e00bbf816");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("1f37c7e4-cf2a-429e-9ece-3582e5de4925"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("6bd18460-d9a9-4460-8186-6585f0862de6"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("7629733a-8948-488b-9470-3fbef56953fe"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("955f1fee-2a74-411c-90a4-48a0f3ed2725"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("aea41cf5-2c2a-4a36-afcd-fff97557ac07"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("3c12dd80-41c3-43c6-8fe3-8876b71f9b0e"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("3f3b8ff6-b09f-4fa7-99b7-443560cccdc6"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("42bef149-9038-4ea1-8dd2-106905cb63b0"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("a101bb14-f520-4c30-9345-c564f0fe8ec7"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("b98c755f-13b8-4115-9a07-8da3cfaa4cfb"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2dfffd8a-e07e-4fbd-8d93-28758a9e087b", null, "Client", "Client" },
                    { "bb47b2ee-2da2-4065-b9f1-dfcc0399a8c3", null, "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "014491a8-619f-441c-89f5-defdf5c2b65c", 0, "eaabed03-6400-47c6-bd13-cf84276e3631", "IdentityUser", "admin@gmail.com", true, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEOmIEiboPE3QR7CZjYQhMpA4padXzNFuTw3ftjNpV86hsCPnhNtP4m1ON2BG+T/5tw==", null, false, "154a0578-ddc9-4b35-89bf-8f7f6cb26494", false, "admin" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("60c5e576-b456-4f60-b82f-7b27d4915e7f"), "", new DateTime(2024, 6, 16, 23, 33, 14, 282, DateTimeKind.Local).AddTicks(3642), null, null, "", null, null, "Green", 1 },
                    { new Guid("6c83abf3-4c12-4aeb-85cb-c3e228309ae1"), "", new DateTime(2024, 6, 16, 23, 33, 14, 282, DateTimeKind.Local).AddTicks(3639), null, null, "", null, null, "Red", 1 },
                    { new Guid("b1e17a93-7c15-4a04-947b-cb027619dede"), "", new DateTime(2024, 6, 16, 23, 33, 14, 282, DateTimeKind.Local).AddTicks(3611), null, null, "", null, null, "White", 1 },
                    { new Guid("dd1174c8-5b89-4180-825a-ec47ad1b071a"), "", new DateTime(2024, 6, 16, 23, 33, 14, 282, DateTimeKind.Local).AddTicks(3640), null, null, "", null, null, "Blue", 1 },
                    { new Guid("e95cce0d-c307-4a25-ad84-bd0aca62a307"), "", new DateTime(2024, 6, 16, 23, 33, 14, 282, DateTimeKind.Local).AddTicks(3637), null, null, "", null, null, "Black", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("158ce9ba-ad5f-4d21-82d5-314679c21d37"), "", new DateTime(2024, 6, 16, 23, 33, 14, 349, DateTimeKind.Local).AddTicks(3186), null, null, "", null, null, "S", 1 },
                    { new Guid("22698ece-c801-46e2-bc77-b8a4b5ab9661"), "", new DateTime(2024, 6, 16, 23, 33, 14, 349, DateTimeKind.Local).AddTicks(3188), null, null, "", null, null, "M", 1 },
                    { new Guid("bb4c8c7f-7c3f-442e-96c2-0ee133e3d113"), "", new DateTime(2024, 6, 16, 23, 33, 14, 349, DateTimeKind.Local).AddTicks(3209), null, null, "", null, null, "XL", 1 },
                    { new Guid("d87fb8e2-c55f-4aa3-8a4b-b8641fa3efb5"), "", new DateTime(2024, 6, 16, 23, 33, 14, 349, DateTimeKind.Local).AddTicks(3163), null, null, "", null, null, "XS", 1 },
                    { new Guid("f71c2f67-d354-4044-8586-57c435f7fa3d"), "", new DateTime(2024, 6, 16, 23, 33, 14, 349, DateTimeKind.Local).AddTicks(3192), null, null, "", null, null, "L", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2dfffd8a-e07e-4fbd-8d93-28758a9e087b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb47b2ee-2da2-4065-b9f1-dfcc0399a8c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "014491a8-619f-441c-89f5-defdf5c2b65c");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("60c5e576-b456-4f60-b82f-7b27d4915e7f"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("6c83abf3-4c12-4aeb-85cb-c3e228309ae1"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("b1e17a93-7c15-4a04-947b-cb027619dede"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("dd1174c8-5b89-4180-825a-ec47ad1b071a"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("e95cce0d-c307-4a25-ad84-bd0aca62a307"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("158ce9ba-ad5f-4d21-82d5-314679c21d37"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("22698ece-c801-46e2-bc77-b8a4b5ab9661"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("bb4c8c7f-7c3f-442e-96c2-0ee133e3d113"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("d87fb8e2-c55f-4aa3-8a4b-b8641fa3efb5"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("f71c2f67-d354-4044-8586-57c435f7fa3d"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f4b80ac-76a6-439f-8383-41bd2b2bcce3", null, "Admin", "Admin" },
                    { "572e7a96-31b1-47e4-bfe4-4c39cc64093f", null, "Client", "Client" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a7cbeee9-955e-4eb6-b2b8-175e00bbf816", 0, "71363b1e-4550-4b38-b4e6-d6f847973326", "IdentityUser", "admin@gmail.com", true, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAENh8Qf4jbc4VVZRhsQfaZz0zuHMbbdCqKAjwtsjW/1h5HM7auG2T3tsCW5cz3E28qQ==", null, false, "492fe997-1b3a-426f-a0d4-a89045bfdb54", false, "admin" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("1f37c7e4-cf2a-429e-9ece-3582e5de4925"), "", new DateTime(2024, 6, 16, 23, 30, 33, 785, DateTimeKind.Local).AddTicks(3713), null, null, "", null, null, "Black", 1 },
                    { new Guid("6bd18460-d9a9-4460-8186-6585f0862de6"), "", new DateTime(2024, 6, 16, 23, 30, 33, 785, DateTimeKind.Local).AddTicks(3684), null, null, "", null, null, "White", 1 },
                    { new Guid("7629733a-8948-488b-9470-3fbef56953fe"), "", new DateTime(2024, 6, 16, 23, 30, 33, 785, DateTimeKind.Local).AddTicks(3718), null, null, "", null, null, "Blue", 1 },
                    { new Guid("955f1fee-2a74-411c-90a4-48a0f3ed2725"), "", new DateTime(2024, 6, 16, 23, 30, 33, 785, DateTimeKind.Local).AddTicks(3749), null, null, "", null, null, "Green", 1 },
                    { new Guid("aea41cf5-2c2a-4a36-afcd-fff97557ac07"), "", new DateTime(2024, 6, 16, 23, 30, 33, 785, DateTimeKind.Local).AddTicks(3716), null, null, "", null, null, "Red", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("3c12dd80-41c3-43c6-8fe3-8876b71f9b0e"), "", new DateTime(2024, 6, 16, 23, 30, 33, 835, DateTimeKind.Local).AddTicks(2387), null, null, "", null, null, "L", 1 },
                    { new Guid("3f3b8ff6-b09f-4fa7-99b7-443560cccdc6"), "", new DateTime(2024, 6, 16, 23, 30, 33, 835, DateTimeKind.Local).AddTicks(2384), null, null, "", null, null, "M", 1 },
                    { new Guid("42bef149-9038-4ea1-8dd2-106905cb63b0"), "", new DateTime(2024, 6, 16, 23, 30, 33, 835, DateTimeKind.Local).AddTicks(2360), null, null, "", null, null, "XS", 1 },
                    { new Guid("a101bb14-f520-4c30-9345-c564f0fe8ec7"), "", new DateTime(2024, 6, 16, 23, 30, 33, 835, DateTimeKind.Local).AddTicks(2381), null, null, "", null, null, "S", 1 },
                    { new Guid("b98c755f-13b8-4115-9a07-8da3cfaa4cfb"), "", new DateTime(2024, 6, 16, 23, 30, 33, 835, DateTimeKind.Local).AddTicks(2389), null, null, "", null, null, "XL", 1 }
                });
        }
    }
}
