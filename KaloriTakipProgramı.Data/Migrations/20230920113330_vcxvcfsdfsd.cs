using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    public partial class vcxvcfsdfsd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Calories", "Carbohydrate", "ConsumeFoodName", "CreatedDate", "Fat", "Protein" },
                values: new object[] { 52f, 14f, "Apple", new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5119), 0.2f, 0.3f });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 3,
                columns: new[] { "Calories", "Carbohydrate", "ConsumeFoodName", "CreatedDate", "Fat", "Protein" },
                values: new object[] { 52f, 14f, "Apple", new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5121), 0.2f, 0.3f });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 4,
                columns: new[] { "Calories", "ConsumeFoodName", "CreatedDate", "Fat", "Protein" },
                values: new object[] { 165f, "Chicken Breast", new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5127), 3.6f, 31f });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 5,
                columns: new[] { "Calories", "Carbohydrate", "ConsumeFoodName", "CreatedDate", "Fat", "Protein" },
                values: new object[] { 130f, 28f, "Rice", new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5129), 0.3f, 2.7f });

            migrationBuilder.InsertData(
                table: "ConsumeFood",
                columns: new[] { "ConsumeFoodID", "AppUserID", "Calories", "Carbohydrate", "ConsumeFoodName", "CreatedDate", "DeletedDate", "Fat", "GramCompensation", "MealID", "ModifiedDate", "ModifiedDate2", "Protein", "Status", "Value" },
                values: new object[,]
                {
                    { 6, 8, 206f, 0f, "Salmon", new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5130), null, 13f, 100f, 1, null, null, 22f, false, 1f },
                    { 7, 8, 206f, 0f, "Salmon", new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5131), null, 13f, 100f, 1, null, null, 22f, false, 1f },
                    { 8, 8, 206f, 0f, "Salmon", new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5132), null, 13f, 100f, 1, null, null, 22f, false, 1f },
                    { 9, 8, 206f, 0f, "Salmon", new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5133), null, 13f, 100f, 1, null, null, 22f, false, 1f },
                    { 10, 8, 206f, 0f, "Salmon", new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5134), null, 13f, 100f, 1, null, null, 22f, false, 1f },
                    { 11, 8, 206f, 0f, "Salmon", new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5135), null, 13f, 100f, 1, null, null, 22f, false, 1f },
                    { 12, 8, 206f, 0f, "Salmon", new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5136), null, 13f, 100f, 1, null, null, 22f, false, 1f },
                    { 13, 8, 206f, 0f, "Salmon", new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5137), null, 13f, 100f, 1, null, null, 22f, false, 1f },
                    { 14, 8, 131f, 25f, "Pasta", new DateTime(2023, 9, 20, 14, 33, 30, 544, DateTimeKind.Local).AddTicks(5138), null, 1.5f, 100f, 1, null, null, 5f, false, 1f }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 14);

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
                columns: new[] { "Calories", "Carbohydrate", "ConsumeFoodName", "CreatedDate", "Fat", "Protein" },
                values: new object[] { 165f, 0f, "Chicken Breast", new DateTime(2023, 9, 20, 14, 27, 34, 588, DateTimeKind.Local).AddTicks(430), 3.6f, 31f });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 3,
                columns: new[] { "Calories", "Carbohydrate", "ConsumeFoodName", "CreatedDate", "Fat", "Protein" },
                values: new object[] { 130f, 28f, "Rice", new DateTime(2023, 9, 20, 14, 27, 34, 588, DateTimeKind.Local).AddTicks(431), 0.3f, 2.7f });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 4,
                columns: new[] { "Calories", "ConsumeFoodName", "CreatedDate", "Fat", "Protein" },
                values: new object[] { 206f, "Salmon", new DateTime(2023, 9, 20, 14, 27, 34, 588, DateTimeKind.Local).AddTicks(432), 13f, 22f });

            migrationBuilder.UpdateData(
                table: "ConsumeFood",
                keyColumn: "ConsumeFoodID",
                keyValue: 5,
                columns: new[] { "Calories", "Carbohydrate", "ConsumeFoodName", "CreatedDate", "Fat", "Protein" },
                values: new object[] { 131f, 25f, "Pasta", new DateTime(2023, 9, 20, 14, 27, 34, 588, DateTimeKind.Local).AddTicks(434), 1.5f, 5f });

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
    }
}
