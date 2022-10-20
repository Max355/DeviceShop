using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeviceShop.Core.Migrations
{
    public partial class start1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "38f1aef2-2c68-43e3-ae72-65eb8b6b83e0", "a1c2c364-7d38-449d-b38c-45206515ed73", "Admin", "ADMIN" },
                    { "6fb04463-e9c9-4d5b-84df-ec504d5145c7", "a67ce63b-9bb0-4783-addf-79571b870f56", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d87ae611-6741-49ad-8a6e-396fe0adb8cc", 0, "ac511cdd-3be5-4ab3-b547-394d134efb91", "user@deviceshop.com", true, null, null, false, null, "USER@DEVICESHOP.COM", "USER@DEVICESHOP.COM", "AQAAAAEAACcQAAAAEC+Axfy0wCQvFcuhAvioSm1KRd+H7FLtNvp0e0ezFguOFVyCbR34doIbPBfjNhrT5w==", null, false, "becfc359-f456-4fe6-a361-ccc7b7e9e79c", false, "user@deviceshop.com" },
                    { "dd4b197c-5207-4a66-ab6a-f39a52cf0624", 0, "0a2988c8-9962-4eaa-a0d6-019adb595cb5", "admin@deviceshop.com", true, null, null, false, null, "ADMIN@DEVICESHOP.COM", "ADMIN@DEVICESHOP.COM", "AQAAAAEAACcQAAAAENut4lNCZ4BwYwgHykb+0rlzgo8YMsLP9E94+yfdC/Bfs6Gw4iuMBT6OP11zVtCOow==", null, false, "fb3e6e23-be20-4a05-a359-63ae0b1d068d", false, "admin@deviceshop.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "38f1aef2-2c68-43e3-ae72-65eb8b6b83e0", "d87ae611-6741-49ad-8a6e-396fe0adb8cc" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6fb04463-e9c9-4d5b-84df-ec504d5145c7", "d87ae611-6741-49ad-8a6e-396fe0adb8cc" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "38f1aef2-2c68-43e3-ae72-65eb8b6b83e0", "dd4b197c-5207-4a66-ab6a-f39a52cf0624" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "38f1aef2-2c68-43e3-ae72-65eb8b6b83e0", "d87ae611-6741-49ad-8a6e-396fe0adb8cc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6fb04463-e9c9-4d5b-84df-ec504d5145c7", "d87ae611-6741-49ad-8a6e-396fe0adb8cc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "38f1aef2-2c68-43e3-ae72-65eb8b6b83e0", "dd4b197c-5207-4a66-ab6a-f39a52cf0624" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38f1aef2-2c68-43e3-ae72-65eb8b6b83e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fb04463-e9c9-4d5b-84df-ec504d5145c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d87ae611-6741-49ad-8a6e-396fe0adb8cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd4b197c-5207-4a66-ab6a-f39a52cf0624");

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
    }
}
