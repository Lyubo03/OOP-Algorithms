using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> nameAndPoints = new Dictionary<string, int>();
            string[] input = Console.ReadLine().Split('-');
            while (input[0].ToLower() != "end")
            {
                string name = input[0];
                int points = int.Parse(input[1]);
                if (!nameAndPoints.ContainsKey(name))
                {
                    nameAndPoints[name] = 0;
                }
                nameAndPoints[name] += points;
                input = Console.ReadLine().Split('-');
            }
            foreach (var kvp in nameAndPoints.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key}->{kvp.Value}");
            }
        }
    }
}