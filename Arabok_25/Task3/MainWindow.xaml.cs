using System;
using System.Windows;
using LiveCharts;
using LiveCharts.Defaults;

namespace Task3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ChartAxisStep = 0.1;
            Values = new ChartValues<ObservablePoint>();
            for (double x = -10; x <= 10; x += ChartAxisStep)
            {
                Values.Add(new ObservablePoint(x, Math.Cos(x)));
            }

            LineSeries.Values = Values;
        }

        public ChartValues<ObservablePoint> Values { get; set; }
        public double ChartAxisStep { get; set; }
    }
}
