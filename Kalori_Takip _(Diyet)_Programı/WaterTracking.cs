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
	public partial class WaterTracking : Form
	{
		public WaterTracking()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{

		}

		private void btnGeriDon_Click(object sender, EventArgs e)
		{
			UserHomePage userHomePage = new UserHomePage();
			this.Hide();
			userHomePage.ShowDialog();
		}
	}
}
