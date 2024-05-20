using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task4
{
    public partial class MainWindow : Window
    {
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += (s, e) => CreateButton();
        }

        private void CreateButton()
        {
            Button button = new Button();
            button.Content = "";
            button.Width = 100;
            button.Height = 100;
            button.MouseEnter += Button_MouseEnter;
            button.Click += Button_Click;

            Canvas.SetLeft(button, random.Next(0, (int)(MainCanvas.ActualWidth - button.Width)));
            Canvas.SetTop(button, random.Next(0, (int)(MainCanvas.ActualHeight - button.Height)));

            MainCanvas.Children.Add(button);
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            CreateButton();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            MainCanvas.Children.Remove(button);
        }
    }
}