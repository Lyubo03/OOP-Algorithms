using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MovingBuddy
{
    public partial class Form1 : Form
    {
        private bool wheather = false;
        private int counter = 0;
        private int goSomewhere = 7;
        public Form1()
        {
            InitializeComponent();
        }

        private void GoSomewhere()
        {
            if (wheather)
            {
                pictureBox1.Top += goSomewhere;
            }
            else
            {
                pictureBox1.Left += goSomewhere;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                pictureBox1.Image = Properties.Resources._0;
            }
            else if (counter == 1)
            {
                pictureBox1.Image = Properties.Resources._1;
            }
            else if (counter == 2)
            {
                pictureBox1.Image = Properties.Resources._2;

            }
            else if (counter == 3)
            {
                pictureBox1.Image = Properties.Resources._3;
            }

            if (goSomewhere == -7 && wheather == false)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
            else if (wheather == true)
            {
                if (goSomewhere == 7)
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
                }
                if (goSomewhere == -7)
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
                }
            }

            counter++;
            if (counter == 4)
            {
                counter = 0;
            }

            GoSomewhere();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goSomewhere = -7;
                wheather = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                goSomewhere = 7;
                wheather = false;
            }
            else if (e.KeyCode == Keys.Up)
            {
                goSomewhere = -7;
                wheather = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                goSomewhere = 7;
                wheather = true;
            }
        }
    }
}
