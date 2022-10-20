using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeviceShop.Core.Migrations
{
    public partial class start2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Devices",
                newName: "DeviceId");

            migrationBuilder.AddColumn<string>(
                name: "Colour",
                table: "Devices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "Devices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Guarantee",
                table: "Devices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Devices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Devices",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6e5e3475-dde5-45ed-a265-6654c7e9a70f", "9bd08490-d0de-46e7-bb8d-64b339b23e9f", "Admin", "ADMIN" },
                    { "a75d3a39-a96e-4474-a77e-118d814bdeb1", "740ff016-a976-487b-934f-d0faf4354038", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3d38e9b2-32ec-4103-b1df-fb51a12084c1", 0, "cdfc563d-d13f-4394-afbf-2aeb01515c81", "user@deviceshop.com", true, null, null, false, null, "USER@DEVICESHOP.COM", "USER@DEVICESHOP.COM", "AQAAAAEAACcQAAAAEEqd7duW4M56l1Lfi4SsnA+HqanTICzeRsNdc4Ij3D4jEbZ2MkkmgUxAwWmCUReQXA==", null, false, "c6494313-55f3-4d63-b27b-a4a3de2252a9", false, "user@deviceshop.com" },
                    { "aeecea6e-a0de-427f-8218-df9cab48df9a", 0, "74d545aa-92d7-481d-8d47-c63d0dce581b", "admin@deviceshop.com", true, null, null, false, null, "ADMIN@DEVICESHOP.COM", "ADMIN@DEVICESHOP.COM", "AQAAAAEAACcQAAAAEBhiS1HzdQpQkHbF1IY6ox3mOYKit6Zef0lO4XXU1wuq+L7USoQx3Vbx53jJ4ZbGhQ==", null, false, "92da1d3f-6b9d-499f-8d56-a2c2900da52b", false, "admin@deviceshop.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6e5e3475-dde5-45ed-a265-6654c7e9a70f", "3d38e9b2-32ec-4103-b1df-fb51a12084c1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a75d3a39-a96e-4474-a77e-118d814bdeb1", "3d38e9b2-32ec-4103-b1df-fb51a12084c1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6e5e3475-dde5-45ed-a265-6654c7e9a70f", "aeecea6e-a0de-427f-8218-df9cab48df9a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6e5e3475-dde5-45ed-a265-6654c7e9a70f", "3d38e9b2-32ec-4103-b1df-fb51a12084c1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a75d3a39-a96e-4474-a77e-118d814bdeb1", "3d38e9b2-32ec-4103-b1df-fb51a12084c1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6e5e3475-dde5-45ed-a265-6654c7e9a70f", "aeecea6e-a0de-427f-8218-df9cab48df9a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e5e3475-dde5-45ed-a265-6654c7e9a70f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a75d3a39-a96e-4474-a77e-118d814bdeb1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d38e9b2-32ec-4103-b1df-fb51a12084c1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aeecea6e-a0de-427f-8218-df9cab48df9a");

            migrationBuilder.DropColumn(
                name: "Colour",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "Guarantee",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Devices");

            migrationBuilder.RenameColumn(
                name: "DeviceId",
                table: "Devices",
                newName: "Id");

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
    }
}
