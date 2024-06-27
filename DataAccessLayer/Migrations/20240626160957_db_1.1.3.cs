using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class db_113 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22e0099b-2148-4f88-a5b6-a85bb23df3cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27bbb44c-4820-4ff3-ab4a-5177323fb6ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1984c6f-2d80-4e04-9d43-87bcc26c0bb2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "275be6a3-0a12-427f-9295-5f742a697365");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("082ea4e2-c322-4e55-881d-b979c708a234"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("607bc903-0eb6-4b9d-a977-89e1026d83ef"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("61ff1dc2-ad36-464e-b83b-e3d5792747c6"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("7c3fc458-59bc-483c-97a4-47f7e7422167"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("7dd6bf48-01dc-4953-b0c8-8f6e30f4fbae"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("12eda5bb-d005-4596-af2c-1a84b6fac084"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("404cf539-19a9-4158-929c-2f31d8cfd5e7"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("755f0678-59f5-4ec5-ae7a-9af210add030"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("8b0adbd9-b238-49ae-920b-e5d909e15cea"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("90ae846e-75ef-4baf-a8df-bfc93a38acf2"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3dac4a91-84f8-4347-b2f5-84ecb10d3434", null, "Client", "Client" },
                    { "f5deeb8c-4f2b-490f-b4a3-7d90574e965b", null, "Admin", "Admin" },
                    { "fd4daf62-36fb-4887-9ec4-1264406131f9", null, "Staff", "Staff" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d72763dc-f7c6-49a7-88de-c6ca9e314506", 0, "6538d46c-0b26-4098-81ff-52ca2c8ad652", "IdentityUser", "admin@gmail.com", true, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEOwHzJOn7rOL8BkJwBL6Vbc5eUxWE+rOXARunPOqxxvzbFwdTZs+h/G0JaAoRZR15A==", null, false, "f3e80f96-1c87-4b80-8d6f-e541a2491d64", false, "admin" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("02134a8c-bd2c-430d-8b34-8113be8cf5ea"), "", new DateTime(2024, 6, 26, 23, 9, 57, 555, DateTimeKind.Local).AddTicks(3799), null, null, "", null, null, "Red", 1 },
                    { new Guid("1fd275f1-4c42-48a0-8335-3150528dfaea"), "", new DateTime(2024, 6, 26, 23, 9, 57, 555, DateTimeKind.Local).AddTicks(3766), null, null, "", null, null, "White", 1 },
                    { new Guid("1fefde74-ada7-44b0-be8f-95663c678354"), "", new DateTime(2024, 6, 26, 23, 9, 57, 555, DateTimeKind.Local).AddTicks(3797), null, null, "", null, null, "Black", 1 },
                    { new Guid("46fa2336-9ac1-4238-9e47-2ed753b9b926"), "", new DateTime(2024, 6, 26, 23, 9, 57, 555, DateTimeKind.Local).AddTicks(3801), null, null, "", null, null, "Blue", 1 },
                    { new Guid("77d3b4ff-33b1-44b6-9a70-35cf62fda24d"), "", new DateTime(2024, 6, 26, 23, 9, 57, 555, DateTimeKind.Local).AddTicks(3803), null, null, "", null, null, "Green", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("0b1d57d9-3c38-4100-b6c3-2aafd88d7778"), "", new DateTime(2024, 6, 26, 23, 9, 57, 605, DateTimeKind.Local).AddTicks(3119), null, null, "", null, null, "L", 1 },
                    { new Guid("62df14d8-0878-4475-8c2d-23a8abcf04f3"), "", new DateTime(2024, 6, 26, 23, 9, 57, 605, DateTimeKind.Local).AddTicks(3117), null, null, "", null, null, "M", 1 },
                    { new Guid("c6d506b1-a4f8-45df-90a3-739ca757495b"), "", new DateTime(2024, 6, 26, 23, 9, 57, 605, DateTimeKind.Local).AddTicks(3106), null, null, "", null, null, "XS", 1 },
                    { new Guid("da852e28-225b-4575-8eae-0713e3458d30"), "", new DateTime(2024, 6, 26, 23, 9, 57, 605, DateTimeKind.Local).AddTicks(3127), null, null, "", null, null, "XL", 1 },
                    { new Guid("ec33d44e-69e4-4327-808b-f4f70c9d4d32"), "", new DateTime(2024, 6, 26, 23, 9, 57, 605, DateTimeKind.Local).AddTicks(3115), null, null, "", null, null, "S", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3dac4a91-84f8-4347-b2f5-84ecb10d3434");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f5deeb8c-4f2b-490f-b4a3-7d90574e965b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd4daf62-36fb-4887-9ec4-1264406131f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d72763dc-f7c6-49a7-88de-c6ca9e314506");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("02134a8c-bd2c-430d-8b34-8113be8cf5ea"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("1fd275f1-4c42-48a0-8335-3150528dfaea"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("1fefde74-ada7-44b0-be8f-95663c678354"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("46fa2336-9ac1-4238-9e47-2ed753b9b926"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("77d3b4ff-33b1-44b6-9a70-35cf62fda24d"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("0b1d57d9-3c38-4100-b6c3-2aafd88d7778"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("62df14d8-0878-4475-8c2d-23a8abcf04f3"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("c6d506b1-a4f8-45df-90a3-739ca757495b"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("da852e28-225b-4575-8eae-0713e3458d30"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("ec33d44e-69e4-4327-808b-f4f70c9d4d32"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "22e0099b-2148-4f88-a5b6-a85bb23df3cc", null, "Client", "Client" },
                    { "27bbb44c-4820-4ff3-ab4a-5177323fb6ad", null, "Admin", "Admin" },
                    { "d1984c6f-2d80-4e04-9d43-87bcc26c0bb2", null, "Staff", "Staff" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "275be6a3-0a12-427f-9295-5f742a697365", 0, "537edb43-7a1d-4e08-8420-b93c6d779bf7", "IdentityUser", "admin@gmail.com", true, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEFwDSCZbiipKRLl9dW+hP0n4M5SwRquUNY6dB5npPYzJHwGxMzEf3gGgffVoxv9FoA==", null, false, "ec2eac82-fa8b-4b6f-8eeb-2470f87764fc", false, "admin" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("082ea4e2-c322-4e55-881d-b979c708a234"), "", new DateTime(2024, 6, 26, 22, 30, 7, 276, DateTimeKind.Local).AddTicks(5127), null, null, "", null, null, "Black", 1 },
                    { new Guid("607bc903-0eb6-4b9d-a977-89e1026d83ef"), "", new DateTime(2024, 6, 26, 22, 30, 7, 276, DateTimeKind.Local).AddTicks(5145), null, null, "", null, null, "Red", 1 },
                    { new Guid("61ff1dc2-ad36-464e-b83b-e3d5792747c6"), "", new DateTime(2024, 6, 26, 22, 30, 7, 276, DateTimeKind.Local).AddTicks(5105), null, null, "", null, null, "White", 1 },
                    { new Guid("7c3fc458-59bc-483c-97a4-47f7e7422167"), "", new DateTime(2024, 6, 26, 22, 30, 7, 276, DateTimeKind.Local).AddTicks(5148), null, null, "", null, null, "Blue", 1 },
                    { new Guid("7dd6bf48-01dc-4953-b0c8-8f6e30f4fbae"), "", new DateTime(2024, 6, 26, 22, 30, 7, 276, DateTimeKind.Local).AddTicks(5150), null, null, "", null, null, "Green", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("12eda5bb-d005-4596-af2c-1a84b6fac084"), "", new DateTime(2024, 6, 26, 22, 30, 7, 352, DateTimeKind.Local).AddTicks(6833), null, null, "", null, null, "XL", 1 },
                    { new Guid("404cf539-19a9-4158-929c-2f31d8cfd5e7"), "", new DateTime(2024, 6, 26, 22, 30, 7, 352, DateTimeKind.Local).AddTicks(6792), null, null, "", null, null, "XS", 1 },
                    { new Guid("755f0678-59f5-4ec5-ae7a-9af210add030"), "", new DateTime(2024, 6, 26, 22, 30, 7, 352, DateTimeKind.Local).AddTicks(6831), null, null, "", null, null, "L", 1 },
                    { new Guid("8b0adbd9-b238-49ae-920b-e5d909e15cea"), "", new DateTime(2024, 6, 26, 22, 30, 7, 352, DateTimeKind.Local).AddTicks(6817), null, null, "", null, null, "S", 1 },
                    { new Guid("90ae846e-75ef-4baf-a8df-bfc93a38acf2"), "", new DateTime(2024, 6, 26, 22, 30, 7, 352, DateTimeKind.Local).AddTicks(6829), null, null, "", null, null, "M", 1 }
                });
        }
    }
}
