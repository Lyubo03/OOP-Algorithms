namespace FunctionalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Security.Cryptography.X509Certificates;

    public class Person
    {
        private string name;
        private int age;

        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> list = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person();
                person.Age = age; person.Name = name;
                list.Add(person);
            }

            string filter = Console.ReadLine();
            int ageFilter = int.Parse(Console.ReadLine());

            Func<int, bool> wheather;
            if (filter.ToLower() == "older")
            {
                wheather = x => x >= ageFilter;
            }
            else
            {
                wheather = x => x < ageFilter;
            }
            List<Person> res = list.Where(x => wheather(x.Age)).ToList();

            string[] printFilter = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Action<Person> action;

            if (printFilter.Length == 2)
            {
                action = x => Console.WriteLine($"{x.Name} {x.Age}");
            }
            else if (printFilter[0] == "age")
            {
                action = x => Console.WriteLine(x.Age);
            }
            else
            {
                action = x => Console.WriteLine(x.Name);
            }

            res.ForEach(action);
        }
    }
}