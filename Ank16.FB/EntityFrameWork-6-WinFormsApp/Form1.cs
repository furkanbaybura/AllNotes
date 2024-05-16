namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        private int i;

        public Form1(Form2 form = null)
        {
            form2 = form ?? new Form2(this);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.SetLabel("Form 1 :" + textBox1.Text, Color.CornflowerBlue);
            SetLabel("\t\t\tForm 1 :" + textBox1.Text, Color.MediumSpringGreen, ContentAlignment.MiddleRight);
            form2.Show();

            textBox1.Text = "";
            this.Hide();
        }

        public void SetLabel(string text, Color color,  ContentAlignment position = ContentAlignment.MiddleLeft)
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
