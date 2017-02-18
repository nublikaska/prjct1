using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        static int lastBall = 1;
        static int counter = 50;
        static int firstBall = 1;
        static int lastToDown = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox pb1 = (PictureBox)Controls["pictureBox1"];
            pictureBox1.Image = new Bitmap("H:\\Users\\denis\\Desktop\\1.jpg");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (++counter >= 50)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Name = "ball" + lastBall;
                lastBall++;
                pictureBox.Location = new Point(-50, 20);
                pictureBox.Size = new Size(50, 50);
                pictureBox.Image = new Bitmap("H:\\Users\\denis\\Desktop\\1.jpg");
                this.Controls.Add(pictureBox);
                this.Controls[pictureBox.Name].BringToFront();
                counter = 0;
            }

            if (this.Controls["ball" + firstBall].Left > 100)
            {
                for (int i = firstBall; i < firstBall + lastToDown; i++)
                {
                   this.Controls["ball" + i].Top++;
                }

                lastToDown++;
            }

            for (int i = lastToDown + 1; i < lastBall; i++)
            {
                this.Controls["ball" + i].Left++;
            }
        }
    }
}