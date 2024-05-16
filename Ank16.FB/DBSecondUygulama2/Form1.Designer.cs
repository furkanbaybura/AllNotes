namespace DBSecondUygulama2
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
			btnekle = new Button();
			btnsil = new Button();
			btnguncelle = new Button();
			txtmarka = new TextBox();
			txtmodel = new TextBox();
			dataGridView1 = new DataGridView();
			lblsecilen = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// btnekle
			// 
			btnekle.Location = new Point(33, 357);
			btnekle.Name = "btnekle";
			btnekle.Size = new Size(107, 27);
			btnekle.TabIndex = 0;
			btnekle.Text = "Ekleme";
			btnekle.UseVisualStyleBackColor = true;
			btnekle.Click += button1_Click;
			// 
			// btnsil
			// 
			btnsil.Location = new Point(170, 357);
			btnsil.Name = "btnsil";
			btnsil.Size = new Size(116, 27);
			btnsil.TabIndex = 1;
			btnsil.Text = "Sil";
			btnsil.UseVisualStyleBackColor = true;
			btnsil.Click += btnsil_Click;
			// 
			// btnguncelle
			// 
			btnguncelle.Location = new Point(313, 357);
			btnguncelle.Name = "btnguncelle";
			btnguncelle.Size = new Size(108, 27);
			btnguncelle.TabIndex = 2;
			btnguncelle.Text = "Güncelle";
			btnguncelle.UseVisualStyleBackColor = true;
			btnguncelle.Click += btnguncelle_Click;
			// 
			// txtmarka
			// 
			txtmarka.Location = new Point(33, 225);
			txtmarka.Name = "txtmarka";
			txtmarka.PlaceholderText = "Marka";
			txtmarka.Size = new Size(107, 23);
			txtmarka.TabIndex = 4;
			txtmarka.TextChanged += txtmarka_TextChanged;
			// 
			// txtmodel
			// 
			txtmodel.Location = new Point(33, 285);
			txtmodel.Name = "txtmodel";
			txtmodel.PlaceholderText = "Model";
			txtmodel.Size = new Size(107, 23);
			txtmodel.TabIndex = 5;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(235, 12);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(553, 266);
			dataGridView1.TabIndex = 6;
			dataGridView1.CellClick += dataGridView1_CellClick;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// lblsecilen
			// 
			lblsecilen.AutoSize = true;
			lblsecilen.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
			lblsecilen.Location = new Point(244, 299);
			lblsecilen.Name = "lblsecilen";
			lblsecilen.Size = new Size(0, 32);
			lblsecilen.TabIndex = 7;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lblsecilen);
			Controls.Add(dataGridView1);
			Controls.Add(txtmodel);
			Controls.Add(txtmarka);
			Controls.Add(btnguncelle);
			Controls.Add(btnsil);
			Controls.Add(btnekle);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnekle;
		private Button btnsil;
		private Button btnguncelle;
		private TextBox txtmarka;
		private TextBox txtmodel;
		private DataGridView dataGridView1;
		private Label lblsecilen;
	}
}
