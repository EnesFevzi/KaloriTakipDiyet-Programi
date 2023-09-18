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
			btnSil = new Button();
			btnKaydet = new Button();
			grpOgleYemegiEkle = new GroupBox();
			label1 = new Label();
			label2 = new Label();
			label4 = new Label();
			lstEklenenUrunler = new ListView();
			label3 = new Label();
			lstUrunler = new ListView();
			txtUrunAra = new TextBox();
			txtMiktar = new TextBox();
			grpOgleYemegiEkle.SuspendLayout();
			SuspendLayout();
			// 
			// btnSil
			// 
			btnSil.Location = new Point(713, 326);
			btnSil.Name = "btnSil";
			btnSil.Size = new Size(75, 23);
			btnSil.TabIndex = 23;
			btnSil.Text = "SİL";
			btnSil.UseVisualStyleBackColor = true;
			// 
			// btnKaydet
			// 
			btnKaydet.Location = new Point(632, 326);
			btnKaydet.Name = "btnKaydet";
			btnKaydet.Size = new Size(75, 23);
			btnKaydet.TabIndex = 24;
			btnKaydet.Text = "KAYDET";
			btnKaydet.UseVisualStyleBackColor = true;
			// 
			// grpOgleYemegiEkle
			// 
			grpOgleYemegiEkle.Controls.Add(label1);
			grpOgleYemegiEkle.Controls.Add(label2);
			grpOgleYemegiEkle.Controls.Add(label4);
			grpOgleYemegiEkle.Controls.Add(lstEklenenUrunler);
			grpOgleYemegiEkle.Controls.Add(label3);
			grpOgleYemegiEkle.Controls.Add(lstUrunler);
			grpOgleYemegiEkle.Controls.Add(txtUrunAra);
			grpOgleYemegiEkle.Controls.Add(txtMiktar);
			grpOgleYemegiEkle.Location = new Point(1, 12);
			grpOgleYemegiEkle.Name = "grpOgleYemegiEkle";
			grpOgleYemegiEkle.Size = new Size(797, 299);
			grpOgleYemegiEkle.TabIndex = 22;
			grpOgleYemegiEkle.TabStop = false;
			grpOgleYemegiEkle.Text = "ARA ÖĞÜN EKLE";
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
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(6, 266);
			label2.Name = "label2";
			label2.Size = new Size(62, 29);
			label2.TabIndex = 11;
			label2.Text = "Miktar";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			label2.UseCompatibleTextRendering = true;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label4.ForeColor = Color.Black;
			label4.Location = new Point(6, 63);
			label4.Name = "label4";
			label4.Size = new Size(78, 29);
			label4.TabIndex = 11;
			label4.Text = "Ürün ara";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			label4.UseCompatibleTextRendering = true;
			// 
			// lstEklenenUrunler
			// 
			lstEklenenUrunler.GridLines = true;
			lstEklenenUrunler.Location = new Point(296, 95);
			lstEklenenUrunler.Name = "lstEklenenUrunler";
			lstEklenenUrunler.Size = new Size(486, 164);
			lstEklenenUrunler.TabIndex = 13;
			lstEklenenUrunler.UseCompatibleStateImageBehavior = false;
			lstEklenenUrunler.View = View.Details;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.Black;
			label3.Location = new Point(198, 266);
			label3.Name = "label3";
			label3.Size = new Size(49, 29);
			label3.TabIndex = 11;
			label3.Text = "gram";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			label3.UseCompatibleTextRendering = true;
			// 
			// lstUrunler
			// 
			lstUrunler.GridLines = true;
			lstUrunler.Location = new Point(6, 95);
			lstUrunler.Name = "lstUrunler";
			lstUrunler.Size = new Size(284, 164);
			lstUrunler.TabIndex = 13;
			lstUrunler.UseCompatibleStateImageBehavior = false;
			lstUrunler.View = View.Details;
			// 
			// txtUrunAra
			// 
			txtUrunAra.Location = new Point(90, 66);
			txtUrunAra.Name = "txtUrunAra";
			txtUrunAra.Size = new Size(200, 23);
			txtUrunAra.TabIndex = 12;
			// 
			// txtMiktar
			// 
			txtMiktar.Location = new Point(74, 268);
			txtMiktar.Name = "txtMiktar";
			txtMiktar.Size = new Size(118, 23);
			txtMiktar.TabIndex = 12;
			// 
			// AddSnack
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSeaGreen;
			ClientSize = new Size(800, 357);
			Controls.Add(btnSil);
			Controls.Add(btnKaydet);
			Controls.Add(grpOgleYemegiEkle);
			Name = "AddSnack";
			Text = "AddSnack";
			grpOgleYemegiEkle.ResumeLayout(false);
			grpOgleYemegiEkle.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Button btnSil;
		private Button btnKaydet;
		private GroupBox grpOgleYemegiEkle;
		private Label label1;
		private Label label2;
		private Label label4;
		private ListView lstEklenenUrunler;
		private Label label3;
		private ListView lstUrunler;
		private TextBox txtUrunAra;
		private TextBox txtMiktar;
	}
}