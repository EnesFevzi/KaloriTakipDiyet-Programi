using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    public partial class sjdjadasda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConsumeFood_AppUsers_AppUserID",
                table: "ConsumeFood");

            migrationBuilder.DropForeignKey(
                name: "FK_ConsumeFood_Meals_MealID",
                table: "ConsumeFood");

            migrationBuilder.DropForeignKey(
                name: "FK_ConsumeFoodFood_ConsumeFood_ConsumeFoodsConsumeFoodID",
                table: "ConsumeFoodFood");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConsumeFood",
                table: "ConsumeFood");

            migrationBuilder.RenameTable(
                name: "ConsumeFood",
                newName: "ConsumeFoods");

            migrationBuilder.RenameIndex(
                name: "IX_ConsumeFood_MealID",
                table: "ConsumeFoods",
                newName: "IX_ConsumeFoods_MealID");

            migrationBuilder.RenameIndex(
                name: "IX_ConsumeFood_AppUserID",
                table: "ConsumeFoods",
                newName: "IX_ConsumeFoods_AppUserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConsumeFoods",
                table: "ConsumeFoods",
                column: "ConsumeFoodID");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.AddForeignKey(
                name: "FK_ConsumeFoodFood_ConsumeFoods_ConsumeFoodsConsumeFoodID",
                table: "ConsumeFoodFood",
                column: "ConsumeFoodsConsumeFoodID",
                principalTable: "ConsumeFoods",
                principalColumn: "ConsumeFoodID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConsumeFoods_AppUsers_AppUserID",
                table: "ConsumeFoods",
                column: "AppUserID",
                principalTable: "AppUsers",
                principalColumn: "AppUserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConsumeFoods_Meals_MealID",
                table: "ConsumeFoods",
                column: "MealID",
                principalTable: "Meals",
                principalColumn: "MealID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConsumeFoodFood_ConsumeFoods_ConsumeFoodsConsumeFoodID",
                table: "ConsumeFoodFood");

            migrationBuilder.DropForeignKey(
                name: "FK_ConsumeFoods_AppUsers_AppUserID",
                table: "ConsumeFoods");

            migrationBuilder.DropForeignKey(
                name: "FK_ConsumeFoods_Meals_MealID",
                table: "ConsumeFoods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConsumeFoods",
                table: "ConsumeFoods");

            migrationBuilder.RenameTable(
                name: "ConsumeFoods",
                newName: "ConsumeFood");

            migrationBuilder.RenameIndex(
                name: "IX_ConsumeFoods_MealID",
                table: "ConsumeFood",
                newName: "IX_ConsumeFood_MealID");

            migrationBuilder.RenameIndex(
                name: "IX_ConsumeFoods_AppUserID",
                table: "ConsumeFood",
                newName: "IX_ConsumeFood_AppUserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConsumeFood",
                table: "ConsumeFood",
                column: "ConsumeFoodID");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 23, 22, 48, 832, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.AddForeignKey(
                name: "FK_ConsumeFood_AppUsers_AppUserID",
                table: "ConsumeFood",
                column: "AppUserID",
                principalTable: "AppUsers",
                principalColumn: "AppUserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConsumeFood_Meals_MealID",
                table: "ConsumeFood",
                column: "MealID",
                principalTable: "Meals",
                principalColumn: "MealID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConsumeFoodFood_ConsumeFood_ConsumeFoodsConsumeFoodID",
                table: "ConsumeFoodFood",
                column: "ConsumeFoodsConsumeFoodID",
                principalTable: "ConsumeFood",
                principalColumn: "ConsumeFoodID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
