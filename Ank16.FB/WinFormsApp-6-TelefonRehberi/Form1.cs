using System.Windows.Forms;

namespace WinFormsApp6_TelefonRehberi
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void BtnRenkSec_Click(object sender, EventArgs e)
		{
			var response = colorDialog1.ShowDialog();

			if (response == DialogResult.OK)
			{
				var renk = colorDialog1.Color.ToArgb();

				MessageBox.Show(renk.ToString());
			}
		}

		private void lsbKisiler_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
