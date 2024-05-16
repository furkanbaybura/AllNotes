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
            cmbMuhendisler = new ComboBox();
            label5 = new Label();
            btnMArabaEkle = new Button();
            btnMarabaSil = new Button();
            label6 = new Label();
            cmbArabalar = new ComboBox();
            dgvMuhendisArabalar = new DataGridView();
            txtPNo = new TextBox();
            label7 = new Label();
            dgvPlakalar = new DataGridView();
            btnPlakaGuncelle = new Button();
            btnPlakaSil = new Button();
            btnPlakaEkle = new Button();
            lblSeciliPlaka = new Label();
            lblSecilenKisi = new Label();
            btnKisiGuncelle = new Button();
            btnKisiSil = new Button();
            btnKisiEkle = new Button();
            dgvKisiler = new DataGridView();
            txtKisiAd = new TextBox();
            label9 = new Label();
            txtKisiSoyad = new TextBox();
            label10 = new Label();
            txtMuhendisSoyad = new TextBox();
            label8 = new Label();
            lblSecilenMuhendis = new Label();
            btnMuhendisGuncelle = new Button();
            btnMuhendisSil = new Button();
            btnMuhendisEkle = new Button();
            dgvMuhebndisler = new DataGridView();
            txtMuhendisAd = new TextBox();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvArabalar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMuhendisArabalar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlakalar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKisiler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMuhebndisler).BeginInit();
            SuspendLayout();
            // 
            // dgvArabalar
            // 
            dgvArabalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArabalar.Location = new Point(178, 66);
            dgvArabalar.Margin = new Padding(2);
            dgvArabalar.Name = "dgvArabalar";
            dgvArabalar.RowHeadersWidth = 62;
            dgvArabalar.Size = new Size(427, 178);
            dgvArabalar.TabIndex = 0;
            dgvArabalar.CellClick += dgvArabalar_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 66);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Marka:";
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(67, 66);
            txtMarka.Margin = new Padding(2);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(106, 23);
            txtMarka.TabIndex = 2;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(67, 102);
            txtModel.Margin = new Padding(2);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(106, 23);
            txtModel.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 102);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Model:";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(170, 279);
            btnEkle.Margin = new Padding(2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(113, 38);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(327, 279);
            btnSil.Margin = new Padding(2);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(113, 38);
            btnSil.TabIndex = 6;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(492, 279);
            btnGuncelle.Margin = new Padding(2);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(113, 38);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // lblSecilen
            // 
            lblSecilen.Location = new Point(288, 9);
            lblSecilen.Margin = new Padding(2, 0, 2, 0);
            lblSecilen.Name = "lblSecilen";
            lblSecilen.Size = new Size(317, 38);
            lblSecilen.TabIndex = 8;
            lblSecilen.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 140);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 9;
            label3.Text = "Kişi:";
            // 
            // cmbKisiler
            // 
            cmbKisiler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKisiler.FormattingEnabled = true;
            cmbKisiler.Location = new Point(68, 140);
            cmbKisiler.Margin = new Padding(2);
            cmbKisiler.Name = "cmbKisiler";
            cmbKisiler.Size = new Size(106, 23);
            cmbKisiler.TabIndex = 10;
            // 
            // cmbPlakalar
            // 
            cmbPlakalar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlakalar.FormattingEnabled = true;
            cmbPlakalar.Location = new Point(67, 183);
            cmbPlakalar.Margin = new Padding(2);
            cmbPlakalar.Name = "cmbPlakalar";
            cmbPlakalar.Size = new Size(106, 23);
            cmbPlakalar.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 183);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 11;
            label4.Text = "Plaka:";
            // 
            // cmbMuhendisler
            // 
            cmbMuhendisler.FormattingEnabled = true;
            cmbMuhendisler.Location = new Point(722, 205);
            cmbMuhendisler.Name = "cmbMuhendisler";
            cmbMuhendisler.Size = new Size(121, 23);
            cmbMuhendisler.TabIndex = 13;
            cmbMuhendisler.SelectedIndexChanged += cmbMuhendisler_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(637, 213);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 15;
            label5.Text = "Mühendis:";
            // 
            // btnMArabaEkle
            // 
            btnMArabaEkle.Location = new Point(658, 279);
            btnMArabaEkle.Margin = new Padding(2);
            btnMArabaEkle.Name = "btnMArabaEkle";
            btnMArabaEkle.Size = new Size(185, 38);
            btnMArabaEkle.TabIndex = 17;
            btnMArabaEkle.Text = "EKLE";
            btnMArabaEkle.UseVisualStyleBackColor = true;
            btnMArabaEkle.Click += btnMArabaEkle_Click;
            // 
            // btnMarabaSil
            // 
            btnMarabaSil.Location = new Point(877, 279);
            btnMarabaSil.Margin = new Padding(2);
            btnMarabaSil.Name = "btnMarabaSil";
            btnMarabaSil.Size = new Size(185, 38);
            btnMarabaSil.TabIndex = 18;
            btnMarabaSil.Text = "ÇIKAR";
            btnMarabaSil.UseVisualStyleBackColor = true;
            btnMarabaSil.Click += btnMarabaSil_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(877, 208);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 20;
            label6.Text = "Araç:";
            // 
            // cmbArabalar
            // 
            cmbArabalar.FormattingEnabled = true;
            cmbArabalar.Location = new Point(941, 205);
            cmbArabalar.Name = "cmbArabalar";
            cmbArabalar.Size = new Size(121, 23);
            cmbArabalar.TabIndex = 19;
            // 
            // dgvMuhendisArabalar
            // 
            dgvMuhendisArabalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMuhendisArabalar.Location = new Point(658, 11);
            dgvMuhendisArabalar.Margin = new Padding(2);
            dgvMuhendisArabalar.Name = "dgvMuhendisArabalar";
            dgvMuhendisArabalar.RowHeadersWidth = 62;
            dgvMuhendisArabalar.Size = new Size(427, 178);
            dgvMuhendisArabalar.TabIndex = 21;
            // 
            // txtPNo
            // 
            txtPNo.Location = new Point(85, 352);
            txtPNo.Margin = new Padding(2);
            txtPNo.Name = "txtPNo";
            txtPNo.Size = new Size(106, 23);
            txtPNo.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 352);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 22;
            label7.Text = "Plaka:";
            // 
            // dgvPlakalar
            // 
            dgvPlakalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlakalar.Location = new Point(11, 390);
            dgvPlakalar.Margin = new Padding(2);
            dgvPlakalar.Name = "dgvPlakalar";
            dgvPlakalar.RowHeadersWidth = 62;
            dgvPlakalar.Size = new Size(429, 137);
            dgvPlakalar.TabIndex = 24;
            dgvPlakalar.CellClick += dgvPlakalar_CellClick;
            // 
            // btnPlakaGuncelle
            // 
            btnPlakaGuncelle.Location = new Point(327, 547);
            btnPlakaGuncelle.Margin = new Padding(2);
            btnPlakaGuncelle.Name = "btnPlakaGuncelle";
            btnPlakaGuncelle.Size = new Size(113, 38);
            btnPlakaGuncelle.TabIndex = 27;
            btnPlakaGuncelle.Text = "GÜNCELLE";
            btnPlakaGuncelle.UseVisualStyleBackColor = true;
            btnPlakaGuncelle.Click += btnPlakaGuncelle_Click;
            // 
            // btnPlakaSil
            // 
            btnPlakaSil.Location = new Point(162, 547);
            btnPlakaSil.Margin = new Padding(2);
            btnPlakaSil.Name = "btnPlakaSil";
            btnPlakaSil.Size = new Size(113, 38);
            btnPlakaSil.TabIndex = 26;
            btnPlakaSil.Text = "SİL";
            btnPlakaSil.UseVisualStyleBackColor = true;
            btnPlakaSil.Click += btnPlakaSil_Click;
            // 
            // btnPlakaEkle
            // 
            btnPlakaEkle.Location = new Point(5, 547);
            btnPlakaEkle.Margin = new Padding(2);
            btnPlakaEkle.Name = "btnPlakaEkle";
            btnPlakaEkle.Size = new Size(113, 38);
            btnPlakaEkle.TabIndex = 25;
            btnPlakaEkle.Text = "EKLE";
            btnPlakaEkle.UseVisualStyleBackColor = true;
            btnPlakaEkle.Click += btnPlakaEkle_Click;
            // 
            // lblSeciliPlaka
            // 
            lblSeciliPlaka.Location = new Point(213, 350);
            lblSeciliPlaka.Margin = new Padding(2, 0, 2, 0);
            lblSeciliPlaka.Name = "lblSeciliPlaka";
            lblSeciliPlaka.Size = new Size(196, 38);
            lblSeciliPlaka.TabIndex = 28;
            lblSeciliPlaka.Text = "label3";
            // 
            // lblSecilenKisi
            // 
            lblSecilenKisi.Location = new Point(889, 371);
            lblSecilenKisi.Margin = new Padding(2, 0, 2, 0);
            lblSecilenKisi.Name = "lblSecilenKisi";
            lblSecilenKisi.Size = new Size(196, 25);
            lblSecilenKisi.TabIndex = 35;
            lblSecilenKisi.Text = "label3";
            // 
            // btnKisiGuncelle
            // 
            btnKisiGuncelle.Location = new Point(835, 563);
            btnKisiGuncelle.Margin = new Padding(2);
            btnKisiGuncelle.Name = "btnKisiGuncelle";
            btnKisiGuncelle.Size = new Size(113, 38);
            btnKisiGuncelle.TabIndex = 34;
            btnKisiGuncelle.Text = "GÜNCELLE";
            btnKisiGuncelle.UseVisualStyleBackColor = true;
            btnKisiGuncelle.Click += btnKisiGuncelle_Click;
            // 
            // btnKisiSil
            // 
            btnKisiSil.Location = new Point(670, 563);
            btnKisiSil.Margin = new Padding(2);
            btnKisiSil.Name = "btnKisiSil";
            btnKisiSil.Size = new Size(113, 38);
            btnKisiSil.TabIndex = 33;
            btnKisiSil.Text = "SİL";
            btnKisiSil.UseVisualStyleBackColor = true;
            btnKisiSil.Click += btnKisiSil_Click;
            // 
            // btnKisiEkle
            // 
            btnKisiEkle.Location = new Point(513, 563);
            btnKisiEkle.Margin = new Padding(2);
            btnKisiEkle.Name = "btnKisiEkle";
            btnKisiEkle.Size = new Size(113, 38);
            btnKisiEkle.TabIndex = 32;
            btnKisiEkle.Text = "EKLE";
            btnKisiEkle.UseVisualStyleBackColor = true;
            btnKisiEkle.Click += btnKisiEkle_Click;
            // 
            // dgvKisiler
            // 
            dgvKisiler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKisiler.Location = new Point(519, 406);
            dgvKisiler.Margin = new Padding(2);
            dgvKisiler.Name = "dgvKisiler";
            dgvKisiler.RowHeadersWidth = 62;
            dgvKisiler.Size = new Size(494, 137);
            dgvKisiler.TabIndex = 31;
            dgvKisiler.CellClick += dgvKisiler_CellClick;
            // 
            // txtKisiAd
            // 
            txtKisiAd.Location = new Point(593, 368);
            txtKisiAd.Margin = new Padding(2);
            txtKisiAd.Name = "txtKisiAd";
            txtKisiAd.Size = new Size(106, 23);
            txtKisiAd.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(532, 368);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(25, 15);
            label9.TabIndex = 29;
            label9.Text = "Ad:";
            // 
            // txtKisiSoyad
            // 
            txtKisiSoyad.Location = new Point(767, 370);
            txtKisiSoyad.Margin = new Padding(2);
            txtKisiSoyad.Name = "txtKisiSoyad";
            txtKisiSoyad.Size = new Size(106, 23);
            txtKisiSoyad.TabIndex = 37;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(706, 370);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 36;
            label10.Text = "Soyad:";
            // 
            // txtMuhendisSoyad
            // 
            txtMuhendisSoyad.Location = new Point(321, 633);
            txtMuhendisSoyad.Margin = new Padding(2);
            txtMuhendisSoyad.Name = "txtMuhendisSoyad";
            txtMuhendisSoyad.Size = new Size(106, 23);
            txtMuhendisSoyad.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(219, 638);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(98, 15);
            label8.TabIndex = 45;
            label8.Text = "Mühendis Soyad:";
            // 
            // lblSecilenMuhendis
            // 
            lblSecilenMuhendis.Location = new Point(445, 633);
            lblSecilenMuhendis.Margin = new Padding(2, 0, 2, 0);
            lblSecilenMuhendis.Name = "lblSecilenMuhendis";
            lblSecilenMuhendis.Size = new Size(196, 25);
            lblSecilenMuhendis.TabIndex = 44;
            lblSecilenMuhendis.Text = "label3";
            // 
            // btnMuhendisGuncelle
            // 
            btnMuhendisGuncelle.Location = new Point(327, 825);
            btnMuhendisGuncelle.Margin = new Padding(2);
            btnMuhendisGuncelle.Name = "btnMuhendisGuncelle";
            btnMuhendisGuncelle.Size = new Size(113, 38);
            btnMuhendisGuncelle.TabIndex = 43;
            btnMuhendisGuncelle.Text = "GÜNCELLE";
            btnMuhendisGuncelle.UseVisualStyleBackColor = true;
            btnMuhendisGuncelle.Click += btnMuhendisGuncelle_Click;
            // 
            // btnMuhendisSil
            // 
            btnMuhendisSil.Location = new Point(162, 825);
            btnMuhendisSil.Margin = new Padding(2);
            btnMuhendisSil.Name = "btnMuhendisSil";
            btnMuhendisSil.Size = new Size(113, 38);
            btnMuhendisSil.TabIndex = 42;
            btnMuhendisSil.Text = "SİL";
            btnMuhendisSil.UseVisualStyleBackColor = true;
            btnMuhendisSil.Click += btnMuhendisSil_Click;
            // 
            // btnMuhendisEkle
            // 
            btnMuhendisEkle.Location = new Point(5, 825);
            btnMuhendisEkle.Margin = new Padding(2);
            btnMuhendisEkle.Name = "btnMuhendisEkle";
            btnMuhendisEkle.Size = new Size(113, 38);
            btnMuhendisEkle.TabIndex = 41;
            btnMuhendisEkle.Text = "EKLE";
            btnMuhendisEkle.UseVisualStyleBackColor = true;
            btnMuhendisEkle.Click += btnMuhendisEkle_Click;
            // 
            // dgvMuhebndisler
            // 
            dgvMuhebndisler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMuhebndisler.Location = new Point(11, 668);
            dgvMuhebndisler.Margin = new Padding(2);
            dgvMuhebndisler.Name = "dgvMuhebndisler";
            dgvMuhebndisler.RowHeadersWidth = 62;
            dgvMuhebndisler.Size = new Size(494, 137);
            dgvMuhebndisler.TabIndex = 40;
            dgvMuhebndisler.CellClick += dgvMuhebndisler_CellClick;
            // 
            // txtMuhendisAd
            // 
            txtMuhendisAd.Location = new Point(109, 630);
            txtMuhendisAd.Margin = new Padding(2);
            txtMuhendisAd.Name = "txtMuhendisAd";
            txtMuhendisAd.Size = new Size(106, 23);
            txtMuhendisAd.TabIndex = 39;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(24, 630);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(81, 15);
            label12.TabIndex = 38;
            label12.Text = "Mühendis Ad:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 881);
            Controls.Add(txtMuhendisSoyad);
            Controls.Add(label8);
            Controls.Add(lblSecilenMuhendis);
            Controls.Add(btnMuhendisGuncelle);
            Controls.Add(btnMuhendisSil);
            Controls.Add(btnMuhendisEkle);
            Controls.Add(dgvMuhebndisler);
            Controls.Add(txtMuhendisAd);
            Controls.Add(label12);
            Controls.Add(txtKisiSoyad);
            Controls.Add(label10);
            Controls.Add(lblSecilenKisi);
            Controls.Add(btnKisiGuncelle);
            Controls.Add(btnKisiSil);
            Controls.Add(btnKisiEkle);
            Controls.Add(dgvKisiler);
            Controls.Add(txtKisiAd);
            Controls.Add(label9);
            Controls.Add(lblSeciliPlaka);
            Controls.Add(btnPlakaGuncelle);
            Controls.Add(btnPlakaSil);
            Controls.Add(btnPlakaEkle);
            Controls.Add(dgvPlakalar);
            Controls.Add(txtPNo);
            Controls.Add(label7);
            Controls.Add(dgvMuhendisArabalar);
            Controls.Add(label6);
            Controls.Add(cmbArabalar);
            Controls.Add(btnMarabaSil);
            Controls.Add(btnMArabaEkle);
            Controls.Add(label5);
            Controls.Add(cmbMuhendisler);
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
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvArabalar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMuhendisArabalar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlakalar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKisiler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMuhebndisler).EndInit();
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
        private ComboBox cmbMuhendisler;
        private Label label5;
        private Button btnMArabaEkle;
        private Button btnMarabaSil;
        private Label label6;
        private ComboBox cmbArabalar;
        private DataGridView dgvMuhendisArabalar;
        private TextBox txtPNo;
        private Label label7;
        private DataGridView dgvPlakalar;
        private Button btnPlakaGuncelle;
        private Button btnPlakaSil;
        private Button btnPlakaEkle;
        private Label lblSeciliPlaka;
        private Label lblSecilenKisi;
        private Button btnKisiGuncelle;
        private Button btnKisiSil;
        private Button btnKisiEkle;
        private DataGridView dgvKisiler;
        private TextBox txtKisiAd;
        private Label label9;
        private TextBox txtKisiSoyad;
        private Label label10;
        private TextBox txtMuhendisSoyad;
        private Label label8;
        private Label lblSecilenMuhendis;
        private Button btnMuhendisGuncelle;
        private Button btnMuhendisSil;
        private Button btnMuhendisEkle;
        private DataGridView dgvMuhebndisler;
        private TextBox txtMuhendisAd;
        private Label label12;
    }
}
