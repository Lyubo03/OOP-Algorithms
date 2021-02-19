namespace StrategyPatern
{
    using System;
    public class Program
    {
        static void Main(string[] args)
        {
            SortedSetAge sortedByAge = new SortedSetAge();
            SortedSetName sortedByName = new SortedSetName();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] parameters = Console.ReadLine().Split();
                string name = parameters[0];
                int age = int.Parse(parameters[1]);

                Person person = new Person(name, age);

                sortedByAge.Add(person);
                sortedByName.Add(person);
            }

            Console.WriteLine();

            Console.WriteLine(sortedByName.ToString());
            Console.WriteLine(sortedByAge.ToString());
        }
    }
}
