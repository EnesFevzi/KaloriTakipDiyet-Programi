using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    public partial class lhgkjlhkjhfdgd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Weight",
                table: "AppUsers",
                type: "real",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "WaistCircle",
                table: "AppUsers",
                type: "real",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "NeckCircle",
                table: "AppUsers",
                type: "real",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Height",
                table: "AppUsers",
                type: "real",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "BasinCircle",
                table: "AppUsers",
                type: "real",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "ActivityValue",
                table: "AppUsers",
                type: "real",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4402), "Atanmadı" });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4405), "Atanmadı" });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4407), "Atanmadı" });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4408), "Atanmadı" });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4409), "Atanmadı" });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4411), "Atanmadı" });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4412), "Atanmadı" });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4413), "Atanmadı" });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4414), "Atanmadı" });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4415), "Atanmadı" });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4416), "Atanmadı" });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4417), "Atanmadı" });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4418), "Atanmadı" });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4419), "Atanmadı" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 12, 23, 45, 229, DateTimeKind.Local).AddTicks(4394));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Weight",
                table: "AppUsers",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "WaistCircle",
                table: "AppUsers",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "NeckCircle",
                table: "AppUsers",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Height",
                table: "AppUsers",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "BasinCircle",
                table: "AppUsers",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ActivityValue",
                table: "AppUsers",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

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
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4918), null });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4921), null });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4923), null });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4924), null });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4925), null });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4926), null });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4931), null });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4934), null });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4935), null });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4936), null });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4937), null });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4938), null });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4940), null });

            migrationBuilder.UpdateData(
                table: "ConsumeFoods",
                keyColumn: "ConsumeFoodID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 21, 10, 23, 7, 572, DateTimeKind.Local).AddTicks(4941), null });

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
    }
}
