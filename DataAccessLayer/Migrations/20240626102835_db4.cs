using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class db4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "IsActive",
                table: "Voucher",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4249adc8-d336-4237-aa6a-f08be45bca3b", null, "Admin", "Admin" },
                    { "59c99511-ac22-457e-853e-bee82042da18", null, "Client", "Client" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "abccb02d-7aea-4b77-94dc-b9191e086fd1", 0, "a4830056-6fc0-428c-a0ea-09e318073185", "IdentityUser", "admin@gmail.com", true, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAECPRtTU0gxXo35bI+Aqy9COwTpE3xAzUKN9zsQWKIyNPp5S+u2nmzRKWuos7ZibNuA==", null, false, "95f51b65-009c-41af-a09d-77b089e2218b", false, "admin" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("36c9cc48-63c5-4e3f-8d37-d005cae15f2f"), "", new DateTime(2024, 6, 26, 17, 28, 35, 3, DateTimeKind.Local).AddTicks(5728), null, null, "", null, null, "White", 1 },
                    { new Guid("a5cd3742-f33c-4f1a-a24f-8bb1721f8005"), "", new DateTime(2024, 6, 26, 17, 28, 35, 3, DateTimeKind.Local).AddTicks(5907), null, null, "", null, null, "Blue", 1 },
                    { new Guid("a882a58d-eba0-4863-9b4e-cda47013f096"), "", new DateTime(2024, 6, 26, 17, 28, 35, 3, DateTimeKind.Local).AddTicks(5890), null, null, "", null, null, "Black", 1 },
                    { new Guid("bf1c8b2a-f8ae-4964-b6be-9d26e5544245"), "", new DateTime(2024, 6, 26, 17, 28, 35, 3, DateTimeKind.Local).AddTicks(5914), null, null, "", null, null, "Green", 1 },
                    { new Guid("c1640887-b86a-43db-9d75-a965a4f603e4"), "", new DateTime(2024, 6, 26, 17, 28, 35, 3, DateTimeKind.Local).AddTicks(5894), null, null, "", null, null, "Red", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("7b7144e4-97b8-443b-9ad2-781f43239250"), "", new DateTime(2024, 6, 26, 17, 28, 35, 125, DateTimeKind.Local).AddTicks(6132), null, null, "", null, null, "L", 1 },
                    { new Guid("e2c49254-71d8-4fd3-9fd2-0d8ba4a69676"), "", new DateTime(2024, 6, 26, 17, 28, 35, 125, DateTimeKind.Local).AddTicks(6127), null, null, "", null, null, "S", 1 },
                    { new Guid("f7ca5f69-9f84-41f5-9a5d-4973a945af43"), "", new DateTime(2024, 6, 26, 17, 28, 35, 125, DateTimeKind.Local).AddTicks(6144), null, null, "", null, null, "XL", 1 },
                    { new Guid("f98603ca-19c9-4601-86bd-2055a479994e"), "", new DateTime(2024, 6, 26, 17, 28, 35, 125, DateTimeKind.Local).AddTicks(6130), null, null, "", null, null, "M", 1 },
                    { new Guid("ff848ab0-fa59-42b7-8ade-bd3c488a6f8c"), "", new DateTime(2024, 6, 26, 17, 28, 35, 125, DateTimeKind.Local).AddTicks(6056), null, null, "", null, null, "XS", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4249adc8-d336-4237-aa6a-f08be45bca3b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59c99511-ac22-457e-853e-bee82042da18");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abccb02d-7aea-4b77-94dc-b9191e086fd1");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("36c9cc48-63c5-4e3f-8d37-d005cae15f2f"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("a5cd3742-f33c-4f1a-a24f-8bb1721f8005"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("a882a58d-eba0-4863-9b4e-cda47013f096"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("bf1c8b2a-f8ae-4964-b6be-9d26e5544245"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("c1640887-b86a-43db-9d75-a965a4f603e4"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("7b7144e4-97b8-443b-9ad2-781f43239250"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("e2c49254-71d8-4fd3-9fd2-0d8ba4a69676"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("f7ca5f69-9f84-41f5-9a5d-4973a945af43"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("f98603ca-19c9-4601-86bd-2055a479994e"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("ff848ab0-fa59-42b7-8ade-bd3c488a6f8c"));

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Voucher",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
