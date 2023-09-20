﻿using KaloriTakipProgramı.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Business.Abstract
{
	internal interface IWaterService : IGenericService<Water>
	{
		Water TGetWaterByUserIdAndDate(int userId, DateTime tarih);
	}
}
