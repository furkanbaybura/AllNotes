namespace WinFormsApp_8_OBS_
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnOgrncGrs_Click(object sender, EventArgs e)
		{
			Program.MainForm = this;
			Program.FirstForm = new IdPasForm();


			Program.FirstForm.Show();
			Program.MainForm.Hide();
		}

		private void btnKay�t_Click(object sender, EventArgs e)
		{
			Program.MainForm = this;
			Program.ThirdForm = new OgrenciKay�tForm();
			Program.ThirdForm.Show();
			Program.MainForm.Hide();
		}

		private void btnOgrtmnGrs_Click(object sender, EventArgs e)
		{

		}
	}
}
