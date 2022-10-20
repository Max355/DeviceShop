using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeviceShop.Core.Migrations
{
    public partial class start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3f57dc08-0542-4e9f-83d9-a450660238ad", "55254af5-a16c-4b98-a7d3-284cd64321ba" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3f57dc08-0542-4e9f-83d9-a450660238ad", "8e0481d7-6ca9-42bf-8dfb-a703ba83970a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4aa5e114-2708-4447-a665-4197ee0abfbd", "8e0481d7-6ca9-42bf-8dfb-a703ba83970a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f57dc08-0542-4e9f-83d9-a450660238ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4aa5e114-2708-4447-a665-4197ee0abfbd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55254af5-a16c-4b98-a7d3-284cd64321ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e0481d7-6ca9-42bf-8dfb-a703ba83970a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14f0fafd-4f98-4fe4-9b89-4b1c1691863d", "8f8baed7-45bb-45ab-a5ee-c1eac2f87eaf", "Admin", "ADMIN" },
                    { "78a93bcc-97c2-4c0e-9382-1700722cbf03", "a6752595-70d8-40f4-b1d3-822f7c862c2a", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5389fd2f-602e-41fc-ba29-f4eec7454cd5", 0, "361d6972-639e-47aa-bd7a-abe4ef911fcd", "admin@deviceshop.com", true, null, null, false, null, "ADMIN@DEVICESHOP.COM", "ADMIN@DEVICESHOP.COM", "AQAAAAEAACcQAAAAEPqCyDxABOdkoOAiBcZ/d15EzKLOa2OJzNIbdVHq7Ato3m8rLK4Q3oDJ9o7iensI2A==", null, false, "1118a686-837c-44d7-a58d-eecf3be7e066", false, "admin@deviceshop.com" },
                    { "ae2558ab-a51c-4b31-9252-34d57bd21b2d", 0, "0586d8f9-ef92-44e4-934a-449d3c34ef3b", "user@deviceshop.com", true, null, null, false, null, "USER@DEVICESHOP.COM", "USER@DEVICESHOP.COM", "AQAAAAEAACcQAAAAEN1xBSiC2Wyxv9Fb5qFhWph3189fZjmuytg+flt6tE2APASvfLyrNxu8PxBXYHXsEQ==", null, false, "e5e2815b-8d52-44c1-85f7-b3f087d6ed72", false, "user@deviceshop.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "14f0fafd-4f98-4fe4-9b89-4b1c1691863d", "5389fd2f-602e-41fc-ba29-f4eec7454cd5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "14f0fafd-4f98-4fe4-9b89-4b1c1691863d", "ae2558ab-a51c-4b31-9252-34d57bd21b2d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "78a93bcc-97c2-4c0e-9382-1700722cbf03", "ae2558ab-a51c-4b31-9252-34d57bd21b2d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "14f0fafd-4f98-4fe4-9b89-4b1c1691863d", "5389fd2f-602e-41fc-ba29-f4eec7454cd5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "14f0fafd-4f98-4fe4-9b89-4b1c1691863d", "ae2558ab-a51c-4b31-9252-34d57bd21b2d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "78a93bcc-97c2-4c0e-9382-1700722cbf03", "ae2558ab-a51c-4b31-9252-34d57bd21b2d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14f0fafd-4f98-4fe4-9b89-4b1c1691863d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78a93bcc-97c2-4c0e-9382-1700722cbf03");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5389fd2f-602e-41fc-ba29-f4eec7454cd5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae2558ab-a51c-4b31-9252-34d57bd21b2d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3f57dc08-0542-4e9f-83d9-a450660238ad", "33d7128b-a36a-4c68-a518-40cd3e963e1a", "Admin", "ADMIN" },
                    { "4aa5e114-2708-4447-a665-4197ee0abfbd", "d39d26cd-6ee6-434d-bbbf-4830fb7d8add", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "55254af5-a16c-4b98-a7d3-284cd64321ba", 0, "0cd195be-9eeb-4c33-ae19-f19b503b9e27", "admin@deviceshop.com", true, null, null, false, null, "ADMIN@DEVICESHOP.COM", "ADMIN@DEVICESHOP.COM", "AQAAAAEAACcQAAAAEM0vwWb+iz/ZlAjv7zSvyrZOcOUdmIMBNB7i/Wc4gAsDRn2y50XbCKtlnbxlACB6Zw==", null, false, "2bff2bc8-4edf-499a-9784-def79447c5de", false, "admin@deviceshop.com" },
                    { "8e0481d7-6ca9-42bf-8dfb-a703ba83970a", 0, "c030ba5e-d575-467a-8756-9b7d23e2cc3f", "user@deviceshop.com", true, null, null, false, null, "USER@DEVICESHOP.COM", "USER@DEVICESHOP.COM", "AQAAAAEAACcQAAAAEC1WpqO7Q0J220Hq76GNnIeRWgtamoJNQ7X2Z970M822HZ4D1SnVOovJmYU1A+67ew==", null, false, "bdc5c997-3939-46a7-86a0-2cfdef338159", false, "user@deviceshop.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3f57dc08-0542-4e9f-83d9-a450660238ad", "55254af5-a16c-4b98-a7d3-284cd64321ba" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3f57dc08-0542-4e9f-83d9-a450660238ad", "8e0481d7-6ca9-42bf-8dfb-a703ba83970a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4aa5e114-2708-4447-a665-4197ee0abfbd", "8e0481d7-6ca9-42bf-8dfb-a703ba83970a" });
        }
    }
}
