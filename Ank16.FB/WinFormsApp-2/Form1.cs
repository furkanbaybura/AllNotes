namespace WinFormsApp_2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int count = 0;
		private void timer1_Tick(object sender, EventArgs e)
		{
			++count;
			listBox1.Items.Insert(0, count);
			if (listBox1.Items.Count == 6)
			{
				listBox1.Items.RemoveAt(5);
				var data = listBox1.Items[listBox1.Items.Count - 1];
				listBox2.Items.Insert(0, data);
				if (listBox2.Items.Count == 11)
				{
					listBox2.Items.RemoveAt(10);
					var data2 = listBox2.Items[listBox2.Items.Count - 1];
					listBox3.Items.Insert(0, data2);

				}

			}
			






		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{


		}

		private void Form1_Load(object sender, EventArgs e)
		{
			

		}

		private void button1_Click(object sender, EventArgs e)
		{
			timer1.Stop();
		}

		private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btBaslat_Click(object sender, EventArgs e)
		{
			timer1.Start();
		}
	}
}
