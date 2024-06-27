using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class db_112 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f439f03-356a-4766-a33f-2ea9a6454556");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b9e33f7-f8f2-4c78-b05a-275af1132924");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6c54abc-1df9-4050-845d-0bf261f377c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ef4bdbe-45e2-42fa-b053-d426e43fe41a");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("4f6443b2-1f7a-4248-8a30-c2f035aedafa"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("595a3c1d-0ae8-444f-b66c-a145b2871662"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("8ebb6dc3-8ee4-4e7f-93a0-18e338d50af4"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("d300fdcf-d629-4678-bb2b-7b0a5df711e0"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("ddd9658f-a064-4c0f-a062-7cefe70fc5cc"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("2c76ffef-7ab6-4737-ae9a-2886784b674d"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("3ef627c2-c833-4117-9a16-3c13196a969a"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("50c55166-9cd6-4ac1-8ab4-6754b7ca17bc"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("b2a71268-9d03-4064-82f9-87fbcf58a623"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("c06c7c9e-1f7e-4a38-80cf-0dd554f0efa0"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "22e0099b-2148-4f88-a5b6-a85bb23df3cc", null, "Client", "Client" },
                    { "27bbb44c-4820-4ff3-ab4a-5177323fb6ad", null, "Admin", "Admin" },
                    { "d1984c6f-2d80-4e04-9d43-87bcc26c0bb2", null, "Staff", "Staff" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "275be6a3-0a12-427f-9295-5f742a697365", 0, "537edb43-7a1d-4e08-8420-b93c6d779bf7", "IdentityUser", "admin@gmail.com", true, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEFwDSCZbiipKRLl9dW+hP0n4M5SwRquUNY6dB5npPYzJHwGxMzEf3gGgffVoxv9FoA==", null, false, "ec2eac82-fa8b-4b6f-8eeb-2470f87764fc", false, "admin" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("082ea4e2-c322-4e55-881d-b979c708a234"), "", new DateTime(2024, 6, 26, 22, 30, 7, 276, DateTimeKind.Local).AddTicks(5127), null, null, "", null, null, "Black", 1 },
                    { new Guid("607bc903-0eb6-4b9d-a977-89e1026d83ef"), "", new DateTime(2024, 6, 26, 22, 30, 7, 276, DateTimeKind.Local).AddTicks(5145), null, null, "", null, null, "Red", 1 },
                    { new Guid("61ff1dc2-ad36-464e-b83b-e3d5792747c6"), "", new DateTime(2024, 6, 26, 22, 30, 7, 276, DateTimeKind.Local).AddTicks(5105), null, null, "", null, null, "White", 1 },
                    { new Guid("7c3fc458-59bc-483c-97a4-47f7e7422167"), "", new DateTime(2024, 6, 26, 22, 30, 7, 276, DateTimeKind.Local).AddTicks(5148), null, null, "", null, null, "Blue", 1 },
                    { new Guid("7dd6bf48-01dc-4953-b0c8-8f6e30f4fbae"), "", new DateTime(2024, 6, 26, 22, 30, 7, 276, DateTimeKind.Local).AddTicks(5150), null, null, "", null, null, "Green", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("12eda5bb-d005-4596-af2c-1a84b6fac084"), "", new DateTime(2024, 6, 26, 22, 30, 7, 352, DateTimeKind.Local).AddTicks(6833), null, null, "", null, null, "XL", 1 },
                    { new Guid("404cf539-19a9-4158-929c-2f31d8cfd5e7"), "", new DateTime(2024, 6, 26, 22, 30, 7, 352, DateTimeKind.Local).AddTicks(6792), null, null, "", null, null, "XS", 1 },
                    { new Guid("755f0678-59f5-4ec5-ae7a-9af210add030"), "", new DateTime(2024, 6, 26, 22, 30, 7, 352, DateTimeKind.Local).AddTicks(6831), null, null, "", null, null, "L", 1 },
                    { new Guid("8b0adbd9-b238-49ae-920b-e5d909e15cea"), "", new DateTime(2024, 6, 26, 22, 30, 7, 352, DateTimeKind.Local).AddTicks(6817), null, null, "", null, null, "S", 1 },
                    { new Guid("90ae846e-75ef-4baf-a8df-bfc93a38acf2"), "", new DateTime(2024, 6, 26, 22, 30, 7, 352, DateTimeKind.Local).AddTicks(6829), null, null, "", null, null, "M", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22e0099b-2148-4f88-a5b6-a85bb23df3cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27bbb44c-4820-4ff3-ab4a-5177323fb6ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1984c6f-2d80-4e04-9d43-87bcc26c0bb2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "275be6a3-0a12-427f-9295-5f742a697365");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("082ea4e2-c322-4e55-881d-b979c708a234"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("607bc903-0eb6-4b9d-a977-89e1026d83ef"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("61ff1dc2-ad36-464e-b83b-e3d5792747c6"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("7c3fc458-59bc-483c-97a4-47f7e7422167"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("7dd6bf48-01dc-4953-b0c8-8f6e30f4fbae"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("12eda5bb-d005-4596-af2c-1a84b6fac084"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("404cf539-19a9-4158-929c-2f31d8cfd5e7"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("755f0678-59f5-4ec5-ae7a-9af210add030"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("8b0adbd9-b238-49ae-920b-e5d909e15cea"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("90ae846e-75ef-4baf-a8df-bfc93a38acf2"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f439f03-356a-4766-a33f-2ea9a6454556", null, "Client", "Client" },
                    { "8b9e33f7-f8f2-4c78-b05a-275af1132924", null, "Admin", "Admin" },
                    { "e6c54abc-1df9-4050-845d-0bf261f377c6", null, "Staff", "Staff" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1ef4bdbe-45e2-42fa-b053-d426e43fe41a", 0, "91e8b2c3-45ff-47c4-bf32-71db11f28eff", "IdentityUser", "admin@gmail.com", true, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAECzKRAKGD7kzL2/nuYOsKEZRB+rNV5DLK90hTiweqiCLt7/ycuOg47eumb5cV+zIHw==", null, false, "fc418a2a-8711-4789-91ab-adaa33712534", false, "admin" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("4f6443b2-1f7a-4248-8a30-c2f035aedafa"), "", new DateTime(2024, 6, 26, 22, 25, 46, 169, DateTimeKind.Local).AddTicks(1882), null, null, "", null, null, "Red", 1 },
                    { new Guid("595a3c1d-0ae8-444f-b66c-a145b2871662"), "", new DateTime(2024, 6, 26, 22, 25, 46, 169, DateTimeKind.Local).AddTicks(1885), null, null, "", null, null, "Green", 1 },
                    { new Guid("8ebb6dc3-8ee4-4e7f-93a0-18e338d50af4"), "", new DateTime(2024, 6, 26, 22, 25, 46, 169, DateTimeKind.Local).AddTicks(1862), null, null, "", null, null, "White", 1 },
                    { new Guid("d300fdcf-d629-4678-bb2b-7b0a5df711e0"), "", new DateTime(2024, 6, 26, 22, 25, 46, 169, DateTimeKind.Local).AddTicks(1883), null, null, "", null, null, "Blue", 1 },
                    { new Guid("ddd9658f-a064-4c0f-a062-7cefe70fc5cc"), "", new DateTime(2024, 6, 26, 22, 25, 46, 169, DateTimeKind.Local).AddTicks(1880), null, null, "", null, null, "Black", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("2c76ffef-7ab6-4737-ae9a-2886784b674d"), "", new DateTime(2024, 6, 26, 22, 25, 46, 227, DateTimeKind.Local).AddTicks(6051), null, null, "", null, null, "XL", 1 },
                    { new Guid("3ef627c2-c833-4117-9a16-3c13196a969a"), "", new DateTime(2024, 6, 26, 22, 25, 46, 227, DateTimeKind.Local).AddTicks(6049), null, null, "", null, null, "L", 1 },
                    { new Guid("50c55166-9cd6-4ac1-8ab4-6754b7ca17bc"), "", new DateTime(2024, 6, 26, 22, 25, 46, 227, DateTimeKind.Local).AddTicks(6022), null, null, "", null, null, "XS", 1 },
                    { new Guid("b2a71268-9d03-4064-82f9-87fbcf58a623"), "", new DateTime(2024, 6, 26, 22, 25, 46, 227, DateTimeKind.Local).AddTicks(6044), null, null, "", null, null, "S", 1 },
                    { new Guid("c06c7c9e-1f7e-4a38-80cf-0dd554f0efa0"), "", new DateTime(2024, 6, 26, 22, 25, 46, 227, DateTimeKind.Local).AddTicks(6047), null, null, "", null, null, "M", 1 }
                });
        }
    }
}
