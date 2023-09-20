namespace Kalori_Takip___Diyet__Programı
{
	partial class ReportConsumeFood
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			radioButton1 = new RadioButton();
			radioButton2 = new RadioButton();
			((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
			SuspendLayout();
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			chart1.Legends.Add(legend1);
			chart1.Location = new Point(12, 12);
			chart1.Name = "chart1";
			chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Yemek";
			chart1.Series.Add(series1);
			chart1.Size = new Size(520, 380);
			chart1.TabIndex = 0;
			chart1.Text = "chart1";
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Location = new Point(550, 74);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(94, 19);
			radioButton1.TabIndex = 1;
			radioButton1.TabStop = true;
			radioButton1.Text = "radioButton1";
			radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(709, 26);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(94, 19);
			radioButton2.TabIndex = 1;
			radioButton2.TabStop = true;
			radioButton2.Text = "radioButton1";
			radioButton2.UseVisualStyleBackColor = true;
			// 
			// ReportConsumeFood
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(850, 533);
			Controls.Add(radioButton2);
			Controls.Add(radioButton1);
			Controls.Add(chart1);
			Name = "ReportConsumeFood";
			Text = "ReportConsumeFood";
			Load += ReportConsumeFood_Load;
			((System.ComponentModel.ISupportInitialize)chart1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private RadioButton radioButton1;
		private RadioButton radioButton2;
	}
}