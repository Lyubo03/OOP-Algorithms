using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Team
{
    class Team
    {
        private string name;
        private List<Player> players;
        public double overallStats;
        public double OverallTeamStats
        {
            set
            {
                overallStats = 0;
                foreach (var player in players)
                {
                    overallStats += player.OverallStats;
                }
                overallStats /= players.Count;
                Math.Round(overallStats, 0);
            }
            get { return overallStats; }
        }
        public List<Player> Players
        {
            set { players = value; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
    }
}
