namespace WinFormsApp_2
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
			components = new System.ComponentModel.Container();
			listBox1 = new ListBox();
			timer1 = new System.Windows.Forms.Timer(components);
			btBaslat = new Button();
			listBox2 = new ListBox();
			listBox3 = new ListBox();
			btDurdur = new Button();
			SuspendLayout();
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Location = new Point(29, 73);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(136, 259);
			listBox1.TabIndex = 0;
			listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
			// 
			// timer1
			// 
			timer1.Interval = 1000;
			timer1.Tick += timer1_Tick;
			// 
			// btBaslat
			// 
			btBaslat.Location = new Point(675, 357);
			btBaslat.Name = "btBaslat";
			btBaslat.Size = new Size(113, 45);
			btBaslat.TabIndex = 1;
			btBaslat.Text = "Başlat";
			btBaslat.UseVisualStyleBackColor = true;
			btBaslat.Click += btBaslat_Click;
			// 
			// listBox2
			// 
			listBox2.FormattingEnabled = true;
			listBox2.ItemHeight = 15;
			listBox2.Location = new Point(244, 73);
			listBox2.Name = "listBox2";
			listBox2.Size = new Size(143, 259);
			listBox2.TabIndex = 2;
			listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
			// 
			// listBox3
			// 
			listBox3.FormattingEnabled = true;
			listBox3.ItemHeight = 15;
			listBox3.Location = new Point(472, 73);
			listBox3.Name = "listBox3";
			listBox3.Size = new Size(145, 259);
			listBox3.TabIndex = 3;
			listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
			// 
			// btDurdur
			// 
			btDurdur.Location = new Point(569, 357);
			btDurdur.Name = "btDurdur";
			btDurdur.Size = new Size(100, 45);
			btDurdur.TabIndex = 4;
			btDurdur.Text = "Durdur";
			btDurdur.UseVisualStyleBackColor = true;
			btDurdur.Click += button1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btDurdur);
			Controls.Add(listBox3);
			Controls.Add(listBox2);
			Controls.Add(btBaslat);
			Controls.Add(listBox1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
		}

		#endregion

		private ListBox listBox1;
		private System.Windows.Forms.Timer timer1;
		private Button btBaslat;
		private ListBox listBox2;
		private ListBox listBox3;
		private Button btDurdur;
	}
}
