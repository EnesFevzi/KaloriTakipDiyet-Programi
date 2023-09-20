using KaloriTakipProgramı.Data.Extensions;
using KaloriTakipProgramı.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Data.Context
{
	public class AppDbContext : DbContext
	{
		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<Food> Foods { get; set; }
		public DbSet<ConsumeFood> ConsumeFoods { get; set; }
		public DbSet<Meal> Meals { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Water> Waters { get; set; }
		public DbSet<AppRole> AppRoles { get; set; }
		public DbSet<MacroFoodReport> MacroFoodReports { get; set; }



		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=DietDB;integrated security=true");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AppRole>().HasData(
				new AppRole()
				{
					RoleID = 1,
					RoleName = "Admin",
					

				});
			modelBuilder.SeedData();

			modelBuilder.Entity<Meal>().HasData(
				new Meal()
				{
					MealID = 1,
					MealName = "Sabah",
					
				});
			modelBuilder.Entity<Meal>().HasData(
				new Meal()
				{
					MealID = 2,
					MealName = "Öğle",

				});
			modelBuilder.Entity<Meal>().HasData(
				new Meal()
				{
					MealID = 3,
					MealName = "Akşam",

				});
			modelBuilder.Entity<Meal>().HasData(
				new Meal()
				{
					MealID = 4,
					MealName = "Snack",

				});

			modelBuilder.Entity<ConsumeFood>().HasData(
				new ConsumeFood()

				{
					ConsumeFoodID = 1,
					ConsumeFoodName = "Apple",
					GramCompensation = 100,
					Calories = 52,
					Carbohydrate = 14,
					Protein = 0.3F,
					Fat = 0.2F,
					AppUserID = 8,
					MealID = 1,
					Value = 1
				},
				new ConsumeFood()

				{
					ConsumeFoodID = 2,
					ConsumeFoodName = "Apple",
					GramCompensation = 100,
					Calories = 52,
					Carbohydrate = 14,
					Protein = 0.3F,
					Fat = 0.2F,
					AppUserID = 8,
					MealID = 1,
					Value = 1
				},
				new ConsumeFood()

				{
					ConsumeFoodID = 3,
					ConsumeFoodName = "Apple",
					GramCompensation = 100,
					Calories = 52,
					Carbohydrate = 14,
					Protein = 0.3F,
					Fat = 0.2F,
					AppUserID = 8,
					MealID = 1,
					Value = 1
				},
	new ConsumeFood
	{
		ConsumeFoodID = 4,
		ConsumeFoodName = "Chicken Breast",
		GramCompensation = 100,
		Calories = 165,
		Carbohydrate = 0,
		Protein = 31,
		Fat = 3.6F,
		AppUserID = 8,
		MealID = 1,
		Value = 1
	},
	new ConsumeFood
	{
		ConsumeFoodID = 5,
		ConsumeFoodName = "Rice",
		GramCompensation = 100,
		Calories = 130,
		Carbohydrate = 28,
		Protein = 2.7F,
		Fat = 0.3F,
		AppUserID = 8,
		MealID = 1,
		Value = 1
	},
	new ConsumeFood
	{
		ConsumeFoodID = 6,
		ConsumeFoodName = "Salmon",
		GramCompensation = 100,
		Calories = 206,
		Carbohydrate = 0,
		Protein = 22,
		Fat = 13,
		AppUserID = 8,
		MealID = 1,
		Value = 1
	},
	new ConsumeFood
	{
		ConsumeFoodID = 7,
		ConsumeFoodName = "Salmon",
		GramCompensation = 100,
		Calories = 206,
		Carbohydrate = 0,
		Protein = 22,
		Fat = 13,
		AppUserID = 8,
		MealID = 1,
		Value = 1
	},
	new ConsumeFood
	{
		ConsumeFoodID = 8,
		ConsumeFoodName = "Salmon",
		GramCompensation = 100,
		Calories = 206,
		Carbohydrate = 0,
		Protein = 22,
		Fat = 13,
		AppUserID = 8,
		MealID = 1,
		Value = 1
	},
	new ConsumeFood
	{
		ConsumeFoodID = 9,
		ConsumeFoodName = "Salmon",
		GramCompensation = 100,
		Calories = 206,
		Carbohydrate = 0,
		Protein = 22,
		Fat = 13,
		AppUserID = 8,
		MealID = 1,
		Value = 1
	},
	new ConsumeFood
	{
		ConsumeFoodID = 10,
		ConsumeFoodName = "Salmon",
		GramCompensation = 100,
		Calories = 206,
		Carbohydrate = 0,
		Protein = 22,
		Fat = 13,
		AppUserID = 8,
		MealID = 1,
		Value = 1
	},
	new ConsumeFood
	{
		ConsumeFoodID = 11,
		ConsumeFoodName = "Salmon",
		GramCompensation = 100,
		Calories = 206,
		Carbohydrate = 0,
		Protein = 22,
		Fat = 13,
		AppUserID = 8,
		MealID = 1,
		Value = 1
	},
	new ConsumeFood
	{
		ConsumeFoodID = 12,
		ConsumeFoodName = "Salmon",
		GramCompensation = 100,
		Calories = 206,
		Carbohydrate = 0,
		Protein = 22,
		Fat = 13,
		AppUserID = 8,
		MealID = 1,
		Value = 1
	},
	new ConsumeFood
	{
		ConsumeFoodID = 13,
		ConsumeFoodName = "Salmon",
		GramCompensation = 100,
		Calories = 206,
		Carbohydrate = 0,
		Protein = 22,
		Fat = 13,
		AppUserID = 8,
		MealID = 1,
		Value = 1
	},
	new ConsumeFood
	{
		ConsumeFoodID = 14,
		ConsumeFoodName = "Pasta",
		GramCompensation = 100,
		Calories = 131,
		Carbohydrate = 25,
		Protein = 5,
		Fat = 1.5F,
		AppUserID = 8,
		MealID = 1,
		Value = 1
	}) ;

			base.OnModelCreating(modelBuilder);
		}
	}
}
