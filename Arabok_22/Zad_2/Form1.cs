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

namespace Zad_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);

                double c;
                double fx = YourFunctionDefinition(x);

                if (Math.Abs(x - y) < 1e-10)
                    c = Math.Pow(fx, 2) + Math.Pow(y, 2) + Math.Sin(y);
                else if (x - y > 0)
                    c = Math.Pow(fx - y, 2) + Math.Cos(y);
                else
                    c = Math.Pow(y - fx, 2) + Math.Tan(y);

                textBox3.Text += Environment.NewLine + "Результат: " + c.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные числа в текстовые поля.");
            }
        }

        private double YourFunctionDefinition(double x)
        {
            return x * x;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }   
}
