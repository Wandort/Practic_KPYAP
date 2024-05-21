using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Point[] trianglePoints = { new Point(30, 70), new Point(90, 20), new Point(150, 70) };
            g.DrawPolygon(Pens.Red, trianglePoints);

            Rectangle ellipseRect = new Rectangle(170, 30, 100, 80);
            g.DrawEllipse(Pens.Blue, ellipseRect);

            Rectangle filledCircleRect = new Rectangle(300, 30, 70, 70);
            g.FillEllipse(Brushes.Orange, filledCircleRect);

            Rectangle filledRectangleRect = new Rectangle(390, 30, 100, 80);
            g.FillRectangle(Brushes.Purple, filledRectangleRect);

            Rectangle sectorRect = new Rectangle(510, 30, 100, 80);
            g.FillPie(Brushes.Yellow, sectorRect, 0, 120);

            Rectangle targetRect = new Rectangle(30, 150, 100, 100);
            g.DrawEllipse(Pens.Green, targetRect);
            g.DrawEllipse(Pens.Green, targetRect.X + 25, targetRect.Y + 25, 50, 50);
            g.DrawEllipse(Pens.Green, targetRect.X + 50, targetRect.Y + 50, 0, 0);

            int squareSize = 30;
            for (int i = 0; i < 4; i++)
            {
                Rectangle squareRect = new Rectangle(180 + i * squareSize, 180 + i * squareSize, squareSize, squareSize);
                g.FillRectangle(Brushes.LightBlue, squareRect);
                g.DrawRectangle(Pens.Red, squareRect);
            }

            int gridSize = 15;
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 6; col++)
                {
                    Brush brush = (row + col) % 2 == 0 ? Brushes.Gray : Brushes.LightGray;
                    Rectangle cellRect = new Rectangle(350 + col * gridSize, 180 + row * gridSize, gridSize, gridSize);
                    g.FillRectangle(brush, cellRect);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
