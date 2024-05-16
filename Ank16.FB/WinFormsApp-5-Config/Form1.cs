namespace WinFormsApp_5Config
{
	public partial class Form1 : Form
	{
		
		public Form1()
		{
			InitializeComponent();
		}
		
		private void Form1_Load(object sender, EventArgs e)
		{
			var Path = File.Exists("config.txt");

			if (Path)
			{
				File.ReadAllLines("config.txt");

			}
			else
			{
				
				string formText = "FormText|Form1";
				string backColor = "BackColor|112312";
				string foreColor = "ForeColor|112312";
				string defaultValue = $"{formText},{backColor},{foreColor}";
				File.WriteAllText("confix.txt",defaultValue); 

			}
		}
	}
}
