using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    public partial class mig_add_fevzi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Balık ve Deniz Ürünleri", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "CreatedDate", "DeletedDate", "ModifiedDate", "ModifiedDate2", "Status", "Value" },
                values: new object[,]
                {
                    { 3, "Meyveler", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(536), null, null, null, false, 1 },
                    { 4, "Sütlü Tatlılar", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(540), null, null, null, false, 1 },
                    { 5, "Şerbetli Tatlılar", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(548), null, null, null, false, 1 },
                    { 6, "Süt Ürünleri", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(555), null, null, null, false, 1 },
                    { 7, "Kahvaltılık Sıcak Ürünler", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(559), null, null, null, false, 1 },
                    { 8, "Şarküteri Ürünleri", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(563), null, null, null, false, 1 },
                    { 9, "Kahvaltılık Ürünleri", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(567), null, null, null, false, 1 },
                    { 10, "Makarna Ürünleri", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(572), null, null, null, false, 1 },
                    { 11, "Sos Ürünleri", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(576), null, null, null, false, 1 },
                    { 12, "Fast-Food Ürünleri", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(581), null, null, null, false, 1 },
                    { 13, "Kırmızı Et Ürünleri", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(585), null, null, null, false, 1 },
                    { 14, "Sebze Ürünleri", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(589), null, null, null, false, 1 },
                    { 15, "Sebze Yemekleri", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(593), null, null, null, false, 1 },
                    { 16, "Salata Çeşitleri", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(597), null, null, null, false, 1 },
                    { 17, "Kuruyemiş Çeşitleri", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(601), null, null, null, false, 1 },
                    { 18, "Atıştırmalık Çeşitleri", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(606), null, null, null, false, 1 },
                    { 19, "Alkolsüz İçecek Çeşitleri", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(610), null, null, null, false, 1 },
                    { 20, "Ev Yemekleri", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(614), null, null, null, false, 1 },
                    { 21, "Ekmek ve Tahıllar", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(618), null, null, null, false, 1 },
                    { 22, "Hamur İşleri", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(623), null, null, null, false, 1 },
                    { 23, "Kurubaklagiller", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(627), null, null, null, false, 1 },
                    { 24, "Hayvansal Yağlar", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(631), null, null, null, false, 1 },
                    { 25, "Bitkisel Yağlar", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(635), null, null, null, false, 1 },
                    { 26, "Alkollü İçecekler", new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(639), null, null, null, false, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "GramCompensation", "TotalCalories" },
                values: new object[] { new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(648), 1f, 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "GramCompensation", "TotalCalories" },
                values: new object[] { new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(656), 1f, 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3,
                columns: new[] { "Carbohydrate", "CreatedDate", "GramCompensation", "TotalCalories" },
                values: new object[] { 0.01f, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(665), 1f, 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4,
                columns: new[] { "Carbohydrate", "CreatedDate", "GramCompensation", "TotalCalories" },
                values: new object[] { 0.01f, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(672), 1f, 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5,
                columns: new[] { "Carbohydrate", "CreatedDate", "GramCompensation", "TotalCalories" },
                values: new object[] { 0.01f, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(677), 1f, 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6,
                columns: new[] { "Carbohydrate", "CreatedDate", "GramCompensation", "TotalCalories" },
                values: new object[] { 0.01f, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(682), 1f, 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7,
                columns: new[] { "CategoryID", "CreatedDate", "GramCompensation", "TotalCalories" },
                values: new object[] { 1, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(687), 1f, 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                columns: new[] { "Carbohydrate", "CategoryID", "CreatedDate", "Fat", "GramCompensation", "TotalCalories" },
                values: new object[] { 0.05f, 1, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(692), 0.1f, 1f, 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                columns: new[] { "CategoryID", "CreatedDate", "GramCompensation", "TotalCalories" },
                values: new object[] { 1, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(696), 1f, 0f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 10,
                columns: new[] { "CategoryID", "CreatedDate", "GramCompensation", "TotalCalories" },
                values: new object[] { 1, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(702), 1f, 0f });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calories", "Carbohydrate", "CategoryID", "CreatedDate", "DeletedDate", "Fat", "FoodName", "GramCompensation", "MacroFoodReportReportID", "ModifiedDate", "ModifiedDate2", "Protein", "Status", "TotalCalories", "Value" },
                values: new object[,]
                {
                    { 11, 0.81f, 0f, 1, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(707), null, 0.02f, "İstavrit", 1f, null, null, null, 0.17f, false, 0f, 1 },
                    { 12, 0.68f, 0f, 1, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(711), null, 0.02f, "İstiridye", 1f, null, null, null, 0.09f, false, 0f, 1 },
                    { 13, 1.53f, 0f, 1, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(716), null, 0.06f, "İzmarit", 1f, null, null, null, 0.23f, false, 0f, 1 },
                    { 14, 1.35f, 0f, 1, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(720), null, 0.06f, "Kalkan Balığı", 1f, null, null, null, 0.2f, false, 0f, 1 },
                    { 15, 1.25f, 0.02f, 1, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(725), null, 0.06f, "Karides Güveç", 1f, null, null, null, 0.16f, false, 0f, 1 },
                    { 16, 3.19f, 0.02f, 1, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(729), null, 0.29f, "Tereyağda Karides", 1f, null, null, null, 0.16f, false, 0f, 1 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calories", "Carbohydrate", "CategoryID", "CreatedDate", "DeletedDate", "Fat", "FoodName", "GramCompensation", "MacroFoodReportReportID", "ModifiedDate", "ModifiedDate2", "Protein", "Status", "TotalCalories", "Value" },
                values: new object[,]
                {
                    { 17, 1.73f, 0f, 1, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(734), null, 0f, "Kefal Balığı", 1f, null, null, null, 0.19f, false, 0f, 1 },
                    { 18, 1.53f, 0f, 1, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(740), null, 0.06f, "Kılıç Balığı", 1f, null, null, null, 0.23f, false, 0f, 1 },
                    { 19, 1.37f, 0f, 1, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(744), null, 0.09f, "Lüfer", 1f, null, null, null, 0.16f, false, 0f, 1 },
                    { 20, 0.82f, 0f, 1, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(749), null, 0.06f, "Mezgit", 1f, null, null, null, 0.18f, false, 0f, 1 },
                    { 21, 1f, 1.03f, 1, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(753), null, 0.02f, "Midye Dolma", 1f, null, null, null, 0.05f, false, 0f, 1 },
                    { 22, 2f, 0.08f, 1, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(758), null, 0.1f, "Midye Tava", 1f, null, null, null, 0.09f, false, 0f, 1 },
                    { 23, 1.51f, 0.08f, 1, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(762), null, 0.07f, "Palamut", 1f, null, null, null, 0.19f, false, 0f, 1 },
                    { 24, 1.6f, 0.08f, 1, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(772), null, 0.09f, "Sardalya", 1f, null, null, null, 0.15f, false, 0f, 1 },
                    { 25, 1.45f, 0f, 1, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(777), null, 0.07f, "Sazan", 1f, null, null, null, 0.19f, false, 0f, 1 },
                    { 26, 1.51f, 0f, 1, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(781), null, 0.04f, "Tekir", 1f, null, null, null, 0.25f, false, 0f, 1 },
                    { 27, 2.9f, 0f, 1, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(786), null, 0.04f, "Ton Balığı", 1f, null, null, null, 0.25f, false, 0f, 1 },
                    { 28, 0.9f, 0.08f, 1, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(791), null, 0.04f, "Suşi", 1f, null, null, null, 0.2f, false, 0f, 1 },
                    { 29, 1.97f, 0f, 2, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(795), null, 0.08f, "Haşlanmış Tavuk Göğsü", 1f, null, null, null, 0.3f, false, 0f, 1 },
                    { 30, 2.2f, 0.02f, 2, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(800), null, 0.12f, "Pişmiş Tavuk Eti", 1f, null, null, null, 0.25f, false, 0f, 1 },
                    { 31, 1.91f, 0.01f, 2, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(804), null, 0.13f, "Kızarmış Tavuk Kanadı", 1f, null, null, null, 0.18f, false, 0f, 1 },
                    { 32, 3f, 0.01f, 2, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(809), null, 0.27f, "Kızarmış Tavuk But", 1f, null, null, null, 0.18f, false, 0f, 1 },
                    { 33, 1.46f, 0.05f, 2, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(813), null, 0.09f, "Haşlanmış Tavuk But", 1f, null, null, null, 0.1f, false, 0f, 1 },
                    { 34, 1.53f, 0.07f, 2, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(822), null, 0.07f, "Tavuk Köftesi", 1f, null, null, null, 0.13f, false, 0f, 1 },
                    { 35, 1.72f, 0.01f, 2, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(831), null, 0.06f, "Tavuk Ciğeri", 1f, null, null, null, 0.26f, false, 0f, 1 },
                    { 36, 1.52f, 0.25f, 2, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(838), null, 0.04f, "Tavuklu Pilav", 1f, null, null, null, 0.08f, false, 0f, 1 },
                    { 37, 2.68f, 0.06f, 2, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(846), null, 0.2f, "Tavuk Nugget", 1f, null, null, null, 0.16f, false, 0f, 1 },
                    { 38, 3.09f, 0.1513f, 2, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(862), null, 0.3637f, "Ekmek Arası Tavuk Döner", 1f, null, null, null, 0.431f, false, 0f, 1 },
                    { 39, 1.43f, 0.0525f, 2, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(879), null, 0.0465f, "Köri Soslu Tavuk", 1f, null, null, null, 0.1885f, false, 0f, 1 },
                    { 40, 1.236f, 0.06052f, 2, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(885), null, 0.14548f, "Tavuk Sote", 1f, null, null, null, 0.1724f, false, 0f, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "MealName" },
                values: new object[] { new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(518), "Aperatif" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calories", "Carbohydrate", "CategoryID", "CreatedDate", "DeletedDate", "Fat", "FoodName", "GramCompensation", "MacroFoodReportReportID", "ModifiedDate", "ModifiedDate2", "Protein", "Status", "TotalCalories", "Value" },
                values: new object[,]
                {
                    { 41, 0.5278f, 0.1396f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(890), null, 0.0017f, "Elma", 1f, null, null, null, 0.0026f, false, 0f, 1 },
                    { 42, 0.4769f, 0.1185f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(895), null, 0.0012f, "Portakal", 1f, null, null, null, 0.0096f, false, 0f, 1 },
                    { 43, 0.302f, 0.075f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(899), null, 0.001f, "Greyfurt", 1f, null, null, null, 0.0055f, false, 0f, 1 },
                    { 44, 0.5333f, 0.1367f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(910), null, 0.0033f, "Mandalina", 1f, null, null, null, 0.008f, false, 0f, 1 },
                    { 45, 0.6087f, 0.1464f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(917), null, 0.0036f, "Kivi", 1f, null, null, null, 0.0089f, false, 0f, 1 },
                    { 46, 0.8898f, 0.2297f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(922), null, 0.004f, "Muz", 1f, null, null, null, 0.011f, false, 0f, 1 },
                    { 47, 0.4857f, 0.1114f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(926), null, 0.0043f, "Kayısı", 1f, null, null, null, 0.0143f, false, 0f, 1 },
                    { 48, 0.3194f, 0.0764f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(931), null, 0.0031f, "Çilek", 1f, null, null, null, 0.0066f, false, 0f, 1 },
                    { 49, 0.75f, 0.2f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(935), null, 0.00208f, "Trabzon Hurması", 1f, null, null, null, 0.00625f, false, 0f, 1 },
                    { 50, 0.6304f, 0.1594f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(940), null, 0.0022f, "Kiraz", 1f, null, null, null, 0.0105f, false, 0f, 1 },
                    { 51, 0.208f, 0.052f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(945), null, 0.0012f, "Vişne", 1f, null, null, null, 0.00412f, false, 0f, 1 },
                    { 52, 0.36f, 0.087f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(949), null, 0.002f, "Kavun", 1f, null, null, null, 0.00225f, false, 0f, 1 },
                    { 53, 0.3067f, 0.10087f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(954), null, 0.007f, "Karpuz", 1f, null, null, null, 0.00933f, false, 0f, 1 },
                    { 54, 0.5f, 0.1312f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(958), null, 0.000291f, "Ananas", 1f, null, null, null, 0.00125f, false, 0f, 1 },
                    { 55, 1.6f, 0.085f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(963), null, 0.147f, "Avakado", 1f, null, null, null, 0.02f, false, 0f, 1 },
                    { 56, 1f, 0.247f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(967), null, 0.0063f, "Mango", 1f, null, null, null, 0.0135f, false, 0f, 1 },
                    { 57, 0.512f, 0.117f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(971), null, 0.0063f, "Ahududu", 1f, null, null, null, 0.012f, false, 0f, 1 },
                    { 58, 0.62f, 0.138f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(976), null, 0.008f, "Böğürtlen", 1f, null, null, null, 0.015f, false, 0f, 1 },
                    { 59, 0.46f, 0.114f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(980), null, 0.003f, "Yeşil Erik", 1f, null, null, null, 0.006f, false, 0f, 1 },
                    { 60, 0.74f, 0.187f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(985), null, 0.003f, "İncir", 1f, null, null, null, 0.008f, false, 0f, 1 },
                    { 61, 0.39f, 0.09f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(990), null, 0.003f, "Şeftali", 1f, null, null, null, 0.01f, false, 0f, 1 },
                    { 62, 0.69f, 0.176f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(994), null, 0.0006f, "Üzüm", 1f, null, null, null, 0.0076f, false, 0f, 1 },
                    { 63, 0.83f, 0.18f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(999), null, 0.01f, "Nar", 1f, null, null, null, 0.02f, false, 0f, 1 },
                    { 64, 29f, 9.32f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1003), null, 0.3f, "Limon", 1f, null, null, null, 1.1f, false, 0f, 1 },
                    { 65, 0.3f, 0.092f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1008), null, 0.003f, "Limon", 1f, null, null, null, 0.01f, false, 0f, 1 },
                    { 66, 0.46f, 0.117f, 3, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1017), null, 0.0015f, "Kırmızı Erik", 1f, null, null, null, 0.0075f, false, 0f, 1 },
                    { 67, 1f, 0.2f, 4, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1022), null, 0.02f, "Sütlaç", 1f, null, null, null, 0.03f, false, 0f, 1 },
                    { 68, 3.5f, 0.8f, 4, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1026), null, 0.02f, "Kazandibi", 1f, null, null, null, 0.05f, false, 0f, 1 },
                    { 69, 3.5f, 0.5f, 4, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1031), null, 0.1f, "Magnolia", 1f, null, null, null, 0.1f, false, 0f, 1 },
                    { 70, 2.5f, 0.33f, 4, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1035), null, 0.1f, "Tiramisu", 1f, null, null, null, 0.05f, false, 0f, 1 },
                    { 71, 3.5f, 0.3f, 4, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1040), null, 0.16f, "Cheesecake", 1f, null, null, null, 0.1f, false, 0f, 1 },
                    { 72, 1f, 0.2f, 4, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1045), null, 0.04f, "Güllaç", 1f, null, null, null, 0.03f, false, 0f, 1 },
                    { 73, 1f, 0.15f, 4, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1050), null, 0.01f, "Tavuk Göğsü Tatlısı", 1f, null, null, null, 0.03f, false, 0f, 1 },
                    { 74, 2f, 0.25f, 4, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1054), null, 0.03f, "Muhallebi", 1f, null, null, null, 0.03f, false, 0f, 1 },
                    { 75, 1f, 0.06f, 4, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1059), null, 0.02f, "Puding", 1f, null, null, null, 0.04f, false, 0f, 1 },
                    { 76, 1.5f, 0.15f, 4, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1063), null, 0.05f, "Supangle", 1f, null, null, null, 0.03f, false, 0f, 1 },
                    { 77, 301f, 39f, 4, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1068), null, 9.25f, "Trileçe", 185f, null, null, null, 12.85f, false, 0f, 1 },
                    { 78, 343f, 111f, 4, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1072), null, 10.8f, "Höşmerim", 120f, null, null, null, 17f, false, 0f, 1 },
                    { 79, 273f, 42.55f, 4, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1077), null, 7.7f, "Keşkül", 250f, null, null, null, 7.3f, false, 0f, 1 },
                    { 80, 344f, 61.21f, 4, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1081), null, 5.5f, "Aşure", 250f, null, null, null, 7.84f, false, 0f, 1 },
                    { 81, 429f, 55.8f, 4, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1086), null, 19.3f, "Profiterol", 180f, null, null, null, 5.8f, false, 0f, 1 },
                    { 82, 99f, 21.05f, 4, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1090), null, 1.02f, "Meyveli Dondurma", 75f, null, null, null, 0.97f, false, 0f, 1 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calories", "Carbohydrate", "CategoryID", "CreatedDate", "DeletedDate", "Fat", "FoodName", "GramCompensation", "MacroFoodReportReportID", "ModifiedDate", "ModifiedDate2", "Protein", "Status", "TotalCalories", "Value" },
                values: new object[,]
                {
                    { 83, 240f, 30.75f, 4, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1095), null, 9f, "Sütlü Dondurma", 150f, null, null, null, 9f, false, 0f, 1 },
                    { 84, 216f, 28.2f, 4, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1099), null, 11f, "Çikolatalı Dondurma", 150f, null, null, null, 3.8f, false, 0f, 1 },
                    { 85, 262f, 43.15f, 4, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1111), null, 5f, "Sütlü İrmik Tatlısı", 170f, null, null, null, 7f, false, 0f, 1 },
                    { 86, 532f, 64.9f, 4, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1115), null, 25.2f, "İrmik Helvası", 100f, null, null, null, 7.77f, false, 0f, 1 },
                    { 87, 294f, 43.5f, 4, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1120), null, 12.18f, "Un Helvası", 90f, null, null, null, 0.12f, false, 0f, 1 },
                    { 88, 660f, 79f, 5, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1124), null, 34.35f, "Baklava", 90f, null, null, null, 12.36f, false, 0f, 1 },
                    { 89, 422f, 51.75f, 5, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1129), null, 22.55f, "Kadayıf", 145f, null, null, null, 6.85f, false, 0f, 1 },
                    { 90, 242f, 34.45f, 5, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1133), null, 7.25f, "Soğuk Baklava", 82f, null, null, null, 3.3f, false, 0f, 1 },
                    { 91, 256f, 40.7f, 5, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1138), null, 14.75f, "Tulumba", 90f, null, null, null, 2.51f, false, 0f, 1 },
                    { 92, 476f, 84.4f, 5, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1142), null, 13.55f, "Kemalpaşa", 285f, null, null, null, 16.6f, false, 0f, 1 },
                    { 93, 476f, 66.75f, 5, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1147), null, 40.6f, "Halka Tatlısı", 673f, null, null, null, 5f, false, 0f, 1 },
                    { 94, 330f, 150.75f, 5, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1151), null, 0.94f, "Şam Tatlısı", 90f, null, null, null, 5f, false, 0f, 1 },
                    { 95, 522f, 59.76f, 5, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1156), null, 29.15f, "Şöbiyet", 160f, null, null, null, 5.95f, false, 0f, 1 },
                    { 96, 426f, 55f, 5, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1160), null, 20.52f, "Künefe", 120f, null, null, null, 7.36f, false, 0f, 1 },
                    { 97, 272f, 45.95f, 5, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1165), null, 8.95f, "Şekerpare", 100f, null, null, null, 2.65f, false, 0f, 1 },
                    { 98, 348f, 55f, 5, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1169), null, 9.4f, "Revani", 100f, null, null, null, 5.82f, false, 0f, 1 },
                    { 99, 78f, 7.52f, 5, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1174), null, 4.82f, "Lokma Tatlısı", 15f, null, null, null, 0.35f, false, 0f, 1 },
                    { 100, 251f, 34.38f, 5, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1178), null, 11.33f, "Kalburabastı", 85f, null, null, null, 4f, false, 0f, 1 },
                    { 101, 210f, 20.95f, 5, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1183), null, 12.08f, "Fıstıklı Sarma Tatlısı", 50f, null, null, null, 3.71f, false, 0f, 1 },
                    { 102, 99f, 12.63f, 5, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1187), null, 4.81f, "Un Helvası", 30f, null, null, null, 0.48f, false, 0f, 1 },
                    { 103, 480f, 37.05f, 5, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1192), null, 33.3f, "San Sebastian", 150f, null, null, null, 7.8f, false, 0f, 1 },
                    { 104, 0.58f, 0.06f, 6, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1196), null, 0.03f, "Tam Yağlı İnek Sütü", 1f, null, null, null, 0.03f, false, 0f, 1 },
                    { 105, 0.39f, 0.08f, 6, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1201), null, 0.015f, "Yarım Yağlı İnek Sütü", 1f, null, null, null, 0.04f, false, 0f, 1 },
                    { 106, 0.65f, 0.18f, 6, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1206), null, 0.015f, "Keçi Sütü", 1f, null, null, null, 0.09f, false, 0f, 1 },
                    { 107, 0.38f, 0.18f, 6, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1214), null, 0.01f, "Badem Sütü", 1f, null, null, null, 0.04f, false, 0f, 1 },
                    { 108, 93f, 0.76f, 6, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1219), null, 7.3f, "Beyaz Peynir", 30f, null, null, null, 6.11f, false, 0f, 1 },
                    { 109, 72f, 1.14f, 6, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1223), null, 6f, "Süzme Peynir", 30f, null, null, null, 3.4f, false, 0f, 1 },
                    { 110, 30f, 0.14f, 6, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1228), null, 2.34f, "Lor Peyniri", 15f, null, null, null, 2.17f, false, 0f, 1 },
                    { 111, 71f, 0.51f, 6, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1232), null, 5.32f, "Kaşar Peyniri", 20f, null, null, null, 5.4f, false, 0f, 1 },
                    { 112, 10f, 0.28f, 6, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1237), null, 0.9f, "Labne", 5f, null, null, null, 0.25f, false, 0f, 1 },
                    { 113, 72f, 0.38f, 6, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1241), null, 5f, "Örgü Peynir", 25f, null, null, null, 6.25f, false, 0f, 1 },
                    { 114, 68f, 1.58f, 6, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1246), null, 4.93f, "Dil Peyniri", 25f, null, null, null, 4.3f, false, 0f, 1 },
                    { 115, 90f, 0.26f, 6, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1251), null, 7.38f, "Hellim Peyniri", 25f, null, null, null, 6.98f, false, 0f, 1 },
                    { 116, 90f, 0.66f, 6, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1255), null, 6.71f, "Beyaz Peynir", 30f, null, null, null, 6.61f, false, 0f, 1 },
                    { 117, 120f, 10f, 6, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1260), null, 6f, "Kefir", 30f, null, null, null, 5.6f, false, 0f, 1 },
                    { 118, 122f, 9.32f, 6, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1264), null, 6.5f, "Yoğurt", 200f, null, null, null, 6.94f, false, 0f, 1 },
                    { 119, 76f, 5.6f, 6, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1269), null, 4f, "Ayran", 200f, null, null, null, 4f, false, 0f, 1 },
                    { 120, 115f, 11f, 6, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1273), null, 4.85f, "Cacık", 200f, null, null, null, 6.66f, false, 0f, 1 },
                    { 121, 78f, 0.56f, 7, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1278), null, 5.31f, "Haşlanmış Yumurta", 50f, null, null, null, 6.3f, false, 0f, 1 },
                    { 122, 101f, 1.27f, 7, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1283), null, 7.94f, "Omlet", 55f, null, null, null, 6.7f, false, 0f, 1 },
                    { 123, 254f, 2.05f, 7, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1287), null, 15f, "Peynirli Omlet", 130f, null, null, null, 15.3f, false, 0f, 1 },
                    { 124, 205f, 3.7f, 7, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1292), null, 10f, "Menemen", 150f, null, null, null, 12.45f, false, 0f, 1 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calories", "Carbohydrate", "CategoryID", "CreatedDate", "DeletedDate", "Fat", "FoodName", "GramCompensation", "MacroFoodReportReportID", "ModifiedDate", "ModifiedDate2", "Protein", "Status", "TotalCalories", "Value" },
                values: new object[,]
                {
                    { 125, 242f, 3.4f, 7, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1296), null, 19.5f, "Sucuklu Yumurta", 100f, null, null, null, 13.5f, false, 0f, 1 },
                    { 126, 489f, 3.95f, 7, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1302), null, 44.4f, "Kuymak - Mıhlama", 120f, null, null, null, 19.1f, false, 0f, 1 },
                    { 127, 166f, 2.57f, 8, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1306), null, 14.2f, "Sucuk", 50f, null, null, null, 7.1f, false, 0f, 1 },
                    { 128, 60f, 0.12f, 8, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1313), null, 5.6f, "Sosis", 40f, null, null, null, 2.24f, false, 0f, 1 },
                    { 129, 45f, 0.64f, 8, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1320), null, 3.92f, "Dana Salam", 15f, null, null, null, 1.65f, false, 0f, 1 },
                    { 130, 17f, 0.24f, 8, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1326), null, 1.13f, "Hindi Salam", 8f, null, null, null, 1.31f, false, 0f, 1 },
                    { 131, 32f, 0.7f, 8, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1330), null, 0f, "Dana Jambon", 30f, null, null, null, 4.92f, false, 0f, 1 },
                    { 132, 15f, 0.35f, 8, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1335), null, 0.46f, "Hindi Jambon", 30f, null, null, null, 2.35f, false, 0f, 1 },
                    { 133, 11f, 0.12f, 8, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1339), null, 0.44f, "Piliç Jambon", 12f, null, null, null, 1.56f, false, 0f, 1 },
                    { 134, 51f, 0f, 8, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1344), null, 1.5f, "Hindi Füme", 30f, null, null, null, 8.8f, false, 0f, 1 },
                    { 135, 26f, 0.3f, 8, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1348), null, 0.9f, "Pilic Füme", 30f, null, null, null, 3.9f, false, 0f, 1 },
                    { 136, 75f, 0f, 8, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1353), null, 4.17f, "Pastırma", 30f, null, null, null, 8.85f, false, 0f, 1 },
                    { 137, 5f, 0.24f, 9, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1358), null, 0.44f, "Siyah Zeytin", 4f, null, null, null, 0.03f, false, 0f, 1 },
                    { 138, 6f, 0.15f, 9, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1362), null, 0.61f, "Yeşil Zeytin", 4f, null, null, null, 0.05f, false, 0f, 1 },
                    { 139, 30f, 8.25f, 9, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1367), null, 0f, "Bal", 10f, null, null, null, 0.04f, false, 0f, 1 },
                    { 140, 29f, 0.17f, 9, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1372), null, 3.16f, "Kaymak", 5f, null, null, null, 0.05f, false, 0f, 1 },
                    { 141, 169f, 13.55f, 9, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1376), null, 10f, "Cevizli Yaz Helvası", 30f, null, null, null, 4.41f, false, 0f, 1 },
                    { 142, 87f, 3.18f, 9, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1380), null, 7.2f, "Tahin", 15f, null, null, null, 2.67f, false, 0f, 1 },
                    { 143, 29f, 0f, 9, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1385), null, 0.01f, "Pekmez", 10f, null, null, null, 0f, false, 0f, 1 },
                    { 144, 66f, 6.45f, 9, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1392), null, 3.48f, "Tahin Pekmez", 15f, null, null, null, 1.52f, false, 0f, 1 },
                    { 145, 27f, 2.88f, 9, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1399), null, 1.55f, "Nutella", 5f, null, null, null, 0.32f, false, 0f, 1 },
                    { 146, 25f, 2.71f, 9, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1404), null, 1.38f, "Kakaolu Fındık Kreması", 5f, null, null, null, 0.44f, false, 0f, 1 },
                    { 147, 34f, 3.08f, 9, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1408), null, 2.23f, "Fındık Ezmesi", 6f, null, null, null, 0.55f, false, 0f, 1 },
                    { 148, 35f, 1.3f, 9, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1413), null, 3f, "Fıstık Ezmesi", 6f, null, null, null, 1.44f, false, 0f, 1 },
                    { 149, 36f, 1.1f, 9, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1417), null, 2.76f, "Şekersiz Fıstık Ezmesi", 6f, null, null, null, 1.32f, false, 0f, 1 },
                    { 150, 157f, 30.59f, 10, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1422), null, 0.93f, "Haşlanmış Makarna", 100f, null, null, null, 5.8f, false, 0f, 1 },
                    { 151, 178f, 27.43f, 10, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1426), null, 4.48f, "Domatesli Makarna", 200f, null, null, null, 6.55f, false, 0f, 1 },
                    { 152, 303f, 20.9f, 10, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1431), null, 17f, "Spagetti Bolonez", 200f, null, null, null, 15.83f, false, 0f, 1 },
                    { 153, 164f, 31.18f, 10, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1435), null, 4.43f, "Penne Arabiata", 100f, null, null, null, 26.5f, false, 0f, 1 },
                    { 154, 289f, 50.1f, 10, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1440), null, 3.8f, "Fettucini Alfredo", 100f, null, null, null, 10.4f, false, 0f, 1 },
                    { 155, 272f, 25f, 10, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1444), null, 13.56f, "Lazanya", 150f, null, null, null, 12.65f, false, 0f, 1 },
                    { 156, 382f, 52.26f, 10, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1449), null, 11.2f, "Fırında Makarna", 230f, null, null, null, 17.14f, false, 0f, 1 },
                    { 157, 283f, 53.75f, 10, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1453), null, 4.04f, "Makarna Salatası", 300f, null, null, null, 8.52f, false, 0f, 1 },
                    { 158, 22f, 4.8f, 11, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1458), null, 0f, "Ketçap", 20f, null, null, null, 0.25f, false, 0f, 1 },
                    { 159, 50f, 3.11f, 11, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1463), null, 4.34f, "Mayonez", 13f, null, null, null, 0.12f, false, 0f, 1 },
                    { 160, 6f, 0.58f, 11, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1467), null, 0.33f, "Hardal", 8f, null, null, null, 0.37f, false, 0f, 1 },
                    { 161, 26f, 6.38f, 11, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1471), null, 0.06f, "Barbekü Sos", 20f, null, null, null, 0.12f, false, 0f, 1 },
                    { 162, 24f, 1.79f, 11, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1476), null, 1.7f, "Ranch Sos", 20f, null, null, null, 0.46f, false, 0f, 1 },
                    { 163, 56f, 1.4f, 11, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1480), null, 5.4f, "Buffalo Sos", 20f, null, null, null, 0.4f, false, 0f, 1 },
                    { 164, 9f, 0.54f, 11, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1485), null, 4.86f, "Pesto Sos", 10f, null, null, null, 3.47f, false, 0f, 1 },
                    { 165, 15f, 3.7f, 11, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1489), null, 0f, "Nar Ekşisi", 8f, null, null, null, 0.05f, false, 0f, 1 },
                    { 166, 22f, 1.6f, 11, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1496), null, 1.7f, "Köri Sos", 10f, null, null, null, 0.05f, false, 0f, 1 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calories", "Carbohydrate", "CategoryID", "CreatedDate", "DeletedDate", "Fat", "FoodName", "GramCompensation", "MacroFoodReportReportID", "ModifiedDate", "ModifiedDate2", "Protein", "Status", "TotalCalories", "Value" },
                values: new object[,]
                {
                    { 167, 6f, 0.56f, 11, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1503), null, 0f, "Soya Sos", 10f, null, null, null, 1.05f, false, 0f, 1 },
                    { 168, 529f, 38.05f, 12, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1507), null, 26.65f, "Çıtır Tavuk", 200f, null, null, null, 34f, false, 0f, 1 },
                    { 169, 270f, 33f, 12, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1512), null, 10f, "Tavuk Burger", 100f, null, null, null, 13f, false, 0f, 1 },
                    { 170, 290f, 30.96f, 12, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1516), null, 12f, "Cheeseburger", 115f, null, null, null, 16.95f, false, 0f, 1 },
                    { 171, 277f, 31.07f, 12, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1521), null, 9.56f, "Etli Ekmek", 130f, null, null, null, 15.28f, false, 0f, 1 },
                    { 172, 221f, 32.27f, 12, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1525), null, 5.55f, "Lahmacun", 150f, null, null, null, 9.75f, false, 0f, 1 },
                    { 173, 380f, 19.05f, 12, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1530), null, 50.34f, "Tantuni", 220f, null, null, null, 43.6f, false, 0f, 1 },
                    { 174, 241f, 40f, 12, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1534), null, 5.63f, "Karışık Pizza", 241f, null, null, null, 7.8f, false, 0f, 1 },
                    { 175, 266f, 41.23f, 12, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1538), null, 6.6f, "Sebzeli Pizza", 220f, null, null, null, 13.1f, false, 0f, 1 },
                    { 176, 433f, 68.77f, 12, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1543), null, 3.93f, "Kokoreç Yarım Ekmek", 245f, null, null, null, 28.1f, false, 0f, 1 },
                    { 177, 361f, 64.75f, 12, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1547), null, 30.64f, "Çiğköfte Dürüm", 150f, null, null, null, 15.06f, false, 0f, 1 },
                    { 178, 309f, 15.13f, 12, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1552), null, 36.37f, "Tavuk Döner Dürüm", 250f, null, null, null, 43.1f, false, 0f, 1 },
                    { 179, 301f, 19.7f, 12, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1556), null, 45.6f, "Et Döner Dürüm", 235f, null, null, null, 29.65f, false, 0f, 1 },
                    { 180, 1296f, 65.74f, 12, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1561), null, 92.35f, "Kumpir", 640f, null, null, null, 50f, false, 0f, 1 },
                    { 181, 325f, 15.02f, 12, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1565), null, 45.5f, "Adana Dürüm", 200f, null, null, null, 27.8f, false, 0f, 1 },
                    { 182, 325f, 15.02f, 12, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1570), null, 45.5f, "Urfa Dürüm", 200f, null, null, null, 27.8f, false, 0f, 1 },
                    { 183, 250f, 33.15f, 12, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1574), null, 11.8f, "Patates Kızartması", 80f, null, null, null, 2.75f, false, 0f, 1 },
                    { 184, 97f, 18.91f, 12, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1579), null, 0.63f, "Soğan Halkası", 100f, null, null, null, 3.4f, false, 0f, 1 },
                    { 185, 628f, 73.44f, 12, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1583), null, 25.57f, "Kıymalı Pide", 300f, null, null, null, 24.6f, false, 0f, 1 },
                    { 186, 600f, 69f, 12, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1588), null, 26.83f, "Kaşarlı Pide", 250f, null, null, null, 19.75f, false, 0f, 1 },
                    { 187, 515f, 73.2f, 12, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1592), null, 11.5f, "Kuşbaşılı pide", 350f, null, null, null, 28.3f, false, 0f, 1 },
                    { 188, 2.31f, 73.2f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1601), null, 11.5f, "Dana Eti", 1f, null, null, null, 28.3f, false, 0f, 1 },
                    { 189, 2.71f, 0f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1606), null, 0.18f, "Kuzu Eti", 1f, null, null, null, 0.25f, false, 0f, 1 },
                    { 190, 2.44f, 0.25f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1610), null, 0.11f, "Etli Sebzeli Pizza", 1f, null, null, null, 0.11f, false, 0f, 1 },
                    { 191, 1.9f, 0f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1614), null, 0.07f, "Kızarmış Hindi Eti", 1f, null, null, null, 0.28f, false, 0f, 1 },
                    { 192, 3.05f, 0f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1619), null, 0.22f, "Kaz Eti", 1f, null, null, null, 0.25f, false, 0f, 1 },
                    { 193, 1.4f, 0f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1623), null, 0.03f, "Keçi Eti", 1f, null, null, null, 0.27f, false, 0f, 1 },
                    { 194, 4.1f, 0.11f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1628), null, 0.25f, "Kurutulmuş Sığır Eti", 1f, null, null, null, 0.33f, false, 0f, 1 },
                    { 195, 1.74f, 0.08f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1632), null, 0.01f, "Etli Nohut", 1f, null, null, null, 0.012f, false, 0f, 1 },
                    { 196, 2.52f, 0.2f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1637), null, 0.11f, "Et Döner", 1f, null, null, null, 0.3f, false, 0f, 1 },
                    { 197, 3.43f, 0f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1641), null, 0.28f, "Et Kavurma", 1f, null, null, null, 0.2f, false, 0f, 1 },
                    { 198, 1.43f, 0.03f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1646), null, 0.07f, "Et Sote", 1f, null, null, null, 0.14f, false, 0f, 1 },
                    { 199, 2.62f, 0.29f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1650), null, 0.1f, "Dana Etli Burrito", 1f, null, null, null, 0.13f, false, 0f, 1 },
                    { 200, 1.43f, 0.13f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1655), null, 0.06f, "Etli Kuru Fasulye", 1f, null, null, null, 0.09f, false, 0f, 1 },
                    { 201, 0.9f, 0.04f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1659), null, 0.056f, "Etli Türlü", 1f, null, null, null, 0.054f, false, 0f, 1 },
                    { 202, 0.88f, 0.024f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1664), null, 0.057f, "Etli Taze Fasulye", 1f, null, null, null, 0.066f, false, 0f, 1 },
                    { 203, 0.79f, 0.036f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1668), null, 0.047f, "Etli Biber Dolması", 1f, null, null, null, 0.054f, false, 0f, 1 },
                    { 204, 2.22f, 0.1f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1672), null, 0.13f, "Sulu Köfte", 1f, null, null, null, 0.14f, false, 0f, 1 },
                    { 205, 0.87f, 0.03f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1677), null, 0.06f, "İslim Kebabı", 1f, null, null, null, 0.05f, false, 0f, 1 },
                    { 206, 1.67f, 0.04f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1681), null, 0.1f, "Izgara Köfte", 1f, null, null, null, 0.14f, false, 0f, 1 },
                    { 207, 1.65f, 0.115f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1686), null, 0.01f, "İzmir Köfte", 1f, null, null, null, 0.08f, false, 0f, 1 },
                    { 208, 2.33f, 0.32f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1691), null, 0.07f, "İçli Köfte", 1f, null, null, null, 0.1f, false, 0f, 1 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calories", "Carbohydrate", "CategoryID", "CreatedDate", "DeletedDate", "Fat", "FoodName", "GramCompensation", "MacroFoodReportReportID", "ModifiedDate", "ModifiedDate2", "Protein", "Status", "TotalCalories", "Value" },
                values: new object[,]
                {
                    { 209, 1.8f, 0.1f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1695), null, 0.076f, "Kasap Köfte", 1f, null, null, null, 0.017f, false, 0f, 1 },
                    { 210, 3f, 0.08f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1704), null, 0.11f, "İnegöl Köfte", 1f, null, null, null, 0.16f, false, 0f, 1 },
                    { 211, 3.52f, 0.14f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1709), null, 0.27f, "Kadınbudu Köfte", 1f, null, null, null, 0.13f, false, 0f, 1 },
                    { 212, 2.29f, 0.08f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1713), null, 0.05f, "Adana Kebabı", 1f, null, null, null, 0.08f, false, 0f, 1 },
                    { 213, 1.02f, 0.048f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1718), null, 0.045f, "Patlıcan Kebabı", 1f, null, null, null, 0.09f, false, 0f, 1 },
                    { 214, 1.25f, 0.1f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1722), null, 0.04f, "Orman Kebabı", 1f, null, null, null, 0.048f, false, 0f, 1 },
                    { 215, 1.67f, 0.038f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1727), null, 0.097f, "Kuzu Şiş", 1f, null, null, null, 0.165f, false, 0f, 1 },
                    { 216, 0.7f, 0.07f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1731), null, 0.04f, "Tas Kebabı", 1f, null, null, null, 0.05f, false, 0f, 1 },
                    { 217, 2f, 0.13f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1736), null, 0.12f, "Beyti Kebabı", 1f, null, null, null, 0.1f, false, 0f, 1 },
                    { 218, 1.67f, 0.038f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1740), null, 0.097f, "Cağ Kebabı", 1f, null, null, null, 0.165f, false, 0f, 1 },
                    { 219, 1.72f, 0.04f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1744), null, 0.123f, "Tepsi Kebabı", 1f, null, null, null, 0.106f, false, 0f, 1 },
                    { 220, 1.77f, 0.016f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1750), null, 0.118f, "Urfa Kebabı", 1f, null, null, null, 0.154f, false, 0f, 1 },
                    { 221, 2.49f, 0.12f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1754), null, 0.28f, "Çökertme Kebabı", 1f, null, null, null, 0.105f, false, 0f, 1 },
                    { 222, 0.8f, 0.036f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1759), null, 0.28f, "Kağıt Kebabı", 1f, null, null, null, 0.103f, false, 0f, 1 },
                    { 223, 1.93f, 0.14f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1763), null, 0.11f, "İskender", 1f, null, null, null, 0.09f, false, 0f, 1 },
                    { 224, 0.57f, 0.03f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1768), null, 0.034f, "Alinazik Kebabı", 1f, null, null, null, 0.035f, false, 0f, 1 },
                    { 225, 5.34f, 3.35f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1772), null, 3.36f, "Manisa Kebabı", 1f, null, null, null, 2.33f, false, 0f, 1 },
                    { 226, 2.79f, 0.05f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1776), null, 0.05f, "Soğan Kebabı", 1f, null, null, null, 0.09f, false, 0f, 1 },
                    { 227, 1.66f, 0.153f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1781), null, 0.08f, "Islak Hamburger", 1f, null, null, null, 0.07f, false, 0f, 1 },
                    { 228, 2.58f, 0.265f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1786), null, 0.104f, "Hamburger", 1f, null, null, null, 0.147f, false, 0f, 1 },
                    { 229, 2.48f, 0.288f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1790), null, 0.104f, "Kıymalı Börek", 1f, null, null, null, 0.092f, false, 0f, 1 },
                    { 230, 1.42f, 0.96f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1795), null, 0.06f, "Patlıcan Musakka", 1f, null, null, null, 0.048f, false, 0f, 1 },
                    { 231, 2.09f, 0.245f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1801), null, 0.085f, "Kıymalı Pide", 1f, null, null, null, 0.082f, false, 0f, 1 },
                    { 232, 3.62f, 0.074f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1807), null, 0.074f, "Kıymalı Yumurta", 1f, null, null, null, 0.25f, false, 0f, 1 },
                    { 233, 2f, 0.007f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1812), null, 0.122f, "Kavrulmuş Kıyma", 1f, null, null, null, 0.276f, false, 0f, 1 },
                    { 234, 3.92f, 0.539f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1816), null, 0.121f, "Kıymalı Makarna", 1f, null, null, null, 0.155f, false, 0f, 1 },
                    { 235, 0.75f, 0.105f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1821), null, 0.023f, "Kıymalı Ispanak", 1f, null, null, null, 0.036f, false, 0f, 1 },
                    { 236, 1.12f, 0.11f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1825), null, 0.06f, "Kıymalı Karnabahar", 1f, null, null, null, 0.03f, false, 0f, 1 },
                    { 237, 0.6f, 0.105f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1830), null, 0.016f, "Kıymalı Kabak Yemeği", 1f, null, null, null, 0.022f, false, 0f, 1 },
                    { 238, 1.42f, 0.025f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1834), null, 0.035f, "Karnıyarık", 1f, null, null, null, 0.032f, false, 0f, 1 },
                    { 239, 0.96f, 0.058f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1839), null, 0.044f, "Kıymalı Bezelye", 1f, null, null, null, 0.079f, false, 0f, 1 },
                    { 240, 0.45f, 0.032f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1843), null, 0.018f, "Kıymalı Bamya", 1f, null, null, null, 0.034f, false, 0f, 1 },
                    { 241, 2.56f, 0.445f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1848), null, 0.06f, "Kıymalı Gözleme", 1f, null, null, null, 0.103f, false, 0f, 1 },
                    { 242, 0.59f, 0.049f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1853), null, 0.032f, "Kıymalı Kapuska", 1f, null, null, null, 0.025f, false, 0f, 1 },
                    { 243, 0.8f, 0.09f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1857), null, 0.03f, "Kıymalı Patates", 1f, null, null, null, 0.04f, false, 0f, 1 },
                    { 244, 1.06f, 0.052f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1862), null, 0.071f, "Kıymalı Yaprak Sarma", 1f, null, null, null, 0.056f, false, 0f, 1 },
                    { 245, 2.2f, 0.025f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1866), null, 0.09f, "Kuzu Küşleme", 1f, null, null, null, 0.328f, false, 0f, 1 },
                    { 246, 1.25f, 0.115f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1871), null, 0.025f, "Etli Lahana Sarma", 1f, null, null, null, 0.04f, false, 0f, 1 },
                    { 247, 1.42f, 0.22f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1875), null, 0.035f, "Etli Pilav", 1f, null, null, null, 0.55f, false, 0f, 1 },
                    { 248, 3.07f, 0.352f, 13, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1880), null, 0.136f, "Etli Ekmek", 1f, null, null, null, 0.11f, false, 0f, 1 },
                    { 249, 22f, 4.78f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1884), null, 0.25f, "Domates", 123f, null, null, null, 1.08f, false, 0f, 1 },
                    { 250, 27f, 5.8f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1889), null, 0.3f, "Çeri Domates", 149f, null, null, null, 1.31f, false, 0f, 1 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calories", "Carbohydrate", "CategoryID", "CreatedDate", "DeletedDate", "Fat", "FoodName", "GramCompensation", "MacroFoodReportReportID", "ModifiedDate", "ModifiedDate2", "Protein", "Status", "TotalCalories", "Value" },
                values: new object[,]
                {
                    { 251, 15f, 3.63f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1893), null, 0.11f, "Salatalık", 100f, null, null, null, 0.65f, false, 0f, 1 },
                    { 252, 5f, 1.03f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1898), null, 0.05f, "Marul", 36f, null, null, null, 0.5f, false, 0f, 1 },
                    { 253, 12f, 2.46f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1904), null, 0.21f, "Çarliston Biber", 46f, null, null, null, 0.76f, false, 0f, 1 },
                    { 254, 37f, 7.18f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1911), null, 0.36f, "Kırmızı Biber", 119f, null, null, null, 1.18f, false, 0f, 1 },
                    { 255, 1f, 0.24f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1915), null, 0.001f, "Nane", 5f, null, null, null, 0.06f, false, 0f, 1 },
                    { 256, 1f, 0.23f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1920), null, 0.03f, "Fesleğen", 10f, null, null, null, 0.13f, false, 0f, 1 },
                    { 257, 1f, 0.23f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1924), null, 0.01f, "Dereotu", 10f, null, null, null, 0.13f, false, 0f, 1 },
                    { 258, 5f, 0.99f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1930), null, 0.32f, "Kişniş", 5f, null, null, null, 0.22f, false, 0f, 1 },
                    { 259, 4f, 0.77f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1934), null, 0.18f, "Biberiye", 5f, null, null, null, 0.06f, false, 0f, 1 },
                    { 260, 1f, 0.24f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1939), null, 0.03f, "Maydanoz", 5f, null, null, null, 0.11f, false, 0f, 1 },
                    { 261, 19f, 3.94f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1943), null, 0.12f, "Turp", 116f, null, null, null, 0.79f, false, 0f, 1 },
                    { 262, 27f, 5.32f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1948), null, 0.3f, "Karnabahar", 107f, null, null, null, 2.05f, false, 0f, 1 },
                    { 263, 31f, 6.04f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1953), null, 0.34f, "Brokoli", 91f, null, null, null, 2.57f, false, 0f, 1 },
                    { 264, 38f, 7.88f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1961), null, 0.26f, "Brüksel Lahana", 88f, null, null, null, 2.97f, false, 0f, 1 },
                    { 265, 22f, 5.16f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1966), null, 0.09f, "Beyaz Lahana", 90f, null, null, null, 1.14f, false, 0f, 1 },
                    { 266, 28f, 6.56f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1970), null, 0.14f, "Kırmızı Lahana", 90f, null, null, null, 1.27f, false, 0f, 1 },
                    { 267, 25f, 5.84f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1974), null, 0.15f, "Havuç", 61f, null, null, null, 0.57f, false, 0f, 1 },
                    { 268, 4f, 0.99f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1979), null, 0.02f, "Sarımsak", 5f, null, null, null, 0.19f, false, 0f, 1 },
                    { 269, 44f, 10.27f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1983), null, 0.11f, "Soğan", 110f, null, null, null, 1.21f, false, 0f, 1 },
                    { 270, 2f, 0.44f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1988), null, 0.01f, "Yeşil Soğan", 5f, null, null, null, 0.11f, false, 0f, 1 },
                    { 271, 9f, 1.46f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1992), null, 0.15f, "Semizotu", 43f, null, null, null, 0.87f, false, 0f, 1 },
                    { 272, 7f, 1.35f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(1997), null, 0.07f, "Pazı", 36f, null, null, null, 0.65f, false, 0f, 1 },
                    { 273, 33f, 6.1f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2001), null, 0.63f, "Kabak", 196f, null, null, null, 2.37f, false, 0f, 1 },
                    { 274, 5f, 0.73f, 14, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2006), null, 0.13f, "Roka", 20f, null, null, null, 0.52f, false, 0f, 1 },
                    { 275, 115f, 5.09f, 15, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2011), null, 10.3f, "Ispanak Yemeği (Etsiz)", 100f, null, null, null, 2.11f, false, 0f, 1 },
                    { 276, 112f, 4.98f, 15, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2015), null, 10.26f, "Zeytinyağlı Semizotu", 100f, null, null, null, 1.29f, false, 0f, 1 },
                    { 277, 131f, 11.89f, 15, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2020), null, 7.18f, "Zeytinyağlı Pazı", 100f, null, null, null, 3.74f, false, 0f, 1 },
                    { 278, 151f, 21.39f, 15, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2024), null, 5.51f, "Zeytinyağlı Taze Fasulye", 100f, null, null, null, 5.54f, false, 0f, 1 },
                    { 279, 120f, 7.25f, 15, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2029), null, 10.27f, "Zeytinyağlı Pırasa", 100f, null, null, null, 0.91f, false, 0f, 1 },
                    { 280, 147f, 11.07f, 15, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2033), null, 10.38f, "Bezelye Yemeği (Etsiz)", 100f, null, null, null, 3.48f, false, 0f, 1 },
                    { 281, 80f, 7.14f, 15, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2038), null, 5.41f, "Zeytinyağlı Brokoli", 100f, null, null, null, 2.37f, false, 0f, 1 },
                    { 282, 115f, 5.29f, 15, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2042), null, 10.41f, "Karnabahar Yemeği (Etsiz)", 100f, null, null, null, 1.48f, false, 0f, 1 },
                    { 283, 113f, 4.68f, 15, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2046), null, 10.57f, "Bamya Yemeği (Etsiz)", 100f, null, null, null, 1.06f, false, 0f, 1 },
                    { 284, 112f, 8.68f, 15, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2051), null, 8.87f, "Zeytinyağlı Türlü", 100f, null, null, null, 1.33f, false, 0f, 1 },
                    { 285, 145f, 9.76f, 15, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2056), null, 10.69f, "Zeytinyağlı Bakla", 100f, null, null, null, 3.32f, false, 0f, 1 },
                    { 286, 90f, 7.14f, 15, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2063), null, 6.37f, "Zeytinyağlı Kereviz", 100f, null, null, null, 1.92f, false, 0f, 1 },
                    { 287, 146f, 12.09f, 15, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2068), null, 10.71f, "Zeytinyağlı Enginar", 100f, null, null, null, 2.93f, false, 0f, 1 },
                    { 288, 90f, 4.55f, 15, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2072), null, 10.19f, "Sebze Sote", 200f, null, null, null, 0.94f, false, 0f, 1 },
                    { 289, 258f, 13.59f, 15, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2077), null, 13.6f, "Zeytinyağlı Sebze Dolması", 200f, null, null, null, 5.6f, false, 0f, 1 },
                    { 290, 108f, 8.32f, 15, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2081), null, 8.15f, "Zeytinyağlı Yaprak Sarma", 60f, null, null, null, 1.33f, false, 0f, 1 },
                    { 291, 111f, 5.19f, 15, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2086), null, 10.18f, "Zeytinyağlı Kabak", 100f, null, null, null, 0.81f, false, 0f, 1 },
                    { 292, 9f, 1.76f, 16, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2090), null, 0.13f, "Sade Salata (Karışık Yeşillik)", 55f, null, null, null, 0.84f, false, 0f, 1 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calories", "Carbohydrate", "CategoryID", "CreatedDate", "DeletedDate", "Fat", "FoodName", "GramCompensation", "MacroFoodReportReportID", "ModifiedDate", "ModifiedDate2", "Protein", "Status", "TotalCalories", "Value" },
                values: new object[,]
                {
                    { 293, 180f, 28f, 16, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2095), null, 5.1f, "Mercimekli Lor Peynirli Salata", 255f, null, null, null, 2.7f, false, 0f, 1 },
                    { 294, 225f, 5.28f, 16, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2100), null, 8.29f, "Tavuklu Salata", 255f, null, null, null, 31.38f, false, 0f, 1 },
                    { 295, 267f, 5.28f, 16, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2105), null, 16.49f, "Etli Salata (Bonfileli/Köfteli/Fümeli)", 260f, null, null, null, 24.84f, false, 0f, 1 },
                    { 296, 215f, 5.28f, 16, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2109), null, 6.35f, "Ton Balıklı Salata", 270f, null, null, null, 21.96f, false, 0f, 1 },
                    { 297, 70f, 9.95f, 16, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2114), null, 2.41f, "Mercimet Köftesi", 30f, null, null, null, 2.75f, false, 0f, 1 },
                    { 298, 588f, 51f, 16, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2118), null, 33.3f, "Tabule Salatası", 370f, null, null, null, 14.4f, false, 0f, 1 },
                    { 299, 225f, 6.7f, 16, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2122), null, 9.81f, "Peynirli Yumurtalı Salata", 260f, null, null, null, 16.78f, false, 0f, 1 },
                    { 300, 115f, 16.62f, 16, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2127), null, 3.76f, "Çoban Salata", 220f, null, null, null, 3.19f, false, 0f, 1 },
                    { 301, 114f, 7.71f, 16, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2131), null, 7.72f, "Gavurdağı Salata", 155f, null, null, null, 2.95f, false, 0f, 1 },
                    { 302, 132f, 21.77f, 16, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2136), null, 3.33f, "Patates Salatası", 187f, null, null, null, 2.46f, false, 0f, 1 },
                    { 303, 172f, 38.4f, 16, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2141), null, 0.96f, "Meyve Salatası", 315f, null, null, null, 1.65f, false, 0f, 1 },
                    { 304, 98f, 22.09f, 17, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2145), null, 0.62f, "Kestane", 50f, null, null, null, 0.81f, false, 0f, 1 },
                    { 305, 76f, 15.58f, 17, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2150), null, 0.84f, "Patlamış Mısır", 20f, null, null, null, 2.4f, false, 0f, 1 },
                    { 306, 71f, 11.7f, 17, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2155), null, 1.25f, "Sarı Leblebi", 20f, null, null, null, 3.73f, false, 0f, 1 },
                    { 307, 72f, 11.9f, 17, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2160), null, 1.2f, "Beyaz Leblebi", 20f, null, null, null, 3.79f, false, 0f, 1 },
                    { 308, 97f, 2.57f, 17, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2167), null, 9.36f, "Fındık", 15f, null, null, null, 2.3f, false, 0f, 1 },
                    { 309, 97f, 3.62f, 17, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2172), null, 8.39f, "Badem", 17f, null, null, null, 3.55f, false, 0f, 1 },
                    { 310, 170f, 4.84f, 17, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2176), null, 14.77f, "Yer Fıstığı", 30f, null, null, null, 7.74f, false, 0f, 1 },
                    { 311, 103f, 5.09f, 17, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2180), null, 8.25f, "Antep Fıstığı", 18f, null, null, null, 3.79f, false, 0f, 1 },
                    { 312, 52f, 1.1f, 17, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2185), null, 5.22f, "Ceviz", 10f, null, null, null, 1.22f, false, 0f, 1 },
                    { 313, 104.4f, 2.68f, 17, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2189), null, 8.42f, "Kabak Çekirdeği", 20f, null, null, null, 6.6f, false, 0f, 1 },
                    { 314, 111f, 6.04f, 17, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2194), null, 8.77f, "Çiğ Kaju", 20f, null, null, null, 3.64f, false, 0f, 1 },
                    { 315, 230f, 13.08f, 17, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2198), null, 18.54f, "Kaju Fıstığı Kavrulmuş", 40f, null, null, null, 6.12f, false, 0f, 1 },
                    { 316, 32f, 5.2f, 17, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2203), null, 0.76f, "Sarı Leblebi", 7f, null, null, null, 0.66f, false, 0f, 1 },
                    { 317, 267f, 68.9f, 17, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2207), null, 1.2f, "Erik Kurusu", 100f, null, null, null, 3.5f, false, 0f, 1 },
                    { 318, 277f, 71.2f, 17, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2212), null, 0.5f, "Üzüm Kurusu", 100f, null, null, null, 2.3f, false, 0f, 1 },
                    { 319, 284f, 72.2f, 17, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2216), null, 1.2f, "Kayısı Kurusu", 100f, null, null, null, 5.4f, false, 0f, 1 },
                    { 320, 238f, 62.3f, 17, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2221), null, 2.1f, "Elma Kurusu", 100f, null, null, null, 2.1f, false, 0f, 1 },
                    { 321, 390f, 80.5f, 17, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2226), null, 1.8f, "Muz Kurusu", 100f, null, null, null, 3.9f, false, 0f, 1 },
                    { 322, 290f, 78f, 17, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2230), null, 1.2f, "Kuru İncir", 100f, null, null, null, 3.6f, false, 0f, 1 },
                    { 323, 277f, 74f, 17, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2234), null, 0.4f, "Hurma", 100f, null, null, null, 2f, false, 0f, 1 },
                    { 324, 48f, 12f, 17, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2239), null, 0.38f, "Yaban Mersini Kurusu", 100f, null, null, null, 0.38f, false, 0f, 1 },
                    { 325, 270f, 62.6f, 17, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2244), null, 0.6f, "Armut Kurusu", 100f, null, null, null, 2.3f, false, 0f, 1 },
                    { 326, 719f, 10.46f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2248), null, 74.78f, "Patates Cipsi", 100f, null, null, null, 1.23f, false, 0f, 1 },
                    { 327, 404f, 42.68f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2253), null, 25.05f, "Mısır Cipsi", 100f, null, null, null, 4.95f, false, 0f, 1 },
                    { 328, 861f, 84.15f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2257), null, 56.1f, "Pringles Original", 165f, null, null, null, 6.27f, false, 0f, 1 },
                    { 329, 198f, 20.72f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2264), null, 11.83f, "Ülker Çikolatalı Gofret", 100f, null, null, null, 2.13f, false, 0f, 1 },
                    { 330, 302f, 68.31f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2270), null, 0.09f, "Jelibon", 100f, null, null, null, 5.85f, false, 0f, 1 },
                    { 331, 765f, 139.77f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2275), null, 16.8f, "Petibör Bisküvi", 175f, null, null, null, 13.53f, false, 0f, 1 },
                    { 332, 184f, 26.69f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2279), null, 4.86f, "Form Kepekli Bisküvi", 45f, null, null, null, 5.9f, false, 0f, 1 },
                    { 333, 18f, 2.96f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2284), null, 0.6f, "Cicibebe Bisküvi", 4f, null, null, null, 0.18f, false, 0f, 1 },
                    { 334, 26f, 2.9f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2288), null, 1.76f, "Çikolata", 5f, null, null, null, 0.22f, false, 0f, 1 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calories", "Carbohydrate", "CategoryID", "CreatedDate", "DeletedDate", "Fat", "FoodName", "GramCompensation", "MacroFoodReportReportID", "ModifiedDate", "ModifiedDate2", "Protein", "Status", "TotalCalories", "Value" },
                values: new object[,]
                {
                    { 335, 76f, 6.6f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2293), null, 4.54f, "Protein Bar", 50f, null, null, null, 2.21f, false, 0f, 1 },
                    { 336, 270f, 41.04f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2297), null, 10.83f, "Oreo", 57f, null, null, null, 2f, false, 0f, 1 },
                    { 337, 286f, 72.2f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2301), null, 0f, "Olips Şeker", 76f, null, null, null, 0f, false, 0f, 1 },
                    { 338, 167f, 14.31f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2306), null, 10.98f, "Tadelle Çikolata", 30f, null, null, null, 2.7f, false, 0f, 1 },
                    { 339, 190f, 21.88f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2310), null, 9.98f, "Dido Çikolata", 35f, null, null, null, 2.7f, false, 0f, 1 },
                    { 340, 259f, 29f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2315), null, 14f, "Karam Gurme", 50f, null, null, null, 2.75f, false, 0f, 1 },
                    { 341, 154f, 22f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2319), null, 7.92f, "Eti Brownie Gold", 40f, null, null, null, 2.04f, false, 0f, 1 },
                    { 342, 118f, 10.75f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2324), null, 7.28f, "Kinder Süt Dilimi", 28f, null, null, null, 2.16f, false, 0f, 1 },
                    { 343, 110f, 10.4f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2328), null, 6.8f, "Kinder Sürpriz Yumurta", 20f, null, null, null, 1.6f, false, 0f, 1 },
                    { 344, 50f, 7.84f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2332), null, 1.78f, "Eti Gong", 11f, null, null, null, 0.64f, false, 0f, 1 },
                    { 345, 50f, 6.51f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2337), null, 2.41f, "Biskrem", 10f, null, null, null, 0.45f, false, 0f, 1 },
                    { 346, 39f, 4.37f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2342), null, 1.9f, "Ülker Probis", 8f, null, null, null, 0.93f, false, 0f, 1 },
                    { 347, 113f, 17.05f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2346), null, 3.78f, "Süt Burger", 35f, null, null, null, 1.75f, false, 0f, 1 },
                    { 348, 90f, 12.65f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2350), null, 4.01f, "Dankek 8kek", 55f, null, null, null, 0.88f, false, 0f, 1 },
                    { 349, 232f, 26.5f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2355), null, 12.85f, "Brownie Intense", 50f, null, null, null, 2.3f, false, 0f, 1 },
                    { 350, 167f, 22.96f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2359), null, 7.24f, "Eti Topkek Kakolu", 40f, null, null, null, 2.12f, false, 0f, 1 },
                    { 351, 264f, 34.62f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2368), null, 12.6f, "Eti Popkek Meyveli", 60f, null, null, null, 2.82f, false, 0f, 1 },
                    { 352, 167f, 22.96f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2372), null, 7.24f, "Eti Topkek Portakallı", 40f, null, null, null, 2.12f, false, 0f, 1 },
                    { 353, 132f, 20.31f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2377), null, 5.1f, "Halley", 30f, null, null, null, 1.2f, false, 0f, 1 },
                    { 354, 33f, 5.16f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2381), null, 1.27f, "Ülker Kremalı Bisküvi", 7f, null, null, null, 0.36f, false, 0f, 1 },
                    { 355, 152f, 18.6f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2386), null, 7.8f, "Ülker Çokoprens", 30f, null, null, null, 1.68f, false, 0f, 1 },
                    { 356, 44f, 7.43f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2390), null, 1.38f, "Eti Cin", 10f, null, null, null, 0.47f, false, 0f, 1 },
                    { 357, 584f, 69.72f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2395), null, 29.28f, "Eti Nero", 120f, null, null, null, 8.28f, false, 0f, 1 },
                    { 358, 51f, 6.1f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2399), null, 2.6f, "Eti Tutku", 10f, null, null, null, 0.5f, false, 0f, 1 },
                    { 359, 46f, 6.13f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2403), null, 2.16f, "Eti Benim'O", 10f, null, null, null, 0.47f, false, 0f, 1 },
                    { 360, 68f, 9.87f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2408), null, 2.54f, "Eti Burçak", 15f, null, null, null, 0.93f, false, 0f, 1 },
                    { 361, 405f, 52.92f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2412), null, 17.64f, "Ülker İkram", 84f, null, null, null, 6.47f, false, 0f, 1 },
                    { 362, 605f, 90.75f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2417), null, 23.75f, "Lotus Bisküvi", 125f, null, null, null, 6.13f, false, 0f, 1 },
                    { 363, 133f, 18.1f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2421), null, 5.4f, "Şölen Greta Zeytinli", 30f, null, null, null, 2.8f, false, 0f, 1 },
                    { 364, 181f, 19.11f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2426), null, 11.32f, "Ülker Çokonat", 33f, null, null, null, 2.05f, false, 0f, 1 },
                    { 365, 120f, 10.4f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2430), null, 7.83f, "Kinder Bueno", 21f, null, null, null, 1.81f, false, 0f, 1 },
                    { 366, 197f, 25.56f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2434), null, 9.8f, "Eti Hoşbeş", 40f, null, null, null, 3.04f, false, 0f, 1 },
                    { 367, 250f, 34f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2439), null, 12f, "Twix", 50f, null, null, null, 4f, false, 0f, 1 },
                    { 368, 237f, 31.31f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2443), null, 11.35f, "Snickers", 50f, null, null, null, 3.8f, false, 0f, 1 },
                    { 369, 225f, 35f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2448), null, 8.5f, "Mars", 50f, null, null, null, 2f, false, 0f, 1 },
                    { 370, 206f, 25.2f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2452), null, 10.64f, "Ülker Albeni", 40f, null, null, null, 2.24f, false, 0f, 1 },
                    { 371, 169f, 20.16f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2457), null, 8.74f, "Crunch Çikolata", 33f, null, null, null, 2.05f, false, 0f, 1 },
                    { 372, 184f, 27.36f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2462), null, 7.4f, "Ülker Metro", 40f, null, null, null, 1.96f, false, 0f, 1 },
                    { 373, 193f, 22.98f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2469), null, 9.78f, "Alaska Frigo", 60f, null, null, null, 2.4f, false, 0f, 1 },
                    { 374, 148f, 15.48f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2474), null, 0f, "Coco Star", 28f, null, null, null, 1.2f, false, 0f, 1 },
                    { 375, 200f, 40.82f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2478), null, 2.91f, "Sade Çubuk Kraker", 52f, null, null, null, 5.51f, false, 0f, 1 },
                    { 376, 172f, 22.39f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2483), null, 7.1f, "Susamlı Çubuk Kraker", 37f, null, null, null, 3.89f, false, 0f, 1 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calories", "Carbohydrate", "CategoryID", "CreatedDate", "DeletedDate", "Fat", "FoodName", "GramCompensation", "MacroFoodReportReportID", "ModifiedDate", "ModifiedDate2", "Protein", "Status", "TotalCalories", "Value" },
                values: new object[,]
                {
                    { 377, 113f, 5.47f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2487), null, 8.86f, "Çizi Bisküvi", 20f, null, null, null, 3.15f, false, 0f, 1 },
                    { 378, 125f, 15f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2491), null, 6.25f, "Cornetto", 75f, null, null, null, 1.56f, false, 0f, 1 },
                    { 379, 239f, 24.64f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2497), null, 14.63f, "Magnum", 77f, null, null, null, 2.7f, false, 0f, 1 },
                    { 380, 179f, 42.05f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2502), null, 0.2f, "Mısır Gevreği / Cornflakes", 50f, null, null, null, 3.75f, false, 0f, 1 },
                    { 381, 195f, 33.14f, 18, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2506), null, 3.45f, "Yulaf Ezmesi", 100f, null, null, null, 8.45f, false, 0f, 1 },
                    { 382, 0f, 0f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2511), null, 0f, "Maden Suyu", 1f, null, null, null, 0f, false, 0f, 1 },
                    { 383, 2.6f, 0f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2515), null, 0f, "Bergamot Çayı", 125f, null, null, null, 0f, false, 0f, 1 },
                    { 384, 279f, 60f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2519), null, 1.8f, "Boza", 275f, null, null, null, 45f, false, 0f, 1 },
                    { 385, 188f, 27.8f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2524), null, 6f, "Salep", 200f, null, null, null, 5.6f, false, 0f, 1 },
                    { 386, 79f, 21.4f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2528), null, 0f, "Kahve", 125f, null, null, null, 0f, false, 0f, 1 },
                    { 387, 22.4f, 21.4f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2533), null, 0f, "CocaCola", 125f, null, null, null, 0f, false, 0f, 1 },
                    { 388, 0f, 0f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2537), null, 0f, "CocaCola Light", 125f, null, null, null, 0f, false, 0f, 1 },
                    { 389, 0f, 0f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2543), null, 0f, "CocaCola Zero", 125f, null, null, null, 0f, false, 0f, 1 },
                    { 390, 95f, 23.4f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2547), null, 0f, "Fanta", 125f, null, null, null, 0f, false, 0f, 1 },
                    { 391, 73f, 14.69f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2552), null, 0.2f, "Limonata", 125f, null, null, null, 0.24f, false, 0f, 1 },
                    { 392, 84f, 0f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2556), null, 0f, "Gazoz", 125f, null, null, null, 0f, false, 0f, 1 },
                    { 393, 230f, 36.8f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2561), null, 5.6f, "Milkshake", 230f, null, null, null, 7.2f, false, 0f, 1 },
                    { 394, 82f, 21f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2566), null, 0f, "Smoothie", 230f, null, null, null, 0.1f, false, 0f, 1 },
                    { 395, 100f, 24.2f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2573), null, 0f, "Meyve Suyu", 200f, null, null, null, 0f, false, 0f, 1 },
                    { 396, 120f, 29.28f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2577), null, 0.33f, "Taze Sıkma Portakal Suyu", 200f, null, null, null, 0.8f, false, 0f, 1 },
                    { 397, 2f, 0f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2581), null, 0f, "Nar Suyu", 200f, null, null, null, 0f, false, 0f, 1 },
                    { 398, 10f, 2.12f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2586), null, 0.22f, "Şalgam Suyu", 200f, null, null, null, 1.03f, false, 0f, 1 },
                    { 399, 106f, 26.06f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2590), null, 0.1f, "Sıcak Çikolata", 250f, null, null, null, 0f, false, 0f, 1 },
                    { 400, 32f, 0f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2595), null, 0f, "Powerade", 250f, null, null, null, 0f, false, 0f, 1 },
                    { 401, 90f, 22f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2600), null, 0.2f, "Red Bull", 200f, null, null, null, 0.6f, false, 0f, 1 },
                    { 402, 0f, 0f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2604), null, 0f, "Zencefilli Bitki Çayı", 200f, null, null, null, 0f, false, 0f, 1 },
                    { 403, 10f, 2.35f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2609), null, 0f, "Çay", 150f, null, null, null, 0f, false, 0f, 1 },
                    { 404, 4f, 0f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2613), null, 0f, "Türk Kahvesi", 200f, null, null, null, 0f, false, 0f, 1 },
                    { 405, 259f, 31.86f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2618), null, 12.04f, "White Chocolate Mocha", 348f, null, null, null, 7.55f, false, 0f, 1 },
                    { 406, 25f, 6.99f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2622), null, 0f, "Cool Lime", 200f, null, null, null, 0f, false, 0f, 1 },
                    { 407, 60f, 20f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2627), null, 0f, "Starbucks Berry Hibiscus", 200f, null, null, null, 0f, false, 0f, 1 },
                    { 408, 50f, 7f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2631), null, 0.005f, "Cappuccino", 250f, null, null, null, 4.19f, false, 0f, 1 },
                    { 409, 60f, 8.5f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2635), null, 0.005f, "Latte", 250f, null, null, null, 6f, false, 0f, 1 },
                    { 410, 3f, 0f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2640), null, 0.07f, "Filtre Kahve", 250f, null, null, null, 0.28f, false, 0f, 1 },
                    { 411, 100f, 16.4f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2644), null, 2.6f, "Nescafe Xpress", 250f, null, null, null, 2.8f, false, 0f, 1 },
                    { 412, 81f, 15.19f, 19, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2649), null, 1.89f, "Nescafe 3'ü 1 arada", 250f, null, null, null, 0.5f, false, 0f, 1 },
                    { 413, 336f, 57.52f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2653), null, 4.44f, "Pilav Üstü Kuru", 230f, null, null, null, 15.28f, false, 0f, 1 },
                    { 414, 334f, 30.3f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2658), null, 12.29f, "Hamsili Pilav", 230f, null, null, null, 26.52f, false, 0f, 1 },
                    { 415, 462f, 82.85f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2662), null, 10.01f, "Şehriyeli Pilav", 270f, null, null, null, 8.53f, false, 0f, 1 },
                    { 416, 169f, 31.29f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2671), null, 2.94f, "Nohutlu Pilav", 100f, null, null, null, 4.15f, false, 0f, 1 },
                    { 417, 139f, 25.99f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2676), null, 2.53f, "İç Pilav", 100f, null, null, null, 2.59f, false, 0f, 1 },
                    { 418, 118f, 22.62f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2680), null, 1.99f, "Sade Pilav", 80f, null, null, null, 1.99f, false, 0f, 1 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calories", "Carbohydrate", "CategoryID", "CreatedDate", "DeletedDate", "Fat", "FoodName", "GramCompensation", "MacroFoodReportReportID", "ModifiedDate", "ModifiedDate2", "Protein", "Status", "TotalCalories", "Value" },
                values: new object[,]
                {
                    { 419, 169f, 31.13f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2685), null, 2.61f, "Domatesli Bulgur Pilavı", 230f, null, null, null, 4.56f, false, 0f, 1 },
                    { 420, 480f, 43.69f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2689), null, 23.76f, "Acem Pilavı", 245f, null, null, null, 22.32f, false, 0f, 1 },
                    { 421, 570f, 58.2f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2694), null, 27.56f, "Özbek Pilavı", 340f, null, null, null, 22.35f, false, 0f, 1 },
                    { 422, 118f, 14.05f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2698), null, 3.1f, "Basmati Pilavı", 50f, null, null, null, 1.65f, false, 0f, 1 },
                    { 423, 380f, 72.76f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2703), null, 3.75f, "Kuskus Pilavı", 180f, null, null, null, 11.79f, false, 0f, 1 },
                    { 424, 283f, 46.47f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2707), null, 8.65f, "Tereyağlı Pirinç Pilavı", 170f, null, null, null, 4.14f, false, 0f, 1 },
                    { 425, 31f, 3.06f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2711), null, 1.6f, "Bezelye Çorbası", 150f, null, null, null, 1.05f, false, 0f, 1 },
                    { 426, 47f, 6.53f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2716), null, 1.66f, "Bezelye Çorbası", 150f, null, null, null, 1.36f, false, 0f, 1 },
                    { 427, 31f, 2.07f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2720), null, 1.73f, "Bezelye Çorbası", 100f, null, null, null, 1.68f, false, 0f, 1 },
                    { 428, 68f, 8.92f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2725), null, 1.76f, "Ezogelin Çorbası", 150f, null, null, null, 2.83f, false, 0f, 1 },
                    { 429, 139f, 4.93f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2729), null, 6.35f, "İşkembe Çorbası", 100f, null, null, null, 15.14f, false, 0f, 1 },
                    { 430, 68f, 12.42f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2733), null, 0.29f, "Kırmızı Mercimek Çorbası", 150f, null, null, null, 3.69f, false, 0f, 1 },
                    { 431, 121f, 12.04f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2738), null, 6.03f, "Yeşil Mercimek Çorbası", 150f, null, null, null, 4.5f, false, 0f, 1 },
                    { 432, 44f, 6.06f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2743), null, 1.68f, "Sebze Çorbası", 100f, null, null, null, 1f, false, 0f, 1 },
                    { 433, 91f, 7.48f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2747), null, 4.93f, "Tarhana Çorbası", 150f, null, null, null, 3.45f, false, 0f, 1 },
                    { 434, 70f, 9.71f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2752), null, 2.41f, "Yayla Çorbası", 150f, null, null, null, 12.19f, false, 0f, 1 },
                    { 435, 83f, 5.17f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2756), null, 2.95f, "Tavuk Çorbası", 150f, null, null, null, 5.96f, false, 0f, 1 },
                    { 436, 29f, 2.41f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2760), null, 1.19f, "Balkabaği Çorbası", 100f, null, null, null, 1.87f, false, 0f, 1 },
                    { 437, 99f, 7.36f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2765), null, 6.37f, "Mantar Çorbası", 150f, null, null, null, 3.06f, false, 0f, 1 },
                    { 438, 120f, 5.21f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2773), null, 11.27f, "Kremalı Mantar Çorbası", 150f, null, null, null, 1.92f, false, 0f, 1 },
                    { 439, 39f, 5.06f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2778), null, 1.47f, "Brokoli Çorbası", 150f, null, null, null, 1.37f, false, 0f, 1 },
                    { 440, 117f, 0.86f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2782), null, 4.29f, "Paça Çorbası", 150f, null, null, null, 18.81f, false, 0f, 1 },
                    { 441, 49f, 4.43f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2787), null, 1.27f, "Balik Çorbası", 100f, null, null, null, 4.51f, false, 0f, 1 },
                    { 442, 72f, 7.2f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2791), null, 3.07f, "Tutmac Çorbası", 100f, null, null, null, 3.01f, false, 0f, 1 },
                    { 443, 67f, 6.51f, 20, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2796), null, 4.16f, "Tutmac Çorbası", 150f, null, null, null, 0.87f, false, 0f, 1 },
                    { 444, 71f, 13.17f, 21, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2801), null, 0.65f, "Beyaz Ekmek", 30f, null, null, null, 3.2f, false, 0f, 1 },
                    { 445, 63f, 10.68f, 21, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2805), null, 0.88f, "Tam Buğday Ekmeği", 25f, null, null, null, 3.11f, false, 0f, 1 },
                    { 446, 63f, 13.15f, 21, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2810), null, 0.27f, "Cavdar Ekmeği", 30f, null, null, null, 1.81f, false, 0f, 1 },
                    { 447, 54f, 11.14f, 21, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2814), null, 0.38f, "Kepekli Ekmek", 25f, null, null, null, 1.51f, false, 0f, 1 },
                    { 448, 20f, 3.53f, 21, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2819), null, 0.36f, "Grissini", 5f, null, null, null, 0.51f, false, 0f, 1 },
                    { 449, 76f, 14.31f, 21, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2823), null, 1f, "Beyaz Tost Ekmeği", 30f, null, null, null, 2.21f, false, 0f, 1 },
                    { 450, 67f, 11.65f, 21, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2827), null, 0.79f, "Çok Tahıllı Tost Ekmeği", 28f, null, null, null, 3.33f, false, 0f, 1 },
                    { 451, 178f, 37.21f, 21, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2832), null, 1.61f, "Sandviç Ekmeği", 65f, null, null, null, 5.07f, false, 0f, 1 },
                    { 452, 171f, 31.08f, 21, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2836), null, 1.5f, "Kepekli Sandviç Ekmeği", 70f, null, null, null, 6.72f, false, 0f, 1 },
                    { 453, 142f, 29.64f, 21, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2841), null, 1.04f, "Hamburger Ekmeği", 52f, null, null, null, 3.64f, false, 0f, 1 },
                    { 454, 387f, 80.18f, 21, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2846), null, 1.41f, "Yufka", 160f, null, null, null, 10.94f, false, 0f, 1 },
                    { 455, 36f, 7.28f, 21, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2850), null, 0.11f, "İrmik", 10f, null, null, null, 1.27f, false, 0f, 1 },
                    { 456, 37f, 9.06f, 21, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2855), null, 0.08f, "Mısır Nişastası", 10f, null, null, null, 0.02f, false, 0f, 1 },
                    { 457, 40f, 7.2f, 21, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2859), null, 0.53f, "Galeta Unu", 10f, null, null, null, 1.34f, false, 0f, 1 },
                    { 458, 40f, 8.54f, 21, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2864), null, 0.01f, "Beyaz Un", 10f, null, null, null, 0.04f, false, 0f, 1 },
                    { 459, 194f, 25.11f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2869), null, 6.85f, "Peynirli Börek", 75f, null, null, null, 7.58f, false, 0f, 1 },
                    { 460, 204f, 26.87f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2876), null, 8.67f, "Patatesli Börek", 75f, null, null, null, 4.27f, false, 0f, 1 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calories", "Carbohydrate", "CategoryID", "CreatedDate", "DeletedDate", "Fat", "FoodName", "GramCompensation", "MacroFoodReportReportID", "ModifiedDate", "ModifiedDate2", "Protein", "Status", "TotalCalories", "Value" },
                values: new object[,]
                {
                    { 461, 116f, 21.39f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2881), null, 2.35f, "Ispanaklı Börek", 75f, null, null, null, 4.29f, false, 0f, 1 },
                    { 462, 172f, 18.77f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2885), null, 8.24f, "Su Böreği", 75f, null, null, null, 5.39f, false, 0f, 1 },
                    { 463, 264f, 32.76f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2890), null, 13.28f, "Çiğ Börek", 70f, null, null, null, 3.18f, false, 0f, 1 },
                    { 464, 107f, 18.43f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2894), null, 1.08f, "Patlıcanlı Börek", 75f, null, null, null, 4.05f, false, 0f, 1 },
                    { 465, 361f, 57.1f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2899), null, 7.97f, "Bisküvili Pasta", 220f, null, null, null, 11.22f, false, 0f, 1 },
                    { 466, 577f, 39.56f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2903), null, 42.85f, "Çikolatalı Pasta", 150f, null, null, null, 7.44f, false, 0f, 1 },
                    { 467, 257f, 41.5f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2908), null, 6.09f, "Meyveli Pasta", 150f, null, null, null, 6.38f, false, 0f, 1 },
                    { 468, 286f, 43.49f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2912), null, 6.8f, "Muzlu Rulo Pasta", 160f, null, null, null, 10.27f, false, 0f, 1 },
                    { 469, 241f, 32.95f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2917), null, 9.15f, "Sade Kek", 70f, null, null, null, 4.45f, false, 0f, 1 },
                    { 470, 268f, 31.2f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2922), null, 13.11f, "Kakaolu Kek", 70f, null, null, null, 3.94f, false, 0f, 1 },
                    { 471, 249f, 26.91f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2926), null, 13.36f, "Havuclu Kek", 70f, null, null, null, 3.84f, false, 0f, 1 },
                    { 472, 188f, 28.92f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2930), null, 5.7f, "Portakallı Kek", 70f, null, null, null, 3.55f, false, 0f, 1 },
                    { 473, 153f, 18.08f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2935), null, 7.66f, "Elmalı Kek", 45f, null, null, null, 2.49f, false, 0f, 1 },
                    { 474, 238f, 22.22f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2939), null, 14.84f, "Fındıklı Kurabiye", 45f, null, null, null, 3.86f, false, 0f, 1 },
                    { 475, 203f, 21.61f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2944), null, 11.38f, "Cevizli Kurabiye", 45f, null, null, null, 3.69f, false, 0f, 1 },
                    { 476, 210f, 21.95f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2948), null, 12.2f, "Çikolatalı Kurabiye", 45f, null, null, null, 2.97f, false, 0f, 1 },
                    { 477, 161f, 17.65f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2953), null, 8.68f, "Yulafli Fit Kurabiye", 45f, null, null, null, 5.48f, false, 0f, 1 },
                    { 478, 102f, 19.39f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2957), null, 1.54f, "Kuru Uzumlu Diyet Kurabiye", 45f, null, null, null, 3.46f, false, 0f, 1 },
                    { 479, 184f, 19.31f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2962), null, 10.22f, "Tuzlu Pastane Kurabiyesi", 30f, null, null, null, 3.82f, false, 0f, 1 },
                    { 480, 128f, 21.06f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2966), null, 4.67f, "Un Kurabiyesi", 30f, null, null, null, 0.18f, false, 0f, 1 },
                    { 481, 167f, 14.97f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2972), null, 60.67f, "Kandil Simidi", 35f, null, null, null, 2.93f, false, 0f, 1 },
                    { 482, 275f, 57.14f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2979), null, 3.57f, "Simit", 100f, null, null, null, 10.71f, false, 0f, 1 },
                    { 483, 243f, 22.33f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2983), null, 14.74f, "Poğaça", 70f, null, null, null, 4.91f, false, 0f, 1 },
                    { 484, 274f, 21.4f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2988), null, 18.29f, "Peynirli Poğaça", 70f, null, null, null, 6.1f, false, 0f, 1 },
                    { 485, 234f, 25.2f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2992), null, 20.44f, "Dereotlu Poğaça", 70f, null, null, null, 5.09f, false, 0f, 1 },
                    { 486, 267f, 23.97f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(2996), null, 17.27f, "Zeytinli Poğaça", 70f, null, null, null, 5.06f, false, 0f, 1 },
                    { 487, 230f, 20.01f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3001), null, 14.96f, "Patatesli Poğaça", 70f, null, null, null, 3.48f, false, 0f, 1 },
                    { 488, 341f, 35.22f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3005), null, 23.89f, "Acma", 90f, null, null, null, 5.91f, false, 0f, 1 },
                    { 489, 268f, 36.71f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3010), null, 10.83f, "Çikolatalı Acma", 75f, null, null, null, 5.32f, false, 0f, 1 },
                    { 490, 354f, 31.25f, 22, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3014), null, 22.95f, "Zeytinli Acma", 90f, null, null, null, 5.27f, false, 0f, 1 },
                    { 491, 250f, 45.16f, 23, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3019), null, 0.63f, "Etsiz Kuru Fasulye", 180f, null, null, null, 17.51f, false, 0f, 1 },
                    { 492, 322f, 41.16f, 23, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3023), null, 0.63f, "Etsiz Nohut Yemeği", 200f, null, null, null, 11.8f, false, 0f, 1 },
                    { 493, 132f, 22.42f, 23, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3028), null, 2.39f, "Bezelye Yemeği", 200f, null, null, null, 6.15f, false, 0f, 1 },
                    { 494, 164f, 17.04f, 23, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3032), null, 4.52f, "Mercimek Yemeği", 230f, null, null, null, 8.97f, false, 0f, 1 },
                    { 495, 140f, 42.83f, 23, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3036), null, 14.14f, "Zeytinyağlı Barbunya", 140f, null, null, null, 15.99f, false, 0f, 1 },
                    { 496, 607f, 110.32f, 23, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3041), null, 1.91f, "Meksika Fasulyesi", 180f, null, null, null, 40.55f, false, 0f, 1 },
                    { 497, 274f, 0.31f, 23, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3046), null, 17.79f, "Soya Fasulyesi", 180f, null, null, null, 28.31f, false, 0f, 1 },
                    { 498, 135f, 0f, 24, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3050), null, 15f, "İç Yağı", 15f, null, null, null, 0f, false, 0f, 1 },
                    { 499, 79f, 0.01f, 24, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3054), null, 8.61f, "Kuyruk Yağı", 14f, null, null, null, 0.29f, false, 0f, 1 },
                    { 500, 44f, 0f, 24, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3059), null, 4.99f, "Balık Yağı", 5f, null, null, null, 0f, false, 0f, 1 },
                    { 501, 44f, 0f, 25, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3063), null, 5f, "Ayçiçeği Yağı", 5f, null, null, null, 0f, false, 0f, 1 },
                    { 502, 35f, 0f, 25, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3068), null, 4f, "Fındık Yağı", 4f, null, null, null, 0f, false, 0f, 1 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calories", "Carbohydrate", "CategoryID", "CreatedDate", "DeletedDate", "Fat", "FoodName", "GramCompensation", "MacroFoodReportReportID", "ModifiedDate", "ModifiedDate2", "Protein", "Status", "TotalCalories", "Value" },
                values: new object[,]
                {
                    { 503, 40f, 0.01f, 25, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3076), null, 4.5f, "Zeytin Yağı", 4f, null, null, null, 0f, false, 0f, 1 },
                    { 504, 125f, 3.81f, 26, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3081), null, 0f, "Beyaz Şarap", 150f, null, null, null, 0.1f, false, 0f, 1 },
                    { 505, 125f, 3.85f, 26, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3085), null, 0f, "Kırmızı Şarap", 150f, null, null, null, 0.1f, false, 0f, 1 },
                    { 506, 139f, 10.3f, 26, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3090), null, 0f, "Bira", 330f, null, null, null, 1.65f, false, 0f, 1 },
                    { 507, 231f, 0f, 26, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3094), null, 0f, "Cin", 100f, null, null, null, 0f, false, 0f, 1 },
                    { 508, 186f, 0.33f, 26, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3099), null, 0f, "Raki", 100f, null, null, null, 0f, false, 0f, 1 },
                    { 509, 116f, 0f, 26, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3103), null, 0f, "Votka", 100f, null, null, null, 0f, false, 0f, 1 },
                    { 510, 0f, 0.06f, 26, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3108), null, 0f, "Viski", 100f, null, null, null, 0f, false, 0f, 1 },
                    { 511, 131f, 15.21f, 26, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3112), null, 0f, "Vişne Likörü", 30f, null, null, null, 0f, false, 0f, 1 },
                    { 512, 96f, 7.5f, 26, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3117), null, 0f, "Portakal Likörü", 30f, null, null, null, 0f, false, 0f, 1 },
                    { 513, 80f, 1.47f, 26, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3121), null, 0f, "Şampanya", 100f, null, null, null, 0.32f, false, 0f, 1 },
                    { 514, 220f, 0f, 26, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3132), null, 0f, "Brandy", 100f, null, null, null, 0f, false, 0f, 1 },
                    { 515, 138f, 7.5f, 26, new DateTime(2023, 9, 22, 10, 1, 32, 380, DateTimeKind.Local).AddTicks(3137), null, 0f, "Tekila", 30f, null, null, null, 0f, false, 0f, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 26);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate" },
                values: new object[] { "Deniz Ürünleri", new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9009) });

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
                columns: new[] { "CreatedDate", "GramCompensation", "TotalCalories" },
                values: new object[] { new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9034), 100f, 2.08f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "GramCompensation", "TotalCalories" },
                values: new object[] { new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9037), 100f, 0.73f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 3,
                columns: new[] { "Carbohydrate", "CreatedDate", "GramCompensation", "TotalCalories" },
                values: new object[] { 0f, new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9039), 100f, 1.01f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 4,
                columns: new[] { "Carbohydrate", "CreatedDate", "GramCompensation", "TotalCalories" },
                values: new object[] { 0f, new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9040), 100f, 1.2f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 5,
                columns: new[] { "Carbohydrate", "CreatedDate", "GramCompensation", "TotalCalories" },
                values: new object[] { 0f, new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9041), 100f, 1.2f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 6,
                columns: new[] { "Carbohydrate", "CreatedDate", "GramCompensation", "TotalCalories" },
                values: new object[] { 0f, new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9042), 100f, 0.79f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 7,
                columns: new[] { "CategoryID", "CreatedDate", "GramCompensation", "TotalCalories" },
                values: new object[] { 2, new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9043), 100f, 2f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 8,
                columns: new[] { "Carbohydrate", "CategoryID", "CreatedDate", "Fat", "GramCompensation", "TotalCalories" },
                values: new object[] { 0f, 2, new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9044), 0.05f, 100f, 1.15f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 9,
                columns: new[] { "CategoryID", "CreatedDate", "GramCompensation", "TotalCalories" },
                values: new object[] { 2, new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9050), 100f, 2.62f });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: 10,
                columns: new[] { "CategoryID", "CreatedDate", "GramCompensation", "TotalCalories" },
                values: new object[] { 2, new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9052), 100f, 0.91f });

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
                columns: new[] { "CreatedDate", "MealName" },
                values: new object[] { new DateTime(2023, 9, 22, 1, 41, 41, 853, DateTimeKind.Local).AddTicks(9080), "Snack" });
        }
    }
}
