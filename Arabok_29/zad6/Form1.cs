using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad6
{
    public partial class Form1 : Form
    {
        private Timer animationTimer;
        private int circleX;
        private const int circleRadius = 10;
        public Form1()
        {
            InitializeComponent();

            this.animationTimer = new Timer { Interval = 50 };
            this.animationTimer.Tick += timer1_Tick;
            this.animationTimer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int circleY = (int)(Math.Sin(circleX / 50.0) * 50 + this.ClientSize.Height / 2);
            e.Graphics.FillEllipse(Brushes.Black, circleX, circleY, circleRadius * 2, circleRadius * 2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circleX = (circleX + 5) % this.ClientSize.Width;
            this.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
