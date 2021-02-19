using System;
using System.Collections.Generic;
using System.Linq;

namespace Pirates
{
    class Program
    {
        static void AddTowns(Dictionary<string, int> citiesPopulation, Dictionary<string, double> citiesTresure)
        {
            string[] commands = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
            while (commands[0].ToLower() != "sail")
            {
                string cityName = commands[0]; int population = int.Parse(commands[1]); double gold = double.Parse(commands[2]);
                if (!citiesPopulation.ContainsKey(cityName) && !citiesPopulation.ContainsKey(cityName))
                {
                    citiesPopulation[cityName] = 0;
                    citiesTresure[cityName] = 0;
                }
                citiesPopulation[cityName] += population;
                citiesTresure[cityName] += gold;
                commands = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
            }
        }
        static void Events(Dictionary<string, int> citiesPopulation, Dictionary<string, double> citiesTresure)
        {
            string[] input = Console.ReadLine().Split(new string[] { "=>" }, StringSplitOptions.RemoveEmptyEntries);
            while (input[0].ToLower() != "end")
            {
                string Town = input[1];
                if (input[0].ToLower() == "plunder")
                {
                    double Gold = double.Parse(input[3]);
                    int killedPeople = int.Parse(input[2]);
                    if (citiesPopulation[Town] >= killedPeople || citiesTresure[Town] >= Gold)
                    {
                        citiesPopulation[Town] -= killedPeople; citiesTresure[Town] -= Gold;
                        Console.WriteLine($"{Town} plundered! {Gold} gold stolen, {killedPeople} citizens killed.");
                    }
                    if (citiesPopulation[Town] <= 0 || citiesTresure[Town] <= 0)
                    {
                        citiesTresure.Remove(Town); citiesPopulation.Remove(Town);
                        Console.WriteLine($"{Town} has been wiped off the map!");
                    }
                }
                if (input[0].ToLower() == "prosper")
                {
                    double Gold = double.Parse(input[2]);
                    if (Gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        citiesTresure[Town] += Gold;
                        Console.WriteLine($"{Gold} gold added to the city treasury. {Town} now has {citiesTresure[Town]} gold.");
                    }
                }
                input = Console.ReadLine().Split(new string[] { "=>" }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
        static void Print(Dictionary<string, int> citiesPopulation, Dictionary<string, double> citiesTresure)
        {
            if (citiesTresure.Any() || citiesPopulation.Any())
            {
                Console.WriteLine($"Ahoy, Captain! There are {citiesPopulation.Count} wealthy settlements to go to:");
                foreach (var kvp in citiesTresure.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    string town = kvp.Key;
                    Console.WriteLine($"{town} -> Population: {citiesPopulation[town]} citizens, Gold: {citiesTresure[town]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, int> citiesPopulation = new Dictionary<string, int>();
            Dictionary<string, double> citiesTresure = new Dictionary<string, double>();
            AddTowns(citiesPopulation, citiesTresure);
            Events(citiesPopulation, citiesTresure);
            Print(citiesPopulation, citiesTresure);
        }
    }
}
