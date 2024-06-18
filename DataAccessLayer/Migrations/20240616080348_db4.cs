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
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Options_IDOptions",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_IDOptions",
                table: "Images");

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
                name: "IDOptions",
                table: "Images");

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Options",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "72cffa60-fcc8-40d6-a937-9febd681d4da", null, "Admin", "Admin" },
                    { "f0ffcb40-b4f0-4ee4-b9d1-93d8551b7aa5", null, "Client", "Client" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "03e3267a-92cc-46f9-8164-7740e9fbf2e2", 0, "122ccd0c-72cb-4fd4-86bb-e8759660edf3", "IdentityUser", "admin@gmail.com", true, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAENrG1ba7mg4RE4iQwsGp4GlO32On9bjXJZgs6Ib6kn79jlT2pO1CjrX13VMZRThH0w==", null, false, "7f54c17f-448b-481b-84d2-d13356309f65", false, "admin" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("39ba778e-26cb-4b88-a21e-45bdfb33edb9"), "", new DateTime(2024, 6, 16, 15, 3, 47, 768, DateTimeKind.Local).AddTicks(88), null, null, "", null, null, "White", 1 },
                    { new Guid("3df5b898-3728-44f9-8543-845bf702c40b"), "", new DateTime(2024, 6, 16, 15, 3, 47, 768, DateTimeKind.Local).AddTicks(105), null, null, "", null, null, "Green", 1 },
                    { new Guid("7c9aaeb6-b01a-4011-8b59-c34879595937"), "", new DateTime(2024, 6, 16, 15, 3, 47, 768, DateTimeKind.Local).AddTicks(104), null, null, "", null, null, "Blue", 1 },
                    { new Guid("83b34480-5f92-43c4-bbe0-e3072400ffb5"), "", new DateTime(2024, 6, 16, 15, 3, 47, 768, DateTimeKind.Local).AddTicks(100), null, null, "", null, null, "Black", 1 },
                    { new Guid("fc7b5b9e-f86d-4d18-9fe4-849b7bf7e257"), "", new DateTime(2024, 6, 16, 15, 3, 47, 768, DateTimeKind.Local).AddTicks(102), null, null, "", null, null, "Red", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "CreateBy", "CreateDate", "DeleteBy", "DeleteDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("16f7cdde-ad69-4f1f-b422-5130231c6676"), "", new DateTime(2024, 6, 16, 15, 3, 47, 838, DateTimeKind.Local).AddTicks(327), null, null, "", null, null, "L", 1 },
                    { new Guid("97afb517-6f30-433f-81db-dae3319746e0"), "", new DateTime(2024, 6, 16, 15, 3, 47, 838, DateTimeKind.Local).AddTicks(324), null, null, "", null, null, "S", 1 },
                    { new Guid("a9911643-7e25-4ad0-a9b3-ab2d03f19a77"), "", new DateTime(2024, 6, 16, 15, 3, 47, 838, DateTimeKind.Local).AddTicks(340), null, null, "", null, null, "XL", 1 },
                    { new Guid("b4eeb05b-c63b-4205-b258-a9ff18a9a706"), "", new DateTime(2024, 6, 16, 15, 3, 47, 838, DateTimeKind.Local).AddTicks(326), null, null, "", null, null, "M", 1 },
                    { new Guid("eb8dc29c-59ab-452b-97cc-84bdcc38663a"), "", new DateTime(2024, 6, 16, 15, 3, 47, 838, DateTimeKind.Local).AddTicks(299), null, null, "", null, null, "XS", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72cffa60-fcc8-40d6-a937-9febd681d4da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0ffcb40-b4f0-4ee4-b9d1-93d8551b7aa5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03e3267a-92cc-46f9-8164-7740e9fbf2e2");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("39ba778e-26cb-4b88-a21e-45bdfb33edb9"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("3df5b898-3728-44f9-8543-845bf702c40b"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("7c9aaeb6-b01a-4011-8b59-c34879595937"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("83b34480-5f92-43c4-bbe0-e3072400ffb5"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ID",
                keyValue: new Guid("fc7b5b9e-f86d-4d18-9fe4-849b7bf7e257"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("16f7cdde-ad69-4f1f-b422-5130231c6676"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("97afb517-6f30-433f-81db-dae3319746e0"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("a9911643-7e25-4ad0-a9b3-ab2d03f19a77"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("b4eeb05b-c63b-4205-b258-a9ff18a9a706"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: new Guid("eb8dc29c-59ab-452b-97cc-84bdcc38663a"));

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Options");

            migrationBuilder.AddColumn<Guid>(
                name: "IDOptions",
                table: "Images",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Images_IDOptions",
                table: "Images",
                column: "IDOptions",
                unique: true,
                filter: "[IDOptions] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Options_IDOptions",
                table: "Images",
                column: "IDOptions",
                principalTable: "Options",
                principalColumn: "ID");
        }
    }
}
