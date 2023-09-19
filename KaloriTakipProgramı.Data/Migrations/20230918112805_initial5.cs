using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    public partial class initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_AppRole_AppRoleRoleID",
                table: "AppUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRole",
                table: "AppRole");

            migrationBuilder.RenameTable(
                name: "AppRole",
                newName: "AppRoles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRoles",
                table: "AppRoles",
                column: "RoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_AppRoles_AppRoleRoleID",
                table: "AppUsers",
                column: "AppRoleRoleID",
                principalTable: "AppRoles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_AppRoles_AppRoleRoleID",
                table: "AppUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRoles",
                table: "AppRoles");

            migrationBuilder.RenameTable(
                name: "AppRoles",
                newName: "AppRole");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRole",
                table: "AppRole",
                column: "RoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_AppRole_AppRoleRoleID",
                table: "AppUsers",
                column: "AppRoleRoleID",
                principalTable: "AppRole",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
