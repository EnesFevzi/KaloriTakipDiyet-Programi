using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRole",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRole", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    MealID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.MealID);
                });

            migrationBuilder.CreateTable(
                name: "Waters",
                columns: table => new
                {
                    WaterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WaterQuantity = table.Column<float>(type: "real", nullable: false),
                    ConsumedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waters", x => x.WaterID);
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    AppUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    VKI = table.Column<float>(type: "real", nullable: false),
                    VYO = table.Column<float>(type: "real", nullable: false),
                    BMH = table.Column<float>(type: "real", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    AppRoleRoleID = table.Column<int>(type: "int", nullable: false),
                    WaterID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.AppUserID);
                    table.ForeignKey(
                        name: "FK_AppUsers_AppRole_AppRoleRoleID",
                        column: x => x.AppRoleRoleID,
                        principalTable: "AppRole",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUsers_Waters_WaterID",
                        column: x => x.WaterID,
                        principalTable: "Waters",
                        principalColumn: "WaterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MacroFoodReport",
                columns: table => new
                {
                    ReportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaloriesValue = table.Column<int>(type: "int", nullable: false),
                    CarbohydrateValue = table.Column<int>(type: "int", nullable: false),
                    ProteinValue = table.Column<int>(type: "int", nullable: false),
                    FatValue = table.Column<int>(type: "int", nullable: false),
                    IssuedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MacroFoodReport", x => x.ReportID);
                    table.ForeignKey(
                        name: "FK_MacroFoodReport_AppUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AppUsers",
                        principalColumn: "AppUserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MealOfDays",
                columns: table => new
                {
                    MealOfDayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealID = table.Column<int>(type: "int", nullable: false),
                    AppUserID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                name: "Foods",
                columns: table => new
                {
                    FoodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GramCompensation = table.Column<float>(type: "real", nullable: false),
                    Calories = table.Column<float>(type: "real", nullable: false),
                    Carbohydrate = table.Column<float>(type: "real", nullable: false),
                    Protein = table.Column<float>(type: "real", nullable: false),
                    Fat = table.Column<float>(type: "real", nullable: false),
                    TotalCalories = table.Column<float>(type: "real", nullable: false),
                    AppUserID = table.Column<int>(type: "int", nullable: true),
                    MealOfDayID = table.Column<int>(type: "int", nullable: true),
                    MacroFoodReportReportID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodID);
                    table.ForeignKey(
                        name: "FK_Foods_AppUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AppUsers",
                        principalColumn: "AppUserID");
                    table.ForeignKey(
                        name: "FK_Foods_MacroFoodReport_MacroFoodReportReportID",
                        column: x => x.MacroFoodReportReportID,
                        principalTable: "MacroFoodReport",
                        principalColumn: "ReportID");
                    table.ForeignKey(
                        name: "FK_Foods_MealOfDays_MealOfDayID",
                        column: x => x.MealOfDayID,
                        principalTable: "MealOfDays",
                        principalColumn: "MealOfDayID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_AppRoleRoleID",
                table: "AppUsers",
                column: "AppRoleRoleID");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_WaterID",
                table: "AppUsers",
                column: "WaterID");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_AppUserID",
                table: "Foods",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_MacroFoodReportReportID",
                table: "Foods",
                column: "MacroFoodReportReportID");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_MealOfDayID",
                table: "Foods",
                column: "MealOfDayID");

            migrationBuilder.CreateIndex(
                name: "IX_MacroFoodReport_AppUserID",
                table: "MacroFoodReport",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_MealOfDays_AppUserID",
                table: "MealOfDays",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_MealOfDays_MealID",
                table: "MealOfDays",
                column: "MealID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "MacroFoodReport");

            migrationBuilder.DropTable(
                name: "MealOfDays");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "AppRole");

            migrationBuilder.DropTable(
                name: "Waters");
        }
    }
}
