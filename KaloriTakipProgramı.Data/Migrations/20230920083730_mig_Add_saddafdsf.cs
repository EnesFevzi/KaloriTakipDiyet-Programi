using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    public partial class mig_Add_saddafdsf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 11, 37, 30, 120, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.InsertData(
                table: "ConsumeFood",
                columns: new[] { "ConsumeFoodID", "AppUserID", "Calories", "Carbohydrate", "ConsumeFoodName", "CreatedDate", "DeletedDate", "Fat", "GramCompensation", "MealID", "ModifiedDate", "ModifiedDate2", "Protein", "Status" },
                values: new object[,]
                {
                    { 1, 8, 52f, 14f, "Apple", new DateTime(2023, 9, 20, 11, 37, 30, 120, DateTimeKind.Local).AddTicks(1632), null, 0.2f, 100f, 1, null, null, 0.3f, false },
                    { 2, 8, 165f, 0f, "Chicken Breast", new DateTime(2023, 9, 20, 11, 37, 30, 120, DateTimeKind.Local).AddTicks(1637), null, 3.6f, 100f, 1, null, null, 31f, false },
                    { 3, 8, 130f, 28f, "Rice", new DateTime(2023, 9, 20, 11, 37, 30, 120, DateTimeKind.Local).AddTicks(1639), null, 0.3f, 100f, 1, null, null, 2.7f, false },
                    { 4, 8, 206f, 0f, "Salmon", new DateTime(2023, 9, 20, 11, 37, 30, 120, DateTimeKind.Local).AddTicks(1640), null, 13f, 100f, 1, null, null, 22f, false },
                    { 5, 8, 131f, 25f, "Pasta", new DateTime(2023, 9, 20, 11, 37, 30, 120, DateTimeKind.Local).AddTicks(1640), null, 1.5f, 100f, 1, null, null, 5f, false }
                });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 11, 37, 30, 120, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 11, 37, 30, 120, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 11, 37, 30, 120, DateTimeKind.Local).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 11, 37, 30, 120, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 11, 37, 30, 120, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 11, 37, 30, 120, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 11, 37, 30, 120, DateTimeKind.Local).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 11, 37, 30, 120, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 11, 37, 30, 120, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 11, 37, 30, 120, DateTimeKind.Local).AddTicks(1615));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 5);

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
        }
    }
}
