using System.Configuration;
using System.Drawing;

namespace Practica_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1, farh1;
            v1 = double.Parse(valor.Text);
            farh1 = v1 * (9.0 / 5.0) + 32;
            Resultado.Text = farh1.ToString();
            label2.Text = " Fahrenheit";

        }

        private void button3_Click(object sender, EventArgs e)
        {
           valor.Text = " ";
            Resultado.Text = " centigrados";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double v1, cent1;
            v1 = double.Parse(valor.Text);
            cent1 = (v1 - 32) * (5.0 / 9.0);
            Resultado.Text = cent1.ToString();
            label2.Text = " Centigrados";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
