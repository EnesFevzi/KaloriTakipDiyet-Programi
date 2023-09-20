namespace Kalori_Takip___Diyet__Programı
{
	partial class AddSnack
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSnack));
			grpAraOguniEkle = new GroupBox();
			label2 = new Label();
			label5 = new Label();
			label6 = new Label();
			txtMiktar = new TextBox();
			btnKaydet = new Button();
			txtUrunAra = new TextBox();
			btnSil = new Button();
			lstUrunler = new ListView();
			columnHeader1 = new ColumnHeader();
			btnEkle = new Button();
			lstEklenenUrunler = new ListView();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			columnHeader6 = new ColumnHeader();
			columnHeader7 = new ColumnHeader();
			label1 = new Label();
			grpAraOguniEkle.SuspendLayout();
			SuspendLayout();
			// 
			// grpAraOguniEkle
			// 
			grpAraOguniEkle.Controls.Add(label2);
			grpAraOguniEkle.Controls.Add(label5);
			grpAraOguniEkle.Controls.Add(label6);
			grpAraOguniEkle.Controls.Add(txtMiktar);
			grpAraOguniEkle.Controls.Add(btnKaydet);
			grpAraOguniEkle.Controls.Add(txtUrunAra);
			grpAraOguniEkle.Controls.Add(btnSil);
			grpAraOguniEkle.Controls.Add(lstUrunler);
			grpAraOguniEkle.Controls.Add(btnEkle);
			grpAraOguniEkle.Controls.Add(lstEklenenUrunler);
			grpAraOguniEkle.Controls.Add(label1);
			grpAraOguniEkle.Location = new Point(2, 36);
			grpAraOguniEkle.Name = "grpAraOguniEkle";
			grpAraOguniEkle.Size = new Size(780, 478);
			grpAraOguniEkle.TabIndex = 22;
			grpAraOguniEkle.TabStop = false;
			grpAraOguniEkle.Text = "ARA ÖĞÜN EKLE";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(407, 78);
			label2.Name = "label2";
			label2.Size = new Size(42, 19);
			label2.TabIndex = 51;
			label2.Text = "gram";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(283, 52);
			label5.Name = "label5";
			label5.Size = new Size(51, 19);
			label5.TabIndex = 52;
			label5.Text = "Miktar";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(6, 52);
			label6.Name = "label6";
			label6.Size = new Size(158, 19);
			label6.TabIndex = 53;
			label6.Text = "Buradan Arayabilirsiniz";
			// 
			// txtMiktar
			// 
			txtMiktar.BackColor = Color.PaleGoldenrod;
			txtMiktar.Location = new Point(283, 74);
			txtMiktar.Name = "txtMiktar";
			txtMiktar.Size = new Size(118, 23);
			txtMiktar.TabIndex = 45;
			// 
			// btnKaydet
			// 
			btnKaydet.BackColor = Color.DarkSeaGreen;
			btnKaydet.BackgroundImage = (Image)resources.GetObject("btnKaydet.BackgroundImage");
			btnKaydet.BackgroundImageLayout = ImageLayout.Stretch;
			btnKaydet.FlatAppearance.BorderSize = 0;
			btnKaydet.FlatStyle = FlatStyle.Popup;
			btnKaydet.Location = new Point(746, 237);
			btnKaydet.Name = "btnKaydet";
			btnKaydet.Size = new Size(33, 30);
			btnKaydet.TabIndex = 48;
			btnKaydet.UseVisualStyleBackColor = false;
			btnKaydet.Click += btnKaydet_Click;
			// 
			// txtUrunAra
			// 
			txtUrunAra.BackColor = Color.PaleGoldenrod;
			txtUrunAra.Location = new Point(6, 74);
			txtUrunAra.Name = "txtUrunAra";
			txtUrunAra.Size = new Size(271, 23);
			txtUrunAra.TabIndex = 44;
			txtUrunAra.TextChanged += txtUrunAra_TextChanged;
			// 
			// btnSil
			// 
			btnSil.BackColor = Color.DarkSeaGreen;
			btnSil.BackgroundImage = (Image)resources.GetObject("btnSil.BackgroundImage");
			btnSil.BackgroundImageLayout = ImageLayout.Stretch;
			btnSil.FlatAppearance.BorderSize = 0;
			btnSil.FlatStyle = FlatStyle.Popup;
			btnSil.Location = new Point(283, 237);
			btnSil.Name = "btnSil";
			btnSil.Size = new Size(33, 30);
			btnSil.TabIndex = 49;
			btnSil.UseVisualStyleBackColor = false;
			btnSil.Click += btnSil_Click;
			// 
			// lstUrunler
			// 
			lstUrunler.BackColor = Color.PaleGoldenrod;
			lstUrunler.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
			lstUrunler.FullRowSelect = true;
			lstUrunler.GridLines = true;
			lstUrunler.Location = new Point(6, 103);
			lstUrunler.Name = "lstUrunler";
			lstUrunler.Size = new Size(271, 164);
			lstUrunler.TabIndex = 47;
			lstUrunler.UseCompatibleStateImageBehavior = false;
			lstUrunler.View = View.Details;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Ürün Adı";
			columnHeader1.Width = 260;
			// 
			// btnEkle
			// 
			btnEkle.BackColor = Color.DarkSeaGreen;
			btnEkle.BackgroundImage = (Image)resources.GetObject("btnEkle.BackgroundImage");
			btnEkle.BackgroundImageLayout = ImageLayout.Stretch;
			btnEkle.FlatAppearance.BorderSize = 0;
			btnEkle.FlatStyle = FlatStyle.Popup;
			btnEkle.Location = new Point(283, 182);
			btnEkle.Name = "btnEkle";
			btnEkle.Size = new Size(33, 30);
			btnEkle.TabIndex = 50;
			btnEkle.UseVisualStyleBackColor = false;
			btnEkle.Click += btnEkle_Click;
			// 
			// lstEklenenUrunler
			// 
			lstEklenenUrunler.BackColor = Color.PaleGoldenrod;
			lstEklenenUrunler.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
			lstEklenenUrunler.FullRowSelect = true;
			lstEklenenUrunler.GridLines = true;
			lstEklenenUrunler.Location = new Point(6, 273);
			lstEklenenUrunler.Name = "lstEklenenUrunler";
			lstEklenenUrunler.Size = new Size(775, 198);
			lstEklenenUrunler.TabIndex = 46;
			lstEklenenUrunler.UseCompatibleStateImageBehavior = false;
			lstEklenenUrunler.View = View.Details;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Ürün Adı";
			columnHeader2.Width = 125;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Miktar";
			columnHeader3.Width = 125;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Kalori";
			columnHeader4.Width = 125;
			// 
			// columnHeader5
			// 
			columnHeader5.Text = "Protein";
			columnHeader5.Width = 125;
			// 
			// columnHeader6
			// 
			columnHeader6.Text = "Yağ";
			columnHeader6.Width = 125;
			// 
			// columnHeader7
			// 
			columnHeader7.Text = "Karbonhidrat";
			columnHeader7.Width = 125;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(6, 19);
			label1.Name = "label1";
			label1.Size = new Size(139, 23);
			label1.TabIndex = 2;
			label1.Text = "ARA ÖĞÜN EKLE";
			// 
			// AddSnack
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSeaGreen;
			ClientSize = new Size(782, 526);
			Controls.Add(grpAraOguniEkle);
			Name = "AddSnack";
			Text = "AddSnack";
			grpAraOguniEkle.ResumeLayout(false);
			grpAraOguniEkle.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private GroupBox grpAraOguniEkle;
		private Label label1;
		private Label label2;
		private Label label5;
		private Label label6;
		private TextBox txtMiktar;
		private Button btnKaydet;
		private TextBox txtUrunAra;
		private Button btnSil;
		private ListView lstUrunler;
		private ColumnHeader columnHeader1;
		private Button btnEkle;
		private ListView lstEklenenUrunler;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader5;
		private ColumnHeader columnHeader6;
		private ColumnHeader columnHeader7;
	}
}