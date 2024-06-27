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

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "AspNetUsers",
                newName: "Images");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IDUser",
                table: "Address",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "400000d4-7808-4bcb-81aa-141f1a3131be", null, "Admin", "Admin" },
                    { "c5323e8f-a644-4a9f-af12-33205eef17d0", null, "Client", "Client" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f907d7c3-a924-4e01-a594-67cf0926b30b", 0, "0c531c4c-c787-478a-bf61-3236cd6288bc", "IdentityUser", "admin@gmail.com", true, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEC6BbYPcfkWouN/1a04tGF6wZda9Il12u5MbI4FulxZkwxkOfmzbFMU1sQ2A6bPa/Q==", null, false, "7e21900e-6c46-4ec7-aa28-1d555f8fcf76", false, "admin" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("52c1a389-d55c-4869-b228-a26f08e853fd"), "", new DateTime(2024, 6, 25, 17, 25, 29, 207, DateTimeKind.Local).AddTicks(467), null, null, "", null, null, "Black", 1 },
                    { new Guid("6888a639-769d-4ae2-b4fa-814cf0292be9"), "", new DateTime(2024, 6, 25, 17, 25, 29, 207, DateTimeKind.Local).AddTicks(470), null, null, "", null, null, "Red", 1 },
                    { new Guid("86d0ca32-9d24-4a02-a675-d5b7199f0d2f"), "", new DateTime(2024, 6, 25, 17, 25, 29, 207, DateTimeKind.Local).AddTicks(489), null, null, "", null, null, "Green", 1 },
                    { new Guid("9b400839-0783-4b0c-aa27-6c76f3ec4717"), "", new DateTime(2024, 6, 25, 17, 25, 29, 207, DateTimeKind.Local).AddTicks(472), null, null, "", null, null, "Blue", 1 },
                    { new Guid("ba90233c-4e70-4427-b2b9-706caf6339c9"), "", new DateTime(2024, 6, 25, 17, 25, 29, 207, DateTimeKind.Local).AddTicks(437), null, null, "", null, null, "White", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("236c00ff-f734-4a5a-bec5-a2d5999a3bbd"), "", new DateTime(2024, 6, 25, 17, 25, 29, 297, DateTimeKind.Local).AddTicks(5270), null, null, "", null, null, "M", 1 },
                    { new Guid("59d3de8a-f1b5-4869-8dd1-232d6d816b6b"), "", new DateTime(2024, 6, 25, 17, 25, 29, 297, DateTimeKind.Local).AddTicks(5291), null, null, "", null, null, "XL", 1 },
                    { new Guid("c6b24407-c3fc-454d-a857-194c91ce4a3c"), "", new DateTime(2024, 6, 25, 17, 25, 29, 297, DateTimeKind.Local).AddTicks(5239), null, null, "", null, null, "XS", 1 },
                    { new Guid("d4d489ef-245d-4b92-bd59-32a2ce281c98"), "", new DateTime(2024, 6, 25, 17, 25, 29, 297, DateTimeKind.Local).AddTicks(5267), null, null, "", null, null, "S", 1 },
                    { new Guid("da23f8c8-62ac-4b36-94a3-b5ad7143c716"), "", new DateTime(2024, 6, 25, 17, 25, 29, 297, DateTimeKind.Local).AddTicks(5275), null, null, "", null, null, "L", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "400000d4-7808-4bcb-81aa-141f1a3131be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5323e8f-a644-4a9f-af12-33205eef17d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f907d7c3-a924-4e01-a594-67cf0926b30b");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("52c1a389-d55c-4869-b228-a26f08e853fd"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("6888a639-769d-4ae2-b4fa-814cf0292be9"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("86d0ca32-9d24-4a02-a675-d5b7199f0d2f"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("9b400839-0783-4b0c-aa27-6c76f3ec4717"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("ba90233c-4e70-4427-b2b9-706caf6339c9"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("236c00ff-f734-4a5a-bec5-a2d5999a3bbd"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("59d3de8a-f1b5-4869-8dd1-232d6d816b6b"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("c6b24407-c3fc-454d-a857-194c91ce4a3c"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("d4d489ef-245d-4b92-bd59-32a2ce281c98"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("da23f8c8-62ac-4b36-94a3-b5ad7143c716"));

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Images",
                table: "AspNetUsers",
                newName: "Address");

            migrationBuilder.AlterColumn<string>(
                name: "IDUser",
                table: "Address",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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
