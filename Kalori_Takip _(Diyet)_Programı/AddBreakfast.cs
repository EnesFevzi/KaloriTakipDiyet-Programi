using Kalori_Takip___Diyet__Programı.Extensions;
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
		private readonly FoodService _foodService;
		private readonly ConsumeFoodService _consumeFoodService;
		private readonly MealService _mealService;
		private AppUser _user;
		float girilenMiktar = 0;
		public AddBreakfast(AppUser user)
		{
			InitializeComponent();
			_foodService = new FoodService();
			_consumeFoodService = new ConsumeFoodService();
			_mealService = new MealService();
			_user = user;
		}

		private void txtUrunAra_TextChanged(object sender, EventArgs e)
		{
			string arananKelime = txtUrunAra.Text.ToLower();

			AramaUrunlerıDoldur(_foodService.TGetAll(), arananKelime);
		}
		private void AramaUrunlerıDoldur(List<Food> foods, string arananKelime = "")
		{
			lstUrunler.Items.Clear();

			foreach (Food food in foods)
			{
				if (food.FoodName.ToLower().Contains(arananKelime))
				{
					ListViewItem item = new ListViewItem(food.FoodName.ToString());
					item.Tag = food;
					lstUrunler.Items.Add(item);
				}
			}
		}

		private Food secilenUrun;

		private void btnEkle_Click(object sender, EventArgs e)
		{
			bool sonuc = float.TryParse(txtMiktar.Text, out girilenMiktar);
			if (txtMiktar.Text.Trim() == string.Empty || lstUrunler.SelectedItems.Count == 0 || sonuc == false)
			{
				MessageBox.Show("Lütfen eklemek istediğiniz ürünü seçin ve tükettiğiniz miktarı sayısal olarak belirtin");
			}
			else
			{
				secilenUrun = (Food)lstUrunler.SelectedItems[0].Tag;
				secilenUrun = _foodService.CalculateFoodInfo(secilenUrun.FoodID, girilenMiktar);

				ListViewItem item = new ListViewItem(secilenUrun.FoodName);
				item.SubItems.Add(girilenMiktar.ToString("0.00"));
				item.SubItems.Add(secilenUrun.Calories.ToString("0.00"));
				item.SubItems.Add(secilenUrun.Protein.ToString("0.00"));
				item.SubItems.Add(secilenUrun.Fat.ToString("0.00"));
				item.SubItems.Add(secilenUrun.Carbohydrate.ToString("0.00"));
				item.Tag = item;
				lstEklenenUrunler.Items.Add(item);

			}
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			var result = _mealService.TGetByMealIDBreakfast();
			if (lstEklenenUrunler.Items.Count == 0)
			{
				MessageBox.Show("Lütfen kaydetmek istediğiniz ürünü/ürünleri bu listeye ekleyin");
			}
			else
			{
				foreach (ListViewItem item in lstEklenenUrunler.Items)
				{
					var consumeFood = new ConsumeFood()
					{
						ConsumeFoodName = item.SubItems[0].Text,
						GramCompensation = Convert.ToSingle(item.SubItems[1].Text),
						Calories = Convert.ToSingle(item.SubItems[2].Text),
						Carbohydrate = Convert.ToSingle(item.SubItems[3].Text),
						Protein = Convert.ToSingle(item.SubItems[4].Text),
						Fat = Convert.ToSingle(item.SubItems[5].Text),
						CreatedDate = DateTime.Now,
						AppUserID = _user.AppUserID,
						MealID = result.MealID,

					};

					_consumeFoodService.TAdd(consumeFood);
				}
			}
			Helper.Temizle(grpKahvaltiEkle.Controls);
			MessageBox.Show("Başarılı bir şekilde kaydedildi");
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (lstEklenenUrunler.SelectedItems.Count > 0)
			{
				lstEklenenUrunler.Items.Remove(lstEklenenUrunler.SelectedItems[0]);
			}
		}

		private void grpKahvaltiEkle_Enter(object sender, EventArgs e)
		{

		}
	}
}
