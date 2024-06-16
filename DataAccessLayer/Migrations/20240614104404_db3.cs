using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class db3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76b152e5-488a-48b7-95cf-d66cf516b38b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff2f4198-7c41-4099-9f9b-8a83c4868144");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f6539e7-08eb-46b0-a735-6d4d625587e5");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("19c913f9-936c-48bb-a2c1-b7fc53ba733e"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("6537bf63-744b-4821-9cf7-7fee6283b840"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("991f6ed7-d23a-43a6-ae39-578c826e2363"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("a75e0112-da50-4043-9355-689ca023e5cc"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("bf5995ba-4177-459d-8151-565266bdd1c2"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("24a8513b-43cc-41c8-a36d-9f960803ecd5"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("55121dc7-2d67-40d4-9f4c-d4bbdd5e08b0"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("7bdd8e02-254f-48fb-96e7-afc3220fcdf8"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("9df53f8d-07d4-493b-b3ab-967a3a3ddcbd"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("a78895e9-cb98-467f-b7cf-4fb3fdcceaf1"));

            migrationBuilder.AddColumn<string>(
                name: "KeyCode",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "KeyCode",
                table: "ProductDetails");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "76b152e5-488a-48b7-95cf-d66cf516b38b", null, "Admin", "Admin" },
                    { "ff2f4198-7c41-4099-9f9b-8a83c4868144", null, "Client", "Client" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1f6539e7-08eb-46b0-a735-6d4d625587e5", 0, "df25839f-5cbc-444f-a398-6c51fcf8ee73", "IdentityUser", "admin@gmail.com", true, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEN2QChA61UBS1hP8xWOgB07FGNro1gqhT+HkQMMJFl4aEudwYzRLmTM92WxASkhIdw==", null, false, "7d8dee9a-23e8-455f-a7a5-0c7b85ad1fd5", false, "admin" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("19c913f9-936c-48bb-a2c1-b7fc53ba733e"), "", new DateTime(2024, 6, 10, 3, 25, 41, 676, DateTimeKind.Local).AddTicks(8822), null, null, "", null, null, "White", 1 },
                    { new Guid("6537bf63-744b-4821-9cf7-7fee6283b840"), "", new DateTime(2024, 6, 10, 3, 25, 41, 676, DateTimeKind.Local).AddTicks(8842), null, null, "", null, null, "Black", 1 },
                    { new Guid("991f6ed7-d23a-43a6-ae39-578c826e2363"), "", new DateTime(2024, 6, 10, 3, 25, 41, 676, DateTimeKind.Local).AddTicks(8858), null, null, "", null, null, "Green", 1 },
                    { new Guid("a75e0112-da50-4043-9355-689ca023e5cc"), "", new DateTime(2024, 6, 10, 3, 25, 41, 676, DateTimeKind.Local).AddTicks(8856), null, null, "", null, null, "Blue", 1 },
                    { new Guid("bf5995ba-4177-459d-8151-565266bdd1c2"), "", new DateTime(2024, 6, 10, 3, 25, 41, 676, DateTimeKind.Local).AddTicks(8844), null, null, "", null, null, "Red", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("24a8513b-43cc-41c8-a36d-9f960803ecd5"), "", new DateTime(2024, 6, 10, 3, 25, 41, 748, DateTimeKind.Local).AddTicks(1100), null, null, "", null, null, "XS", 1 },
                    { new Guid("55121dc7-2d67-40d4-9f4c-d4bbdd5e08b0"), "", new DateTime(2024, 6, 10, 3, 25, 41, 748, DateTimeKind.Local).AddTicks(1138), null, null, "", null, null, "XL", 1 },
                    { new Guid("7bdd8e02-254f-48fb-96e7-afc3220fcdf8"), "", new DateTime(2024, 6, 10, 3, 25, 41, 748, DateTimeKind.Local).AddTicks(1119), null, null, "", null, null, "S", 1 },
                    { new Guid("9df53f8d-07d4-493b-b3ab-967a3a3ddcbd"), "", new DateTime(2024, 6, 10, 3, 25, 41, 748, DateTimeKind.Local).AddTicks(1121), null, null, "", null, null, "M", 1 },
                    { new Guid("a78895e9-cb98-467f-b7cf-4fb3fdcceaf1"), "", new DateTime(2024, 6, 10, 3, 25, 41, 748, DateTimeKind.Local).AddTicks(1122), null, null, "", null, null, "L", 1 }
                });
        }
    }
}
