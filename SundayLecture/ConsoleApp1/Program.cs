using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input;
            List<Person> persons = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();
                string name = input[0], familyname = input[1]; int years = int.Parse(input[2]); double salary = double.Parse(input[3]);
                Person person = new Person(name, familyname, years, salary);
                persons.Add(person);
            }
            double bonus = double.Parse(Console.ReadLine());
            foreach (var item in persons)
            {
                item.IncreaseBonus(bonus);
                Console.WriteLine(item.IntroducePerson());
            }
        }
    }
}
