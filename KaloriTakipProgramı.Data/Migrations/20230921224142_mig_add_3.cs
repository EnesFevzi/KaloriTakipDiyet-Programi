using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    public partial class mig_add_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7,
                columns: new[] { "CategoryID", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                columns: new[] { "CategoryID", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                columns: new[] { "CategoryID", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 10,
                columns: new[] { "CategoryID", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9080));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 34, 10, 937, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 34, 10, 937, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 34, 10, 937, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 34, 10, 937, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 34, 10, 937, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 34, 10, 937, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 34, 10, 937, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 34, 10, 937, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7,
                columns: new[] { "CategoryID", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 9, 22, 1, 34, 10, 937, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                columns: new[] { "CategoryID", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 9, 22, 1, 34, 10, 937, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                columns: new[] { "CategoryID", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 9, 22, 1, 34, 10, 937, DateTimeKind.Local).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 10,
                columns: new[] { "CategoryID", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 9, 22, 1, 34, 10, 937, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 34, 10, 937, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 34, 10, 937, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 34, 10, 937, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 34, 10, 937, DateTimeKind.Local).AddTicks(4060));
        }
    }
}
