using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    public partial class addmigrationsdsda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Value",
                table: "ConsumeFood",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 26, 18, 663, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 26, 18, 663, DateTimeKind.Local).AddTicks(3568), 1f });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 26, 18, 663, DateTimeKind.Local).AddTicks(3571), 1f });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 26, 18, 663, DateTimeKind.Local).AddTicks(3573), 1f });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 26, 18, 663, DateTimeKind.Local).AddTicks(3574), 1f });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 26, 18, 663, DateTimeKind.Local).AddTicks(3575), 1f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 26, 18, 663, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 26, 18, 663, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 26, 18, 663, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 26, 18, 663, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 26, 18, 663, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 26, 18, 663, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 26, 18, 663, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 26, 18, 663, DateTimeKind.Local).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 26, 18, 663, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 26, 18, 663, DateTimeKind.Local).AddTicks(3554));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "ConsumeFood");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 11, 37, 30, 120, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 11, 37, 30, 120, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 11, 37, 30, 120, DateTimeKind.Local).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 11, 37, 30, 120, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 11, 37, 30, 120, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 11, 37, 30, 120, DateTimeKind.Local).AddTicks(1640));

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
    }
}
