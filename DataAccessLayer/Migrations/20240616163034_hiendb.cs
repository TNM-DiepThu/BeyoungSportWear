using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class hiendb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ed76b52-3374-4e53-b4c5-b9b80917bdf7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b216aedf-8e6e-46af-b5b2-0dc878699ddc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df9a4318-41ba-4905-9c67-265feaedbe31");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("414bdea7-308c-4faa-9af3-214a3d38b8fa"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("45a18b19-3fe8-4c99-87b7-7ee2cbaa7cb0"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("acd86281-81b4-4a2e-b92a-8578c312d71a"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("aeba5145-acc3-4ad2-b11a-ea01eb9e5d20"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("cab7ab6c-0c45-4b4e-ace4-9ca58eb21aa5"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("0ef3ef60-dfa7-4a63-b86a-b3cc9d551baa"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("389d36aa-b604-494b-8a7d-f194f6e94a12"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("549b7f87-901b-4306-936d-2cd0523d7cda"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("c459a1d6-c1fa-471a-9dc3-68f5fbb48e9f"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("d4f3ea3b-1d73-4076-8067-7919ef013fee"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "4ed76b52-3374-4e53-b4c5-b9b80917bdf7", null, "Admin", "Admin" },
                    { "b216aedf-8e6e-46af-b5b2-0dc878699ddc", null, "Client", "Client" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "df9a4318-41ba-4905-9c67-265feaedbe31", 0, "346991bc-f948-4992-8eb6-264e7df43533", "IdentityUser", "admin@gmail.com", true, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAENAyt+mD7v9XZuMUeaSpcGou0+vDrBl10xbRWuMpRx85uljHu4a/IrgpWwdbaQruAA==", null, false, "ab8343ef-a489-4c5a-a7d2-f0f7ee40a7e4", false, "admin" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("414bdea7-308c-4faa-9af3-214a3d38b8fa"), "", new DateTime(2024, 6, 14, 17, 44, 3, 235, DateTimeKind.Local).AddTicks(6566), null, null, "", null, null, "White", 1 },
                    { new Guid("45a18b19-3fe8-4c99-87b7-7ee2cbaa7cb0"), "", new DateTime(2024, 6, 14, 17, 44, 3, 235, DateTimeKind.Local).AddTicks(6638), null, null, "", null, null, "Black", 1 },
                    { new Guid("acd86281-81b4-4a2e-b92a-8578c312d71a"), "", new DateTime(2024, 6, 14, 17, 44, 3, 235, DateTimeKind.Local).AddTicks(6644), null, null, "", null, null, "Red", 1 },
                    { new Guid("aeba5145-acc3-4ad2-b11a-ea01eb9e5d20"), "", new DateTime(2024, 6, 14, 17, 44, 3, 235, DateTimeKind.Local).AddTicks(6698), null, null, "", null, null, "Blue", 1 },
                    { new Guid("cab7ab6c-0c45-4b4e-ace4-9ca58eb21aa5"), "", new DateTime(2024, 6, 14, 17, 44, 3, 235, DateTimeKind.Local).AddTicks(6703), null, null, "", null, null, "Green", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("0ef3ef60-dfa7-4a63-b86a-b3cc9d551baa"), "", new DateTime(2024, 6, 14, 17, 44, 3, 468, DateTimeKind.Local).AddTicks(6539), null, null, "", null, null, "XS", 1 },
                    { new Guid("389d36aa-b604-494b-8a7d-f194f6e94a12"), "", new DateTime(2024, 6, 14, 17, 44, 3, 468, DateTimeKind.Local).AddTicks(6734), null, null, "", null, null, "M", 1 },
                    { new Guid("549b7f87-901b-4306-936d-2cd0523d7cda"), "", new DateTime(2024, 6, 14, 17, 44, 3, 468, DateTimeKind.Local).AddTicks(6758), null, null, "", null, null, "L", 1 },
                    { new Guid("c459a1d6-c1fa-471a-9dc3-68f5fbb48e9f"), "", new DateTime(2024, 6, 14, 17, 44, 3, 468, DateTimeKind.Local).AddTicks(6727), null, null, "", null, null, "S", 1 },
                    { new Guid("d4f3ea3b-1d73-4076-8067-7919ef013fee"), "", new DateTime(2024, 6, 14, 17, 44, 3, 468, DateTimeKind.Local).AddTicks(6861), null, null, "", null, null, "XL", 1 }
                });
        }
    }
}
