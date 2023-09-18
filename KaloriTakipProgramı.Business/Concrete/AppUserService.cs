using KaloriTakipProgramı.Business.Abstract;
using KaloriTakipProgramı.Data.Concrete.EF;
using KaloriTakipProgramı.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Business.Concrete
{
	public class AppUserService : IAppUserService
	{
		private readonly AppUserRepository _repository;

        public AppUserService()
        {
            _repository = new AppUserRepository();
        }
        public void TAdd(AppUser appUser)
		{
			_repository.Add(appUser);
		}

		public void TDelete(AppUser t)
		{
			_repository.Delete(t);
		}

		public AppUser TGetByFilter(Expression<Func<AppUser, bool>> filter)
		{
			return _repository.GetByFilter(filter);
		}

		public List<AppUser> TGetByFilterList(Expression<Func<AppUser, bool>> filter)
		{
			return _repository.GetByFilterList(filter);
		}

		public AppUser TGetByID(int id)
		{
			return _repository.GetByID(id);
		}

		public List<AppUser> TGetAll()
		{
			return _repository.GetAll();
		}

		public void TUpdate(AppUser t)
		{
			_repository.Update(t);
		}
	}
}
