using System.Drawing;
using System;
using System.Windows.Forms;

namespace TImer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            //lblFTW.Text = "Fuck the world!";
            //lblFTW.ForeColor = Color.Red;
            //lblFTW.Font = new Font("Arial", 24, FontStyle.Bold);
            //lblFTW.TextAlign = ContentAlignment.MiddleCenter;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }
        public void timer_Tick(object sender, EventArgs e)
        {
            //lblFTW.Visible = !lblFTW.Visible;
            pictureBox1.Top += 15;
        }
        private void label1_Click(object sender, System.EventArgs e)
        {

        }
    }
}