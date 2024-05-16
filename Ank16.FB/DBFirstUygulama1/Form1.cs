using DBFirstUygulama1.Models;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;

namespace DBFirstUygulama1
{
	public partial class Form1 : Form
	{
		NorthWindFurkanContext db = new NorthWindFurkanContext();
		Customer customer = new Customer();
		Employee employee = new Employee();
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
			if (customer != null)
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

			customer = (Customer)dgvCmpny.SelectedRows[0].DataBoundItem;
			lblscm.Text = "Seçilen Kiþi : " + customer.CompanyName;
			txtid.Text = customer.CustomerId;
			txtcmpy.Text = customer.CompanyName;
		}

		private void btngncl_Click(object sender, EventArgs e)
		{
			Customer customer = new Customer();
			customer.CompanyName = txtcmpy.Text;
			customer.CustomerId = txtid.Text;
			db.Customers.Update(customer);
			MessageBox.Show("Data Updated");
			dgvCmpny.DataSource = db.Customers.ToList();
		}

		private void btnshwemply_Click(object sender, EventArgs e)
		{
			//06.03.2024 Görevler
			//Linq Sorgularý
			var data1 = db.Employees.ToList();
			var data2 = db.Employees.FirstOrDefault();
			var data3 = db.Employees.Where(x => x.FirstName.StartsWith("A")).ToList();
			var data4 = db.Employees.Where(x => x.FirstName.StartsWith("A")).FirstOrDefault();
			var data5 = db.Employees.Where(x => x.FirstName.Contains("A")).ToList();
			var data6 = db.Employees.Where(x => x.FirstName.Contains("A")).FirstOrDefault();
			var data7 = db.Employees.Where(x => x.FirstName.Equals("Andrew")).ToList();
			var data8 = db.Products.Max(x => x.UnitPrice);
			var data9 = db.Products.Min(x => x.UnitPrice);
			var data10 = db.Products.Average(x => x.UnitPrice);
			var data11 = db.Products.Sum(x => x.UnitPrice);
			var data12 = db.Employees.OrderBy(x=> x.FirstName).ToList().FirstOrDefault();
			var data13 = db.Products.OrderBy(x => x.UnitsInStock).ToList();
			var data14 = db.Products.OrderByDescending(x => x.UnitsInStock).ThenByDescending(x => x.ProductName).ToList();
			var data15 = db.Employees.Where(x => x.FirstName.Contains("M")).OrderBy(x => x.LastName).ToList();


			
		}

		private void btnshwfirstemploye_Click(object sender, EventArgs e)
		{
			dgvfirstempl.DataSource = db.Employees.Where(x => x.FirstName.StartsWith("A")).FirstOrDefault();
		}

		private void btnilkharfa_Click(object sender, EventArgs e)
		{
			dgvfirsta.DataSource = db.Employees.Where(x => x.FirstName.StartsWith("A")).ToList();
		}

		private void btnaiceren_Click(object sender, EventArgs e)
		{
			dgvina.DataSource = db.Employees.Where(x => x.FirstName.Contains("A")).ToList();
		}
	}
}
