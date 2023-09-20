using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    public partial class vcxvcxx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 27, 34, 588, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 27, 34, 588, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 27, 34, 588, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 27, 34, 588, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 27, 34, 588, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 27, 34, 588, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 27, 34, 588, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 27, 34, 588, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 27, 34, 588, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 27, 34, 588, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 27, 34, 588, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 27, 34, 588, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 27, 34, 588, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 27, 34, 588, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 27, 34, 588, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 27, 34, 588, DateTimeKind.Local).AddTicks(413));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 26, 18, 663, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 26, 18, 663, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 26, 18, 663, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 26, 18, 663, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 26, 18, 663, DateTimeKind.Local).AddTicks(3575));

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
    }
}
