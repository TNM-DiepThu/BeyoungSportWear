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
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Options_IDOrder",
                table: "OrderDetails");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20c3a121-fe10-4f96-8c0d-2f792ef9c475");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "febb7552-7b34-4593-b821-13848709e73e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16a1b97d-8343-49bb-a9c5-2c41c7285d8c");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("56da5952-f4b1-4be8-b421-571bdafb22e6"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("65c8cd6c-9628-4320-b63d-a8095b40ba96"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("6d07d53f-037f-40d1-85a8-c5e1a4bc5d5d"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("6e3b1fa4-6c18-42a9-8bb1-626271da0a15"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("b7e6c278-542c-4f9d-b4ec-d7e45c9a21ad"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("585f479e-a97d-429b-9d9c-14ebb242bdf8"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("b3df72f5-2440-4db7-a89f-7f21c36cb3f4"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("bf7a8f11-b2e1-46c2-89d1-863b0800c142"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("dfd3ee87-3bc4-4267-b2ab-5c2c757cf2cc"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("f70f6300-afc2-4c73-a475-8e7767196cb0"));

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

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_IDOptions",
                table: "OrderDetails",
                column: "IDOptions");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Options_IDOptions",
                table: "OrderDetails",
                column: "IDOptions",
                principalTable: "Options",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Options_IDOptions",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_IDOptions",
                table: "OrderDetails");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "20c3a121-fe10-4f96-8c0d-2f792ef9c475", null, "Admin", "Admin" },
                    { "febb7552-7b34-4593-b821-13848709e73e", null, "Client", "Client" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "16a1b97d-8343-49bb-a9c5-2c41c7285d8c", 0, "2a901424-de87-4a7e-8b32-7066540a4891", "IdentityUser", "admin@gmail.com", true, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEMiKlSwf1CaS2Vid1mQVttaYbvo5wf4Yq56Vl2tANcLthV+2x9telD53rDektTGN4g==", null, false, "6df2bb98-6cbf-4285-990d-efc5f4247383", false, "admin" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("56da5952-f4b1-4be8-b421-571bdafb22e6"), "", new DateTime(2024, 6, 8, 1, 20, 34, 391, DateTimeKind.Local).AddTicks(954), null, null, "", null, null, "Green", 1 },
                    { new Guid("65c8cd6c-9628-4320-b63d-a8095b40ba96"), "", new DateTime(2024, 6, 8, 1, 20, 34, 391, DateTimeKind.Local).AddTicks(952), null, null, "", null, null, "Blue", 1 },
                    { new Guid("6d07d53f-037f-40d1-85a8-c5e1a4bc5d5d"), "", new DateTime(2024, 6, 8, 1, 20, 34, 391, DateTimeKind.Local).AddTicks(950), null, null, "", null, null, "Red", 1 },
                    { new Guid("6e3b1fa4-6c18-42a9-8bb1-626271da0a15"), "", new DateTime(2024, 6, 8, 1, 20, 34, 391, DateTimeKind.Local).AddTicks(923), null, null, "", null, null, "White", 1 },
                    { new Guid("b7e6c278-542c-4f9d-b4ec-d7e45c9a21ad"), "", new DateTime(2024, 6, 8, 1, 20, 34, 391, DateTimeKind.Local).AddTicks(948), null, null, "", null, null, "Black", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("585f479e-a97d-429b-9d9c-14ebb242bdf8"), "", new DateTime(2024, 6, 8, 1, 20, 34, 481, DateTimeKind.Local).AddTicks(8614), null, null, "", null, null, "M", 1 },
                    { new Guid("b3df72f5-2440-4db7-a89f-7f21c36cb3f4"), "", new DateTime(2024, 6, 8, 1, 20, 34, 481, DateTimeKind.Local).AddTicks(8611), null, null, "", null, null, "S", 1 },
                    { new Guid("bf7a8f11-b2e1-46c2-89d1-863b0800c142"), "", new DateTime(2024, 6, 8, 1, 20, 34, 481, DateTimeKind.Local).AddTicks(8616), null, null, "", null, null, "L", 1 },
                    { new Guid("dfd3ee87-3bc4-4267-b2ab-5c2c757cf2cc"), "", new DateTime(2024, 6, 8, 1, 20, 34, 481, DateTimeKind.Local).AddTicks(8588), null, null, "", null, null, "XS", 1 },
                    { new Guid("f70f6300-afc2-4c73-a475-8e7767196cb0"), "", new DateTime(2024, 6, 8, 1, 20, 34, 481, DateTimeKind.Local).AddTicks(8618), null, null, "", null, null, "XL", 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Options_IDOrder",
                table: "OrderDetails",
                column: "IDOrder",
                principalTable: "Options",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
