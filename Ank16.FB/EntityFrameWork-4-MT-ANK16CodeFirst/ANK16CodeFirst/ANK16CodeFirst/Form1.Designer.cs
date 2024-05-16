namespace ANK16CodeFirst
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
            dgvArabalar = new DataGridView();
            label1 = new Label();
            txtMarka = new TextBox();
            txtModel = new TextBox();
            label2 = new Label();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            lblSecilen = new Label();
            label3 = new Label();
            cmbKisiler = new ComboBox();
            cmbPlakalar = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvArabalar).BeginInit();
            SuspendLayout();
            // 
            // dgvArabalar
            // 
            dgvArabalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArabalar.Location = new Point(314, 118);
            dgvArabalar.Name = "dgvArabalar";
            dgvArabalar.RowHeadersWidth = 62;
            dgvArabalar.Size = new Size(795, 296);
            dgvArabalar.TabIndex = 0;
            dgvArabalar.CellClick += dgvArabalar_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 118);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 1;
            label1.Text = "Marka:";
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(115, 118);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(150, 31);
            txtMarka.TabIndex = 2;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(115, 178);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(150, 31);
            txtModel.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 178);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 3;
            label2.Text = "Model:";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(393, 480);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(161, 64);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(617, 480);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(161, 64);
            btnSil.TabIndex = 6;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(853, 480);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(161, 64);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // lblSecilen
            // 
            lblSecilen.Location = new Point(471, 24);
            lblSecilen.Name = "lblSecilen";
            lblSecilen.Size = new Size(453, 63);
            lblSecilen.TabIndex = 8;
            lblSecilen.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 242);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 9;
            label3.Text = "Kişi:";
            // 
            // cmbKisiler
            // 
            cmbKisiler.FormattingEnabled = true;
            cmbKisiler.Location = new Point(116, 242);
            cmbKisiler.Name = "cmbKisiler";
            cmbKisiler.Size = new Size(149, 33);
            cmbKisiler.TabIndex = 10;
            // 
            // cmbPlakalar
            // 
            cmbPlakalar.FormattingEnabled = true;
            cmbPlakalar.Location = new Point(115, 314);
            cmbPlakalar.Name = "cmbPlakalar";
            cmbPlakalar.Size = new Size(149, 33);
            cmbPlakalar.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 314);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 11;
            label4.Text = "Plaka:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 618);
            Controls.Add(cmbPlakalar);
            Controls.Add(label4);
            Controls.Add(cmbKisiler);
            Controls.Add(label3);
            Controls.Add(lblSecilen);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(txtModel);
            Controls.Add(label2);
            Controls.Add(txtMarka);
            Controls.Add(label1);
            Controls.Add(dgvArabalar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvArabalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvArabalar;
        private Label label1;
        private TextBox txtMarka;
        private TextBox txtModel;
        private Label label2;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private Label lblSecilen;
        private Label label3;
        private ComboBox cmbKisiler;
        private ComboBox cmbPlakalar;
        private Label label4;
    }
}
