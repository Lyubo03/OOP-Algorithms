using System;

namespace Football_Team
{
    class SkillsStats
    {
        private int agility;
        private int sprint;
        private int dribbling;
        private int passing;
        private int shouting;
        private int overallStats;
        public SkillsStats(int agility, int sprint, int dribbling, int passing, int shouting)
        {
            if (agility > 100 && agility < 0)
            {
                throw new Exception($"Agility should be between 0 and 100.");
            }
            this.agility = agility;
            if (sprint > 100 && sprint < 0)
            {
                throw new Exception($"Sprint should be between 0 and 100.");
            }
            this.sprint = sprint;
            if (dribbling > 100 && dribbling < 0)
            {
                throw new Exception($"Dribbling should be between 0 and 100.");
            }
            this.dribbling = dribbling;
            if (shouting > 100 && shouting < 0)
            {
                throw new Exception($"Shouting should be between 0 and 100.");
            }
            this.shouting = shouting;
            if (passing > 100 && passing < 0)
            {
                throw new Exception($"Passing should be between 0 and 100.");
            }
            this.passing = passing;
        }
        public int OverallStats
        {
            set { overallStats = (agility + sprint + dribbling + shouting + passing) / 5; }
            get { return overallStats; }
        }
    }
}
