using System;
using System.Collections.Generic;

namespace Football_Team
{
    class StartUp
    {
        private static void RemovePlayer(List<Player> players, string[] input, out bool wheather)
        {
            string playerName = input[2];
            wheather = false;
            for (int i = 0; i < players.Count; i++)
            {
                if (playerName == players[i].Name)
                {
                    players.Remove(players[i]);
                    wheather = true;
                }
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, Team> footballTeams = new Dictionary<string, Team>();
            string[] input = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            List<Player> players = new List<Player>();
            while (input[0].ToLower() != "end")
            {
                switch (input[0].ToLower())
                {
                    case "team":
                        string teamName = input[1];
                        if (!footballTeams.ContainsKey(teamName))
                        {
                            footballTeams[teamName] = new Team();
                            footballTeams[teamName].Name = teamName;
                        }
                        break;
                    case "add":
                        teamName = input[1];
                        if (footballTeams.ContainsKey(teamName))
                        {
                            AddPlayer(input, players);
                            footballTeams[teamName].Players = players;

                        }
                        break;
                    case "remove":
                        teamName = input[1];
                        if (footballTeams.ContainsKey(teamName))
                        {
                            bool wheather = true;
                            string playerName = input[2];
                            RemovePlayer(players, input, out wheather);
                            footballTeams[teamName].Players = players;
                            footballTeams[teamName].OverallTeamStats = 0;
                            if (wheather == false)
                            {
                                Console.WriteLine($"Player {playerName} is not in {input[1]} team.");
                            }
                        }
                        break;
                    case "rating":
                        teamName = input[1];
                        if (footballTeams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"{teamName} - {footballTeams[teamName].OverallTeamStats}");
                        }
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
        private static void AddPlayer(string[] input, List<Player> players)
        {

            Player player = new Player();
            string name = input[2];
            player.Name = name;
            int agility = int.Parse(input[3]);
            player.Agitlity = agility;
            int sprint = int.Parse(input[4]);
            player.Sprint = sprint;
            int dribbling = int.Parse(input[5]);
            player.Dribbling = dribbling;
            int passing = int.Parse(input[6]);
            player.Passing = passing;
            int shouting = int.Parse(input[7]);
            player.Shouting = shouting;
            player.OverallStats = 0;
            if (agility <= 100 && agility >= 0 &&
                dribbling <= 100 && dribbling >= 0 &&
                sprint <= 100 && sprint >= 0 &&
                passing <= 100 && passing >= 0 &&
                shouting <= 100 && shouting >= 0)
            {
                players.Add(player);
            }
        }
    }
}
