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
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			groupBox2.SuspendLayout();
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
			label1.Click += label1_Click;
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
			label3.Click += label1_Click;
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
			groupBox2.Location = new Point(12, 207);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(643, 140);
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
			label4.Location = new Point(8, 426);
			label4.Name = "label4";
			label4.Size = new Size(196, 15);
			label4.TabIndex = 1;
			label4.Text = "Bir bardak 250 ml su içermektedir.";
			label4.Click += label1_Click;
			// 
			// WaterTracking
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSeaGreen;
			ClientSize = new Size(667, 450);
			Controls.Add(btnGeriDon);
			Controls.Add(groupBox2);
			Controls.Add(pictureBox1);
			Controls.Add(groupBox1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label1);
			Name = "WaterTracking";
			Text = "WaterTracking";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			groupBox2.ResumeLayout(false);
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
	}
}