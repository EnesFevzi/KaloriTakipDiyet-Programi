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
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kalori_Takip___Diyet__Programı
{
	public partial class ReportConsumeFood : Form
	{
		private readonly ConsumeFoodService _service;
		public ReportConsumeFood()
		{
			_service = new ConsumeFoodService();
			InitializeComponent();
		}

		private void ReportConsumeFood_Load(object sender, EventArgs e)
		{
			DateTime startDate = new DateTime(2023, 9, 21);
			DateTime endDate = new DateTime(2023, 9, 17);
			var consumedFoods = _service.GetMostConsumedFoodsByDate(endDate, startDate);
			chart1.Series.Clear();
			chart1.Series.Add("Yemek");
			chart1.Series["Yemek"].Points.DataBind(consumedFoods, "ConsumeFoodName", "Value", "");
			chart1.Series["Yemek"].ChartType = SeriesChartType.Column;
			//Series series = new Series("Örnek Veri");
			chart1.ChartAreas[0].AxisX.Interval = 1;
			chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
			//series.ChartType = SeriesChartType.Column; // Sütun grafik türünü ayarlayın
			//chart1.Series["Yemek"].Points.Clear();

			//chart1.Series["Yemek"].Points.Add(10);
			//chart1.Series["Yemek"].Points.Add(20);
			//chart1.Series["Yemek"].Points.Add(30);
			//chart1.Series["Yemek"].Points.Add(40);
			//chart1.Series["Yemek"].Points.Add(50);
			//chart1.Series["Yemek"].Points[0].AxisLabel = "Sabah";
			//chart1.Series["Yemek"].Points[1].AxisLabel = "1.Ara";
			//chart1.Series["Yemek"].Points[2].AxisLabel = "Öğle";
			//chart1.Series["Yemek"].Points[3].AxisLabel = "2.Ara";
			//chart1.Series["Yemek"].Points[4].AxisLabel = "Akşam";












			// Verileri ekleyin (örnek olarak)
			//chart1.Points.[0].AddXY(1, 10);
			//chart1.Points.[0].AddXY(2, 20);
			//chart1.Points.AddXY(3, 30);
			//chart1.Points.AddXY(4, 25);
			//chart1.Points.AddXY(5, 15);
			//chart1.Points.AddXY(6, 22);
			//chart1.Points.AddXY(7, 18);
			//// Veri serisini grafiğe ekleyin
			//chart1.Series.Add(series);

			//// Eksen etiketlerini ayarlayın
			//chart1.ChartAreas[0].AxisX.Title = "Günler";
			//chart1.ChartAreas[0].AxisY.Title = "Miktar";

			//// Eksen aralıklarını ayarlayın (isteğe bağlı)
			////chart1.ChartAreas[0].AxisX.Minimum = 1;
			////chart1.ChartAreas[0].AxisX.Maximum = 7;
			////chart1.ChartAreas[0].AxisY.Minimum = 0;
			////chart1.ChartAreas[0].AxisY.Maximum = 35;

			//// X ekseni etiketlerini belirtin
			//chart1.ChartAreas[0].AxisX.CustomLabels.Add(1.5, 1.5, "Pzt");
			//chart1.ChartAreas[0].AxisX.CustomLabels.Add(2.5, 2.5, "Sal");
			//chart1.ChartAreas[0].AxisX.CustomLabels.Add(3.5, 3.5, "Çar");
			//chart1.ChartAreas[0].AxisX.CustomLabels.Add(4.5, 4.5, "Per");
			//chart1.ChartAreas[0].AxisX.CustomLabels.Add(5.5, 5.5, "Cum");
			//chart1.ChartAreas[0].AxisX.CustomLabels.Add(6.5, 6.5, "Cmt");
			//chart1.ChartAreas[0].AxisX.CustomLabels.Add(7.5, 7.5, "Paz");
		}
	}
}
