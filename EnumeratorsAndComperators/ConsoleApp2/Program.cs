namespace ConsoleApp2
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static int GetData(List<Person> people)
        {
            int comparer = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    comparer = int.Parse(Console.ReadLine());
                    break;
                }

                string[] data = input.Split();

                string name = data[0];
                int age = int.Parse(data[1]);
                string town = data[2];

                Person person = new Person(name, age, town);
                people.Add(person);
            }
            return comparer;
        }
        public static void Main()
        {
            List<Person> people = new List<Person>();

            int comparer = GetData(people)-1;

            int equal = 1;
            int different = 0;

            for (int i = 0; i < people.Count; i++)
            {
                if (people[comparer].CompareTo(people[i]) == 0 && i != comparer)
                {
                    equal++;
                }
                else if(people[comparer].CompareTo(people[i]) != 0)
                {
                    different++;
                }
            }

            if (equal > 1)
            {
                Console.WriteLine($"{equal} {different} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }

        }
    }
}