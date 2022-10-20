using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeviceShop.Core.Migrations
{
    public partial class start4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c49e4c34-6ac0-4ec6-b1bc-a0d7ba08efed", "5b193c87-db23-4ece-8c4c-92cbcee19caa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "78a6fb81-400d-48e7-a281-f11cb38982cf", "f9bb1594-be0b-44b7-bad2-082559da490a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c49e4c34-6ac0-4ec6-b1bc-a0d7ba08efed", "f9bb1594-be0b-44b7-bad2-082559da490a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78a6fb81-400d-48e7-a281-f11cb38982cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c49e4c34-6ac0-4ec6-b1bc-a0d7ba08efed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b193c87-db23-4ece-8c4c-92cbcee19caa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9bb1594-be0b-44b7-bad2-082559da490a");

            migrationBuilder.DropColumn(
                name: "Colour",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "Guarantee",
                table: "Devices");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "aa5f94e4-df13-47d0-b7e0-10d1a8c46e0f", "220e9c62-9572-4f4b-a6ec-b784a0914a0e", "Admin", "ADMIN" },
                    { "adcbf5c7-2299-4f20-a4a1-a97e200b995c", "0811325f-7a1f-4d7b-b8cc-23ca5b0fd365", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5cd4906d-8e4d-4cba-b643-ff9ba5387463", 0, "75a3b392-afdc-4c8e-be37-d37d50014cf9", "admin@deviceshop.com", true, null, null, false, null, "ADMIN@DEVICESHOP.COM", "ADMIN@DEVICESHOP.COM", "AQAAAAEAACcQAAAAEERjP42Ik3Dmlll++WxLTLtqYYdQ46at6Jybg1ORFwjcABnMzGR7o2Ox856TE5+7wA==", null, false, "85bf6b2c-fe00-469f-b6ee-b80891abeb54", false, "admin@deviceshop.com" },
                    { "7a1ec81d-75d7-44f5-9c3e-65e03fe23fcf", 0, "8e2d2732-5c0d-41a5-b9a2-f263bfafd3b8", "user@deviceshop.com", true, null, null, false, null, "USER@DEVICESHOP.COM", "USER@DEVICESHOP.COM", "AQAAAAEAACcQAAAAEDMHtpQUkyZz9a3qYhGtjTZpkn8wWdTkkYP6EHJdc87n2PBaJ0qy8yoyQL9Ol2B02g==", null, false, "fc99493c-b445-434f-ab0c-392663e75c37", false, "user@deviceshop.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "aa5f94e4-df13-47d0-b7e0-10d1a8c46e0f", "5cd4906d-8e4d-4cba-b643-ff9ba5387463" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "aa5f94e4-df13-47d0-b7e0-10d1a8c46e0f", "7a1ec81d-75d7-44f5-9c3e-65e03fe23fcf" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "adcbf5c7-2299-4f20-a4a1-a97e200b995c", "7a1ec81d-75d7-44f5-9c3e-65e03fe23fcf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aa5f94e4-df13-47d0-b7e0-10d1a8c46e0f", "5cd4906d-8e4d-4cba-b643-ff9ba5387463" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aa5f94e4-df13-47d0-b7e0-10d1a8c46e0f", "7a1ec81d-75d7-44f5-9c3e-65e03fe23fcf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "adcbf5c7-2299-4f20-a4a1-a97e200b995c", "7a1ec81d-75d7-44f5-9c3e-65e03fe23fcf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa5f94e4-df13-47d0-b7e0-10d1a8c46e0f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adcbf5c7-2299-4f20-a4a1-a97e200b995c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cd4906d-8e4d-4cba-b643-ff9ba5387463");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a1ec81d-75d7-44f5-9c3e-65e03fe23fcf");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "78a6fb81-400d-48e7-a281-f11cb38982cf", "657214fd-03eb-4c36-8bf4-4b7163ba6ee4", "User", "USER" },
                    { "c49e4c34-6ac0-4ec6-b1bc-a0d7ba08efed", "faa129e0-a580-462a-9f02-ac066139d838", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5b193c87-db23-4ece-8c4c-92cbcee19caa", 0, "59726ead-7b02-4d01-804f-2cbed4b83814", "admin@deviceshop.com", true, null, null, false, null, "ADMIN@DEVICESHOP.COM", "ADMIN@DEVICESHOP.COM", "AQAAAAEAACcQAAAAEDbZrI4CHR2CA5vx89PRsmf6b+CjgpezbH3HcKIgauDfPCCYZK0SP7mcvr5/uch4AQ==", null, false, "14bce653-eb23-4b8c-8c5f-27b5d41a015f", false, "admin@deviceshop.com" },
                    { "f9bb1594-be0b-44b7-bad2-082559da490a", 0, "452719ad-849a-44a9-bba5-dafe6a1080b1", "user@deviceshop.com", true, null, null, false, null, "USER@DEVICESHOP.COM", "USER@DEVICESHOP.COM", "AQAAAAEAACcQAAAAEBP2qZIJHE1NEQVVdG5Nvwwv1s+YJOdC2ZQOR263IE2mwzmuyzU1JvvTzfcU63U7eQ==", null, false, "945fe413-3f80-43e3-a8e3-48673beb4c72", false, "user@deviceshop.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c49e4c34-6ac0-4ec6-b1bc-a0d7ba08efed", "5b193c87-db23-4ece-8c4c-92cbcee19caa" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "78a6fb81-400d-48e7-a281-f11cb38982cf", "f9bb1594-be0b-44b7-bad2-082559da490a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c49e4c34-6ac0-4ec6-b1bc-a0d7ba08efed", "f9bb1594-be0b-44b7-bad2-082559da490a" });
        }
    }
}
