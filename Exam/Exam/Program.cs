using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal price = 0;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "t-shirt": price += 20; break;
                    case "jeans": price += 50; break;
                    case "trainers": price += 70; break;
                    case "jacket": price += 60; break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"{price:F2}");
        }
    }
}