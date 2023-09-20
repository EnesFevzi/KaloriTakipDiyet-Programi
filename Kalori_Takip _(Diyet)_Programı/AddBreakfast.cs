using KaloriTakipProgramı.Business.Concrete;
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
	public partial class AddBreakfast : Form
	{
		private readonly ConsumeFoodService _consumeFoodService;
		public AddBreakfast()
		{
			InitializeComponent();
			_consumeFoodService = new ConsumeFoodService();
		}
		DateTime startDate = new DateTime(2023, 9, 21);
		DateTime endDate = new DateTime(2023, 9, 17);
		private void AddBreakfast_Load(object sender, EventArgs e)
		{
			var consume = _consumeFoodService.GetMostConsumedFoodsByDate(endDate, startDate);
			KisileriDoldur(consume);
		}
		private void KisileriDoldur(List<ConsumeFood> foods)
		{
			lstEklenenUrunler.Items.Clear();

			foreach (ConsumeFood food in foods)
			{

				ListViewItem item = new ListViewItem(food.ConsumeFoodID.ToString());
				item.SubItems.Add(food.ConsumeFoodName);
				item.Tag = food;
				lstEklenenUrunler.Items.Add(item);

			}
		}

		private void grpKahvaltiEkle_Enter(object sender, EventArgs e)
		{

		}
	}
}
