using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    public partial class mig_Add_sadda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Category_CategoryID",
                table: "Foods");

            migrationBuilder.DropForeignKey(
                name: "FK_Foods_MacroFoodReport_MacroFoodReportReportID",
                table: "Foods");

            migrationBuilder.DropForeignKey(
                name: "FK_MacroFoodReport_AppUsers_AppUserID",
                table: "MacroFoodReport");

            migrationBuilder.DropTable(
                name: "FoodMealOfDay");

            migrationBuilder.DropTable(
                name: "MealOfDays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MacroFoodReport",
                table: "MacroFoodReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "MacroFoodReport",
                newName: "MacroFoodReports");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_MacroFoodReport_AppUserID",
                table: "MacroFoodReports",
                newName: "IX_MacroFoodReports_AppUserID");

            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Meals",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Meals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Meals",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Meals",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate2",
                table: "Meals",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Meals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MacroFoodReports",
                table: "MacroFoodReports",
                column: "ReportID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryID");

            migrationBuilder.CreateTable(
                name: "ConsumeFood",
                columns: table => new
                {
                    ConsumeFoodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsumeFoodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GramCompensation = table.Column<float>(type: "real", nullable: false),
                    Calories = table.Column<float>(type: "real", nullable: false),
                    Carbohydrate = table.Column<float>(type: "real", nullable: false),
                    Protein = table.Column<float>(type: "real", nullable: false),
                    Fat = table.Column<float>(type: "real", nullable: false),
                    AppUserID = table.Column<int>(type: "int", nullable: false),
                    MealID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate2 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumeFood", x => x.ConsumeFoodID);
                    table.ForeignKey(
                        name: "FK_ConsumeFood_AppUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AppUsers",
                        principalColumn: "AppUserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsumeFood_Meals_MealID",
                        column: x => x.MealID,
                        principalTable: "Meals",
                        principalColumn: "MealID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsumeFoodFood",
                columns: table => new
                {
                    ConsumeFoodsConsumeFoodID = table.Column<int>(type: "int", nullable: false),
                    FoodsFoodID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumeFoodFood", x => new { x.ConsumeFoodsConsumeFoodID, x.FoodsFoodID });
                    table.ForeignKey(
                        name: "FK_ConsumeFoodFood_ConsumeFood_ConsumeFoodsConsumeFoodID",
                        column: x => x.ConsumeFoodsConsumeFoodID,
                        principalTable: "ConsumeFood",
                        principalColumn: "ConsumeFoodID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsumeFoodFood_Foods_FoodsFoodID",
                        column: x => x.FoodsFoodID,
                        principalTable: "Foods",
                        principalColumn: "FoodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 10, 55, 35, 959, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 10, 55, 35, 959, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 10, 55, 35, 959, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 10, 55, 35, 959, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 10, 55, 35, 959, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 10, 55, 35, 959, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 10, 55, 35, 959, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 10, 55, 35, 959, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 10, 55, 35, 959, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 10, 55, 35, 959, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 10, 55, 35, 959, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.CreateIndex(
                name: "IX_Meals_AppUserID",
                table: "Meals",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumeFood_AppUserID",
                table: "ConsumeFood",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumeFood_MealID",
                table: "ConsumeFood",
                column: "MealID");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumeFoodFood_FoodsFoodID",
                table: "ConsumeFoodFood",
                column: "FoodsFoodID");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Categories_CategoryID",
                table: "Foods",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_MacroFoodReports_MacroFoodReportReportID",
                table: "Foods",
                column: "MacroFoodReportReportID",
                principalTable: "MacroFoodReports",
                principalColumn: "ReportID");

            migrationBuilder.AddForeignKey(
                name: "FK_MacroFoodReports_AppUsers_AppUserID",
                table: "MacroFoodReports",
                column: "AppUserID",
                principalTable: "AppUsers",
                principalColumn: "AppUserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_AppUsers_AppUserID",
                table: "Meals",
                column: "AppUserID",
                principalTable: "AppUsers",
                principalColumn: "AppUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Categories_CategoryID",
                table: "Foods");

            migrationBuilder.DropForeignKey(
                name: "FK_Foods_MacroFoodReports_MacroFoodReportReportID",
                table: "Foods");

            migrationBuilder.DropForeignKey(
                name: "FK_MacroFoodReports_AppUsers_AppUserID",
                table: "MacroFoodReports");

            migrationBuilder.DropForeignKey(
                name: "FK_Meals_AppUsers_AppUserID",
                table: "Meals");

            migrationBuilder.DropTable(
                name: "ConsumeFoodFood");

            migrationBuilder.DropTable(
                name: "ConsumeFood");

            migrationBuilder.DropIndex(
                name: "IX_Meals_AppUserID",
                table: "Meals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MacroFoodReports",
                table: "MacroFoodReports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "ModifiedDate2",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Meals");

            migrationBuilder.RenameTable(
                name: "MacroFoodReports",
                newName: "MacroFoodReport");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_MacroFoodReports_AppUserID",
                table: "MacroFoodReport",
                newName: "IX_MacroFoodReport_AppUserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MacroFoodReport",
                table: "MacroFoodReport",
                column: "ReportID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CategoryID");

            migrationBuilder.CreateTable(
                name: "MealOfDays",
                columns: table => new
                {
                    MealOfDayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserID = table.Column<int>(type: "int", nullable: false),
                    MealID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate2 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealOfDays", x => x.MealOfDayID);
                    table.ForeignKey(
                        name: "FK_MealOfDays_AppUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AppUsers",
                        principalColumn: "AppUserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MealOfDays_Meals_MealID",
                        column: x => x.MealID,
                        principalTable: "Meals",
                        principalColumn: "MealID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodMealOfDay",
                columns: table => new
                {
                    FoodsFoodID = table.Column<int>(type: "int", nullable: false),
                    MealOfDaysMealOfDayID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodMealOfDay", x => new { x.FoodsFoodID, x.MealOfDaysMealOfDayID });
                    table.ForeignKey(
                        name: "FK_FoodMealOfDay_Foods_FoodsFoodID",
                        column: x => x.FoodsFoodID,
                        principalTable: "Foods",
                        principalColumn: "FoodID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodMealOfDay_MealOfDays_MealOfDaysMealOfDayID",
                        column: x => x.MealOfDaysMealOfDayID,
                        principalTable: "MealOfDays",
                        principalColumn: "MealOfDayID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_FoodMealOfDay_MealOfDaysMealOfDayID",
                table: "FoodMealOfDay",
                column: "MealOfDaysMealOfDayID");

            migrationBuilder.CreateIndex(
                name: "IX_MealOfDays_AppUserID",
                table: "MealOfDays",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_MealOfDays_MealID",
                table: "MealOfDays",
                column: "MealID");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Category_CategoryID",
                table: "Foods",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_MacroFoodReport_MacroFoodReportReportID",
                table: "Foods",
                column: "MacroFoodReportReportID",
                principalTable: "MacroFoodReport",
                principalColumn: "ReportID");

            migrationBuilder.AddForeignKey(
                name: "FK_MacroFoodReport_AppUsers_AppUserID",
                table: "MacroFoodReport",
                column: "AppUserID",
                principalTable: "AppUsers",
                principalColumn: "AppUserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
