using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataandUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3dc84d96-02c2-4d0b-aca7-642ac9bfe078", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "ad8dd0da-232e-4d9a-933b-062bbc76bdc9", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "a1643db1-e881-4544-87b6-fc63b3f27a7b", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEFT8jvXqheuft1zvKHGOzaOt0GexQ5l3bKX1GzRuED5VBLo2oPwAnLtFkf8rfsZ3hg==", null, false, "97b3312a-1e73-4780-a758-d67922268ff3", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 19, 19, 16, 48, 429, DateTimeKind.Local).AddTicks(6065), new DateTime(2022, 11, 19, 19, 16, 48, 430, DateTimeKind.Local).AddTicks(4584), "Black", "System" },
                    { 2, "System", new DateTime(2022, 11, 19, 19, 16, 48, 430, DateTimeKind.Local).AddTicks(5074), new DateTime(2022, 11, 19, 19, 16, 48, 430, DateTimeKind.Local).AddTicks(5077), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 19, 19, 16, 48, 431, DateTimeKind.Local).AddTicks(3176), new DateTime(2022, 11, 19, 19, 16, 48, 431, DateTimeKind.Local).AddTicks(3185), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 11, 19, 19, 16, 48, 431, DateTimeKind.Local).AddTicks(3187), new DateTime(2022, 11, 19, 19, 16, 48, 431, DateTimeKind.Local).AddTicks(3188), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 19, 19, 16, 48, 431, DateTimeKind.Local).AddTicks(5541), new DateTime(2022, 11, 19, 19, 16, 48, 431, DateTimeKind.Local).AddTicks(5552), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 11, 19, 19, 16, 48, 431, DateTimeKind.Local).AddTicks(5554), new DateTime(2022, 11, 19, 19, 16, 48, 431, DateTimeKind.Local).AddTicks(5554), "X5", "System" },
                    { 3, "System", new DateTime(2022, 11, 19, 19, 16, 48, 431, DateTimeKind.Local).AddTicks(5556), new DateTime(2022, 11, 19, 19, 16, 48, 431, DateTimeKind.Local).AddTicks(5556), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 11, 19, 19, 16, 48, 431, DateTimeKind.Local).AddTicks(5558), new DateTime(2022, 11, 19, 19, 16, 48, 431, DateTimeKind.Local).AddTicks(5558), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
