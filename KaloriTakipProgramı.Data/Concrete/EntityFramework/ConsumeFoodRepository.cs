using KaloriTakipProgramı.Data.Repositories;
using KaloriTakipProgramı.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Data.Concrete.EntityFramework
{
	public class ConsumeFoodRepository:GenericRepository<ConsumeFood>
	{
		public List<ConsumeFood> GetConsumeFoodByValue(DateTime secilenTarih)
		{
			return _context.ConsumeFoods.Where(x => x.CreatedDate.Date == secilenTarih.Date).ToList();
		}
		public List<ConsumeFood> GetConsumeFoodByMealID(string mealName, DateTime tarih)
		{
			return _context.ConsumeFoods.Where(x => x.Meal.MealName == mealName && x.CreatedDate.Date == tarih.Date).ToList();
		}
		public List<ConsumeFood> GetConsumeFood(int id, DateTime tarih)
		{
			return _context.ConsumeFoods.Where(x => x.Meal.MealID == id && x.CreatedDate.Date == tarih.Date).ToList();
		}
		public ConsumeFood GetConsumeFood2(int id, DateTime tarih)
		{
			return _context.ConsumeFoods.OrderBy(x=>x.CreatedDate).LastOrDefault(x => x.Meal.MealID == id && x.CreatedDate.Date == tarih.Date);
		}
	}
}
