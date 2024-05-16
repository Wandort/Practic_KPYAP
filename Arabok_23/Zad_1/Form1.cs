using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputString = InputListBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(inputString))
            {
                int punctuationCount = inputString.Count(char.IsPunctuation);
                OutputLabel.Text = $"Количество знаков препинания: {punctuationCount}";
            }
            else
            {
                OutputLabel.Text = "Выберите строку из списка.";
            }
        }

        private void InputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
