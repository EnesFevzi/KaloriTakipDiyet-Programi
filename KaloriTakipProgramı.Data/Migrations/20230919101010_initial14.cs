using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    public partial class initial14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_Waters_WaterID",
                table: "AppUsers");

            migrationBuilder.DropIndex(
                name: "IX_AppUsers_WaterID",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "WaterID",
                table: "AppUsers");

            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Waters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Waters_AppUserID",
                table: "Waters",
                column: "AppUserID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Waters_AppUsers_AppUserID",
                table: "Waters",
                column: "AppUserID",
                principalTable: "AppUsers",
                principalColumn: "AppUserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Waters_AppUsers_AppUserID",
                table: "Waters");

            migrationBuilder.DropIndex(
                name: "IX_Waters_AppUserID",
                table: "Waters");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Waters");

            migrationBuilder.AddColumn<int>(
                name: "WaterID",
                table: "AppUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_WaterID",
                table: "AppUsers",
                column: "WaterID");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_Waters_WaterID",
                table: "AppUsers",
                column: "WaterID",
                principalTable: "Waters",
                principalColumn: "WaterID");
        }
    }
}
