﻿using KaloriTakipProgramı.Entity.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Entity.Entities
{
	public class Food : BaseEntity
	{
		public int FoodID { get; set; }
		public string FoodName { get; set; }
		public float GramCompensation { get; set; }
		public float Calories { get; set; }
		public float Carbohydrate { get; set; }
		public float Protein { get; set; }
		public float Fat { get; set; }
		public float TotalCalories { get; set; }


		//Navigation Property


		public ICollection<MealOfDay> MealOfDays { get; set; }
	}
}
