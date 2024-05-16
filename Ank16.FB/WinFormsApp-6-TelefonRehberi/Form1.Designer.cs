namespace WinFormsApp6_TelefonRehberi
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			txtAdi = new TextBox();
			txtNumarasi = new TextBox();
			btnKaydet = new Button();
			BtnRenkSec = new Button();
			lsbKisiler = new ListBox();
			btnYenile = new Button();
			colorDialog1 = new ColorDialog();
			SuspendLayout();
			// 
			// txtAdi
			// 
			txtAdi.Location = new Point(72, 49);
			txtAdi.Name = "txtAdi";
			txtAdi.PlaceholderText = "AdıSoyadı";
			txtAdi.Size = new Size(100, 23);
			txtAdi.TabIndex = 0;
			// 
			// txtNumarasi
			// 
			txtNumarasi.Location = new Point(72, 110);
			txtNumarasi.Name = "txtNumarasi";
			txtNumarasi.PlaceholderText = "Numarası";
			txtNumarasi.Size = new Size(100, 23);
			txtNumarasi.TabIndex = 1;
			// 
			// btnKaydet
			// 
			btnKaydet.Location = new Point(72, 250);
			btnKaydet.Name = "btnKaydet";
			btnKaydet.Size = new Size(100, 40);
			btnKaydet.TabIndex = 3;
			btnKaydet.Text = "Kaydet";
			btnKaydet.UseVisualStyleBackColor = true;
			// 
			// BtnRenkSec
			// 
			BtnRenkSec.Location = new Point(72, 173);
			BtnRenkSec.Name = "BtnRenkSec";
			BtnRenkSec.Size = new Size(100, 30);
			BtnRenkSec.TabIndex = 4;
			BtnRenkSec.Text = "Renk Seç";
			BtnRenkSec.UseVisualStyleBackColor = true;
			BtnRenkSec.Click += BtnRenkSec_Click;
			// 
			// lsbKisiler
			// 
			lsbKisiler.FormattingEnabled = true;
			lsbKisiler.ItemHeight = 15;
			lsbKisiler.Location = new Point(481, 72);
			lsbKisiler.Name = "lsbKisiler";
			lsbKisiler.Size = new Size(270, 304);
			lsbKisiler.TabIndex = 5;
			lsbKisiler.SelectedIndexChanged += lsbKisiler_SelectedIndexChanged;
			// 
			// btnYenile
			// 
			btnYenile.Location = new Point(481, 43);
			btnYenile.Name = "btnYenile";
			btnYenile.Size = new Size(75, 23);
			btnYenile.TabIndex = 6;
			btnYenile.Text = "Yenile";
			btnYenile.UseVisualStyleBackColor = true;
			btnYenile.Click += button1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnYenile);
			Controls.Add(lsbKisiler);
			Controls.Add(BtnRenkSec);
			Controls.Add(btnKaydet);
			Controls.Add(txtNumarasi);
			Controls.Add(txtAdi);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtAdi;
		private TextBox txtNumarasi;
		private Button btnKaydet;
		private Button BtnRenkSec;
		private ListBox lsbKisiler;
		private Button btnYenile;
		private ColorDialog colorDialog1;
	}
}
