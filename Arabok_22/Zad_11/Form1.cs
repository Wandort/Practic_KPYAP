using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0,0374";
            textBox2.Text = "-0,825";
            textBox3.Text = "0,0016";
            textBox4.Text = "1,0553";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                double x = double.Parse(textBox1.Text);
                textBox5.Text += Environment.NewLine +
                "X = " + x.ToString();

                double y = double.Parse(textBox2.Text);
                textBox5.Text += Environment.NewLine +
                "Y = " + y.ToString();

                double z = double.Parse(textBox3.Text);
                textBox5.Text += Environment.NewLine +
                "Z = " + z.ToString();

                double v = double.Parse(textBox4.Text);
                textBox5.Text += Environment.NewLine +
                    "V = " + v.ToString();


                var result = Math.Cos(x) + Math.Cos(y) * (1 + z + Math.Pow(z, 2) / 2 + Math.Pow(z, 3) / 3 + Math.Pow(z, 4) / 4);

                textBox5.Text += Environment.NewLine + "Результат: " + result.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
