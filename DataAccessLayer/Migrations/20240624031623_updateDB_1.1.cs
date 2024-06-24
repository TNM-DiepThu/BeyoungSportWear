using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class updateDB_11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "City",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "Commune",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "DistrictCounty",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "SpecificAddress",
                table: "Address",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "AdressType",
                table: "Address",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3d684e32-29a7-448d-b009-e880d53c788a", null, "Client", "Client" },
                    { "a89612e1-43ea-493f-892e-8c4684a68b1c", null, "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "24104da8-01aa-4940-a074-372355e77004", 0, "84d21866-8b62-4d81-afd0-b865e4c62ee0", "IdentityUser", "admin@gmail.com", true, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEACP0hX9sJ7XyW0MYcfb/dS5QGox2/oI14eGikykSP2w6j4C/xlrFsjs/ORVc8QlsQ==", null, false, "bee3eb4f-979d-45db-8f26-8690c6f7df6d", false, "admin" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("25ebaf0e-595f-4bfb-99d0-bf6c42449446"), "", new DateTime(2024, 6, 24, 10, 16, 23, 145, DateTimeKind.Local).AddTicks(2815), null, null, "", null, null, "Black", 1 },
                    { new Guid("28eb84e3-bf37-4278-91cd-3e45833a220c"), "", new DateTime(2024, 6, 24, 10, 16, 23, 145, DateTimeKind.Local).AddTicks(2798), null, null, "", null, null, "White", 1 },
                    { new Guid("340e63df-5470-4419-8345-0cbf26c28364"), "", new DateTime(2024, 6, 24, 10, 16, 23, 145, DateTimeKind.Local).AddTicks(2818), null, null, "", null, null, "Blue", 1 },
                    { new Guid("bac83d72-a0f6-4563-99c9-a9d1977510bd"), "", new DateTime(2024, 6, 24, 10, 16, 23, 145, DateTimeKind.Local).AddTicks(2834), null, null, "", null, null, "Green", 1 },
                    { new Guid("d4ef584d-2118-40ff-bebd-487157002c95"), "", new DateTime(2024, 6, 24, 10, 16, 23, 145, DateTimeKind.Local).AddTicks(2817), null, null, "", null, null, "Red", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("67d893b0-c8d6-4fdc-9853-c2833b45ece1"), "", new DateTime(2024, 6, 24, 10, 16, 23, 194, DateTimeKind.Local).AddTicks(9352), null, null, "", null, null, "M", 1 },
                    { new Guid("6e542b36-5cb3-4d95-8291-e42ae0983346"), "", new DateTime(2024, 6, 24, 10, 16, 23, 194, DateTimeKind.Local).AddTicks(9332), null, null, "", null, null, "XS", 1 },
                    { new Guid("790066fb-ee06-4dec-a913-e98f2e0d20e8"), "", new DateTime(2024, 6, 24, 10, 16, 23, 194, DateTimeKind.Local).AddTicks(9354), null, null, "", null, null, "L", 1 },
                    { new Guid("8c80c214-94c3-4b34-90eb-75535c933174"), "", new DateTime(2024, 6, 24, 10, 16, 23, 194, DateTimeKind.Local).AddTicks(9355), null, null, "", null, null, "XL", 1 },
                    { new Guid("904a7647-c4fa-4bd6-97f2-449a81f532be"), "", new DateTime(2024, 6, 24, 10, 16, 23, 194, DateTimeKind.Local).AddTicks(9350), null, null, "", null, null, "S", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d684e32-29a7-448d-b009-e880d53c788a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a89612e1-43ea-493f-892e-8c4684a68b1c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24104da8-01aa-4940-a074-372355e77004");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("25ebaf0e-595f-4bfb-99d0-bf6c42449446"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("28eb84e3-bf37-4278-91cd-3e45833a220c"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("340e63df-5470-4419-8345-0cbf26c28364"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("bac83d72-a0f6-4563-99c9-a9d1977510bd"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("d4ef584d-2118-40ff-bebd-487157002c95"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("67d893b0-c8d6-4fdc-9853-c2833b45ece1"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("6e542b36-5cb3-4d95-8291-e42ae0983346"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("790066fb-ee06-4dec-a913-e98f2e0d20e8"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("8c80c214-94c3-4b34-90eb-75535c933174"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("904a7647-c4fa-4bd6-97f2-449a81f532be"));

            migrationBuilder.DropColumn(
                name: "AdressType",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Address",
                newName: "SpecificAddress");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Commune",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Address",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DeleteBy",
                table: "Address",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Address",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DistrictCounty",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Address",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Address",
                type: "datetime2",
                nullable: true);

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
    }
}
