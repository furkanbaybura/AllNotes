namespace WinFormsApp3_SatrancTahtası
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
		int x = 20;
		int y = 20;
		private void button1_Click(object sender, EventArgs e)
		{
			var btn = new Button();
			for (int i = 0; i < 8; i++)
			{

				for (int j = 0; j < 8; j++)
				{
					btn.Width = 100;
					btn.Height = 100;
					btn.Location = new Point(x, y);
					btn.Text = "A1";
					btn.BackColor = Color.White;
					btn.ForeColor = Color.Black;

				}

			}

			this.Controls.Add(btn);
			x += 100;
		}
	}
}
