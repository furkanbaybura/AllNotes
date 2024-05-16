namespace WinFormsApp_8_OBS_
{
	partial class OgrenciKayıtForm
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
			txtkytad = new TextBox();
			txtkytsoyad = new TextBox();
			txtkytogrn = new TextBox();
			txtkytsifre = new TextBox();
			btnkayıttamamla = new Button();
			SuspendLayout();
			// 
			// txtkytad
			// 
			txtkytad.Location = new Point(77, 82);
			txtkytad.Name = "txtkytad";
			txtkytad.PlaceholderText = "Ad";
			txtkytad.Size = new Size(100, 23);
			txtkytad.TabIndex = 0;
			txtkytad.TextChanged += textBox1_TextChanged;
			// 
			// txtkytsoyad
			// 
			txtkytsoyad.Location = new Point(77, 132);
			txtkytsoyad.Name = "txtkytsoyad";
			txtkytsoyad.PlaceholderText = "Soyad";
			txtkytsoyad.Size = new Size(100, 23);
			txtkytsoyad.TabIndex = 1;
			txtkytsoyad.TextChanged += txtkytsoyad_TextChanged;
			// 
			// txtkytogrn
			// 
			txtkytogrn.Location = new Point(77, 188);
			txtkytogrn.Name = "txtkytogrn";
			txtkytogrn.PlaceholderText = "Öğrenci Numarası";
			txtkytogrn.Size = new Size(100, 23);
			txtkytogrn.TabIndex = 2;
			txtkytogrn.TextChanged += txtkytogrn_TextChanged;
			// 
			// txtkytsifre
			// 
			txtkytsifre.Location = new Point(77, 251);
			txtkytsifre.Name = "txtkytsifre";
			txtkytsifre.PlaceholderText = "Şifre";
			txtkytsifre.Size = new Size(100, 23);
			txtkytsifre.TabIndex = 3;
			txtkytsifre.TextChanged += txtkytsifre_TextChanged;
			// 
			// btnkayıttamamla
			// 
			btnkayıttamamla.Location = new Point(83, 327);
			btnkayıttamamla.Name = "btnkayıttamamla";
			btnkayıttamamla.Size = new Size(75, 23);
			btnkayıttamamla.TabIndex = 4;
			btnkayıttamamla.Text = "Kayıt Ol";
			btnkayıttamamla.UseVisualStyleBackColor = true;
			btnkayıttamamla.Click += btnkayıttamamla_Click;
			// 
			// OgrenciKayıtForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnkayıttamamla);
			Controls.Add(txtkytsifre);
			Controls.Add(txtkytogrn);
			Controls.Add(txtkytsoyad);
			Controls.Add(txtkytad);
			Name = "OgrenciKayıtForm";
			Text = "OgrenciKayıtForm";
			Load += OgrenciKayıtForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtkytad;
		private TextBox txtkytsoyad;
		private TextBox txtkytogrn;
		private TextBox txtkytsifre;
		private Button btnkayıttamamla;
	}
}