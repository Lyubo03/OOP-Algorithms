namespace ExplicitInterface
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string enter = Console.ReadLine();
                if (enter == "End")
                {
                    break;
                }
                string[] input = enter.Split();

                string name = input[0];
                string country = input[1];
                int age = int.Parse(input[2]);

                Citizen citizen = new Citizen(name, country, age);

                IPerson person = citizen; 
                Console.WriteLine(person.GetName());

                IResident resident = citizen as IResident;
                Console.WriteLine(resident.GetName());

            }
        }
    }
}