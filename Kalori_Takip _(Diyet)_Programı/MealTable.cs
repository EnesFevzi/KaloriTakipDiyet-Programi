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
	public partial class MealTable : Form
	{
		public MealTable()
		{
			InitializeComponent();
		}

		private void btnKahvaltiEkle_Click(object sender, EventArgs e)
		{
			AddBreakfast addBreakfast = new AddBreakfast();
			this.Hide();
			addBreakfast.ShowDialog();
			this.Show();
		}

		private void btnOgleYemegi_Click(object sender, EventArgs e)
		{
			AddLunch addLunch = new AddLunch();
			this.Hide();
			addLunch.ShowDialog();
			this.Show();
		}

		private void btnAksamYemegi_Click(object sender, EventArgs e)
		{
			AddDinner addDinner = new AddDinner();
			this.Hide();
			addDinner.ShowDialog();
			this.Show();
		}

		private void btnAperatifEkle_Click(object sender, EventArgs e)
		{
			AddSnack addSnack = new AddSnack();
			this.Show();
			addSnack.ShowDialog();
			this.Show();
		}
	}
}
