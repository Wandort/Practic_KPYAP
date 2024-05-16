using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad_5
{
    public partial class Form1 : Form
    {
        private double[] randomArray;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            randomArray = new double[15];
            Random random = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = Math.Round(random.NextDouble() * 100, 2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Join(Environment.NewLine, randomArray.Select((num, index) => $"Mas[{index}] = {num}"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double maxElement = randomArray.Max();

            double lastElement = randomArray[randomArray.Length - 1];
            randomArray[randomArray.Length - 1] = maxElement;
            randomArray[randomArray.Length - 2] = lastElement;

            textBox2.Text = string.Join(Environment.NewLine, randomArray.Select((num, index) => $"Mas[{index}] = {num}"));
        }
    }
}
