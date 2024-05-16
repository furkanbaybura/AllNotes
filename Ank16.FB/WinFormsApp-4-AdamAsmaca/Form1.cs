namespace WinFormsApp_4_AdamAsmaca
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			char[] kelime = { 'e', 'l', 'm', 'a' };
			var tb = sender as TextBox;
			if (tb.Text == string.Empty)
			{
				return;
			}
			MessageBox.Show(tb.Text.ToString());


			



		}

	}
}
