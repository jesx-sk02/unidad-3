namespace Practica_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            int sum = num1 + num2;
            label3.Text = "el resultado es de:  " + sum;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
