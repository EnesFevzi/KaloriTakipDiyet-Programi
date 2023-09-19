﻿// <auto-generated />
using System;
using KaloriTakipProgramı.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230918221115_initial10")]
    partial class initial10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FoodMealOfDay", b =>
                {
                    b.Property<int>("FoodsFoodID")
                        .HasColumnType("int");

                    b.Property<int>("MealOfDaysMealOfDayID")
                        .HasColumnType("int");

                    b.HasKey("FoodsFoodID", "MealOfDaysMealOfDayID");

                    b.HasIndex("MealOfDaysMealOfDayID");

                    b.ToTable("FoodMealOfDay");
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

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<double?>("BMH")
                        .HasColumnType("float");

                    b.Property<double?>("BasinCircle")
                        .HasColumnType("float");

                    b.Property<double?>("ChestCircle")
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

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<double?>("WaistCircle")
                        .HasColumnType("float");

                    b.Property<int?>("WaterID")
                        .HasColumnType("int");

                    b.Property<double?>("Weight")
                        .HasColumnType("float");

                    b.HasKey("AppUserID");

                    b.HasIndex("RoleID");

                    b.HasIndex("WaterID");

                    b.ToTable("AppUsers");
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

                    b.Property<float>("Protein")
                        .HasColumnType("real");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<float>("TotalCalories")
                        .HasColumnType("real");

                    b.HasKey("FoodID");

                    b.HasIndex("MacroFoodReportReportID");

                    b.ToTable("Foods");
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

                    b.ToTable("MacroFoodReport");
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.Meal", b =>
                {
                    b.Property<int>("MealID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MealID"), 1L, 1);

                    b.Property<string>("MealName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MealID");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.MealOfDay", b =>
                {
                    b.Property<int>("MealOfDayID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MealOfDayID"), 1L, 1);

                    b.Property<int>("AppUserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MealID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("MealOfDayID");

                    b.HasIndex("AppUserID");

                    b.HasIndex("MealID");

                    b.ToTable("MealOfDays");
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.Water", b =>
                {
                    b.Property<int>("WaterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WaterID"), 1L, 1);

                    b.Property<DateTime>("ConsumedDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("WaterQuantity")
                        .HasColumnType("real");

                    b.HasKey("WaterID");

                    b.ToTable("Waters");
                });

            modelBuilder.Entity("FoodMealOfDay", b =>
                {
                    b.HasOne("KaloriTakipProgramı.Entity.Entities.Food", null)
                        .WithMany()
                        .HasForeignKey("FoodsFoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KaloriTakipProgramı.Entity.Entities.MealOfDay", null)
                        .WithMany()
                        .HasForeignKey("MealOfDaysMealOfDayID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.AppUser", b =>
                {
                    b.HasOne("KaloriTakipProgramı.Entity.Entities.AppRole", "AppRole")
                        .WithMany("AppUsers")
                        .HasForeignKey("RoleID");

                    b.HasOne("KaloriTakipProgramı.Entity.Entities.Water", "Water")
                        .WithMany("AppUsers")
                        .HasForeignKey("WaterID");

                    b.Navigation("AppRole");

                    b.Navigation("Water");
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.Food", b =>
                {
                    b.HasOne("KaloriTakipProgramı.Entity.Entities.MacroFoodReport", null)
                        .WithMany("Foods")
                        .HasForeignKey("MacroFoodReportReportID");
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

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.MealOfDay", b =>
                {
                    b.HasOne("KaloriTakipProgramı.Entity.Entities.AppUser", "AppUser")
                        .WithMany("MealOfDays")
                        .HasForeignKey("AppUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KaloriTakipProgramı.Entity.Entities.Meal", "Meal")
                        .WithMany("MealOfDays")
                        .HasForeignKey("MealID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.AppRole", b =>
                {
                    b.Navigation("AppUsers");
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.AppUser", b =>
                {
                    b.Navigation("MacroFoodReports");

                    b.Navigation("MealOfDays");
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.MacroFoodReport", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.Meal", b =>
                {
                    b.Navigation("MealOfDays");
                });

            modelBuilder.Entity("KaloriTakipProgramı.Entity.Entities.Water", b =>
                {
                    b.Navigation("AppUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
