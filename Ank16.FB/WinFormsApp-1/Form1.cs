namespace WinFormsApp_1
{

	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void Register_Click(object sender, EventArgs e)
		{
			Person person = new Person();
			person.colors = new();
			

			foreach (var item in Renkler.Controls)
			{

				if (item is CheckBox)
				{
					var data = item as CheckBox;
					if (data.Checked)
					{
						person.colors.Add(data.Text);
					}
				}
			}
			string temp = "";
			foreach (var item in person.colors)
			{

				temp += person.colors;


			}
			MessageBox.Show(temp);
			MessageBox.Show(Cinsiyet.Text);
			MessageBox.Show($"Ad.Text" + Ad );
			MessageBox.Show(Soyad.Text);
			MessageBox.Show(Yas.Text);
			
			


		}
	}
}
