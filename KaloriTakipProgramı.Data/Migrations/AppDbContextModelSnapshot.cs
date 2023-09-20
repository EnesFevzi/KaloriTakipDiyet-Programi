﻿// <auto-generated />
using System;
using KaloriTakipProgramı.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ConsumeFoodFood", b =>
                {
                    b.Property<int>("ConsumeFoodsConsumeFoodID")
                        .HasColumnType("int");

                    b.Property<int>("FoodsFoodID")
                        .HasColumnType("int");

                    b.HasKey("ConsumeFoodsConsumeFoodID", "FoodsFoodID");

                    b.HasIndex("FoodsFoodID");

                    b.ToTable("ConsumeFoodFood");
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.AppRole", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"), 1L, 1);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("AppRoles");

                    b.HasData(
                        new
                        {
                            RoleID = 1,
                            RoleName = "Admin"
                        });
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.AppUser", b =>
                {
                    b.Property<int>("AppUserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppUserID"), 1L, 1);

                    b.Property<double?>("ActivityValue")
                        .HasColumnType("float");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<double?>("BMH")
                        .HasColumnType("float");

                    b.Property<double?>("BasinCircle")
                        .HasColumnType("float");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Height")
                        .HasColumnType("float");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastWaterAdditionDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate2")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("NeckCircle")
                        .HasColumnType("float");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleID")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("VKI")
                        .HasColumnType("float");

                    b.Property<double?>("VYO")
                        .HasColumnType("float");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.Property<double?>("WaistCircle")
                        .HasColumnType("float");

                    b.Property<double?>("Weight")
                        .HasColumnType("float");

                    b.HasKey("AppUserID");

                    b.HasIndex("RoleID");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate2")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Deniz Ürünleri",
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9451),
                            Status = false,
                            Value = 1
                        });
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.ConsumeFood", b =>
                {
                    b.Property<int>("ConsumeFoodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConsumeFoodID"), 1L, 1);

                    b.Property<int>("AppUserID")
                        .HasColumnType("int");

                    b.Property<float>("Calories")
                        .HasColumnType("real");

                    b.Property<float>("Carbohydrate")
                        .HasColumnType("real");

                    b.Property<string>("ConsumeFoodName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("Fat")
                        .HasColumnType("real");

                    b.Property<float>("GramCompensation")
                        .HasColumnType("real");

                    b.Property<int>("MealID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate2")
                        .HasColumnType("datetime2");

                    b.Property<float>("Protein")
                        .HasColumnType("real");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("ConsumeFoodID");

                    b.HasIndex("AppUserID");

                    b.HasIndex("MealID");

                    b.ToTable("ConsumeFoods");

                    b.HasData(
                        new
                        {
                            ConsumeFoodID = 1,
                            AppUserID = 8,
                            Calories = 52f,
                            Carbohydrate = 14f,
                            ConsumeFoodName = "Apple",
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9517),
                            Fat = 0.2f,
                            GramCompensation = 100f,
                            MealID = 1,
                            Protein = 0.3f,
                            Status = false,
                            Value = 1
                        },
                        new
                        {
                            ConsumeFoodID = 2,
                            AppUserID = 8,
                            Calories = 52f,
                            Carbohydrate = 14f,
                            ConsumeFoodName = "Apple",
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9520),
                            Fat = 0.2f,
                            GramCompensation = 100f,
                            MealID = 1,
                            Protein = 0.3f,
                            Status = false,
                            Value = 1
                        },
                        new
                        {
                            ConsumeFoodID = 3,
                            AppUserID = 8,
                            Calories = 52f,
                            Carbohydrate = 14f,
                            ConsumeFoodName = "Apple",
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9521),
                            Fat = 0.2f,
                            GramCompensation = 100f,
                            MealID = 1,
                            Protein = 0.3f,
                            Status = false,
                            Value = 1
                        },
                        new
                        {
                            ConsumeFoodID = 4,
                            AppUserID = 8,
                            Calories = 165f,
                            Carbohydrate = 0f,
                            ConsumeFoodName = "Chicken Breast",
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9522),
                            Fat = 3.6f,
                            GramCompensation = 100f,
                            MealID = 1,
                            Protein = 31f,
                            Status = false,
                            Value = 1
                        },
                        new
                        {
                            ConsumeFoodID = 5,
                            AppUserID = 8,
                            Calories = 130f,
                            Carbohydrate = 28f,
                            ConsumeFoodName = "Rice",
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9526),
                            Fat = 0.3f,
                            GramCompensation = 100f,
                            MealID = 1,
                            Protein = 2.7f,
                            Status = false,
                            Value = 1
                        },
                        new
                        {
                            ConsumeFoodID = 6,
                            AppUserID = 8,
                            Calories = 206f,
                            Carbohydrate = 0f,
                            ConsumeFoodName = "Salmon",
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9531),
                            Fat = 13f,
                            GramCompensation = 100f,
                            MealID = 1,
                            Protein = 22f,
                            Status = false,
                            Value = 1
                        },
                        new
                        {
                            ConsumeFoodID = 7,
                            AppUserID = 8,
                            Calories = 206f,
                            Carbohydrate = 0f,
                            ConsumeFoodName = "Salmon",
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9532),
                            Fat = 13f,
                            GramCompensation = 100f,
                            MealID = 1,
                            Protein = 22f,
                            Status = false,
                            Value = 1
                        },
                        new
                        {
                            ConsumeFoodID = 8,
                            AppUserID = 8,
                            Calories = 206f,
                            Carbohydrate = 0f,
                            ConsumeFoodName = "Salmon",
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9533),
                            Fat = 13f,
                            GramCompensation = 100f,
                            MealID = 1,
                            Protein = 22f,
                            Status = false,
                            Value = 1
                        },
                        new
                        {
                            ConsumeFoodID = 9,
                            AppUserID = 8,
                            Calories = 206f,
                            Carbohydrate = 0f,
                            ConsumeFoodName = "Salmon",
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9534),
                            Fat = 13f,
                            GramCompensation = 100f,
                            MealID = 1,
                            Protein = 22f,
                            Status = false,
                            Value = 1
                        },
                        new
                        {
                            ConsumeFoodID = 10,
                            AppUserID = 8,
                            Calories = 206f,
                            Carbohydrate = 0f,
                            ConsumeFoodName = "Salmon",
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9535),
                            Fat = 13f,
                            GramCompensation = 100f,
                            MealID = 1,
                            Protein = 22f,
                            Status = false,
                            Value = 1
                        },
                        new
                        {
                            ConsumeFoodID = 11,
                            AppUserID = 8,
                            Calories = 206f,
                            Carbohydrate = 0f,
                            ConsumeFoodName = "Salmon",
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9536),
                            Fat = 13f,
                            GramCompensation = 100f,
                            MealID = 1,
                            Protein = 22f,
                            Status = false,
                            Value = 1
                        },
                        new
                        {
                            ConsumeFoodID = 12,
                            AppUserID = 8,
                            Calories = 206f,
                            Carbohydrate = 0f,
                            ConsumeFoodName = "Salmon",
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9537),
                            Fat = 13f,
                            GramCompensation = 100f,
                            MealID = 1,
                            Protein = 22f,
                            Status = false,
                            Value = 1
                        },
                        new
                        {
                            ConsumeFoodID = 13,
                            AppUserID = 8,
                            Calories = 206f,
                            Carbohydrate = 0f,
                            ConsumeFoodName = "Salmon",
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9538),
                            Fat = 13f,
                            GramCompensation = 100f,
                            MealID = 1,
                            Protein = 22f,
                            Status = false,
                            Value = 1
                        },
                        new
                        {
                            ConsumeFoodID = 14,
                            AppUserID = 8,
                            Calories = 131f,
                            Carbohydrate = 25f,
                            ConsumeFoodName = "Pasta",
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9539),
                            Fat = 1.5f,
                            GramCompensation = 100f,
                            MealID = 1,
                            Protein = 5f,
                            Status = false,
                            Value = 1
                        });
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.Food", b =>
                {
                    b.Property<int>("FoodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodID"), 1L, 1);

                    b.Property<float>("Calories")
                        .HasColumnType("real");

                    b.Property<float>("Carbohydrate")
                        .HasColumnType("real");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("Fat")
                        .HasColumnType("real");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("GramCompensation")
                        .HasColumnType("real");

                    b.Property<int?>("MacroFoodReportReportID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate2")
                        .HasColumnType("datetime2");

                    b.Property<float>("Protein")
                        .HasColumnType("real");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<float>("TotalCalories")
                        .HasColumnType("real");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("FoodID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("MacroFoodReportReportID");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            FoodID = 1,
                            Calories = 2.08f,
                            Carbohydrate = 0f,
                            CategoryID = 1,
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9467),
                            Fat = 0.13f,
                            FoodName = "Somon",
                            GramCompensation = 100f,
                            Protein = 0.19f,
                            Status = false,
                            TotalCalories = 2.08f,
                            Value = 1
                        },
                        new
                        {
                            FoodID = 2,
                            Calories = 0.73f,
                            Carbohydrate = 0.01f,
                            CategoryID = 1,
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9470),
                            Fat = 0.08f,
                            FoodName = "Ahtapot",
                            GramCompensation = 100f,
                            Protein = 0.15f,
                            Status = false,
                            TotalCalories = 0.73f,
                            Value = 1
                        },
                        new
                        {
                            FoodID = 3,
                            Calories = 1.01f,
                            Carbohydrate = 0f,
                            CategoryID = 1,
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9472),
                            Fat = 0.02f,
                            FoodName = "Alabalık",
                            GramCompensation = 100f,
                            Protein = 0.19f,
                            Status = false,
                            TotalCalories = 1.01f,
                            Value = 1
                        },
                        new
                        {
                            FoodID = 4,
                            Calories = 1.2f,
                            Carbohydrate = 0f,
                            CategoryID = 1,
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9473),
                            Fat = 0.06f,
                            FoodName = "Barbun",
                            GramCompensation = 100f,
                            Protein = 0.16f,
                            Status = false,
                            TotalCalories = 1.2f,
                            Value = 1
                        },
                        new
                        {
                            FoodID = 5,
                            Calories = 1.2f,
                            Carbohydrate = 0f,
                            CategoryID = 1,
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9474),
                            Fat = 0.06f,
                            FoodName = "Çipura",
                            GramCompensation = 100f,
                            Protein = 0.16f,
                            Status = false,
                            TotalCalories = 1.2f,
                            Value = 1
                        },
                        new
                        {
                            FoodID = 6,
                            Calories = 0.79f,
                            Carbohydrate = 0f,
                            CategoryID = 1,
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9475),
                            Fat = 0f,
                            FoodName = "Dil Balığı",
                            GramCompensation = 100f,
                            Protein = 0.19f,
                            Status = false,
                            TotalCalories = 0.79f,
                            Value = 1
                        },
                        new
                        {
                            FoodID = 7,
                            Calories = 2f,
                            Carbohydrate = 0.05f,
                            CategoryID = 1,
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9476),
                            Fat = 0.1f,
                            FoodName = "Izgara Hamsi",
                            GramCompensation = 100f,
                            Protein = 0.19f,
                            Status = false,
                            TotalCalories = 2f,
                            Value = 1
                        },
                        new
                        {
                            FoodID = 8,
                            Calories = 1.15f,
                            Carbohydrate = 0f,
                            CategoryID = 1,
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9477),
                            Fat = 0.05f,
                            FoodName = "Kızartma Hamsi",
                            GramCompensation = 100f,
                            Protein = 0.17f,
                            Status = false,
                            TotalCalories = 1.15f,
                            Value = 1
                        },
                        new
                        {
                            FoodID = 9,
                            Calories = 2.62f,
                            Carbohydrate = 0.03f,
                            CategoryID = 1,
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9478),
                            Fat = 0.15f,
                            FoodName = "Havyar",
                            GramCompensation = 100f,
                            Protein = 0.26f,
                            Status = false,
                            TotalCalories = 2.62f,
                            Value = 1
                        },
                        new
                        {
                            FoodID = 10,
                            Calories = 0.91f,
                            Carbohydrate = 0f,
                            CategoryID = 1,
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9479),
                            Fat = 0.02f,
                            FoodName = "Istakoz",
                            GramCompensation = 100f,
                            Protein = 0.17f,
                            Status = false,
                            TotalCalories = 0.91f,
                            Value = 1
                        });
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.MacroFoodReport", b =>
                {
                    b.Property<int>("ReportID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReportID"), 1L, 1);

                    b.Property<int>("AppUserID")
                        .HasColumnType("int");

                    b.Property<int>("CaloriesValue")
                        .HasColumnType("int");

                    b.Property<int>("CarbohydrateValue")
                        .HasColumnType("int");

                    b.Property<int>("FatValue")
                        .HasColumnType("int");

                    b.Property<DateTime>("IssuedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProteinValue")
                        .HasColumnType("int");

                    b.HasKey("ReportID");

                    b.HasIndex("AppUserID");

                    b.ToTable("MacroFoodReports");
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.Meal", b =>
                {
                    b.Property<int>("MealID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MealID"), 1L, 1);

                    b.Property<int?>("AppUserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MealName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate2")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("MealID");

                    b.HasIndex("AppUserID");

                    b.ToTable("Meals");

                    b.HasData(
                        new
                        {
                            MealID = 1,
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9493),
                            MealName = "Sabah",
                            Status = false,
                            Value = 1
                        },
                        new
                        {
                            MealID = 2,
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9500),
                            MealName = "Öğle",
                            Status = false,
                            Value = 1
                        },
                        new
                        {
                            MealID = 3,
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9505),
                            MealName = "Akşam",
                            Status = false,
                            Value = 1
                        },
                        new
                        {
                            MealID = 4,
                            CreatedDate = new DateTime(2023, 9, 21, 0, 45, 18, 780, DateTimeKind.Local).AddTicks(9509),
                            MealName = "Snack",
                            Status = false,
                            Value = 1
                        });
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.Water", b =>
                {
                    b.Property<int>("WaterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WaterID"), 1L, 1);

                    b.Property<int>("AppUserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ConsumedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate2")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.Property<float>("WaterQuantity")
                        .HasColumnType("real");

                    b.HasKey("WaterID");

                    b.HasIndex("AppUserID");

                    b.ToTable("Waters");
                });

            modelBuilder.Entity("ConsumeFoodFood", b =>
                {
                    b.HasOne("KaloriTakipProgramı.Entity.Entities.ConsumeFood", null)
                        .WithMany()
                        .HasForeignKey("ConsumeFoodsConsumeFoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KaloriTakipProgramı.Entity.Entities.Food", null)
                        .WithMany()
                        .HasForeignKey("FoodsFoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.AppUser", b =>
                {
                    b.HasOne("KaloriTakipProgramı.Entity.Entities.AppRole", "AppRole")
                        .WithMany("AppUsers")
                        .HasForeignKey("RoleID");

                    b.Navigation("AppRole");
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.ConsumeFood", b =>
                {
                    b.HasOne("KaloriTakipProgramı.Entity.Entities.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KaloriTakipProgramı.Entity.Entities.Meal", "Meal")
                        .WithMany("ConsumeFoods")
                        .HasForeignKey("MealID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.Food", b =>
                {
                    b.HasOne("KaloriTakipProgramı.Entity.Entities.Category", "Category")
                        .WithMany("Foods")
                        .HasForeignKey("CategoryID");

                    b.HasOne("KaloriTakipProgramı.Entity.Entities.MacroFoodReport", null)
                        .WithMany("Foods")
                        .HasForeignKey("MacroFoodReportReportID");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.MacroFoodReport", b =>
                {
                    b.HasOne("KaloriTakipProgramı.Entity.Entities.AppUser", "AppUser")
                        .WithMany("MacroFoodReports")
                        .HasForeignKey("AppUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.Meal", b =>
                {
                    b.HasOne("KaloriTakipProgramı.Entity.Entities.AppUser", null)
                        .WithMany("Meals")
                        .HasForeignKey("AppUserID");
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.Water", b =>
                {
                    b.HasOne("KaloriTakipProgramı.Entity.Entities.AppUser", "AppUser")
                        .WithMany("Waters")
                        .HasForeignKey("AppUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.AppRole", b =>
                {
                    b.Navigation("AppUsers");
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.AppUser", b =>
                {
                    b.Navigation("MacroFoodReports");

                    b.Navigation("Meals");

                    b.Navigation("Waters");
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.Category", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.MacroFoodReport", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.Meal", b =>
                {
                    b.Navigation("ConsumeFoods");
                });
#pragma warning restore 612, 618
        }
    }
}
