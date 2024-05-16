using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_8_OBS_
{
	public partial class IdPasForm : Form
	{
		public IdPasForm()
		{
			InitializeComponent();
		}

		private void btnGrs_Click(object sender, EventArgs e)
		{	OgrenciKayıtForm ogrenciKayıtForm = new OgrenciKayıtForm();
			Program.FirstForm = this;
			Program.SecondForm = new OgrenciBilgiFormu();
			Program.SecondForm.Show();
			Program.FirstForm.Hide();

			

		}

		private void IdPasForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Program.FirstForm = this;
			Program.MainForm = new Form1();			
			Program.MainForm.Show();
		}
	}
}
