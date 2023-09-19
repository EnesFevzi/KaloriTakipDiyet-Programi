using KaloriTakipProgramı.Business.Abstract;
using KaloriTakipProgramı.Data.Concrete.EF;
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
	public class AppRoleService : IAppRoleService
	{
		private readonly AppRoleRepository _repository;
        public AppRoleService()
        {
            _repository = new AppRoleRepository();
        }
        public void TAdd(AppRole t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(AppRole t)
		{
			throw new NotImplementedException();
		}

		public List<AppRole> TGetAll()
		{
			throw new NotImplementedException();
		}

		public AppRole TGetByFilter(Expression<Func<AppRole, bool>> filter)
		{
			return _repository.GetByFilter(filter);
		}

		public List<AppRole> TGetByFilterList(Expression<Func<AppRole, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public AppRole TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(AppRole t)
		{
			throw new NotImplementedException();
		}
		public int TGetRoleIDByName(string roleName)
		{
			return _repository.GetRoleIdByName(roleName);
		}

	}
}
