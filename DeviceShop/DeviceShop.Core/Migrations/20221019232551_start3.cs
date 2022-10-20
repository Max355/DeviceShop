using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeviceShop.Core.Migrations
{
    public partial class start3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "ColourId",
                table: "Devices",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Devices",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GuaranteeId",
                table: "Devices",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Colours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColourTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guarantees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuaranteeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guarantees", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Devices_ColourId",
                table: "Devices",
                column: "ColourId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_CompanyId",
                table: "Devices",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_GuaranteeId",
                table: "Devices",
                column: "GuaranteeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Colours_ColourId",
                table: "Devices",
                column: "ColourId",
                principalTable: "Colours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Companys_CompanyId",
                table: "Devices",
                column: "CompanyId",
                principalTable: "Companys",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Guarantees_GuaranteeId",
                table: "Devices",
                column: "GuaranteeId",
                principalTable: "Guarantees",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Colours_ColourId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Companys_CompanyId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Guarantees_GuaranteeId",
                table: "Devices");

            migrationBuilder.DropTable(
                name: "Colours");

            migrationBuilder.DropTable(
                name: "Companys");

            migrationBuilder.DropTable(
                name: "Guarantees");

            migrationBuilder.DropIndex(
                name: "IX_Devices_ColourId",
                table: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_Devices_CompanyId",
                table: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_Devices_GuaranteeId",
                table: "Devices");

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
                name: "ColourId",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "GuaranteeId",
                table: "Devices");

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
    }
}
