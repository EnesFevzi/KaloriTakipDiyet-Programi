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
	public class ConsumeFoodService : IConsumeFoodService
	{
		private readonly ConsumeFoodRepository _consumeFoodRepository;
        public ConsumeFoodService()
        {
            _consumeFoodRepository = new ConsumeFoodRepository();
        }
        public void TAdd(ConsumeFood t)
		{
			_consumeFoodRepository.Add(t);
		}

		public void TDelete(ConsumeFood t)
		{
			_consumeFoodRepository.Delete(t);
		}

		public List<ConsumeFood> TGetAll()
		{
			return _consumeFoodRepository.GetAll();
		}

		public ConsumeFood TGetByFilter(Expression<Func<ConsumeFood, bool>> filter)
		{
			return _consumeFoodRepository.GetByFilter(filter);
		}

		public List<ConsumeFood> TGetByFilterList(Expression<Func<ConsumeFood, bool>> filter)
		{
			return _consumeFoodRepository.GetByFilterList(filter);
		}

		public ConsumeFood TGetByID(int id)
		{
			return _consumeFoodRepository.GetByID(id);
		}

		public void TUpdate(ConsumeFood t)
		{
			_consumeFoodRepository.Update(t);
		}
		//2 tarih arasında yenen en çok yiyecekler
		public List<ConsumeFood> GetMostConsumedFoodsByDate(DateTime startDate, DateTime endDate)
		{
			return _consumeFoodRepository.GetByFilterList(cf => cf.CreatedDate >= startDate && cf.CreatedDate <= endDate)
						.GroupBy(cf => cf.ConsumeFoodName)
						.Select(g => new ConsumeFood
						{
							ConsumeFoodName = g.Key,
							Value = g.Sum(cf => cf.Value)
						})
						.OrderByDescending(cf => cf.Value)
						.ToList();
		}
		//2 tarih arasında kulalncıya göre yenen yiyecekler
		public List<ConsumeFood> GetMostConsumedFoodsByUserAndDate(int UserID,DateTime startDate, DateTime endDate)
		{
			return _consumeFoodRepository.GetByFilterList(x=>x.AppUserID==UserID && x.CreatedDate >= startDate && x.CreatedDate <= endDate)
						.GroupBy(cf => cf.ConsumeFoodName)
						.Select(g => new ConsumeFood
						{
							ConsumeFoodName = g.Key,
							GramCompensation = g.Sum(cf => cf.GramCompensation)
						})
						.OrderByDescending(cf => cf.GramCompensation)
						.ToList();
		}
		//2 tarih arasında yenen en çok yiyeceğin kategorileri
		//public List<ConsumeFood> GetMostConsumedFoodsByCategoryAndDate(DateTime startDate, DateTime endDate)
		//{
		//	return _consumeFoodRepository.GetByFilterList(x => x.CreatedDate >= startDate && x.CreatedDate <= endDate)
		//				.SelectMany(x => x.Foods)
		//				.GroupBy(cf => cf.Category.CategoryName)
		//				.Select(g => new ConsumeFood
		//				{
		//					CategoryName = g.Key,
		//					Value = g.Sum(cf => cf.Value)
		//				})
		//				.OrderByDescending(cf => cf.Value)
		//				.ToList();
		//}
	}
}
