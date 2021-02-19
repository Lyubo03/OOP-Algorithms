using System;
using System.Collections.Generic;
using System.Linq;

namespace RainAir
{
    public class Program
    {
        static void Main()
        {
            Dictionary<string, HashSet<string>> creaturesAndMates = new Dictionary<string, HashSet<string>>();
            string enter = Console.ReadLine();
            while (enter.ToLower() != "blaze it!")
            {
                string[] input = enter.Split().ToArray();
                string creature = input[0];
                string squadMate = input[2];
                if (!creaturesAndMates.ContainsKey(creature))
                {
                    creaturesAndMates[creature] = new HashSet<string>();

                }
                if (creature != squadMate)
                {
                    creaturesAndMates[creature].Add(squadMate);
                }
                enter = Console.ReadLine();
            }
            int countOfMates = 0;
            foreach (var kvp in creaturesAndMates.OrderByDescending(x => x.Value.Count))
            {
                countOfMates = 0;
                string creature = kvp.Key;
                if (!kvp.Value.Any())
                {
                    Console.WriteLine($"{creature} : {countOfMates}");
                }
                else
                {
                    foreach (var mate in creaturesAndMates[creature])
                    {
                        if (creaturesAndMates.ContainsKey(mate) && creaturesAndMates[mate].Contains(creature))
                        {
                        }
                        else
                        {
                            countOfMates++;
                        }
                    }
                    Console.WriteLine($"{creature} : {countOfMates}");
                }
            }
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace ConsoleApp35
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Dictionary<string, HashSet<string>> team = new Dictionary<string, HashSet<string>>();
//            string[] input; string creature, mate;
//            while (true)
//            {
//                input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.None).ToArray();
//                if (input[0] == "Blaze it!")
//                {
//                    break;
//                }
//                creature = input[0]; mate = input[1];
//                if (!team.ContainsKey(creature))
//                {
//                    team[creature] = new HashSet<string>();
//                }
//                if (creature != mate)
//                {
//                    team[creature].Add(mate);
//                }
//            }
//            Dictionary<string, HashSet<string>> result = new Dictionary<string, HashSet<string>>();
//            foreach (var monster in team)
//            {
//                result[monster.Key] = new HashSet<string>();
//                foreach (var item in monster.Value)
//                {
//                    if (team.ContainsKey(item) && team[item].Contains(monster.Key))
//                    {
//                        continue;
//                    }
//                    else
//                    {
//                        result[monster.Key].Add(item);
//                    }
//                }
//            }
//            foreach (KeyValuePair<string, HashSet<string>> kvp in result.OrderByDescending(x => x.Value.Count))
//            {
//                Console.WriteLine($"{kvp.Key} : {kvp.Value.Count}");
//            }
//        }
//    }
//}