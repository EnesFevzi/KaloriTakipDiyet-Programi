using KaloriTakipProgramı.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Data.Extensions
{
	public static class ModelBuilderExtensions
	{
		public static void SeedData(this ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData(
				new Category
				{
					CategoryID = 1,
					CategoryName = "Deniz Ürünleri",
				}
				);





			modelBuilder.Entity<Food>().HasData(
				new Food
				{
					FoodID = 1,
					FoodName = "Somon",
					GramCompensation = 100,
					Calories = 2.08F,
					Carbohydrate = 0,
					Protein = 0.19F,
					Fat = 0.13F,
					TotalCalories = 2.08F,
					CategoryID = 1,
				},
				new Food
				{
					FoodID = 2,
					FoodName = "Ahtapot",
					GramCompensation = 100,
					Calories = 0.73F,
					Carbohydrate = 0.01F,
					Protein = 0.15F,
					Fat = 0.08F,
					CategoryID = 1,
					TotalCalories = 0.73F
				},
				new Food
				{
					FoodID = 3,
					FoodName = "Alabalık",
					GramCompensation = 100,
					Calories = 1.01F,
					Carbohydrate = 0,
					Protein = 0.19F,
					Fat = 0.02F,
					CategoryID = 1,
					TotalCalories = 1.01F
				},
						new Food
						{
							FoodID = 4,
							FoodName = "Barbun",
							GramCompensation = 100,
							Calories = 1.2F,
							Carbohydrate = 0,
							Protein = 0.16F,
							Fat = 0.06F,
							CategoryID = 1,
							TotalCalories = 1.2F
						},
						new Food
						{
							FoodID = 5,
							FoodName = "Çipura",
							GramCompensation = 100,
							Calories = 1.2F,
							Carbohydrate = 0,
							Protein = 0.16F,
							Fat = 0.06F,
							CategoryID = 1,
							TotalCalories = 1.2F
						},
						new Food
						{
							FoodID = 6,
							FoodName = "Dil Balığı",
							GramCompensation = 100,
							Calories = 0.79F,
							Carbohydrate = 0,
							Protein = 0.19F,
							Fat = 0,
							CategoryID = 1,
							TotalCalories = 0.79F
						},
						new Food
						{
							FoodID = 7,
							FoodName = "Izgara Hamsi",
							GramCompensation = 100,
							Calories = 2F,
							Carbohydrate = 0.05F,
							Protein = 0.19F,
							Fat = 0.1F,
							CategoryID = 1,
							TotalCalories = 2F
						},
						new Food
						{
							FoodID = 8,
							FoodName = "Kızartma Hamsi",
							GramCompensation = 100,
							Calories = 1.15F,
							Carbohydrate = 0,
							Protein = 0.17F,
							Fat = 0.05F,
							CategoryID = 1,
							TotalCalories = 1.15F
						},
						new Food
						{
							FoodID = 9,
							FoodName = "Havyar",
							GramCompensation = 100,
							Calories = 2.62F,
							Carbohydrate = 0.03F,
							Protein = 0.26F,
							Fat = 0.15F,
							CategoryID = 1,
							TotalCalories = 2.62F
						},
						new Food
						{
							FoodID = 10,
							FoodName = "Istakoz",
							GramCompensation = 100,
							Calories = 0.91F,
							Carbohydrate = 0,
							Protein = 0.17F,
							Fat = 0.02F,
							CategoryID = 1,
							TotalCalories = 0.91F,
						}

			);


		}
	}
}
