using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class db2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "436e4044-8f43-40f6-97c7-229fba7f8d24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b10a4e42-680c-445a-9bd0-43d7d85b6a07");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09dd181e-f215-4b52-8740-765e633a8bff");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("57f087a0-fbec-41bc-9991-09db340b6ec4"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("8ba4f278-5488-4b52-879c-37dc125c4e1f"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("e3c4dc7c-8a56-4a26-844e-9a473b541b40"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("f72bc682-1b17-404c-8c02-60e15bf1681a"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("f83d0578-ff80-4dd7-b90c-d4165bedf4ed"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("0affc896-89de-49b9-a6fc-a53b53175c58"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("0ba8acac-8dd5-4f8c-ac85-5deaaa6837e2"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("205ad0c9-bc32-4ca2-b3b9-cfce1f7df872"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("41632505-e5fe-440a-a97e-34a93a943c1e"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("7c625b95-34e9-4e82-88ea-0c2862d40685"));

            migrationBuilder.AlterColumn<decimal>(
                name: "MinimumAmount",
                table: "Voucher",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "MaximumAmount",
                table: "Voucher",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "168a8488-8987-4a88-8c19-bc6c85b9dd58", null, "Client", "Client" },
                    { "f9aba027-6d9d-4d0f-8bf2-9268ee7243f6", null, "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f2458623-a48d-47c6-b50b-f1f57f38643d", 0, "332fc48b-2274-4396-8242-607087f56ed4", "IdentityUser", "admin@gmail.com", true, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAENOlWRkjmPkG4NTqWermXIWIVn4oFqNhelScHquyVo3zuMv15bBG0qgnu8sfhPJHTQ==", null, false, "0058309f-0a54-4ec8-a38d-256837cde611", false, "admin" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("62c2d3b6-090b-4dba-9368-ad847ccef82c"), "", new DateTime(2024, 6, 21, 16, 42, 18, 93, DateTimeKind.Local).AddTicks(7826), null, null, "", null, null, "Black", 1 },
                    { new Guid("72c56af7-7a4e-4944-afeb-b16fdb3af328"), "", new DateTime(2024, 6, 21, 16, 42, 18, 93, DateTimeKind.Local).AddTicks(7813), null, null, "", null, null, "White", 1 },
                    { new Guid("b2847f29-34d7-4449-92ae-6baed5900964"), "", new DateTime(2024, 6, 21, 16, 42, 18, 93, DateTimeKind.Local).AddTicks(7849), null, null, "", null, null, "Green", 1 },
                    { new Guid("d569081c-0e58-41d8-aaf2-ef651e87d7b7"), "", new DateTime(2024, 6, 21, 16, 42, 18, 93, DateTimeKind.Local).AddTicks(7847), null, null, "", null, null, "Blue", 1 },
                    { new Guid("eea148a2-f420-47fd-b84a-866c9d33a760"), "", new DateTime(2024, 6, 21, 16, 42, 18, 93, DateTimeKind.Local).AddTicks(7845), null, null, "", null, null, "Red", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("22169530-a992-4608-bb2b-9ed7c6f62b16"), "", new DateTime(2024, 6, 21, 16, 42, 18, 174, DateTimeKind.Local).AddTicks(8978), null, null, "", null, null, "L", 1 },
                    { new Guid("241a2882-bc56-422e-96d2-b2b9202b5e52"), "", new DateTime(2024, 6, 21, 16, 42, 18, 174, DateTimeKind.Local).AddTicks(8950), null, null, "", null, null, "XS", 1 },
                    { new Guid("27944c6e-ae29-4f87-a52a-cb7c6cd03b5f"), "", new DateTime(2024, 6, 21, 16, 42, 18, 174, DateTimeKind.Local).AddTicks(8980), null, null, "", null, null, "XL", 1 },
                    { new Guid("643fc63e-5533-4602-ab04-a370717f7d08"), "", new DateTime(2024, 6, 21, 16, 42, 18, 174, DateTimeKind.Local).AddTicks(8973), null, null, "", null, null, "S", 1 },
                    { new Guid("84f2c96a-ca33-45f7-8463-70139fe87fce"), "", new DateTime(2024, 6, 21, 16, 42, 18, 174, DateTimeKind.Local).AddTicks(8976), null, null, "", null, null, "M", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "168a8488-8987-4a88-8c19-bc6c85b9dd58");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9aba027-6d9d-4d0f-8bf2-9268ee7243f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2458623-a48d-47c6-b50b-f1f57f38643d");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("62c2d3b6-090b-4dba-9368-ad847ccef82c"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("72c56af7-7a4e-4944-afeb-b16fdb3af328"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("b2847f29-34d7-4449-92ae-6baed5900964"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("d569081c-0e58-41d8-aaf2-ef651e87d7b7"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("eea148a2-f420-47fd-b84a-866c9d33a760"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("22169530-a992-4608-bb2b-9ed7c6f62b16"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("241a2882-bc56-422e-96d2-b2b9202b5e52"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("27944c6e-ae29-4f87-a52a-cb7c6cd03b5f"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("643fc63e-5533-4602-ab04-a370717f7d08"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("84f2c96a-ca33-45f7-8463-70139fe87fce"));

            migrationBuilder.DropColumn(
                name: "MaximumAmount",
                table: "Voucher");

            migrationBuilder.AlterColumn<int>(
                name: "MinimumAmount",
                table: "Voucher",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "436e4044-8f43-40f6-97c7-229fba7f8d24", null, "Admin", "Admin" },
                    { "b10a4e42-680c-445a-9bd0-43d7d85b6a07", null, "Client", "Client" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "09dd181e-f215-4b52-8740-765e633a8bff", 0, "ca17858e-c460-4b64-b789-7c1419be21b1", "IdentityUser", "admin@gmail.com", true, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEKSgzjhfMV7Uc646HGj16851YiCwQYhaqeeFp4YfY4j0BpuS1i9aGtLm0cPnCkLang==", null, false, "7e2ee81a-0935-4836-87cf-df878b6ea7a7", false, "admin" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("57f087a0-fbec-41bc-9991-09db340b6ec4"), "", new DateTime(2024, 6, 19, 1, 16, 48, 680, DateTimeKind.Local).AddTicks(4732), null, null, "", null, null, "Blue", 1 },
                    { new Guid("8ba4f278-5488-4b52-879c-37dc125c4e1f"), "", new DateTime(2024, 6, 19, 1, 16, 48, 680, DateTimeKind.Local).AddTicks(4728), null, null, "", null, null, "Black", 1 },
                    { new Guid("e3c4dc7c-8a56-4a26-844e-9a473b541b40"), "", new DateTime(2024, 6, 19, 1, 16, 48, 680, DateTimeKind.Local).AddTicks(4734), null, null, "", null, null, "Green", 1 },
                    { new Guid("f72bc682-1b17-404c-8c02-60e15bf1681a"), "", new DateTime(2024, 6, 19, 1, 16, 48, 680, DateTimeKind.Local).AddTicks(4708), null, null, "", null, null, "White", 1 },
                    { new Guid("f83d0578-ff80-4dd7-b90c-d4165bedf4ed"), "", new DateTime(2024, 6, 19, 1, 16, 48, 680, DateTimeKind.Local).AddTicks(4730), null, null, "", null, null, "Red", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("0affc896-89de-49b9-a6fc-a53b53175c58"), "", new DateTime(2024, 6, 19, 1, 16, 48, 781, DateTimeKind.Local).AddTicks(5566), null, null, "", null, null, "XL", 1 },
                    { new Guid("0ba8acac-8dd5-4f8c-ac85-5deaaa6837e2"), "", new DateTime(2024, 6, 19, 1, 16, 48, 781, DateTimeKind.Local).AddTicks(5564), null, null, "", null, null, "L", 1 },
                    { new Guid("205ad0c9-bc32-4ca2-b3b9-cfce1f7df872"), "", new DateTime(2024, 6, 19, 1, 16, 48, 781, DateTimeKind.Local).AddTicks(5532), null, null, "", null, null, "XS", 1 },
                    { new Guid("41632505-e5fe-440a-a97e-34a93a943c1e"), "", new DateTime(2024, 6, 19, 1, 16, 48, 781, DateTimeKind.Local).AddTicks(5554), null, null, "", null, null, "S", 1 },
                    { new Guid("7c625b95-34e9-4e82-88ea-0c2862d40685"), "", new DateTime(2024, 6, 19, 1, 16, 48, 781, DateTimeKind.Local).AddTicks(5556), null, null, "", null, null, "M", 1 }
                });
        }
    }
}
