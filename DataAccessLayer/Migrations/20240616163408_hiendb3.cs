using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class hiendb3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
