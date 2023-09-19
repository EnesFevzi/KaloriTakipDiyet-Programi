namespace Kalori_Takip___Diyet__Programı
{
	partial class WaterTracking
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaterTracking));
			label1 = new Label();
			groupBox1 = new GroupBox();
			lblKilo = new Label();
			label2 = new Label();
			label3 = new Label();
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			groupBox2 = new GroupBox();
			btnGeriDon = new Button();
			label4 = new Label();
			btnSuEkle = new Button();
			label5 = new Label();
			nmrSuMiktari = new NumericUpDown();
			dtSuTarih = new DateTimePicker();
			label6 = new Label();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nmrSuMiktari).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(2, 32);
			label1.Name = "label1";
			label1.Size = new Size(86, 23);
			label1.TabIndex = 1;
			label1.Text = "SU TAKİBİ";
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.Transparent;
			groupBox1.Controls.Add(lblKilo);
			groupBox1.Controls.Add(label2);
			groupBox1.Location = new Point(2, 86);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(138, 53);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "KişiselBilgiler";
			// 
			// lblKilo
			// 
			lblKilo.AutoSize = true;
			lblKilo.Font = new Font("Calibri", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
			lblKilo.Location = new Point(81, 19);
			lblKilo.Name = "lblKilo";
			lblKilo.Size = new Size(20, 23);
			lblKilo.TabIndex = 0;
			lblKilo.Text = "0";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(6, 19);
			label2.Name = "label2";
			label2.Size = new Size(33, 19);
			label2.TabIndex = 0;
			label2.Text = "Kilo";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(2, 55);
			label3.Name = "label3";
			label3.Size = new Size(515, 15);
			label3.TabIndex = 1;
			label3.Text = "Güncel kilonuz ile günlük tüketmeniz gereken su miktarını otomatik olarak hesaplanmaktadır.";
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(555, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(100, 161);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 5;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(6, 22);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(53, 98);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 5;
			pictureBox2.TabStop = false;
			// 
			// groupBox2
			// 
			groupBox2.BackColor = Color.Transparent;
			groupBox2.Controls.Add(pictureBox2);
			groupBox2.Location = new Point(8, 250);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(647, 140);
			groupBox2.TabIndex = 6;
			groupBox2.TabStop = false;
			groupBox2.Text = "Su Miktarı";
			// 
			// btnGeriDon
			// 
			btnGeriDon.BackColor = Color.Transparent;
			btnGeriDon.BackgroundImage = (Image)resources.GetObject("btnGeriDon.BackgroundImage");
			btnGeriDon.BackgroundImageLayout = ImageLayout.Stretch;
			btnGeriDon.FlatAppearance.BorderSize = 0;
			btnGeriDon.FlatStyle = FlatStyle.Flat;
			btnGeriDon.Location = new Point(2, 2);
			btnGeriDon.Name = "btnGeriDon";
			btnGeriDon.Size = new Size(30, 27);
			btnGeriDon.TabIndex = 7;
			btnGeriDon.UseVisualStyleBackColor = false;
			btnGeriDon.Click += btnGeriDon_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(12, 402);
			label4.Name = "label4";
			label4.Size = new Size(196, 15);
			label4.TabIndex = 1;
			label4.Text = "Bir bardak 250 ml su içermektedir.";
			label4.Click += label4_Click;
			// 
			// btnSuEkle
			// 
			btnSuEkle.Location = new Point(47, 221);
			btnSuEkle.Name = "btnSuEkle";
			btnSuEkle.Size = new Size(75, 23);
			btnSuEkle.TabIndex = 8;
			btnSuEkle.Text = "Ekle";
			btnSuEkle.UseVisualStyleBackColor = true;
			btnSuEkle.Click += btnSuEkle_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label5.Location = new Point(2, 142);
			label5.Name = "label5";
			label5.Size = new Size(57, 18);
			label5.TabIndex = 1;
			label5.Text = "Su İçtim";
			label5.Click += label4_Click;
			// 
			// nmrSuMiktari
			// 
			nmrSuMiktari.Location = new Point(2, 192);
			nmrSuMiktari.Name = "nmrSuMiktari";
			nmrSuMiktari.Size = new Size(120, 23);
			nmrSuMiktari.TabIndex = 9;
			// 
			// dtSuTarih
			// 
			dtSuTarih.Location = new Point(2, 163);
			dtSuTarih.Name = "dtSuTarih";
			dtSuTarih.Size = new Size(200, 23);
			dtSuTarih.TabIndex = 10;
			dtSuTarih.ValueChanged += dtSuTarih_ValueChanged;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(2, 536);
			label6.Name = "label6";
			label6.Size = new Size(196, 15);
			label6.TabIndex = 1;
			label6.Text = "Bir bardak 250 ml su içermektedir.";
			label6.Click += label4_Click;
			// 
			// WaterTracking
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSeaGreen;
			ClientSize = new Size(667, 560);
			Controls.Add(dtSuTarih);
			Controls.Add(nmrSuMiktari);
			Controls.Add(btnSuEkle);
			Controls.Add(btnGeriDon);
			Controls.Add(groupBox2);
			Controls.Add(pictureBox1);
			Controls.Add(groupBox1);
			Controls.Add(label5);
			Controls.Add(label6);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label1);
			Name = "WaterTracking";
			Text = "WaterTracking";
			Load += WaterTracking_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)nmrSuMiktari).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label1;
		private GroupBox groupBox1;
		private Label lblKilo;
		private Label label2;
		private Label label3;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private GroupBox groupBox2;
		private Button btnGeriDon;
		private Label label4;
		private Button btnSuEkle;
		private Label label5;
		private NumericUpDown nmrSuMiktari;
		private DateTimePicker dtSuTarih;
		private Label label6;
	}
}