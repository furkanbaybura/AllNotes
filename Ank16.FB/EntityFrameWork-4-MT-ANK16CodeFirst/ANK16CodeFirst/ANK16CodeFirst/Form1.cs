using ANK16CodeFirst.Context;
using ANK16CodeFirst.Entitites;

namespace ANK16CodeFirst
{
    public partial class Form1 : Form
    {
        UygulamaDbContext db = new UygulamaDbContext();

        Araba secilenAraba;

        public Form1()
        {
            InitializeComponent();
            lblSecilen.Text = "Seçilen araba: ";
            ArabalariGoster();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Araba araba = new Araba();
            araba.Marka = txtMarka.Text;
            araba.Model = txtModel.Text;

            db.Arabalar.Add(araba);
            db.SaveChanges();

            MessageBox.Show("Araba eklenmiştir");
            ArabalariGoster();
        }

        private void ArabalariGoster()
        {
            dgvArabalar.DataSource = db.Arabalar.ToList();
        }

        private void dgvArabalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenAraba = (Araba)dgvArabalar.SelectedRows[0].DataBoundItem;
            lblSecilen.Text = "Seçilen araba: " + secilenAraba.Marka + " " + secilenAraba.Model;
            txtMarka.Text = secilenAraba.Marka;
            txtModel.Text = secilenAraba.Model;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenAraba != null)
            {
                secilenAraba.Marka = txtMarka.Text;
                secilenAraba.Model = txtModel.Text;

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
    }
}
