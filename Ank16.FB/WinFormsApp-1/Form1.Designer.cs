namespace WinFormsApp_1
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
			Kırmızı = new CheckBox();
			Yeşil = new CheckBox();
			Mor = new CheckBox();
			Sarı = new CheckBox();
			Mavi = new CheckBox();
			Renkler = new GroupBox();
			Erkek = new RadioButton();
			Kadın = new RadioButton();
			Cinsiyet = new GroupBox();
			Name = new TextBox();
			Surname = new TextBox();
			Age = new TextBox();
			Ad = new Label();
			Soyad = new Label();
			Yas = new Label();
			KisiselBilgiler = new GroupBox();
			Register = new Button();
			Renkler.SuspendLayout();
			Cinsiyet.SuspendLayout();
			KisiselBilgiler.SuspendLayout();
			SuspendLayout();
			// 
			// Kırmızı
			// 
			Kırmızı.AutoSize = true;
			Kırmızı.Location = new Point(6, 110);
			Kırmızı.Name = "Kırmızı";
			Kırmızı.Size = new Size(62, 19);
			Kırmızı.TabIndex = 0;
			Kırmızı.Text = "Kırmızı";
			Kırmızı.UseVisualStyleBackColor = true;
			// 
			// Yeşil
			// 
			Yeşil.AutoSize = true;
			Yeşil.Location = new Point(6, 91);
			Yeşil.Name = "Yeşil";
			Yeşil.Size = new Size(49, 19);
			Yeşil.TabIndex = 1;
			Yeşil.Text = "Yeşil";
			Yeşil.UseVisualStyleBackColor = true;
			// 
			// Mor
			// 
			Mor.AutoSize = true;
			Mor.Location = new Point(6, 72);
			Mor.Name = "Mor";
			Mor.Size = new Size(48, 19);
			Mor.TabIndex = 2;
			Mor.Text = "Mor";
			Mor.UseVisualStyleBackColor = true;
			// 
			// Sarı
			// 
			Sarı.AutoSize = true;
			Sarı.Location = new Point(6, 53);
			Sarı.Name = "Sarı";
			Sarı.Size = new Size(45, 19);
			Sarı.TabIndex = 3;
			Sarı.Text = "Sarı";
			Sarı.UseVisualStyleBackColor = true;
			// 
			// Mavi
			// 
			Mavi.AutoSize = true;
			Mavi.Location = new Point(6, 34);
			Mavi.Name = "Mavi";
			Mavi.Size = new Size(52, 19);
			Mavi.TabIndex = 4;
			Mavi.Text = "Mavi";
			Mavi.UseVisualStyleBackColor = true;
			Mavi.CheckedChanged += checkBox5_CheckedChanged;
			// 
			// Renkler
			// 
			Renkler.Controls.Add(Mor);
			Renkler.Controls.Add(Mavi);
			Renkler.Controls.Add(Kırmızı);
			Renkler.Controls.Add(Sarı);
			Renkler.Controls.Add(Yeşil);
			Renkler.Location = new Point(12, 12);
			Renkler.Name = "Renkler";
			Renkler.Size = new Size(265, 190);
			Renkler.TabIndex = 5;
			Renkler.TabStop = false;
			Renkler.Text = "Renkler";
			// 
			// Erkek
			// 
			Erkek.AutoSize = true;
			Erkek.Location = new Point(6, 43);
			Erkek.Name = "Erkek";
			Erkek.Size = new Size(53, 19);
			Erkek.TabIndex = 6;
			Erkek.TabStop = true;
			Erkek.Text = "Erkek";
			Erkek.UseVisualStyleBackColor = true;
			// 
			// Kadın
			// 
			Kadın.AutoSize = true;
			Kadın.Location = new Point(6, 70);
			Kadın.Name = "Kadın";
			Kadın.Size = new Size(55, 19);
			Kadın.TabIndex = 7;
			Kadın.TabStop = true;
			Kadın.Text = "Kadın";
			Kadın.UseVisualStyleBackColor = true;
			// 
			// Cinsiyet
			// 
			Cinsiyet.Controls.Add(Erkek);
			Cinsiyet.Controls.Add(Kadın);
			Cinsiyet.Location = new Point(297, 22);
			Cinsiyet.Name = "Cinsiyet";
			Cinsiyet.Size = new Size(327, 180);
			Cinsiyet.TabIndex = 8;
			Cinsiyet.TabStop = false;
			Cinsiyet.Text = "Cinsiyet";
			// 
			// Name
			// 
			Name.Location = new Point(146, 23);
			Name.Name = "Name";
			Name.Size = new Size(100, 23);
			Name.TabIndex = 9;
			// 
			// Surname
			// 
			Surname.Location = new Point(146, 69);
			Surname.Name = "Surname";
			Surname.Size = new Size(100, 23);
			Surname.TabIndex = 10;
			// 
			// Age
			// 
			Age.Location = new Point(146, 119);
			Age.Name = "Age";
			Age.Size = new Size(100, 23);
			Age.TabIndex = 11;
			// 
			// Ad
			// 
			Ad.AutoSize = true;
			Ad.Location = new Point(61, 31);
			Ad.Name = "Ad";
			Ad.Size = new Size(46, 15);
			Ad.TabIndex = 12;
			Ad.Text = "Adınız :";
			// 
			// Soyad
			// 
			Soyad.AutoSize = true;
			Soyad.Location = new Point(61, 77);
			Soyad.Name = "Soyad";
			Soyad.Size = new Size(66, 15);
			Soyad.TabIndex = 13;
			Soyad.Text = "Soyadınız : ";
			// 
			// Yas
			// 
			Yas.AutoSize = true;
			Yas.Location = new Point(61, 127);
			Yas.Name = "Yas";
			Yas.Size = new Size(51, 15);
			Yas.TabIndex = 14;
			Yas.Text = "Yaşınız : ";
			// 
			// KisiselBilgiler
			// 
			KisiselBilgiler.Controls.Add(Ad);
			KisiselBilgiler.Controls.Add(Yas);
			KisiselBilgiler.Controls.Add(Name);
			KisiselBilgiler.Controls.Add(Soyad);
			KisiselBilgiler.Controls.Add(Surname);
			KisiselBilgiler.Controls.Add(Age);
			KisiselBilgiler.Location = new Point(12, 222);
			KisiselBilgiler.Name = "KisiselBilgiler";
			KisiselBilgiler.Size = new Size(313, 158);
			KisiselBilgiler.TabIndex = 15;
			KisiselBilgiler.TabStop = false;
			KisiselBilgiler.Text = "Kişisel Bilgiler";
			// 
			// Register
			// 
			Register.Location = new Point(423, 323);
			Register.Name = "Register";
			Register.Size = new Size(176, 55);
			Register.TabIndex = 16;
			Register.Text = "Register";
			Register.UseVisualStyleBackColor = true;
			Register.Click += Register_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(945, 392);
			Controls.Add(Register);
			Controls.Add(KisiselBilgiler);
			Controls.Add(Cinsiyet);
			Controls.Add(Renkler);
			//Name = "Form1";
			//Text = "Form1";
			Load += Form1_Load;
			Renkler.ResumeLayout(false);
			Renkler.PerformLayout();
			Cinsiyet.ResumeLayout(false);
			Cinsiyet.PerformLayout();
			KisiselBilgiler.ResumeLayout(false);
			KisiselBilgiler.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private CheckBox Kırmızı;
		private CheckBox Yeşil;
		private CheckBox Mor;
		private CheckBox Sarı;
		private CheckBox Mavi;
		private GroupBox Renkler;
		private RadioButton Erkek;
		private RadioButton Kadın;
		private GroupBox Cinsiyet;
		private TextBox Name;
		private TextBox Surname;
		private TextBox Age;
		private Label Ad;
		private Label Soyad;
		private Label Yas;
		private GroupBox KisiselBilgiler;
		private Button Register;
	}
}
