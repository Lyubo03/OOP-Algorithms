namespace TrafficLight
{
    using System;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var currentTime = DateTime.Now;
            var statedTime = DateTime.Now;
            int addMinutes = 10;
            statedTime.AddSeconds(addMinutes);
            var yellowLight = currentTime.AddSeconds(10);
            while (true)
            {
                if(currentTime == yellowLight)
                {
                    picBoxTraffic.Image = Properties.Resources.trafficYelow;
                    addMinutes = 3;
                }
            }
        }
    }
}