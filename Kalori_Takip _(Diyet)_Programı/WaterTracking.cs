using KaloriTakipProgramı.Business.Concrete;
using KaloriTakipProgramı.Business.Formules;
using KaloriTakipProgramı.Entity.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalori_Takip___Diyet__Programı
{
	public partial class WaterTracking : Form
	{
		private AppUser _user;
		private Water _water;
		private readonly WaterService _waterService;
		private readonly AppUserService _userService;


		public WaterTracking(AppUser user)
		{
			InitializeComponent();
			_user = user;
			_waterService = new WaterService();
			_water = new Water();
			_userService = new AppUserService();

		}

		private void btnGeriDon_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		double kilo;
		private void WaterTracking_Load(object sender, EventArgs e)
		{
			kilo = (double)_user.Weight;

			lblKilo.Text = kilo.ToString();
			double sulitresi = Formul.HesaplaGunlukSuIhtiyaci(kilo);
			lblİcmenizGerekenSuMiktari.Text = $"Bugün İçmeniz Gereken Su Miktarı {(sulitresi / 1000)} Litredir.";

			#region Daha Sonra Bakılacak
			//flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
			//for (int i = 0; i < suMiktari.WaterQuantity; i++)
			//{

			//	PictureBox bardakPictureBox = new PictureBox();
			//	bardakPictureBox.Image = pbxSuBardagi.Image;
			//	flowLayoutPanel1.Controls.Add(bardakPictureBox);
			//}
			#endregion

		}


		Water guncellenecekWater;
		private void btnSuEkle_Click(object sender, EventArgs e)
		{
			if (!_user.LastWaterAdditionDate.HasValue || _user.LastWaterAdditionDate.Value.Date < DateTime.Now.Date)
			{
				_water = new Water()
				{
					WaterQuantity = (float)nmrSuMiktari.Value,
					ConsumedDate = DateTime.Now,
					AppUserID = _user.AppUserID,
					ModifiedDate2 = DateTime.Now,
				};
				_waterService.TAdd(_water);
				_user.LastWaterAdditionDate = DateTime.Now;
				_userService.TUpdate(_user);
			}
			else
			{
				guncellenecekWater = _waterService.GetWaterByUserIdAndDate(_user.AppUserID, DateTime.Now.Date);
				guncellenecekWater.WaterQuantity += (float)nmrSuMiktari.Value;
				guncellenecekWater.ModifiedDate2 = DateTime.Now;
				_user.LastWaterAdditionDate = DateTime.Now;
				_userService.TUpdate(_user);
				_waterService.TUpdate(guncellenecekWater);
			}



		}

		Water suMiktari;
		private void dtSuTarih_ValueChanged(object sender, EventArgs e)
		{
			suMiktari = _waterService.GetWaterByUserIdAndDate(_user.AppUserID, dtSuTarih.Value.Date);
			lblGecmisİcilmisSu.Text = $"İçtiğiniz su {suMiktari.WaterQuantity} bardaktır";
		}
	}
}
