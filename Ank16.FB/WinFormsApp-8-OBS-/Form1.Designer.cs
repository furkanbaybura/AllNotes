namespace WinFormsApp_8_OBS_
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
			btnOgrtmnGrs = new Button();
			btnOgrncGrs = new Button();
			btnKayıt = new Button();
			SuspendLayout();
			// 
			// btnOgrtmnGrs
			// 
			btnOgrtmnGrs.Location = new Point(144, 285);
			btnOgrtmnGrs.Name = "btnOgrtmnGrs";
			btnOgrtmnGrs.Size = new Size(121, 63);
			btnOgrtmnGrs.TabIndex = 0;
			btnOgrtmnGrs.Text = "Öğretmen Girişi";
			btnOgrtmnGrs.UseVisualStyleBackColor = true;
			btnOgrtmnGrs.Click += btnOgrtmnGrs_Click;
			// 
			// btnOgrncGrs
			// 
			btnOgrncGrs.Location = new Point(479, 285);
			btnOgrncGrs.Name = "btnOgrncGrs";
			btnOgrncGrs.Size = new Size(125, 63);
			btnOgrncGrs.TabIndex = 1;
			btnOgrncGrs.Text = "Öğrenci Giriş";
			btnOgrncGrs.UseVisualStyleBackColor = true;
			btnOgrncGrs.Click += btnOgrncGrs_Click;
			// 
			// btnKayıt
			// 
			btnKayıt.Location = new Point(296, 362);
			btnKayıt.Name = "btnKayıt";
			btnKayıt.Size = new Size(147, 45);
			btnKayıt.TabIndex = 4;
			btnKayıt.Text = "Kayıt Ol";
			btnKayıt.UseVisualStyleBackColor = true;
			btnKayıt.Click += btnKayıt_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnKayıt);
			Controls.Add(btnOgrncGrs);
			Controls.Add(btnOgrtmnGrs);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private Button btnOgrtmnGrs;
		private Button btnOgrncGrs;
		private Button btnKayıt;
	}
}
