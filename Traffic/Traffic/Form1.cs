namespace Traffic
{
    using System;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        private int counter = 0;
        private bool wheather = false;
        private int secondsToAdd;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (counter == 0)
            //{
            //    picBoxTraffic.Image = Properties.Resources.trafficYelow;
            //    timer1.Interval = 3000;
            //    counter++;
            //    lblText.Text = "Приготви се";
            //}
            //else if (counter == 1)
            //{
            //    picBoxTraffic.Image = Properties.Resources.trafficRed;
            //    picBoxMan.Image = Properties.Resources.ManGreen;
            //    timer1.Interval = 10000;
            //    counter++;
            //    lblText.Text = "Пресечи";
            //}
            //else if (counter == 2)
            //{
            //    picBoxMan.Image = Properties.Resources.ManRed;
            //    picBoxTraffic.Image = Properties.Resources.trafficGreen;
            //    counter = 0;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Start()
        {
            secondsToAdd = 10;
            var timeToChange = DateTime.Now.AddSeconds(secondsToAdd);

            while (true)
            {
                if (DateTime.Now >= timeToChange && counter == 0)
                {
                    picBoxTraffic.Image = Properties.Resources.trafficYelow;
                    secondsToAdd = 3;
                    lblText.Text = "Приготви се";
                    counter++;
                    timeToChange = DateTime.Now.AddSeconds(secondsToAdd);
                }
                else if (DateTime.Now >= timeToChange && counter == 1)
                {
                    picBoxTraffic.Image = Properties.Resources.trafficRed;
                    picBoxMan.Image = Properties.Resources.ManGreen;
                    secondsToAdd = 10;
                    counter++;
                    lblText.Text = "Пресечи";
                    timeToChange = DateTime.Now.AddSeconds(secondsToAdd);
                }
                else if (DateTime.Now >= timeToChange && counter == 2)
                {
                    picBoxMan.Image = Properties.Resources.ManRed;
                    picBoxTraffic.Image = Properties.Resources.trafficGreen;
                    counter = 0;
                    lblText.Text = "Не пресичай";
                    timeToChange = DateTime.Now.AddSeconds(secondsToAdd);
                }
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Close();
            wheather = true;
        }
    }
}