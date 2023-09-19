using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    public partial class initial12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ChestCircle",
                table: "AppUsers",
                newName: "NeckCircle");

            migrationBuilder.AddColumn<double>(
                name: "ActivityValue",
                table: "AppUsers",
                type: "float",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivityValue",
                table: "AppUsers");

            migrationBuilder.RenameColumn(
                name: "NeckCircle",
                table: "AppUsers",
                newName: "ChestCircle");
        }
    }
}
