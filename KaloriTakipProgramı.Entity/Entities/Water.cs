using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Entity.Entities
{
	public class Water
	{
        public int WaterID { get; set; }
        public float WaterQuantity { get; set; }
		public DateTime ConsumedDate { get; set; }

		//Navigation Property

		public virtual ICollection<AppUser> AppUsers { get; set; }
	}
}
