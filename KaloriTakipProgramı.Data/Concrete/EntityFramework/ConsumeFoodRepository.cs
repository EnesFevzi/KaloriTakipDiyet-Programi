using KaloriTakipProgramı.Data.Repositories;
using KaloriTakipProgramı.Entity.Entities;
using Microsoft.EntityFrameworkCore;
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


		#region Haftalık Ogun İçin
		public List<Meal> HaftalıkBazdaOgunRaporu(DateTime dateTime)
		{
			DateTime startTime = dateTime.AddDays(-7).Date;
			DateTime endTime = dateTime.Date;
			return _context.ConsumeFoods.Include(cf => cf.Meal).Where(x => x.CreatedDate >= startTime && x.CreatedDate <= endTime)
						.GroupBy(cf => cf.Meal.MealName)
						.Select(g => new Meal
						{
							MealName = g.Key,
							Value = g.Sum(cf => cf.Value)
						})
						.OrderByDescending(cf => cf.Value)
						.ToList();
		}
		public List<Meal> HaftalıkBazdaOgunRaporuKullanıcıİle(int ID, DateTime dateTime)
		{
			DateTime startTime = dateTime.AddDays(-7).Date;
			DateTime endTime = dateTime.Date;
			return _context.ConsumeFoods.Include(cf => cf.Meal).Where(x => x.AppUserID == ID && x.CreatedDate >= startTime && x.CreatedDate <= endTime)
						.GroupBy(cf => cf.Meal.MealName)
						.Select(g => new Meal
						{
							MealName = g.Key,
							Value = g.Sum(cf => cf.Value)
						})
						.OrderByDescending(cf => cf.Value)
						.ToList();
		}
		#endregion
		#region Aylık Ogunler İçin
		public List<Meal> AylıkBazdaOgunRaporu(DateTime dateTime)
		{
			DateTime endTime = dateTime.Date;
			return _context.ConsumeFoods.Include(cf => cf.Meal).Where(x => x.CreatedDate.Month == endTime.Month)
						.GroupBy(cf => cf.Meal.MealName)
						.Select(g => new Meal
						{
							MealName = g.Key,
							Value = g.Sum(cf => cf.Value)
						})
						.OrderByDescending(cf => cf.Value)
						.ToList();
		}
		public List<Meal> AylıkBazdaOgunRaporuKullanıcıİle(int ID, DateTime dateTime)
		{
			DateTime endTime = dateTime.Date;
			return _context.ConsumeFoods.Include(cf => cf.Meal).Where(x => x.AppUserID == ID && x.CreatedDate.Month == endTime.Month)
						.GroupBy(cf => cf.Meal.MealName)
						.Select(g => new Meal
						{
							MealName = g.Key,
							Value = g.Sum(cf => cf.Value)
						})
						.OrderByDescending(cf => cf.Value)
						.ToList();
		}
		#endregion

		#region Haftalık Kategori İçin
		public List<Category> HaftalıkBazdaKategoriRaporuİle(DateTime dateTime)
		{
			DateTime startTime = dateTime.AddDays(-7).Date;
			DateTime endTime = dateTime.Date;
			return _context.ConsumeFoods.Where(x => x.CreatedDate >= startTime && x.CreatedDate <= endTime)
						.SelectMany(x => x.Foods)
						.GroupBy(cf => cf.Category.CategoryName)
						.Select(g => new Category
						{
							CategoryName = g.Key,
							Value = g.Sum(cf => cf.Value)
						})
						.OrderByDescending(cf => cf.Value)
						.ToList();
		}
		public List<Category> HaftalıkBazdaKategoriRaporuKullanıcıİle(int id, DateTime dateTime)
		{
			DateTime startTime = dateTime.AddDays(-7).Date;
			DateTime endTime = dateTime.Date;
			return _context.ConsumeFoods.Where(x => x.AppUserID == id && x.CreatedDate >= startTime && x.CreatedDate <= endTime)
						.SelectMany(x => x.Foods)
						.GroupBy(cf => cf.Category.CategoryName)
						.Select(g => new Category
						{
							CategoryName = g.Key,
							Value = g.Sum(cf => cf.Value)
						})
						.OrderByDescending(cf => cf.Value)
						.ToList();
		}
		#endregion

		#region Aylık Kategori
		public List<Category> AylıkBazdaKategoriRaporu(DateTime dateTime)
		{
			DateTime endTime = dateTime.Date;
			return _context.ConsumeFoods.Where(x => x.CreatedDate.Month == endTime.Month)
						.SelectMany(x => x.Foods)
						.GroupBy(cf => cf.Category.CategoryName)
						.Select(g => new Category
						{
							CategoryName = g.Key,
							Value = g.Sum(cf => cf.Value)
						})
						.OrderByDescending(cf => cf.Value)
						.ToList();
		}
		public List<Category> AylıkBazdaKategoriRaporuKullanıcıİle(int id, DateTime dateTime)
		{
			DateTime endTime = dateTime.Date;
			return _context.ConsumeFoods.Where(x => x.AppUserID == id && x.CreatedDate.Month == endTime.Month)
						.SelectMany(x => x.Foods)
						.GroupBy(cf => cf.Category.CategoryName)
						.Select(g => new Category
						{
							CategoryName = g.Key,
							Value = g.Sum(cf => cf.Value)
						})
						.OrderByDescending(cf => cf.Value)
						.ToList();
		}
		#endregion



	}
}
