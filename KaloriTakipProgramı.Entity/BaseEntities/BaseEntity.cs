﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Entity.BaseEntities
{
	public class BaseEntity
	{
		public DateTime CreatedDate { get; set; }
		public DateTime? ModifiedDate { get; set; }
		public DateTime? ModifiedDate2 { get; set; }
		public DateTime? DeletedDate { get; set; }
		public bool Status { get; set; }
	}
}
