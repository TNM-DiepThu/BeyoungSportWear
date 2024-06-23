using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class DB01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "CartProductDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sex",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "051b7b1b-3937-4e21-b488-b349a80887c0", null, "Admin", "Admin" },
                    { "811cbc73-2ff6-4017-bf6c-baa613eafe03", null, "Client", "Client" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "80e46676-ea00-4c23-911d-b1f01f63f68b", 0, "6f7711b1-85ff-4c49-8552-70e62f2ddbd6", "IdentityUser", "admin@gmail.com", true, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEKTsZf3waPLwBvim+hw/TFzrhqf2OS9B++AGB7LRiAPGSLGupx0QbF4M/FBN9Btq6Q==", null, false, "e9fdb850-c00d-4b28-8fa4-ba7cd4217bd4", false, "admin" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("419a2291-29e4-40e1-8930-4072ff6a0fe5"), "", new DateTime(2024, 6, 24, 1, 35, 13, 135, DateTimeKind.Local).AddTicks(2788), null, null, "", null, null, "Black", 1 },
                    { new Guid("47d4efeb-d529-42ba-8280-5a3b378a649a"), "", new DateTime(2024, 6, 24, 1, 35, 13, 135, DateTimeKind.Local).AddTicks(2791), null, null, "", null, null, "Blue", 1 },
                    { new Guid("a9b87710-6d7f-49e5-829e-4a4c4b34b434"), "", new DateTime(2024, 6, 24, 1, 35, 13, 135, DateTimeKind.Local).AddTicks(2770), null, null, "", null, null, "White", 1 },
                    { new Guid("d0091b01-43f7-4716-8f34-680941b69fb0"), "", new DateTime(2024, 6, 24, 1, 35, 13, 135, DateTimeKind.Local).AddTicks(2790), null, null, "", null, null, "Red", 1 },
                    { new Guid("d010b847-ceeb-431d-be8c-4a9106171a9c"), "", new DateTime(2024, 6, 24, 1, 35, 13, 135, DateTimeKind.Local).AddTicks(2793), null, null, "", null, null, "Green", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("60847095-04b8-45fd-93cb-147827793277"), "", new DateTime(2024, 6, 24, 1, 35, 13, 200, DateTimeKind.Local).AddTicks(754), null, null, "", null, null, "XL", 1 },
                    { new Guid("6613b56f-113b-4230-9cf8-8b52a9671d82"), "", new DateTime(2024, 6, 24, 1, 35, 13, 200, DateTimeKind.Local).AddTicks(751), null, null, "", null, null, "M", 1 },
                    { new Guid("8a0d8e85-8d8d-4578-9e13-ca81370bbbf9"), "", new DateTime(2024, 6, 24, 1, 35, 13, 200, DateTimeKind.Local).AddTicks(753), null, null, "", null, null, "L", 1 },
                    { new Guid("caa64749-1526-4523-8817-27169bfeaaee"), "", new DateTime(2024, 6, 24, 1, 35, 13, 200, DateTimeKind.Local).AddTicks(749), null, null, "", null, null, "S", 1 },
                    { new Guid("dfaaf2a9-37b7-4545-8d27-f46b3682c57a"), "", new DateTime(2024, 6, 24, 1, 35, 13, 200, DateTimeKind.Local).AddTicks(729), null, null, "", null, null, "XS", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "051b7b1b-3937-4e21-b488-b349a80887c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "811cbc73-2ff6-4017-bf6c-baa613eafe03");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80e46676-ea00-4c23-911d-b1f01f63f68b");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("419a2291-29e4-40e1-8930-4072ff6a0fe5"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("47d4efeb-d529-42ba-8280-5a3b378a649a"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("a9b87710-6d7f-49e5-829e-4a4c4b34b434"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("d0091b01-43f7-4716-8f34-680941b69fb0"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("d010b847-ceeb-431d-be8c-4a9106171a9c"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("60847095-04b8-45fd-93cb-147827793277"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("6613b56f-113b-4230-9cf8-8b52a9671d82"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("8a0d8e85-8d8d-4578-9e13-ca81370bbbf9"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("caa64749-1526-4523-8817-27169bfeaaee"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("dfaaf2a9-37b7-4545-8d27-f46b3682c57a"));

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "CartProductDetails");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "AspNetUsers");

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
    }
}
