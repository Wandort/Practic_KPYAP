using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad5
{
    public partial class Form1 : Form
    {
        private PictureBox rocketPictureBox;
        private Button launchButton;
        private Timer animationTimer;
        private int rocketPosition;
        public Form1()
        {
            InitializeComponent();

            this.rocketPictureBox = new PictureBox
            {
                Image = Image.FromFile("C:\\Практика КПиЯп\\Arabok_29\\zad5\\Images/RRocket.png"),
                SizeMode = PictureBoxSizeMode.AutoSize,
                Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height)
            };

            this.launchButton = new Button
            {
                Text = "Запуск",
                Location = new Point(this.ClientSize.Width / 2, 30),
                BackColor = Color.Red
            };
            this.launchButton.Click += LaunchButton_Click;

            this.animationTimer = new Timer { Interval = 50 };
            this.animationTimer.Tick += timer1_Tick;

            this.Controls.Add(this.rocketPictureBox);
            this.Controls.Add(this.launchButton);
        }
        private void LaunchButton_Click(object sender, EventArgs e)
        {
            this.rocketPosition = this.ClientSize.Height;
            this.animationTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.rocketPosition -= 5;

            if (this.rocketPosition < 0)
            {
                this.animationTimer.Stop();
            }
            else
            {
                this.rocketPictureBox.Location = new Point(this.rocketPictureBox.Location.X, this.rocketPosition);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
