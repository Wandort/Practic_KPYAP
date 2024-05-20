using System;
using System.Windows;

namespace Task1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SayName_Click(object sender, RoutedEventArgs e)
        {
            string name = NameInput.Text;
            HelloText.Text = $"Hello, {name}!";
        }
    }
}