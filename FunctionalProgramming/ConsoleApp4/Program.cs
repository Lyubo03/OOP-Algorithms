namespace ConsoleApp4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static Func<string, int, bool> howMuch = (g, l) => g.Length == l;
        public static Func<string, string, bool> StartsWith = (n, condition) => n.StartsWith(condition);
        public static Func<string, string, bool> EndsWith = (n, condition) => n.EndsWith(condition);

        static Action<List<string>> Double = g =>
            {
                int length = g.Count;
                for (int i = 0; i < length; i++)
                {
                    string name = g[i];
                    g.Add(name);
                }
            };

        static Action<List<string>, List<string>> AddToList = (l, a) =>
        {
            foreach (var people in a)
            {
                l.Add(people);
            }
        };

        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split().ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command.ToLower() == "party!")
                {
                    break;
                }
                else
                {
                    string[] instructions = command.Split();
                    string toDo = instructions[0];
                    string filter = instructions[1];
                    string condition = instructions[2];

                    if (toDo == "Remove")
                    {
                        guests = Remove(guests, filter, condition);
                    }

                    if (toDo == "Double")
                    {
                        guests = DoubleGuests(guests, filter, condition);
                    }
                }
            }

            Print(guests);
        }

        static List<string> DoubleGuests(List<string> guests, string filter, string condition)
        {
            List<string> people = new List<string>();
            if (filter == "StartsWith")
            {
                people = guests.Where(g => StartsWith(g, condition)).ToList();
                guests = guests.Where(g => !StartsWith(g, condition)).ToList();
            }
            else if (filter == "EndsWith")
            {
                people = guests.Where(g => EndsWith(g, condition)).ToList();
                guests = guests.Where(g => !EndsWith(g, condition)).ToList();
            }
            else if (filter == "Length")
            {
                people = guests.Where(g => howMuch(g, int.Parse(condition))).ToList();
                guests = guests.Where(g => !howMuch(g, int.Parse(condition))).ToList();

            }

            Double(people);
            AddToList(guests, people);

            return guests;
        }

        static void Print(List<string> guests)
        {
            guests = guests.OrderBy(x => x).ToList();

            if (guests.Any())
            {
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        static List<string> Remove(List<string> guests, string filter, string condition)
        {
            if (filter == "StartsWith")
            {
                guests = guests.Where(g => !StartsWith(g, condition)).ToList();
            }
            else if (filter == "EndsWith")
            {
                guests = guests.Where(g => !EndsWith(g, condition)).ToList();
            }
            else if (filter == "Length")
            {
                guests = guests.Where(g => !howMuch(g, int.Parse(condition))).ToList();
            }
            return guests;
        }
    }
}
//Gosho Pesho Misho Stoqn Ivan Pesho Petkan
//Double StartsWith P
//Remove EndsWith n
//Double StartsWith Pe
//Party!