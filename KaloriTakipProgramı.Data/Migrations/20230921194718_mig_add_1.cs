using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    public partial class mig_add_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate2 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    MealID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate2 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.MealID);
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    AppUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<float>(type: "real", nullable: true),
                    Weight = table.Column<float>(type: "real", nullable: true),
                    BasinCircle = table.Column<float>(type: "real", nullable: true),
                    NeckCircle = table.Column<float>(type: "real", nullable: true),
                    WaistCircle = table.Column<float>(type: "real", nullable: true),
                    ActivityValue = table.Column<float>(type: "real", nullable: true),
                    LastWaterAdditionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VKI = table.Column<double>(type: "float", nullable: true),
                    VYO = table.Column<double>(type: "float", nullable: true),
                    BMH = table.Column<double>(type: "float", nullable: true),
                    RoleID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate2 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.AppUserID);
                    table.ForeignKey(
                        name: "FK_AppUsers_AppRoles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "AppRoles",
                        principalColumn: "RoleID");
                });

            migrationBuilder.CreateTable(
                name: "ConsumeFoods",
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
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserID = table.Column<int>(type: "int", nullable: false),
                    MealID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate2 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumeFoods", x => x.ConsumeFoodID);
                    table.ForeignKey(
                        name: "FK_ConsumeFoods_AppUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AppUsers",
                        principalColumn: "AppUserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsumeFoods_Meals_MealID",
                        column: x => x.MealID,
                        principalTable: "Meals",
                        principalColumn: "MealID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MacroFoodReports",
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
                    table.PrimaryKey("PK_MacroFoodReports", x => x.ReportID);
                    table.ForeignKey(
                        name: "FK_MacroFoodReports_AppUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AppUsers",
                        principalColumn: "AppUserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Waters",
                columns: table => new
                {
                    WaterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WaterQuantity = table.Column<float>(type: "real", nullable: false),
                    ConsumedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate2 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waters", x => x.WaterID);
                    table.ForeignKey(
                        name: "FK_Waters_AppUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AppUsers",
                        principalColumn: "AppUserID",
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
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    MacroFoodReportReportID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate2 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodID);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID");
                    table.ForeignKey(
                        name: "FK_Foods_MacroFoodReports_MacroFoodReportReportID",
                        column: x => x.MacroFoodReportReportID,
                        principalTable: "MacroFoodReports",
                        principalColumn: "ReportID");
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
                        name: "FK_ConsumeFoodFood_ConsumeFoods_ConsumeFoodsConsumeFoodID",
                        column: x => x.ConsumeFoodsConsumeFoodID,
                        principalTable: "ConsumeFoods",
                        principalColumn: "ConsumeFoodID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsumeFoodFood_Foods_FoodsFoodID",
                        column: x => x.FoodsFoodID,
                        principalTable: "Foods",
                        principalColumn: "FoodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "RoleID", "RoleName" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Member" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "CreatedDate", "DeletedDate", "ModifiedDate", "ModifiedDate2", "Status", "Value" },
                values: new object[] { 1, "Deniz Ürünleri", new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2365), null, null, null, false, 1 });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "MealID", "CreatedDate", "DeletedDate", "MealName", "ModifiedDate", "ModifiedDate2", "Status", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2408), null, "Sabah", null, null, false, 1 },
                    { 2, new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2416), null, "Öğle", null, null, false, 1 },
                    { 3, new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2421), null, "Akşam", null, null, false, 1 },
                    { 4, new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2425), null, "Snack", null, null, false, 1 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calories", "Carbohydrate", "CategoryID", "CreatedDate", "DeletedDate", "Fat", "FoodName", "GramCompensation", "MacroFoodReportReportID", "ModifiedDate", "ModifiedDate2", "Protein", "Status", "TotalCalories", "Value" },
                values: new object[,]
                {
                    { 1, 2.08f, 0f, 1, new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2386), null, 0.13f, "Somon", 100f, null, null, null, 0.19f, false, 2.08f, 1 },
                    { 2, 0.73f, 0.01f, 1, new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2389), null, 0.08f, "Ahtapot", 100f, null, null, null, 0.15f, false, 0.73f, 1 },
                    { 3, 1.01f, 0f, 1, new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2390), null, 0.02f, "Alabalık", 100f, null, null, null, 0.19f, false, 1.01f, 1 },
                    { 4, 1.2f, 0f, 1, new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2391), null, 0.06f, "Barbun", 100f, null, null, null, 0.16f, false, 1.2f, 1 },
                    { 5, 1.2f, 0f, 1, new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2392), null, 0.06f, "Çipura", 100f, null, null, null, 0.16f, false, 1.2f, 1 },
                    { 6, 0.79f, 0f, 1, new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2393), null, 0f, "Dil Balığı", 100f, null, null, null, 0.19f, false, 0.79f, 1 },
                    { 7, 2f, 0.05f, 1, new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2394), null, 0.1f, "Izgara Hamsi", 100f, null, null, null, 0.19f, false, 2f, 1 },
                    { 8, 1.15f, 0f, 1, new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2395), null, 0.05f, "Kızartma Hamsi", 100f, null, null, null, 0.17f, false, 1.15f, 1 },
                    { 9, 2.62f, 0.03f, 1, new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2396), null, 0.15f, "Havyar", 100f, null, null, null, 0.26f, false, 2.62f, 1 },
                    { 10, 0.91f, 0f, 1, new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2397), null, 0.02f, "Istakoz", 100f, null, null, null, 0.17f, false, 0.91f, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_RoleID",
                table: "AppUsers",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumeFoodFood_FoodsFoodID",
                table: "ConsumeFoodFood",
                column: "FoodsFoodID");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumeFoods_AppUserID",
                table: "ConsumeFoods",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumeFoods_MealID",
                table: "ConsumeFoods",
                column: "MealID");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryID",
                table: "Foods",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_MacroFoodReportReportID",
                table: "Foods",
                column: "MacroFoodReportReportID");

            migrationBuilder.CreateIndex(
                name: "IX_MacroFoodReports_AppUserID",
                table: "MacroFoodReports",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Waters_AppUserID",
                table: "Waters",
                column: "AppUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsumeFoodFood");

            migrationBuilder.DropTable(
                name: "Waters");

            migrationBuilder.DropTable(
                name: "ConsumeFoods");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "MacroFoodReports");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "AppRoles");
        }
    }
}
