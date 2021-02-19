namespace Football_Team_Generator
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, Team> teams = new Dictionary<string, Team>();
            while (true)
            {
                if (input[0] == "END")
                {
                    break;
                }
                try
                {

                    string teamName = input[1];
                    string command = input[0];

                    if (command == "Team")
                    {
                        if (!teams.ContainsKey(teamName))
                        {
                            Team team = new Team(teamName);
                            teams[teamName] = team;
                        }
                    }
                    else if (command == "Rating")
                    {

                        if (!teams.ContainsKey(teamName))
                        {
                            throw new InvalidOperationException($"Team {teamName} does not exist.");
                        }

                        Console.WriteLine($"{teamName} - {teams[teamName].Stat}");
                    }
                    else
                    {
                        string playerName = input[2];
                        if (command == "Remove")
                        {
                            teams[teamName].RemovePlayer(playerName);
                        }
                        else if (command == "Add")
                        {
                            int endurance = int.Parse(input[3]);
                            int sprint = int.Parse(input[4]);
                            int dribble = int.Parse(input[5]);
                            int passing = int.Parse(input[6]);
                            int shooting = int.Parse(input[7]);

                            Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

                            if (!teams.ContainsKey(teamName))
                            {
                                throw new ArgumentException($"Team {teamName} does not exist.");
                            }
                            teams[teamName].AddPlayer(player);
                        }
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                input = Console.ReadLine().Split(new[] { ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}