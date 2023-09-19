using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    public partial class initial6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_AppRoles_AppRoleRoleID",
                table: "AppUsers");

            migrationBuilder.DropIndex(
                name: "IX_AppUsers_AppRoleRoleID",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "AppRoleRoleID",
                table: "AppUsers");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_RoleID",
                table: "AppUsers",
                column: "RoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_AppRoles_RoleID",
                table: "AppUsers",
                column: "RoleID",
                principalTable: "AppRoles",
                principalColumn: "RoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_AppRoles_RoleID",
                table: "AppUsers");

            migrationBuilder.DropIndex(
                name: "IX_AppUsers_RoleID",
                table: "AppUsers");

            migrationBuilder.AddColumn<int>(
                name: "AppRoleRoleID",
                table: "AppUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_AppRoleRoleID",
                table: "AppUsers",
                column: "AppRoleRoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_AppRoles_AppRoleRoleID",
                table: "AppUsers",
                column: "AppRoleRoleID",
                principalTable: "AppRoles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
