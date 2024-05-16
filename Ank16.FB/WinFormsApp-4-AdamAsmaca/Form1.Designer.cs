namespace WinFormsApp_4_AdamAsmaca
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
			btOnay = new Button();
			textBox1 = new TextBox();
			tb1 = new Label();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			SuspendLayout();
			// 
			// btOnay
			// 
			btOnay.Location = new Point(628, 341);
			btOnay.Name = "btOnay";
			btOnay.Size = new Size(107, 57);
			btOnay.TabIndex = 0;
			btOnay.Text = "Onayla";
			btOnay.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(126, 85);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(129, 23);
			textBox1.TabIndex = 1;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// tb1
			// 
			tb1.AutoSize = true;
			tb1.Font = new Font("Segoe UI", 100F, FontStyle.Regular, GraphicsUnit.Point);
			tb1.Location = new Point(126, 111);
			tb1.Name = "tb1";
			tb1.Size = new Size(129, 177);
			tb1.TabIndex = 2;
			tb1.Text = "-";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(272, 85);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(129, 23);
			textBox2.TabIndex = 3;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(420, 85);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(129, 23);
			textBox3.TabIndex = 4;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(567, 85);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(129, 23);
			textBox4.TabIndex = 5;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 100F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(272, 111);
			label1.Name = "label1";
			label1.Size = new Size(129, 177);
			label1.TabIndex = 6;
			label1.Text = "-";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 100F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(420, 111);
			label2.Name = "label2";
			label2.Size = new Size(129, 177);
			label2.TabIndex = 7;
			label2.Text = "-";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 100F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(567, 111);
			label3.Name = "label3";
			label3.Size = new Size(129, 177);
			label3.TabIndex = 8;
			label3.Text = "-";
			// 
			// label4
			// 
			label4.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(12, 362);
			label4.Name = "label4";
			label4.Size = new Size(230, 79);
			label4.TabIndex = 9;
			label4.Text = "Kalan Can : ";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(tb1);
			Controls.Add(textBox1);
			Controls.Add(btOnay);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btOnay;
		private TextBox textBox1;
		private Label tb1;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
	}
}
