using KaloriTakipProgramı.Entity.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Entity.Entities
{
	public class AppUser : BaseEntity
	{

        public AppUser()
        {
			MealOfDays = new List<MealOfDay>();
			MacroFoodReports= new List<MacroFoodReport>();

		}
        [Key]
		public int AppUserID { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Username { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }
		public string Gender { get; set; }
		public string? ImagePath { get; set; }
		public int? Age { get; set; }
		public double? Height { get; set; }
		public double? Weight { get; set; }
		public double? BasinCircle { get; set; }
		public double? NeckCircle { get; set; }
		public double? WaistCircle { get; set; }
		public double? ActivityValue { get; set; }
		public DateTime? LastWaterAdditionDate { get; set; }

		public double? VKI { get; set; }
		public double? VYO { get; set; }
		public double? BMH { get; set; }


		//Navigation Property

		[ForeignKey("AppRole")]
        public virtual int? RoleID { get; set; }
        public AppRole AppRole  { get; set; }

		public virtual ICollection<MealOfDay>? MealOfDays { get; set; }

		public virtual ICollection<Water> Waters { get; set; }
		//public Water Water { get; set; }


		/// <summary>
		/// Bir kişinin birden fazla makro besin raporu olabilir.
		/// </summary>
		public virtual ICollection<MacroFoodReport>? MacroFoodReports { get; set; }
	}
}
