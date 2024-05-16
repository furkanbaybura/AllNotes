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
	public partial class OgrenciBilgiFormu : Form
	{
		public OgrenciBilgiFormu()
		{
			InitializeComponent();
		}

		private void OgrenciBilgiFormu_FormClosing(object sender, FormClosingEventArgs e)
		{
			Program.SecondForm = this;

			Program.MainForm = new Form1();
			
			Program.MainForm.Show();
		}
	}
}
