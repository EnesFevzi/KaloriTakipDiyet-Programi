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
		double kilo;
		double boy;
		int yas;
		double activityValue;
		private void UserInformatıons_Load(object sender, EventArgs e)
		{
			kilo = (double)_user.Weight;
			boy = (double)_user.Height;



			lblAd.Text = $"{_user.Name} {_user.Surname}";
			cinsiyet = _user.Gender;
			lblYas.Text = _user.Age.ToString();
			lblBoy.Text = boy.ToString();
			lblKilo.Text = kilo.ToString();
			lblVki.Text = _user.VKI.ToString();
			lblBazalMetabolizma.Text = _user.BMH.ToString();
			lblYagOrani.Text = _user.VYO.ToString();
			lblAlinmasiGerekenKalori.Text = Formul.HesaplaGunlukKaloriIhtiyaci(cinsiyet, kilo, boy, yas, activityValue).ToString();

			string imagePath = Path.Combine(Application.StartupPath, "UserImage", _user.ImagePath);

			if (File.Exists(imagePath))
			{
				using (FileStream stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
				{
					pbxUserImage.Image = Image.FromStream(stream);
				}
			}
			else
			{
				MessageBox.Show("Resim bulunamadı.");
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
			this.Hide();
		}
	}
}
