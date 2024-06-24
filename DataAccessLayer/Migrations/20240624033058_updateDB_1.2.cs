using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class updateDB_12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Address",
                newName: "ParentID");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9bd7a165-0b30-4f73-a0b1-2572cc18a1cf", null, "Client", "Client" },
                    { "fea7922e-85b2-4324-8eb9-d2edfbdab5df", null, "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "58022c6d-dc31-4ff5-960e-6d1629e68d7a", 0, "660008bc-02cc-4daf-b178-b41871581f85", "IdentityUser", "admin@gmail.com", true, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEGG92AlFpiemDzoHHrSezE3VHV/3isybM3EDvUjLPS76Q6VZeGTCDQWsReF//a+3/Q==", null, false, "1df2e871-b076-471b-bfce-7595ae7689c8", false, "admin" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("0b5b4ecf-a4b6-49cb-8f6e-4c99fcc31044"), "", new DateTime(2024, 6, 24, 10, 30, 58, 263, DateTimeKind.Local).AddTicks(8998), null, null, "", null, null, "Red", 1 },
                    { new Guid("0db998ce-889a-4489-89ed-3ca8f12797b4"), "", new DateTime(2024, 6, 24, 10, 30, 58, 263, DateTimeKind.Local).AddTicks(8996), null, null, "", null, null, "Black", 1 },
                    { new Guid("15b4c771-8f3f-4b1c-ae75-9cb7bd3478d6"), "", new DateTime(2024, 6, 24, 10, 30, 58, 263, DateTimeKind.Local).AddTicks(9000), null, null, "", null, null, "Blue", 1 },
                    { new Guid("712d2647-4788-461c-a1fb-58f4f7cca507"), "", new DateTime(2024, 6, 24, 10, 30, 58, 263, DateTimeKind.Local).AddTicks(8976), null, null, "", null, null, "White", 1 },
                    { new Guid("7b8528b6-3bc2-497c-ae71-950e86cb5286"), "", new DateTime(2024, 6, 24, 10, 30, 58, 263, DateTimeKind.Local).AddTicks(9002), null, null, "", null, null, "Green", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("1520b20b-86dc-447e-9adb-899f97b8ffb4"), "", new DateTime(2024, 6, 24, 10, 30, 58, 314, DateTimeKind.Local).AddTicks(2608), null, null, "", null, null, "L", 1 },
                    { new Guid("1abd1702-6f9d-4973-8486-3e96fd28dfae"), "", new DateTime(2024, 6, 24, 10, 30, 58, 314, DateTimeKind.Local).AddTicks(2604), null, null, "", null, null, "M", 1 },
                    { new Guid("3f18852d-a98b-4279-9f9e-125bca1e0bfa"), "", new DateTime(2024, 6, 24, 10, 30, 58, 314, DateTimeKind.Local).AddTicks(2610), null, null, "", null, null, "XL", 1 },
                    { new Guid("93134f97-ef77-4bca-920c-e89f81ad5306"), "", new DateTime(2024, 6, 24, 10, 30, 58, 314, DateTimeKind.Local).AddTicks(2584), null, null, "", null, null, "XS", 1 },
                    { new Guid("9e8369b6-2dbd-4119-95aa-340e7422bbe5"), "", new DateTime(2024, 6, 24, 10, 30, 58, 314, DateTimeKind.Local).AddTicks(2602), null, null, "", null, null, "S", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bd7a165-0b30-4f73-a0b1-2572cc18a1cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fea7922e-85b2-4324-8eb9-d2edfbdab5df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58022c6d-dc31-4ff5-960e-6d1629e68d7a");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("0b5b4ecf-a4b6-49cb-8f6e-4c99fcc31044"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("0db998ce-889a-4489-89ed-3ca8f12797b4"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("15b4c771-8f3f-4b1c-ae75-9cb7bd3478d6"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("712d2647-4788-461c-a1fb-58f4f7cca507"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("7b8528b6-3bc2-497c-ae71-950e86cb5286"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("1520b20b-86dc-447e-9adb-899f97b8ffb4"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("1abd1702-6f9d-4973-8486-3e96fd28dfae"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("3f18852d-a98b-4279-9f9e-125bca1e0bfa"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("93134f97-ef77-4bca-920c-e89f81ad5306"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("9e8369b6-2dbd-4119-95aa-340e7422bbe5"));

            migrationBuilder.RenameColumn(
                name: "ParentID",
                table: "Address",
                newName: "Status");

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
    }
}
