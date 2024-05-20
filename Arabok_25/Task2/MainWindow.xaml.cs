using System.Windows;

namespace Task2
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

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
