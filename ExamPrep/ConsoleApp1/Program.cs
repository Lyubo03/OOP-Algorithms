using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> nameAndMeals = new Dictionary<string, List<string>>();
            string[] input = Console.ReadLine().Split('-');
            int unliked = 0;
            while (input[0].ToLower() != "stop")
            {
                string guest = input[1]; string meal = input[2];
                if (input[0].ToLower() == "like")
                {
                    if (!nameAndMeals.ContainsKey(guest))
                    {
                        nameAndMeals[guest] = new List<string>();
                    }
                    nameAndMeals[guest].Add(meal);
                }
                if (input[0].ToLower() == "unlike")
                {
                    if (!nameAndMeals.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                    else
                    {
                        bool wheather = false;
                        foreach (var Meal in nameAndMeals[guest])
                        {
                            if (meal == Meal)
                            {
                                Console.WriteLine($"{guest} doesn't like the {meal}.");
                                nameAndMeals[guest].Remove(meal); 
                                wheather = true;
                                unliked++;
                                break;
                            }
                        }
                        if (!wheather)
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        }
                    }
                }
                input = Console.ReadLine().Split('-');
            }
            foreach (var item in nameAndMeals.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
               
            } 
            Console.WriteLine("Unliked meals: " + unliked);
        }
    }
}
