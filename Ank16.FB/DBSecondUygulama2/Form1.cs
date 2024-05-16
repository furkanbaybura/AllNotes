namespace DBSecondUygulama2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			dataGridView1.DataSource = arabadb.Arabalar.ToList();

		}
		ArabaContext arabadb = new ArabaContext();
		Araba araba;
		private void button1_Click(object sender, EventArgs e)
		{
			Araba araba = new Araba();
			araba.Marka = txtmarka.Text;
			araba.Model = txtmodel.Text;
			arabadb.Add(araba);
			arabadb.SaveChanges();
			MessageBox.Show("Baþarýlý Bir Þekilde Eklendi");
			txtmarka.Text = "";
			txtmodel.Text = "";
			dataGridView1.DataSource = arabadb.Arabalar.ToList();
		}

		private void txtid_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnsil_Click(object sender, EventArgs e)
		{

			//var secilenaraba = arabadb.Arabalar.Where(a => a.ID == int.Parse(txtid.Text));
			if (araba == null)
			{
				MessageBox.Show("Kayýt Silmek Ýçin Bir Kayýt Seçiniz");


			}
			else
			{
				arabadb.Arabalar.Remove(araba);
				MessageBox.Show("Kayýt Baþarýyla Silindi");
				arabadb.SaveChanges();

			}
			txtmarka.Text = "";
			txtmodel.Text = "";
			dataGridView1.DataSource = arabadb.Arabalar.ToList();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			araba = (Araba)dataGridView1.SelectedRows[0].DataBoundItem;
			lblsecilen.Text = "Seçilen Araç => " + araba.Model + araba.Marka;
			txtmarka.Text = araba.Marka;
			txtmodel.Text = araba.Model;
		}

		private void btnguncelle_Click(object sender, EventArgs e)
		{

			araba.Model = txtmodel.Text;
			araba.Marka = txtmarka.Text;
			arabadb.Arabalar.Update(araba);
			MessageBox.Show("Model Güncellendi");
			dataGridView1.DataSource = arabadb.Arabalar.ToList();
			txtmarka.Text = "";
			txtmodel.Text = "";
		}

		private void txtmarka_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
