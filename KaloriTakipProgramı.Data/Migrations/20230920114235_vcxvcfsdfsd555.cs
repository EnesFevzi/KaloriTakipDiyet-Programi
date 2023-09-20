using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    public partial class vcxvcfsdfsd555 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1199), 1 });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1229));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5105));
        }
    }
}
