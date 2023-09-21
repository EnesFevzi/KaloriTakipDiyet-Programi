using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    public partial class lhgkjlhkjh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "ConsumeFoods",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4911));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "ConsumeFoods");

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
        }
    }
}
