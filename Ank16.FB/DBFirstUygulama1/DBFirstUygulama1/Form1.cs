using DBFirstUygulama1.Models;

namespace DBFirstUygulama1
{
	public partial class Form1 : Form
	{
		NorthWindFurkanContext db = new NorthWindFurkanContext();
		Customer customer = new Customer() ;
		public Form1()
		{
			NorthWindFurkanContext db = new NorthWindFurkanContext();
			InitializeComponent();
			dgvCmpny.DataSource = db.Customers.ToList();

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnekle_Click(object sender, EventArgs e)
		{
			Customer customer = new Customer();

			customer.CustomerId = txtid.Text;
			customer.CompanyName = txtcmpy.Text;
			db.Customers.Add(customer);
			db.SaveChanges();
			MessageBox.Show("ADDED", "SUCCESFULL", MessageBoxButtons.OK);
			dgvCmpny.DataSource = db.Customers.ToList();
		}

		private void txtid_TextChanged(object sender, EventArgs e)
		{


		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void txtdlt_Click(object sender, EventArgs e)
		{
			Customer customer = new Customer();
			customer = db.Customers.Where(x => x.CustomerId == txtid.Text).FirstOrDefault();
			if (customer !=null)
			{	
				db.Customers.Remove(customer);
				db.SaveChanges();
			}
			else
			{
				MessageBox.Show("Lütfen Silmek Ýstediðiniz Müþteriyi Seçiniz");
			}
			
			MessageBox.Show("Baþarýyla Silindi");
			dgvCmpny.DataSource = db.Customers.ToList();
		}

		private void dgvCmpny_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
			 customer = (Customer) dgvCmpny.SelectedRows[0].DataBoundItem;
			
			MessageBox.Show("Seçilen Müþteri ID : "+ customer.CustomerId+"=> Company Name : "+ customer.CompanyName);

			txtid.Text = customer.CustomerId;
			txtcmpy.Text = customer.CompanyName;
		}
	}
}
