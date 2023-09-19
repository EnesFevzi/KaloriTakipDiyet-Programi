﻿using KaloriTakipProgramı.Business.Concrete;
using KaloriTakipProgramı.Entity.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalori_Takip___Diyet__Programı
{
	public partial class IntroduceYourselfActıvıty : Form
	{
		private AppUser _user;
		private readonly AppUserService _service;


		public IntroduceYourselfActıvıty(AppUser user)
		{
			InitializeComponent();
			_user = user;
			_service = new AppUserService();
		}

		private void rdbHareketsiz_CheckedChanged(object sender, EventArgs e)
		{
			_user.ActivityValue = 1.2;
		}

		private void rdbHafifEgzersiz_CheckedChanged(object sender, EventArgs e)
		{
			_user.ActivityValue = 1.375;
		}

		private void rdbOrtaSeviyeEgzersiz_CheckedChanged(object sender, EventArgs e)
		{
			_user.ActivityValue = 1.55;
		}

		private void rdbYogunEgzersiz_CheckedChanged(object sender, EventArgs e)
		{
			_user.ActivityValue = 1.725;
		}

		private void rdbCokYogun_CheckedChanged(object sender, EventArgs e)
		{
			_user.ActivityValue = 1.9;
		}



		private void btnİleriGit_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Aktivite Düzeyinizi Kaydediyoruz! Emin Misin ?", "İ-FEAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dr == DialogResult.Yes)
			{
				_user.ModifiedDate2 = DateTime.Now;
				_service.TUpdate(_user);
				UserHomePage userHomePage = new UserHomePage(_user);
				this.Hide();
				userHomePage.ShowDialog();
			}
			else
			{
				return;
			}
		}
	}
}
