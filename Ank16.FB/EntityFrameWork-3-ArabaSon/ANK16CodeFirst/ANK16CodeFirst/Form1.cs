using ANK16CodeFirst.Context;
using ANK16CodeFirst.Entitites;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace ANK16CodeFirst
{
    public partial class Form1 : Form
    {
        UygulamaDbContext db = new UygulamaDbContext();

        Araba secilenAraba;
        Muhendis seciliMuhendis;
        Plaka seciliPlaka;
        Kisi secilenKisi;
        Muhendis secilenMuhendis;

        public Form1()
        {
            InitializeComponent();
            lblSecilen.Text = "Seçilen araba: ";
            ArabalariGoster();
            PlakalariGetir();
            KisileriGetir();
            MuhendisleriGetir();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (db.Arabalar.Any(a => a.LicenseNumber == ((Plaka)(cmbPlakalar.SelectedItem)).Id))
            {
                MessageBox.Show("Bu plakaya araba vardır.Lütfen başka plaka seçiniz.");
                return;
            }

            Araba araba = new Araba();
            araba.Marka = txtMarka.Text;
            araba.Model = txtModel.Text;

            araba.LicenseNumber = ((Plaka)(cmbPlakalar.SelectedItem)).Id;
            araba.PersonNo = ((Kisi)(cmbKisiler.SelectedItem)).KisiTekilAnahtar;

            db.Arabalar.Add(araba);
            db.SaveChanges();

            MessageBox.Show("Araba eklenmiştir");
            ArabalariGoster();
        }
        private void MuhendisleriGetir()
        {
            var muhendisler = db.Muhendisler.Include(m => m.Arabalar).ToList();
            cmbMuhendisler.DataSource = muhendisler;
            dgvMuhebndisler.DataSource = muhendisler;

        }

        private void PlakalariGetir()
        {
            dgvPlakalar.DataSource = db.Plakalar.ToList();
            cmbPlakalar.DataSource = db.Plakalar.ToList();
        }

        private void KisileriGetir()
        {
            var tumKisiler = db.Kisiler.ToList();
            cmbKisiler.DataSource = tumKisiler;
            dgvKisiler.DataSource = tumKisiler;
        }

        private void ArabalariGoster()
        {
            var tumArabalar = db.Arabalar.Include(a => a.Plaka).ToList();
            dgvArabalar.DataSource = tumArabalar;
            cmbArabalar.DataSource = tumArabalar;
        }

        private void dgvArabalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenAraba = (Araba)dgvArabalar.SelectedRows[0].DataBoundItem;
            lblSecilen.Text = "Seçilen araba: " + secilenAraba.Marka + " " + secilenAraba.Model;
            txtMarka.Text = secilenAraba.Marka;
            txtModel.Text = secilenAraba.Model;

            cmbKisiler.SelectedItem = secilenAraba.Kisi;
            cmbPlakalar.SelectedItem = secilenAraba.Plaka;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenAraba != null)
            {
                secilenAraba.Marka = txtMarka.Text;
                secilenAraba.Model = txtModel.Text;

                secilenAraba.LicenseNumber = ((Plaka)(cmbPlakalar.SelectedItem)).Id;
                secilenAraba.PersonNo = ((Kisi)(cmbKisiler.SelectedItem)).KisiTekilAnahtar;

                db.SaveChanges();

                MessageBox.Show("Araba güncellenmiştir");
                ArabalariGoster();

                txtMarka.Text = "";
                txtModel.Text = "";

                secilenAraba = null;
                lblSecilen.Text = "Seçilen araba: ";

            }
            else
                MessageBox.Show("Güncellemek için araba seçiniz!");

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenAraba != null)
            {
                db.Arabalar.Remove(secilenAraba);
                db.SaveChanges();

                MessageBox.Show("Araba siliniştir");
                ArabalariGoster();

                txtMarka.Text = "";
                txtModel.Text = "";

                secilenAraba = null;
                lblSecilen.Text = "Seçilen araba: ";

            }
            else
                MessageBox.Show("Silmek için araba seçiniz!");
        }

        private void cmbMuhendisler_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliMuhendis = ((Muhendis)(cmbMuhendisler.SelectedItem));
            dgvMuhendisArabalar.DataSource = seciliMuhendis.Arabalar.ToList();
        }

        private void btnMArabaEkle_Click(object sender, EventArgs e)
        {
            var secilenMuhendis = ((Muhendis)(cmbMuhendisler.SelectedItem));

            secilenMuhendis.Arabalar.Add((Araba)(cmbArabalar.SelectedItem));



            db.SaveChanges();
            dgvMuhendisArabalar.DataSource = seciliMuhendis.Arabalar.ToList();


        }

        private void btnMarabaSil_Click(object sender, EventArgs e)
        {
            var secilenMuhendis = ((Muhendis)(cmbMuhendisler.SelectedItem));

            secilenMuhendis.Arabalar.Remove((Araba)(cmbArabalar.SelectedItem));

            db.SaveChanges();
            dgvMuhendisArabalar.DataSource = seciliMuhendis.Arabalar.ToList();
        }

        private void btnPlakaEkle_Click(object sender, EventArgs e)
        {
            if (db.Plakalar.Any(a => a.Numarasi == txtPNo.Text))
            {
                MessageBox.Show("Bu plakaya vardır.Lütfen başka numara yazınız.");
                return;
            }

            Plaka plaka = new Plaka();
            plaka.Numarasi = txtPNo.Text;

            db.Plakalar.Add(plaka);
            db.SaveChanges();

            MessageBox.Show("Plaka eklenmiştir");
            PlakalariGetir();
        }

        private void btnPlakaSil_Click(object sender, EventArgs e)
        {
            if (seciliPlaka != null)
            {
                db.Plakalar.Remove(seciliPlaka);
                db.SaveChanges();
                MessageBox.Show("Plaka Silinmiştir");
                PlakalariGetir();
                seciliPlaka = null;
                lblSeciliPlaka.Text = "Seçilen Plaka:";

            }
            else
                MessageBox.Show("Plaka seçiniz");
        }

        private void dgvPlakalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seciliPlaka = (Plaka)(dgvPlakalar.SelectedRows[0].DataBoundItem);
            lblSeciliPlaka.Text = "Seçilen Plaka: " + seciliPlaka.Numarasi;
        }

        private void btnPlakaGuncelle_Click(object sender, EventArgs e)
        {

            if (seciliPlaka != null)
            {
                seciliPlaka.Numarasi = txtPNo.Text;


                db.SaveChanges();

                MessageBox.Show("Plaka güncellenmiştir");
                PlakalariGetir();

                seciliPlaka = null;
                lblSeciliPlaka.Text = "Seçilen plaka: ";

            }
            else
                MessageBox.Show("Güncellemek için plaka seçiniz!");

        }

        private void btnKisiEkle_Click(object sender, EventArgs e)
        {


            Kisi kisi = new Kisi();
            kisi.Ad = txtKisiAd.Text;
            kisi.Soyad = txtKisiSoyad.Text;

            db.Kisiler.Add(kisi);
            db.SaveChanges();

            MessageBox.Show("Kisi eklenmiştir");

            KisileriGetir();


        }

        private void btnKisiSil_Click(object sender, EventArgs e)
        {
            if (secilenKisi != null)
            {
                db.Kisiler.Remove(secilenKisi);

                db.SaveChanges();

                MessageBox.Show("Kişi güncellenmiştir");
                KisileriGetir();

                lblSecilenKisi.Text = "Seçilen kişi: ";

            }
            else
                MessageBox.Show("Güncellemek için plaka seçiniz!");
        }

        private void dgvKisiler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenKisi = (Kisi)(dgvKisiler.SelectedRows[0].DataBoundItem);
            lblSecilenKisi.Text = "Seçilen kişi: " + secilenKisi.Ad + " " + secilenKisi.Soyad;
        }

        private void btnKisiGuncelle_Click(object sender, EventArgs e)
        {

            if (secilenKisi != null)
            {
                secilenKisi.Ad = txtKisiAd.Text;
                secilenKisi.Soyad = txtKisiSoyad.Text;



                db.SaveChanges();

                MessageBox.Show("Kişi güncellenmiştir");
                KisileriGetir();

                secilenKisi = null;
                lblSecilenKisi.Text = "Seçilen kişi: ";

            }
            else
                MessageBox.Show("Güncellemek için plaka seçiniz!");
        }

        private void btnMuhendisEkle_Click(object sender, EventArgs e)
        {
            Muhendis muhendis = new Muhendis();
            muhendis.Ad = txtMuhendisAd.Text;
            muhendis.Soyad = txtMuhendisSoyad.Text;

            db.Muhendisler.Add(muhendis);
            db.SaveChanges();

            MessageBox.Show("Kisi eklenmiştir");

            MuhendisleriGetir();
        }

        private void btnMuhendisSil_Click(object sender, EventArgs e)
        {
            if (secilenMuhendis != null)
            {
                db.Muhendisler.Remove(secilenMuhendis);

                db.SaveChanges();

                MessageBox.Show("Mühendis silinmiştir");
                MuhendisleriGetir();

                lblSecilenKisi.Text = "Seçilen mühendis: ";

            }
            else
                MessageBox.Show("Güncellemek için plaka seçiniz!");
        }

        private void btnMuhendisGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenMuhendis != null)
            {
                secilenMuhendis.Ad = txtMuhendisAd.Text;
                secilenMuhendis.Soyad = txtMuhendisSoyad.Text;


                db.SaveChanges();

                MessageBox.Show("Muhendis güncellenmiştir");
                MuhendisleriGetir();

                lblSecilenMuhendis.Text = "Seçilen mühendis: ";

            }
            else
                MessageBox.Show("Güncellemek için mühendis seçiniz!");
        }

        private void dgvMuhebndisler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenMuhendis = (Muhendis)(dgvMuhebndisler.SelectedRows[0].DataBoundItem);

        }
    }
}
