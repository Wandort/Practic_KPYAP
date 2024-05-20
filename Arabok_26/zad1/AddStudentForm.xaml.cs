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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using System.Xml.Linq;
using zad1.Interfaces;
using zad1.Models;

namespace zad1
{
    /// <summary>
    /// Логика взаимодействия для AddForm.xaml
    /// </summary>
    public partial class AddStudentForm : Window
    {
        private readonly IXmlWorker _worker;
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void buttonAddNewFlight_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();

            Student newStudent = new Student
            {
                LastName = textBoxDestinationName.Text,
                Birthday = (textBoxFlightNumber.Text).ToString(),
                Name = textBoxDepartureTime.Text
            };

            XDocument doc = XDocument.Load("C:\\Users\\Lenovo\\OneDrive\\Рабочий стол\\Arabok_26\\zad1\\Files/Student.xml");

            // Создаем новый элемент <student>
            XElement studentElem = new XElement("student",
                new XElement("LastName", newStudent.LastName),
                new XElement("Birthday", newStudent.Birthday),
                new XElement("Name", newStudent.Name)
            );

            // Добавляем элемент в корневой элемент
            doc.Root.Add(studentElem);

            // Сохраняем изменения
            doc.Save("C:\\Users\\Lenovo\\OneDrive\\Рабочий стол\\Arabok_26\\zad1\\Files/Student.xml");
            //main.PrintFlights(_worker.GetAll());

            this.Close();
        }
    }
}
