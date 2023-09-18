using KaloriTakipProgramı.Business.Concrete;
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
	public partial class Login : Form
	{
		private readonly AppUserService _service;
		public Login()
		{
			_service = new AppUserService();
			InitializeComponent();
		}

		private void Login_Load(object sender, EventArgs e)
		{

		}

		private void btnGeriDon_Click(object sender, EventArgs e)
		{
			OpeningPage openingPage = new OpeningPage();
			this.Hide();
			openingPage.ShowDialog();

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
