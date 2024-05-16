namespace KitapStokYönetim
{
    partial class KitapForm
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
			label1 = new Label();
			groupBox1 = new GroupBox();
			button1 = new Button();
			txtSatisAdet = new TextBox();
			groupboxguncel = new GroupBox();
			txtboxfiyat = new TextBox();
			txtboxadet = new TextBox();
			txtbguncelad = new TextBox();
			btnguncelle = new Button();
			groupBox1.SuspendLayout();
			groupboxguncel.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.BackColor = SystemColors.ActiveCaption;
			label1.BorderStyle = BorderStyle.Fixed3D;
			label1.Location = new Point(10, 21);
			label1.Name = "label1";
			label1.Size = new Size(178, 231);
			label1.TabIndex = 0;
			label1.TextAlign = ContentAlignment.MiddleCenter;
			label1.Click += label1_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(txtSatisAdet);
			groupBox1.Location = new Point(224, 21);
			groupBox1.Margin = new Padding(3, 2, 3, 2);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(3, 2, 3, 2);
			groupBox1.Size = new Size(347, 128);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Satış alanı";
			// 
			// button1
			// 
			button1.Location = new Point(137, 77);
			button1.Margin = new Padding(3, 2, 3, 2);
			button1.Name = "button1";
			button1.Size = new Size(71, 47);
			button1.TabIndex = 1;
			button1.Text = "Satış";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// txtSatisAdet
			// 
			txtSatisAdet.Location = new Point(96, 36);
			txtSatisAdet.Margin = new Padding(3, 2, 3, 2);
			txtSatisAdet.Name = "txtSatisAdet";
			txtSatisAdet.PlaceholderText = "Adet";
			txtSatisAdet.Size = new Size(154, 23);
			txtSatisAdet.TabIndex = 0;
			// 
			// groupboxguncel
			// 
			groupboxguncel.Controls.Add(txtboxfiyat);
			groupboxguncel.Controls.Add(txtboxadet);
			groupboxguncel.Controls.Add(txtbguncelad);
			groupboxguncel.Controls.Add(btnguncelle);
			groupboxguncel.Location = new Point(224, 154);
			groupboxguncel.Name = "groupboxguncel";
			groupboxguncel.Size = new Size(347, 167);
			groupboxguncel.TabIndex = 2;
			groupboxguncel.TabStop = false;
			groupboxguncel.Text = "Güncelleme";
			// 
			// txtboxfiyat
			// 
			txtboxfiyat.Location = new Point(123, 98);
			txtboxfiyat.Name = "txtboxfiyat";
			txtboxfiyat.PlaceholderText = "Fiyat";
			txtboxfiyat.Size = new Size(100, 23);
			txtboxfiyat.TabIndex = 3;
			// 
			// txtboxadet
			// 
			txtboxadet.Location = new Point(123, 56);
			txtboxadet.Name = "txtboxadet";
			txtboxadet.PlaceholderText = "Adet";
			txtboxadet.Size = new Size(100, 23);
			txtboxadet.TabIndex = 2;
			// 
			// txtbguncelad
			// 
			txtbguncelad.Location = new Point(123, 22);
			txtbguncelad.Name = "txtbguncelad";
			txtbguncelad.PlaceholderText = "Name";
			txtbguncelad.Size = new Size(100, 23);
			txtbguncelad.TabIndex = 1;
			// 
			// btnguncelle
			// 
			btnguncelle.Location = new Point(133, 138);
			btnguncelle.Name = "btnguncelle";
			btnguncelle.Size = new Size(75, 23);
			btnguncelle.TabIndex = 0;
			btnguncelle.Text = "Güncelle";
			btnguncelle.UseVisualStyleBackColor = true;
			btnguncelle.Click += btnguncelle_Click;
			// 
			// KitapForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(700, 338);
			Controls.Add(groupboxguncel);
			Controls.Add(groupBox1);
			Controls.Add(label1);
			Margin = new Padding(3, 2, 3, 2);
			Name = "KitapForm";
			Text = "KitapForm";
			Load += KitapForm_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupboxguncel.ResumeLayout(false);
			groupboxguncel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
        private GroupBox groupBox1;
        private TextBox txtSatisAdet;
        private Button button1;
		private GroupBox groupboxguncel;
		private Button btnguncelle;
		private TextBox txtboxfiyat;
		private TextBox txtboxadet;
		private TextBox txtbguncelad;
	}
}