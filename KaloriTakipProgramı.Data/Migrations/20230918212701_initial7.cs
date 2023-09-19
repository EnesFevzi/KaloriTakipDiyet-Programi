using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    public partial class initial7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "BasinCircle",
                table: "AppUsers",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ChestCircle",
                table: "AppUsers",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "WaistCircle",
                table: "AppUsers",
                type: "float",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BasinCircle",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "ChestCircle",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "WaistCircle",
                table: "AppUsers");
        }
    }
}
