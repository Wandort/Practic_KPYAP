using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad_6
{
    public partial class Form1 : Form
    {
        private DataGridView dataGridView;
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ColumnCount = 4,
                RowCount = 4
            };

            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = random.Next(1, 101);
                }
            }

            Controls.Add(dataGridView);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maxElement = int.MinValue;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value is int value)
                    {
                        maxElement = Math.Max(maxElement, value);
                    }
                }
            }

            MessageBox.Show($"Наибольший элемент: {maxElement}");
        }

    }
}
