using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Zad_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var chart = new Chart();
            chart.Dock = DockStyle.Fill;
            this.Controls.Add(chart);

            chart.ChartAreas.Add(new ChartArea("MainArea"));
            chart.Series.Add(new Series("Cosine"));
            chart.Series["Cosine"].ChartType = SeriesChartType.Line;
            chart.Series["Cosine"].Color = Color.Blue;

            double h = 0.1;
            for (double x = -10; x <= 10; x += h)
            {
                double y = Math.Cos(x);
                chart.Series["Cosine"].Points.AddXY(x, y);
            }

            var dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            this.Controls.Add(dataGridView);

            dataGridView.Columns.Add("X", "X");
            dataGridView.Columns.Add("Y", "Y");

            for (double x = -10; x <= 10; x += h)
            {
                double y = Math.Cos(x);
                dataGridView.Rows.Add(x, y);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
