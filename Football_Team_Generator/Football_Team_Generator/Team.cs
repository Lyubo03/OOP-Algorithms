namespace Football_Team_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }
        public int Stat => CalculateStat();
        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }
        public void RemovePlayer(string name)
        {
            Player player = players.FirstOrDefault(x => x.Name == name);
            if (player == null)
            {
                throw new InvalidOperationException($"Player {name} is not in {this.Name} team.");
            }
            players.Remove(player);
        }
        private int CalculateStat()
        {
            double overal = 0;
            if (players.Count == 0)
            {
                return 0;
            }
            for (int i = 0; i < players.Count; i++)
            {
                overal += players[i].Stat;
            }
            overal /= players.Count;
            return (int)Math.Ceiling(overal);
        }
    }
}