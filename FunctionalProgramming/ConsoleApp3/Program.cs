using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split().ToList();

            Func<string, int, bool> howMuch = (guest, l) => guest.Length == l;
            Func<string, string, bool> StartsWith = (n, condition) => n.StartsWith(condition);
            Func<string, string, bool> EndsWith = (n, condition) => n.EndsWith(condition);

            Action<List<string>> Double = guests =>
            {
                for (int i = 0; i < guests.Count; i += 2)
                {
                    string name = guests[i];
                    guests.Add(name);
                }
            };

            Action<List<string>, List<string>> AddToList = (l, a) =>
             {
                 foreach (var people in a)
                 {
                     l.Add(people);
                 }
             };

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
                    }
                    if (toDo == "Double")
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

                    }
                }
            }

            if (guests.Any())
            {
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}