using System.Diagnostics.Eventing.Reader;

namespace Ejercicio_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lado1, lado2, lado3;
            lado1 = double.Parse(textBox1.Text);
            lado2 = double.Parse(textBox2.Text);
            lado3 = double.Parse(textBox3.Text);
            if ((lado1 == lado2) && (lado2 == lado3))
                textBox4.Text = "Equilatero";
            else
                if ((lado1==lado2)||(lado1==lado3)||(lado2==lado3) )
                    textBox4.Text = "Isosceles";
            textBox4.Text = "Escaleno";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
