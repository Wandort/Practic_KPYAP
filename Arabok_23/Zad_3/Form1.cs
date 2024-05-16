using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawFlower(e.Graphics);
        }

        private void DrawFlower(Graphics g)
        {
            Pen stemPen = new Pen(Color.Green, 3);
            g.DrawLine(stemPen, 120, 200, 120, 100);

            Brush petalBrush = new SolidBrush(Color.Pink);
            g.FillEllipse(petalBrush, 80, 50, 40, 20);
            g.FillEllipse(petalBrush, 120, 50, 40, 20);
            g.FillEllipse(petalBrush, 80, 80, 40, 20);
            g.FillEllipse(petalBrush, 120, 80, 40, 20);

            Brush centerBrush = new SolidBrush(Color.Yellow);
            g.FillEllipse(centerBrush, 110, 70, 20, 20);
        }

        public static void MainEntryPoint()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }
    }
}

