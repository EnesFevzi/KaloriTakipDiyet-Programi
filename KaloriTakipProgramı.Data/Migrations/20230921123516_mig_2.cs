using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "RoleID", "RoleName" },
                values: new object[] { 2, "Member" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 35, 16, 461, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 35, 16, 461, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 35, 16, 461, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 35, 16, 461, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 35, 16, 461, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 35, 16, 461, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 35, 16, 461, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 35, 16, 461, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 35, 16, 461, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 35, 16, 461, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 35, 16, 461, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 35, 16, 461, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 35, 16, 461, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 35, 16, 461, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 35, 16, 461, DateTimeKind.Local).AddTicks(6758));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "RoleID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 32, 49, 216, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 32, 49, 216, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 32, 49, 216, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 32, 49, 216, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 32, 49, 216, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 32, 49, 216, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 32, 49, 216, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 32, 49, 216, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 32, 49, 216, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 32, 49, 216, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 32, 49, 216, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 32, 49, 216, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 32, 49, 216, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 32, 49, 216, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 15, 32, 49, 216, DateTimeKind.Local).AddTicks(6815));
        }
    }
}
