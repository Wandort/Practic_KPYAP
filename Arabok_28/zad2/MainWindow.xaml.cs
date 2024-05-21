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

namespace zad2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class TestDrawing : Control
    {
        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            Point p1 = new Point(60, 60);
            Point p2 = new Point(120, 140);
            Point p3 = new Point(180, 60);
            Pen trianglePen = new Pen(Brushes.Green, 3);
            drawingContext.DrawLine(trianglePen, p1, p2);
            drawingContext.DrawLine(trianglePen, p2, p3);
            drawingContext.DrawLine(trianglePen, p3, p1);

            Rect ellipseRect = new Rect(new Point(230, 70), new Size(120, 60));
            Pen ellipsePen = new Pen(Brushes.Orange, 3);
            drawingContext.DrawEllipse(null, ellipsePen, new Point(290, 100), 60, 30);

            Rect filledCircleRect = new Rect(new Point(370, 70), new Size(60, 60));
            Brush filledCircleBrush = new SolidColorBrush(Color.FromRgb(0, 0, 255));
            drawingContext.DrawEllipse(filledCircleBrush, null, new Point(400, 100), 30, 30);

            Rect filledRectangleRect = new Rect(new Point(470, 70), new Size(120, 60));
            Brush filledRectangleBrush = new SolidColorBrush(Color.FromRgb(128, 0, 128));
            drawingContext.DrawRectangle(filledRectangleBrush, null, filledRectangleRect);

            Point center = new Point(620, 100);
            double radius = 60;
            double startAngle = 0;
            double endAngle = 90;
            StreamGeometry sectorGeometry = new StreamGeometry();
            using (StreamGeometryContext context = sectorGeometry.Open())
            {
                context.BeginFigure(center + new Vector(radius, 0), true, true);
                context.ArcTo(center, new Size(radius, radius), 0, false, SweepDirection.Clockwise, true, true);
                context.LineTo(center, true, true);
            }
            Pen sectorPen = new Pen(Brushes.Yellow, 3);
            drawingContext.DrawGeometry(new SolidColorBrush(Color.FromRgb(255, 0, 0)), sectorPen, sectorGeometry);

            Rect square1 = new Rect(new Point(80, 200), new Size(40, 40));
            Rect square2 = new Rect(new Point(110, 230), new Size(40, 40));
            Rect square3 = new Rect(new Point(140, 260), new Size(40, 40));
            Rect square4 = new Rect(new Point(170, 290), new Size(40, 40));
            Rect square5 = new Rect(new Point(200, 320), new Size(40, 40));
            Pen squarePen = new Pen(Brushes.DarkBlue, 2);
            drawingContext.DrawRectangle(new SolidColorBrush(Color.FromRgb(173, 216, 230)), squarePen, square1);
            drawingContext.DrawRectangle(new SolidColorBrush(Color.FromRgb(173, 216, 230)), squarePen, square2);
            drawingContext.DrawRectangle(new SolidColorBrush(Color.FromRgb(173, 216, 230)), squarePen, square3);
            drawingContext.DrawRectangle(new SolidColorBrush(Color.FromRgb(173, 216, 230)), squarePen, square4);
            drawingContext.DrawRectangle(new SolidColorBrush(Color.FromRgb(173, 216, 230)), squarePen, square5);

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Rect cellRect = new Rect(new Point(350 + i * 40, 200 + j * 40), new Size(40, 40));
                    Brush cellBrush = (i + j) % 2 == 0 ? Brushes.LightGray : Brushes.DarkGray;
                    drawingContext.DrawRectangle(cellBrush, null, cellRect);
                }
            }
        }
    }

}
