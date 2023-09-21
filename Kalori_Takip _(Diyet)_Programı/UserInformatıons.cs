using Kalori_Takip___Diyet__Programı.Extensions;
using Kalori_Takip___Diyet__Programı.Properties;
using KaloriTakipProgramı.Business.Formules;
using KaloriTakipProgramı.Entity.Entities;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Kalori_Takip___Diyet__Programı
{
	public partial class UserInformatıons : Form
	{
		private AppUser _user;
		public UserInformatıons(AppUser user)
		{
			InitializeComponent();
			_user = user;
		}
		string cinsiyet;
		float kilo;
		float boy;
		int yas;
		float activityValue;
		private void UserInformatıons_Load(object sender, EventArgs e)
		{
			kilo = (float)_user.Weight;
			boy = (float)_user.Height;
			activityValue = (float)_user.ActivityValue;


			lblAd.Text = $"{_user.Name} {_user.Surname}";
			cinsiyet = _user.Gender;
			lblYas.Text = _user.Age.ToString();
			lblBoy.Text = boy.ToString();
			lblKilo.Text = kilo.ToString();
			lblVki.Text = _user.VKI.ToString();
			lblBazalMetabolizma.Text = _user.BMH.ToString();
			lblYagOrani.Text = _user.VYO.ToString();
			lblAlinmasiGerekenKalori.Text = Formul.HesaplaGunlukKaloriIhtiyaci(cinsiyet, kilo, boy, yas, activityValue).ToString("0.00");

			Image userImage = LoadImages.LoadUserImage(_user.ImagePath);
			if (userImage != null)
			{
				pbxUserImage.Image = userImage;
			}
		}

		private void btnAyarlar_Click(object sender, EventArgs e)
		{
			UserSettings userSettings = new UserSettings(_user);
			this.Hide();
			userSettings.ShowDialog();
			this.Show();
		}

		private void btnGeriDon_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
