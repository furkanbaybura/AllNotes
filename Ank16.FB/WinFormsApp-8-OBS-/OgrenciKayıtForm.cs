using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_8_OBS_
{
	public partial class OgrenciKayıtForm : Form
	{
		List<Ogrenci> ogrenciList = new List<Ogrenci>();
		private string kayit = "";
		private string Path = "\"ogrenciler.txt\"";
		public OgrenciKayıtForm()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (txtkytsoyad != null && txtkytsoyad.Text != string.Empty && txtkytad != null && txtkytad.Text != string.Empty && txtkytogrn != null && txtkytogrn.Text != string.Empty && txtkytsifre != null && txtkytsifre.Text != string.Empty)
			{
				btnkayıttamamla.Enabled = true;

			}
			else { btnkayıttamamla.Enabled = false; }


		}

		private void btnkayıttamamla_Click(object sender, EventArgs e)
		{
			Ogrenci person = new Ogrenci();
			person.Ad = txtkytad.Text;
			person.Soyad = txtkytsoyad.Text;
			person.OgrenciSifre = txtkytsifre.Text;
			person.OgrenciNo = txtkytogrn.Text;
			
			//foreach (var item in ogrenciList)
			//{
			//	if (item.OgrenciNo == person.OgrenciNo)
			//	{
			//		MessageBox.Show("girdiğiniz öğrenci numarası zaten sistemde kayıtlı");


			//	}
			//	else
			//	{
					ogrenciList.Add(person);
					MessageBox.Show("Kayıt Başarıyla Oluşturuldu");
					kayit = $"{person.Ad} {person.Soyad} {person.OgrenciNo} {person.OgrenciSifre} " + Environment.NewLine;
					MessageBox.Show(kayit);
					File.AppendAllText("ogrenciler.txt", kayit);
			//	}
			//}




		

		}
		public void Add()
		{
			//ogrenciList.Add();
		}

		private void OgrenciKayıtForm_Load(object sender, EventArgs e)
		{
			var PathKayitList = File.Exists(Path);
			btnkayıttamamla.Enabled = false;
		}

		private void txtkytsoyad_TextChanged(object sender, EventArgs e)
		{
			if (txtkytsoyad != null && txtkytsoyad.Text != string.Empty && txtkytad != null && txtkytad.Text != string.Empty && txtkytogrn != null && txtkytogrn.Text != string.Empty && txtkytsifre != null && txtkytsifre.Text != string.Empty)
			{
				btnkayıttamamla.Enabled = true;

			}
			else { btnkayıttamamla.Enabled = false; }
		}

		private void txtkytogrn_TextChanged(object sender, EventArgs e)
		{
			if (txtkytsoyad != null && txtkytsoyad.Text != string.Empty && txtkytad != null && txtkytad.Text != string.Empty && txtkytogrn != null && txtkytogrn.Text != string.Empty && txtkytsifre != null && txtkytsifre.Text != string.Empty)
			{
				btnkayıttamamla.Enabled = true;

			}
			else { btnkayıttamamla.Enabled = false; }
		}

		private void txtkytsifre_TextChanged(object sender, EventArgs e)
		{
			if (txtkytsoyad != null && txtkytsoyad.Text != string.Empty && txtkytad != null && txtkytad.Text != string.Empty && txtkytogrn != null && txtkytogrn.Text != string.Empty && txtkytsifre != null && txtkytsifre.Text != string.Empty)
			{
				btnkayıttamamla.Enabled = true;

			}
			else { btnkayıttamamla.Enabled = false; }
		}
	}
}
