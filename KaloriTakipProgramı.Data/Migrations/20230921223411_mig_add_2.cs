using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    public partial class mig_add_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 34, 10, 937, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "CreatedDate", "DeletedDate", "ModifiedDate", "ModifiedDate2", "Status", "Value" },
                values: new object[] { 2, "Beyaz Et Ürünleri", new DateTime(2023, 9, 22, 1, 34, 10, 937, DateTimeKind.Local).AddTicks(4011), null, null, null, false, 1 });

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
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 34, 10, 937, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 34, 10, 937, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 34, 10, 937, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 1, 34, 10, 937, DateTimeKind.Local).AddTicks(4031));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 22, 47, 18, 739, DateTimeKind.Local).AddTicks(2425));
        }
    }
}
