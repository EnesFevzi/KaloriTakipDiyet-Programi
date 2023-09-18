using KaloriTakipProgramı.Entity.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Entity.Entities
{
	public class AppUser : BaseEntity
	{
		[Key]
		public int AppUserID { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }
		public string Gender { get; set; }
		public int Age { get; set; }
		public int Height { get; set; }
		public int Weight { get; set; }

		public float VKI { get; set; }
		public float VYO { get; set; }
		public float BMH { get; set; }


        //Navigation Property

        public virtual int RoleID { get; set; }
        public AppRole AppRole  { get; set; }

		public virtual ICollection<MealOfDay> MealOfDays { get; set; }


		public virtual int WaterID { get; set; }
		public Water Water { get; set; }


		/// <summary>
		/// Bir kişinin birden fazla makro besin raporu olabilir.
		/// </summary>
		public virtual ICollection<MacroFoodReport> MacroFoodReports { get; set; }
	}
}
