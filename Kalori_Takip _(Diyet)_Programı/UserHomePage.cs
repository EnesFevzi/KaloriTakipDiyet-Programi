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

		private void UserHomePage_Load(object sender, EventArgs e)
		{
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
			lblBoy.Text = _user.Height.ToString();
			lblKilo.Text = _user.Weight.ToString();
			lblVki.Text = _user.VKI.ToString();
			lblBazalMetabolizma.Text = _user.BMH.ToString();
			lblYagOrani.Text = _user.VYO.ToString();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
