using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class update_11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fcb4923-d61c-4cd4-9210-38cd062cba20");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a401284-b734-4185-ad63-337c9d4929ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3283be2b-0d5b-4d75-995a-720c73b2d147");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("07443cfa-4074-4954-b311-68376abe435b"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("11b8ddc2-4f0d-4def-a6fb-95034fdbbc4b"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("7f884502-1bf0-42a5-b481-4b30667b7510"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("beab1086-4398-4991-bff6-71da0a167203"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("ea865e38-2abc-4956-94c2-a7f9f5425bbb"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("2097e0ad-3a6d-411a-8034-5e7b4401a183"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("4bb86da0-5916-4662-b2c3-0bf1fcbc5c22"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("5c483497-292e-42f7-aa3e-c8d44f1cd714"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("aecb6878-93d1-4f0d-b3de-86cb8990512e"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("b5a72d6b-8f4f-4039-b748-ea806ee7dca9"));

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "Sizes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "Sizes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1fcb4923-d61c-4cd4-9210-38cd062cba20", null, "Client", "Client" },
                    { "9a401284-b734-4185-ad63-337c9d4929ba", null, "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3283be2b-0d5b-4d75-995a-720c73b2d147", 0, "9aba5586-e50c-4570-acdb-b519057fb776", "IdentityUser", "admin@gmail.com", true, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEFW9FQ8S9atSr/6SpxexnzxnKkjvqWvyjn7kIE993L7n2iDYjaLsHA0JjVIoOwe7Iw==", null, false, "233a0fe0-7b31-4571-8a59-5022c542d3e1", false, "admin" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("07443cfa-4074-4954-b311-68376abe435b"), "", new DateTime(2024, 6, 16, 23, 34, 7, 945, DateTimeKind.Local).AddTicks(2198), null, null, "", null, null, "Black", 1 },
                    { new Guid("11b8ddc2-4f0d-4def-a6fb-95034fdbbc4b"), "", new DateTime(2024, 6, 16, 23, 34, 7, 945, DateTimeKind.Local).AddTicks(2177), null, null, "", null, null, "White", 1 },
                    { new Guid("7f884502-1bf0-42a5-b481-4b30667b7510"), "", new DateTime(2024, 6, 16, 23, 34, 7, 945, DateTimeKind.Local).AddTicks(2201), null, null, "", null, null, "Red", 1 },
                    { new Guid("beab1086-4398-4991-bff6-71da0a167203"), "", new DateTime(2024, 6, 16, 23, 34, 7, 945, DateTimeKind.Local).AddTicks(2224), null, null, "", null, null, "Green", 1 },
                    { new Guid("ea865e38-2abc-4956-94c2-a7f9f5425bbb"), "", new DateTime(2024, 6, 16, 23, 34, 7, 945, DateTimeKind.Local).AddTicks(2203), null, null, "", null, null, "Blue", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("2097e0ad-3a6d-411a-8034-5e7b4401a183"), "", new DateTime(2024, 6, 16, 23, 34, 8, 8, DateTimeKind.Local).AddTicks(9659), null, null, "", null, null, "XS", 1 },
                    { new Guid("4bb86da0-5916-4662-b2c3-0bf1fcbc5c22"), "", new DateTime(2024, 6, 16, 23, 34, 8, 8, DateTimeKind.Local).AddTicks(9687), null, null, "", null, null, "XL", 1 },
                    { new Guid("5c483497-292e-42f7-aa3e-c8d44f1cd714"), "", new DateTime(2024, 6, 16, 23, 34, 8, 8, DateTimeKind.Local).AddTicks(9685), null, null, "", null, null, "L", 1 },
                    { new Guid("aecb6878-93d1-4f0d-b3de-86cb8990512e"), "", new DateTime(2024, 6, 16, 23, 34, 8, 8, DateTimeKind.Local).AddTicks(9683), null, null, "", null, null, "M", 1 },
                    { new Guid("b5a72d6b-8f4f-4039-b748-ea806ee7dca9"), "", new DateTime(2024, 6, 16, 23, 34, 8, 8, DateTimeKind.Local).AddTicks(9681), null, null, "", null, null, "S", 1 }
                });
        }
    }
}
