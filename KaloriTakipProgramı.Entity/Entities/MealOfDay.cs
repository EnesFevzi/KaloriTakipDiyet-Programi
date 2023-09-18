using KaloriTakipProgramı.Entity.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Entity.Entities
{
	public class MealOfDay:BaseEntity
	{
		public int MealOfDayID { get; set; }

		//Navigation Property
		public int MealID { get; set; }
		public Meal Meal { get; set; }

		public ICollection<Food> Foods { get; set; }

		public int AppUserID { get; set; }
		public AppUser AppUser { get; set; }


	} 
}
