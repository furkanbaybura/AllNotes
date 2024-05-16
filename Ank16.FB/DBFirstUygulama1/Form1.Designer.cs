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
			btngncl = new Button();
			lblscm = new Label();
			btnshwemply = new Button();
			dgvemply = new DataGridView();
			btnshwfirstemploye = new Button();
			dgvfirstempl = new DataGridView();
			dgvfirsta = new DataGridView();
			dgvina = new DataGridView();
			btnilkharfa = new Button();
			btnaiceren = new Button();
			((System.ComponentModel.ISupportInitialize)dgvCmpny).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvemply).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvfirstempl).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvfirsta).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvina).BeginInit();
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
			dgvCmpny.Location = new Point(221, 361);
			dgvCmpny.Name = "dgvCmpny";
			dgvCmpny.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvCmpny.Size = new Size(567, 88);
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
			// btngncl
			// 
			btngncl.Location = new Point(29, 331);
			btngncl.Name = "btngncl";
			btngncl.Size = new Size(148, 45);
			btngncl.TabIndex = 5;
			btngncl.Text = "Update";
			btngncl.UseVisualStyleBackColor = true;
			btngncl.Click += btngncl_Click;
			// 
			// lblscm
			// 
			lblscm.AutoSize = true;
			lblscm.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblscm.Location = new Point(12, 9);
			lblscm.Name = "lblscm";
			lblscm.Size = new Size(0, 32);
			lblscm.TabIndex = 6;
			// 
			// btnshwemply
			// 
			btnshwemply.Location = new Point(250, 12);
			btnshwemply.Name = "btnshwemply";
			btnshwemply.Size = new Size(141, 52);
			btnshwemply.TabIndex = 7;
			btnshwemply.Text = "Show Employee";
			btnshwemply.UseVisualStyleBackColor = true;
			btnshwemply.Click += btnshwemply_Click;
			// 
			// dgvemply
			// 
			dgvemply.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvemply.Location = new Point(426, 9);
			dgvemply.Name = "dgvemply";
			dgvemply.Size = new Size(362, 109);
			dgvemply.TabIndex = 8;
			// 
			// btnshwfirstemploye
			// 
			btnshwfirstemploye.Location = new Point(250, 113);
			btnshwfirstemploye.Name = "btnshwfirstemploye";
			btnshwfirstemploye.Size = new Size(141, 54);
			btnshwfirstemploye.TabIndex = 9;
			btnshwfirstemploye.Text = "Show First Employee";
			btnshwfirstemploye.UseVisualStyleBackColor = true;
			btnshwfirstemploye.Click += btnshwfirstemploye_Click;
			// 
			// dgvfirstempl
			// 
			dgvfirstempl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvfirstempl.Location = new Point(436, 127);
			dgvfirstempl.Name = "dgvfirstempl";
			dgvfirstempl.Size = new Size(362, 54);
			dgvfirstempl.TabIndex = 10;
			// 
			// dgvfirsta
			// 
			dgvfirsta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvfirsta.Location = new Point(436, 198);
			dgvfirsta.Name = "dgvfirsta";
			dgvfirsta.Size = new Size(362, 54);
			dgvfirsta.TabIndex = 11;
			// 
			// dgvina
			// 
			dgvina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvina.Location = new Point(436, 272);
			dgvina.Name = "dgvina";
			dgvina.Size = new Size(362, 54);
			dgvina.TabIndex = 12;
			// 
			// btnilkharfa
			// 
			btnilkharfa.Location = new Point(250, 186);
			btnilkharfa.Name = "btnilkharfa";
			btnilkharfa.Size = new Size(141, 54);
			btnilkharfa.TabIndex = 14;
			btnilkharfa.Text = "First A";
			btnilkharfa.UseVisualStyleBackColor = true;
			btnilkharfa.Click += btnilkharfa_Click;
			// 
			// btnaiceren
			// 
			btnaiceren.Location = new Point(250, 272);
			btnaiceren.Name = "btnaiceren";
			btnaiceren.Size = new Size(141, 54);
			btnaiceren.TabIndex = 15;
			btnaiceren.Text = "Employee In 'A'";
			btnaiceren.UseVisualStyleBackColor = true;
			btnaiceren.Click += btnaiceren_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnaiceren);
			Controls.Add(btnilkharfa);
			Controls.Add(dgvina);
			Controls.Add(dgvfirsta);
			Controls.Add(dgvfirstempl);
			Controls.Add(btnshwfirstemploye);
			Controls.Add(dgvemply);
			Controls.Add(btnshwemply);
			Controls.Add(lblscm);
			Controls.Add(btngncl);
			Controls.Add(txtdlt);
			Controls.Add(dgvCmpny);
			Controls.Add(txtcmpy);
			Controls.Add(txtid);
			Controls.Add(btnekle);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dgvCmpny).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvemply).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvfirstempl).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvfirsta).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvina).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnekle;
		private TextBox txtid;
		private TextBox txtcmpy;
		private DataGridView dgvCmpny;
		private Button txtdlt;
		private Button btngncl;
		private Label lblscm;
		private Button btnshwemply;
		private DataGridView dgvemply;
		private Button btnshwfirstemploye;
		private DataGridView dgvfirstempl;
		private DataGridView dgvfirsta;
		private DataGridView dgvina;
		private Button btnilkharfa;
		private Button btnaiceren;
	}
}
