using ClassLibrary1.Concreate;
using ClassLibrary1.Entities;
using KitapStokYönetim.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapStokYönetim
{
	public partial class KitapForm : Form
	{
		public Product Kitap { get; set; }
		ProductRepository productRepo = new ProductRepository();
		UserRepository userREpo = new UserRepository();
		public KitapYönetimForm Form;
		public KitapForm()
		{
			InitializeComponent();
		}

		private void KitapForm_Load(object sender, EventArgs e)
		{
			label1.Text += "kitap ıd => " + Kitap.Id;
			label1.Text += Environment.NewLine;
			label1.Text += "kitap ad => " + Kitap.Name;
			label1.Text += Environment.NewLine;
			label1.Text += "kitap fiyat => " + Kitap.Price;
			label1.Text += Environment.NewLine;
			label1.Text += "kitap adet => " + Kitap.StockAmount;

			txtbguncelad.Text = Kitap.Name;
			txtboxadet.Text = Kitap.StockAmount.ToString();
			txtboxfiyat.Text = Kitap.Price.ToString();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!MyCustomControl.ControlStingToNumber(txtSatisAdet.Text, out int adet))
			{
				MessageBox.Show("düzgün veri girer misin canım!");
				return;
			}

			Kitap.StockAmount -= adet;
			if (Kitap.StockAmount < 0)
			{
				MessageBox.Show("stoktan fazla gridiniz");
				return;
			}
			productRepo.Update(Kitap);

			var user = userREpo.GetById(Program.CurrentUserId);

			user.Balance += Kitap.Price * adet;

			userREpo.Update(user);

			Form.UpdateListBox(productRepo.GetAll());


			this.Close();

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnguncelle_Click(object sender, EventArgs e)
		{
			Kitap.Name = txtbguncelad.Text;
			Kitap.StockAmount = int.Parse(txtboxadet.Text);
			Kitap.Price = int.Parse(txtboxfiyat.Text);

			productRepo.Update(Kitap);
			Form.UpdateListBox(productRepo.GetAll());
			MessageBox.Show("Güncellendi");
			this.Close();
		}
	}
}
