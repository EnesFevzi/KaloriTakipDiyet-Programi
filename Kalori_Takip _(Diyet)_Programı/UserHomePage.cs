using KaloriTakipProgramı.Business.Formules;
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
	public partial class UserHomePage : Form
	{
		private readonly AppUser _user;

		public UserHomePage(AppUser user)
		{
			InitializeComponent();
			_user = user;
		}

		private void btnKaloriTakibi_Click(object sender, EventArgs e)
		{
			MealTable mealTable = new MealTable();
			this.Hide();
			mealTable.ShowDialog();
		}
		string cinsiyet;
		double kilo;
		double boy;
		int yas;
		double activityValue;
		private void UserHomePage_Load(object sender, EventArgs e)
		{
			cinsiyet = _user.Gender.ToString();
			kilo = (double)_user.Weight;
			boy = (double)_user.Height;
			yas = (int)_user.Age;
			activityValue = (double)_user.ActivityValue;


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
			lblKisiAdi.Text = $"{_user.Name} {_user.Surname}";
			lblYas.Text = _user.Age.ToString();
			lblBoy.Text = boy.ToString();
			lblKilo.Text = kilo.ToString();
			lblVki.Text = _user.VKI.ToString();
			lblBazalMetabolizma.Text = _user.BMH.ToString();
			lblYagOrani.Text = _user.VYO.ToString();
			lblAlinmasiGerekenKalori.Text = Formul.HesaplaGunlukKaloriIhtiyaci(cinsiyet, kilo, boy, yas, activityValue).ToString();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void btnSuTakibi_Click(object sender, EventArgs e)
		{
			WaterTracking waterTracking = new WaterTracking(_user);
			this.Hide();
			waterTracking.ShowDialog();
		}
	}
}
