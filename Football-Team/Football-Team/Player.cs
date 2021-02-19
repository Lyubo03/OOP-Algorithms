using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Team
{
    class Player
    {
        private string playerName;
        private int agility;
        private int sprint;
        private int dribbling;
        private int passing;
        private int shouting;
        private double overallStats;
        public int Agitlity
        {
            set
            {
                agility = value;
                if (agility > 100 || agility < 0)
                {
                    Console.WriteLine($"Agility should be between 0 and 100.");
                    return;
                }
            }
        }
        public int Sprint
        {
            set
            {
                this.sprint = value;
                if (sprint > 100 || sprint < 0)
                {
                    Console.WriteLine($"Sprint should be between 0 and 100.");
                }
            }
        }
        public int Dribbling
        {
            set
            {
                this.dribbling = value;
                if (dribbling > 100 || dribbling < 0)
                {
                    Console.WriteLine($"Dribbling should be between 0 and 100.");
                }
            }
        }
        public int Shouting
        {
            set
            {
                this.shouting = value;
                if (shouting > 100 || shouting < 0)
                {
                    Console.WriteLine($"Shouting should be between 0 and 100.");
                }
            }
        }
        public int Passing
        {
            set
            {
                this.passing = value;
                if (passing > 100 || passing < 0)
                {
                    Console.WriteLine($"Passing should be between 0 and 100.");
                }
            }
        }
        public double OverallStats
        {
            set
            {
                overallStats = (agility + sprint + dribbling + shouting + passing) / 5.00;
                overallStats = Math.Round(overallStats, 0);
            }
            get { return overallStats; }
        }
        public string Name
        {
            set { playerName = value; }
            get { return playerName; }
        }
    }
}
