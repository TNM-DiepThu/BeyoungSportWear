using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class update_12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34f0f7ca-ed8a-4a20-a86e-3b8386174b39");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afe2f0fb-11fd-450e-9136-0da868ec84c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d1668d7-086c-477c-8378-3af95308e918");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("39619a8a-6e65-4a6b-a275-c374e644adf3"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("7dd5a7e1-d64a-4926-9813-eb672be18ac2"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("817498ac-44f0-497c-953f-eee3e26a5bb3"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("b49ff806-69e7-4789-9fae-c1ee8363fd63"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("b72c375b-9b37-4c07-879b-e60873ed2e90"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("409a25eb-9c44-49d4-a2b3-5d22d0914f22"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("541e112f-4aee-48e1-b089-15f197545862"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("7b8a9308-592f-4d16-8e3b-f45900da9ff7"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("b526e1d5-81eb-416f-8a20-495a44541064"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("c03356f5-a334-4bec-b6aa-d1500ccfd53a"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6bb7bd12-c196-4762-aa2f-565d46744ccf", null, "Client", "Client" },
                    { "de69c655-a092-4dee-b4b8-d64eee72198e", null, "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bfa7323f-9d65-4fd3-95aa-1685e22ba653", 0, "964174cf-c72d-4933-a4d1-a462bbbcf125", "IdentityUser", "admin@gmail.com", true, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEIHhvfbvqpfernlwRHAq5qqaiUw2So5FpYOCoy0VsX6ZjflDfyCFaOjfn8PMrXGU6Q==", null, false, "e53bdb75-8c63-4102-9499-cd4e01aa3417", false, "admin" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("28a7a11d-93bd-45ef-8c77-95af3a2dad3d"), "", new DateTime(2024, 6, 23, 0, 9, 42, 384, DateTimeKind.Local).AddTicks(1644), null, null, "", null, null, "Red", 1 },
                    { new Guid("c0e8815a-2272-4024-807b-b9facb5747ce"), "", new DateTime(2024, 6, 23, 0, 9, 42, 384, DateTimeKind.Local).AddTicks(1646), null, null, "", null, null, "Blue", 1 },
                    { new Guid("db03ca95-c26d-4453-8e03-5872c479248b"), "", new DateTime(2024, 6, 23, 0, 9, 42, 384, DateTimeKind.Local).AddTicks(1624), null, null, "", null, null, "White", 1 },
                    { new Guid("fb388775-e07d-4bd8-912d-83d6c036acd1"), "", new DateTime(2024, 6, 23, 0, 9, 42, 384, DateTimeKind.Local).AddTicks(1648), null, null, "", null, null, "Green", 1 },
                    { new Guid("fec46e82-9948-46c2-b565-61e4aa678760"), "", new DateTime(2024, 6, 23, 0, 9, 42, 384, DateTimeKind.Local).AddTicks(1642), null, null, "", null, null, "Black", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("06b19cfa-b3d1-4269-b57d-f4ec9aca1975"), "", new DateTime(2024, 6, 23, 0, 9, 42, 438, DateTimeKind.Local).AddTicks(7029), null, null, "", null, null, "L", 1 },
                    { new Guid("19e4efec-95d4-45b7-9452-38e515f03648"), "", new DateTime(2024, 6, 23, 0, 9, 42, 438, DateTimeKind.Local).AddTicks(7025), null, null, "", null, null, "S", 1 },
                    { new Guid("7e7eb40a-a0df-4b07-8054-2867483a40fd"), "", new DateTime(2024, 6, 23, 0, 9, 42, 438, DateTimeKind.Local).AddTicks(7027), null, null, "", null, null, "M", 1 },
                    { new Guid("b75d038f-c495-4e85-bc50-b04578d3e509"), "", new DateTime(2024, 6, 23, 0, 9, 42, 438, DateTimeKind.Local).AddTicks(7032), null, null, "", null, null, "XL", 1 },
                    { new Guid("e6f1600b-1c32-42ea-91f9-f4265095e257"), "", new DateTime(2024, 6, 23, 0, 9, 42, 438, DateTimeKind.Local).AddTicks(7002), null, null, "", null, null, "XS", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bb7bd12-c196-4762-aa2f-565d46744ccf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de69c655-a092-4dee-b4b8-d64eee72198e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bfa7323f-9d65-4fd3-95aa-1685e22ba653");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("28a7a11d-93bd-45ef-8c77-95af3a2dad3d"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("c0e8815a-2272-4024-807b-b9facb5747ce"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("db03ca95-c26d-4453-8e03-5872c479248b"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("fb388775-e07d-4bd8-912d-83d6c036acd1"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("fec46e82-9948-46c2-b565-61e4aa678760"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("06b19cfa-b3d1-4269-b57d-f4ec9aca1975"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("19e4efec-95d4-45b7-9452-38e515f03648"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("7e7eb40a-a0df-4b07-8054-2867483a40fd"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("b75d038f-c495-4e85-bc50-b04578d3e509"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("e6f1600b-1c32-42ea-91f9-f4265095e257"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "34f0f7ca-ed8a-4a20-a86e-3b8386174b39", null, "Client", "Client" },
                    { "afe2f0fb-11fd-450e-9136-0da868ec84c6", null, "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9d1668d7-086c-477c-8378-3af95308e918", 0, "108f7201-160c-41c1-a6f3-46113266f308", "IdentityUser", "admin@gmail.com", true, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEOlAn+LMR3IiXCkxtk8TxG+qIwS74Od8Ilr2taDDaeDMTwnnrzWW18kLQUWrk4Rw2g==", null, false, "43734043-9f39-47ff-90ae-591e69b0c910", false, "admin" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("39619a8a-6e65-4a6b-a275-c374e644adf3"), "", new DateTime(2024, 6, 23, 0, 4, 41, 392, DateTimeKind.Local).AddTicks(7764), null, null, "", null, null, "Green", 1 },
                    { new Guid("7dd5a7e1-d64a-4926-9813-eb672be18ac2"), "", new DateTime(2024, 6, 23, 0, 4, 41, 392, DateTimeKind.Local).AddTicks(7763), null, null, "", null, null, "Blue", 1 },
                    { new Guid("817498ac-44f0-497c-953f-eee3e26a5bb3"), "", new DateTime(2024, 6, 23, 0, 4, 41, 392, DateTimeKind.Local).AddTicks(7759), null, null, "", null, null, "Black", 1 },
                    { new Guid("b49ff806-69e7-4789-9fae-c1ee8363fd63"), "", new DateTime(2024, 6, 23, 0, 4, 41, 392, DateTimeKind.Local).AddTicks(7761), null, null, "", null, null, "Red", 1 },
                    { new Guid("b72c375b-9b37-4c07-879b-e60873ed2e90"), "", new DateTime(2024, 6, 23, 0, 4, 41, 392, DateTimeKind.Local).AddTicks(7743), null, null, "", null, null, "White", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("409a25eb-9c44-49d4-a2b3-5d22d0914f22"), "", new DateTime(2024, 6, 23, 0, 4, 41, 460, DateTimeKind.Local).AddTicks(5335), null, null, "", null, null, "L", 1 },
                    { new Guid("541e112f-4aee-48e1-b089-15f197545862"), "", new DateTime(2024, 6, 23, 0, 4, 41, 460, DateTimeKind.Local).AddTicks(5356), null, null, "", null, null, "XL", 1 },
                    { new Guid("7b8a9308-592f-4d16-8e3b-f45900da9ff7"), "", new DateTime(2024, 6, 23, 0, 4, 41, 460, DateTimeKind.Local).AddTicks(5301), null, null, "", null, null, "XS", 1 },
                    { new Guid("b526e1d5-81eb-416f-8a20-495a44541064"), "", new DateTime(2024, 6, 23, 0, 4, 41, 460, DateTimeKind.Local).AddTicks(5328), null, null, "", null, null, "S", 1 },
                    { new Guid("c03356f5-a334-4bec-b6aa-d1500ccfd53a"), "", new DateTime(2024, 6, 23, 0, 4, 41, 460, DateTimeKind.Local).AddTicks(5331), null, null, "", null, null, "M", 1 }
                });
        }
    }
}
