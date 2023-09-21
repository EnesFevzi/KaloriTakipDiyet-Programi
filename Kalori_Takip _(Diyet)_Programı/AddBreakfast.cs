﻿using Kalori_Takip___Diyet__Programı.Extensions;
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
		private ConsumeFood _consumeFood;
		float girilenMiktar = 0;
		public AddBreakfast(AppUser user)
		{
			InitializeComponent();
			_foodService = new FoodService();
			_consumeFoodService = new ConsumeFoodService();
			_mealService = new MealService();
			_user = user;
			_consumeFood = new ConsumeFood();
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
		private Food Urun;
		private ConsumeFood tuketilenUrun;

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
				Urun = secilenUrun;
				secilenUrun = _foodService.CalculateFoodInfo(secilenUrun.FoodID, girilenMiktar);

				ListViewItem item = new ListViewItem();
				item.Text = secilenUrun.FoodName;
				item.SubItems.Add(girilenMiktar.ToString("0.00"));
				item.SubItems.Add(secilenUrun.Calories.ToString("0.00"));
				item.SubItems.Add(secilenUrun.Protein.ToString("0.00"));
				item.SubItems.Add(secilenUrun.Fat.ToString("0.00"));
				item.SubItems.Add(secilenUrun.Carbohydrate.ToString("0.00"));
				item.Tag = item;
				lstEklenenUrunler.Items.Add(item);

			}
		}
		ConsumeFood consumeFood;
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
					consumeFood = new ConsumeFood()
					{
						ConsumeFoodName = item.SubItems[0].Text,
						GramCompensation = Convert.ToSingle(item.SubItems[1].Text),
						Calories = Convert.ToSingle(item.SubItems[2].Text),
						Carbohydrate = Convert.ToSingle(item.SubItems[3].Text),
						Protein = Convert.ToSingle(item.SubItems[4].Text),
						Fat = Convert.ToSingle(item.SubItems[5].Text),
						CreatedDate = DateTime.Now,
						ImagePath = imageName,
						AppUserID = _user.AppUserID,
						Foods = new List<Food>() { Urun },
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
		string imageName;
		private void btnResimEkle_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif|Tüm Dosyalar|*.*";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string selectedImagePath = openFileDialog.FileName;
				string fileExtension = Path.GetExtension(selectedImagePath);
				imageName = Guid.NewGuid().ToString() + fileExtension;
				string saveLocation = Path.Combine(Application.StartupPath, "FoodImage", imageName);
				File.Copy(selectedImagePath, saveLocation);
				_consumeFood.ImagePath = imageName;
			}

			Image ımage = LoadImages.LoadFoodImage(_consumeFood.ImagePath);
			pbxYemekResmi.Image = ımage;
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void pbxYemekResmi_Click(object sender, EventArgs e)
		{
		}
	}
}
