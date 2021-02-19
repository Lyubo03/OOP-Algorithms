namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            Person person1 = new Person("Ivan", "Goshev", 12, 22.22m);
            var persons = new List<Person>();
            try
            {
                for (int i = 0; i < lines; i++)
                {
                    var cmdArgs = Console.ReadLine().Split();
                    var person = new Person(cmdArgs[0],
                                            cmdArgs[1],
                                            int.Parse(cmdArgs[2]),
                                            decimal.Parse(cmdArgs[3]));

                    persons.Add(person);
                }
                var parcentage = decimal.Parse(Console.ReadLine());
                persons.ForEach(p => p.IncreaseSalary(parcentage));
                persons.ForEach(p => Console.WriteLine(p.ToString()));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }
        }
    }
}