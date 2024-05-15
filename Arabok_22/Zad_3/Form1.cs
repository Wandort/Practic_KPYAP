using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zad_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x0 = -0.5;
                double xk = 2.5;
                double dx = 0.05;
                double a = 10.2;
                double b = 1.25;

                StringBuilder resultText = new StringBuilder();

                for (double x = x0; x <= xk; x += dx)
                {
                    double y = CalculateY(x, a, b);
                    resultText.AppendLine($"x = {x}, y = {y}");
                }

                textBox6.Text = resultText.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные числа в текстовые поля.");
            }
        }

        double CalculateY(double x, double a, double b)
        {
            double term = Math.Pow(10, -1) * a * Math.Pow(x, 3) * Math.Tan(a - b * x);
            return term;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
