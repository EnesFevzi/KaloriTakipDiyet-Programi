using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    public partial class vcxvcfsdfsd55599 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "Waters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "Meals",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Value",
                table: "ConsumeFood",
                type: "int",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "Value",
                table: "Categories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "AppUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(135), 1 });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(138), 1 });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(140), 1 });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(142), 1 });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(143), 1 });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(144), 1 });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(145), 1 });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(146), 1 });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(148), 1 });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(149), 1 });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(150), 1 });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(153), 1 });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(155), 1 });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(156), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(97), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(104), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(110), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(115), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(116), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(117), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(119), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(120), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(121), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 46, 24, 503, DateTimeKind.Local).AddTicks(122), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "Waters");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "AppUsers");

            migrationBuilder.AlterColumn<float>(
                name: "Value",
                table: "ConsumeFood",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Value",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1246), 1f });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1249), 1f });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1251), 1f });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1252), 1f });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1253), 1f });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1254), 1f });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1255), 1f });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1256), 1f });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1258), 1f });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1259), 1f });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1260), 1f });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1261), 1f });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1262), 1f });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Value" },
                values: new object[] { new DateTime(2023, 9, 20, 14, 42, 35, 170, DateTimeKind.Local).AddTicks(1263), 1f });

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
    }
}
