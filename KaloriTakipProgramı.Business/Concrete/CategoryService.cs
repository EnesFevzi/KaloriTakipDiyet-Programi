using KaloriTakipProgramı.Business.Abstract;
using KaloriTakipProgramı.Data.Concrete.EntityFramework;
using KaloriTakipProgramı.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Business.Concrete
{
    public class CategoryService : ICategoryService
	{
		private readonly CategoryRepository _categoryRepository;

        public CategoryService()
        {
            _categoryRepository = new CategoryRepository();
        }
        public void TAdd(Category t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Category t)
		{
			throw new NotImplementedException();
		}

		public List<Category> TGetAll()
		{
			throw new NotImplementedException();
		}

		public Category TGetByFilter(Expression<Func<Category, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public List<Category> TGetByFilterList(Expression<Func<Category, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public Category TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Category t)
		{
			throw new NotImplementedException();
		}
		public List<Category> GetMostConsumedFoodsByCategoryWeek(DateTime dateTime)
		{
			DateTime startTime = dateTime.AddDays(-7).Date;
			DateTime endTime = dateTime.Date;

			return _categoryRepository.GetByFilterList(x => x.CreatedDate >= startTime && x.CreatedDate <= endTime)
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
		//2 tarih arasında kulalncıya göre yenen yiyecekler
		public List<Category> GetMostConsumedFoodsByUserAndCategoryWeek(int categoryID, DateTime dateTime)
		{
			DateTime startTime = dateTime.AddDays(-7).Date;
			DateTime endTime = dateTime.Date;
			return _categoryRepository.GetByFilterList(x => x. CategoryID== categoryID && x.CreatedDate >= startTime && x.CreatedDate <= endTime)
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
		//public List<ConsumeFood> GetMostConsumedFoodsByUserAndDateMonth(int UserID, DateTime dateTime)
		//{
		//	DateTime startTime = dateTime.AddDays(-7).Date;
		//	DateTime endTime = dateTime.Date;
		//	return _consumeFoodRepository.GetByFilterList(x => x.AppUserID == UserID && x.CreatedDate >= startTime && x.CreatedDate <= endTime)
		//				.GroupBy(cf => cf.ConsumeFoodName)
		//				.Select(g => new ConsumeFood
		//				{
		//					ConsumeFoodName = g.Key,
		//					Value = g.Sum(cf => cf.Value)
		//				})
		//				.OrderByDescending(cf => cf.Value)
		//				.ToList();
		//}
		//public List<ConsumeFood> GetMostConsumedFoodsByUserAndDateMonth(DateTime dateTime)
		//{
		//	DateTime time = dateTime.Date;
		//	return _consumeFoodRepository.GetByFilterList(x => x.CreatedDate.Month == time.Date.Month)
		//				.GroupBy(cf => cf.ConsumeFoodName)
		//				.Select(g => new ConsumeFood
		//				{
		//					ConsumeFoodName = g.Key,
		//					Value = g.Sum(cf => cf.Value)
		//				})
		//				.OrderByDescending(cf => cf.Value)
		//				.ToList();
		//}
	}
}
