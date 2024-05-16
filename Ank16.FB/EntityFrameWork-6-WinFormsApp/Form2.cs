namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        private int i;

        public Form2(Form1 form)
        {
            form1 = form;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.SetLabel("Form 2 :" + textBox1.Text, Color.CornflowerBlue);
            SetLabel("\t\t\tForm 2 :" + textBox1.Text, Color.MediumSpringGreen, ContentAlignment.MiddleRight);
            form1.Show();

            textBox1.Text = "";
            this.Hide();
        }

        public void SetLabel(string text, Color color, ContentAlignment position = ContentAlignment.MiddleLeft)
        {
            Label label = new Label();

            label.ForeColor = Color.White;
            label.Size = new Size(panel1.Width, 15);

            label.Text = text;
            label.TextAlign = position;
            label.BackColor = color;
            label.Top += i * 15;
            label.AutoSize = false;


            panel1.Controls.Add(label);

            i++;
        }
    }
}
