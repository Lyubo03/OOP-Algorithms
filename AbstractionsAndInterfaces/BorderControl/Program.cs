namespace BorderControl
{
    using BorderControl.Interfaces;
    using BorderControl.LiveObjects;
    using System;
    using System.Collections.Generic;
    using System.Text.Json;

    public class Program
    {
        static void Main(string[] args)
        {
            HashSet<IPerson> citizens = new HashSet<IPerson>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                if (input.Length == 4)
                {
                    string id = input[2];
                    string birthdate = input[3];
                    citizens.Add(new Person(name, age, id, birthdate));
                }
                else if (input.Length == 3)
                {
                    string group = input[2];
                    citizens.Add(new Rebel(name, age, group));
                }
            }
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                if (!input.Contains(" "))
                {
                    foreach (var person in citizens)
                    {
                        if (person.Name == input)
                        {
                            person.Buy();
                        }
                    }
                }
            }

            int food = 0;

            foreach (var person in citizens)
            {
                food += person.Food;
            }
            Console.WriteLine(food);
        }
    }
}