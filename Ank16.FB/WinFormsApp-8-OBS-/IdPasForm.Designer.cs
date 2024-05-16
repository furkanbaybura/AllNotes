namespace WinFormsApp_8_OBS_
{
	partial class IdPasForm
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
			txtOgrNo = new TextBox();
			txtPrl = new TextBox();
			btnGrs = new Button();
			SuspendLayout();
			// 
			// txtOgrNo
			// 
			txtOgrNo.Location = new Point(160, 74);
			txtOgrNo.Name = "txtOgrNo";
			txtOgrNo.PlaceholderText = "Öğrenci Numarası";
			txtOgrNo.Size = new Size(118, 23);
			txtOgrNo.TabIndex = 0;
			// 
			// txtPrl
			// 
			txtPrl.Location = new Point(159, 152);
			txtPrl.Name = "txtPrl";
			txtPrl.PasswordChar = '*';
			txtPrl.PlaceholderText = "Parola";
			txtPrl.Size = new Size(119, 23);
			txtPrl.TabIndex = 1;
			// 
			// btnGrs
			// 
			btnGrs.Location = new Point(148, 278);
			btnGrs.Name = "btnGrs";
			btnGrs.Size = new Size(75, 23);
			btnGrs.TabIndex = 2;
			btnGrs.Text = "Giriş Yap";
			btnGrs.UseVisualStyleBackColor = true;
			btnGrs.Click += btnGrs_Click;
			// 
			// IdPasForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnGrs);
			Controls.Add(txtPrl);
			Controls.Add(txtOgrNo);
			Name = "IdPasForm";
			Text = "IdPasForm";
			FormClosing += IdPasForm_FormClosing;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtOgrNo;
		private TextBox txtPrl;
		private Button btnGrs;
	}
}