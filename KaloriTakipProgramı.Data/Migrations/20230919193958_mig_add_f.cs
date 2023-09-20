using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    public partial class mig_add_f : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate2 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName", "CreatedDate", "DeletedDate", "ModifiedDate", "ModifiedDate2", "Status" },
                values: new object[] { 1, "Deniz Ürünleri", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calories", "Carbohydrate", "CategoryID", "CreatedDate", "DeletedDate", "Fat", "FoodName", "GramCompensation", "MacroFoodReportReportID", "ModifiedDate", "ModifiedDate2", "Protein", "Status", "TotalCalories" },
                values: new object[,]
                {
                    { 1, 2.08f, 0f, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.13f, "Somon", 100f, null, null, null, 0.19f, false, 2.08f },
                    { 2, 0.73f, 0.01f, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.08f, "Ahtapot", 100f, null, null, null, 0.15f, false, 0.73f },
                    { 3, 1.01f, 0f, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, "Alabalık", 100f, null, null, null, 0.19f, false, 1.01f },
                    { 4, 1.2f, 0f, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.06f, "Barbun", 100f, null, null, null, 0.16f, false, 1.2f },
                    { 5, 1.2f, 0f, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.06f, "Çipura", 100f, null, null, null, 0.16f, false, 1.2f },
                    { 6, 0.79f, 0f, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, "Dil Balığı", 100f, null, null, null, 0.19f, false, 0.79f },
                    { 7, 2f, 0.05f, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.1f, "Izgara Hamsi", 100f, null, null, null, 0.19f, false, 2f },
                    { 8, 1.15f, 0f, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.05f, "Kızartma Hamsi", 100f, null, null, null, 0.17f, false, 1.15f },
                    { 9, 2.62f, 0.03f, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.15f, "Havyar", 100f, null, null, null, 0.26f, false, 2.62f },
                    { 10, 0.91f, 0f, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.02f, "Istakoz", 100f, null, null, null, 0.17f, false, 0.91f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryID",
                table: "Foods",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Category_CategoryID",
                table: "Foods",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Category_CategoryID",
                table: "Foods");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Foods_CategoryID",
                table: "Foods");

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Foods");
        }
    }
}
