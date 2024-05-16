namespace DBFirstUygulama1
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
			txtid = new TextBox();
			txtcmpy = new TextBox();
			dgvCmpny = new DataGridView();
			txtdlt = new Button();
			((System.ComponentModel.ISupportInitialize)dgvCmpny).BeginInit();
			SuspendLayout();
			// 
			// btnekle
			// 
			btnekle.Location = new Point(29, 164);
			btnekle.Name = "btnekle";
			btnekle.Size = new Size(148, 50);
			btnekle.TabIndex = 0;
			btnekle.Text = "Add Person";
			btnekle.UseVisualStyleBackColor = true;
			btnekle.Click += btnekle_Click;
			// 
			// txtid
			// 
			txtid.Location = new Point(29, 46);
			txtid.Name = "txtid";
			txtid.PlaceholderText = "ID";
			txtid.Size = new Size(109, 23);
			txtid.TabIndex = 1;
			txtid.TextChanged += txtid_TextChanged;
			// 
			// txtcmpy
			// 
			txtcmpy.Location = new Point(29, 95);
			txtcmpy.Name = "txtcmpy";
			txtcmpy.PlaceholderText = "Company Name";
			txtcmpy.Size = new Size(154, 23);
			txtcmpy.TabIndex = 2;
			// 
			// dgvCmpny
			// 
			dgvCmpny.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvCmpny.Location = new Point(221, 184);
			dgvCmpny.Name = "dgvCmpny";
			dgvCmpny.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvCmpny.Size = new Size(567, 263);
			dgvCmpny.TabIndex = 3;
			dgvCmpny.CellClick += dgvCmpny_CellClick;
			dgvCmpny.CellContentClick += dataGridView1_CellContentClick;
			// 
			// txtdlt
			// 
			txtdlt.Location = new Point(29, 238);
			txtdlt.Name = "txtdlt";
			txtdlt.Size = new Size(148, 50);
			txtdlt.TabIndex = 4;
			txtdlt.Text = "Delete";
			txtdlt.UseVisualStyleBackColor = true;
			txtdlt.Click += txtdlt_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(txtdlt);
			Controls.Add(dgvCmpny);
			Controls.Add(txtcmpy);
			Controls.Add(txtid);
			Controls.Add(btnekle);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dgvCmpny).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnekle;
		private TextBox txtid;
		private TextBox txtcmpy;
		private DataGridView dgvCmpny;
		private Button txtdlt;
	}
}
