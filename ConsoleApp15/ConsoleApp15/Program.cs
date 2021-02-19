namespace ConsoleApp15
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {

        public static Func<string, bool> StartsWith;
        public static Func<string, bool> EndsWith;
        public static Func<string, bool> Length;
        public static Func<string, bool> Contains;

        public static Dictionary<string, Func<string, bool>> RemoveFilter(Dictionary<string, Func<string, bool>> filters, string[] commands)
        {
            string filter = commands[1];
            string parameter = commands[2];

            if (filter == "Starts with")
            {
                filters.Remove(parameter);
            }
            else if (filter == "Ends with")
            {
                filters.Remove(parameter);
            }
            else if (filter == "Length")
            {
                filters.Remove(parameter);
            }
            else if (filter == "Contains")
            {
                filters.Remove(parameter);
            }

            return filters;
        }
        public static Dictionary<string, Func<string, bool>> AddFilter(Dictionary<string, Func<string, bool>> filters, string[] commands)
        {
            string filter = commands[1];
            string parameter = commands[2];

            if (filter == "Starts with")
            {
                StartsWith = invit => invit.StartsWith(parameter);
                filters[parameter] = StartsWith;
            }
            else if (filter == "Ends with")
            {
                EndsWith = invit => invit.EndsWith(parameter);
                filters[parameter] = EndsWith;
            }
            else if (filter == "Length")
            {
                Length = invit => invit.Length == int.Parse(parameter);
                filters[parameter] = Length;
            }
            else if (filter == "Contains")
            {
                Contains = invit => invit.Contains(parameter);
                filters[parameter] = Contains;
            }

            return filters;
        }
        public static List<string> ApplyFilters(List<string> invitations, Dictionary<string, Func<string, bool>> filters)
        {
            foreach (var kvp in filters)
            {
                invitations = invitations.Where(g => !kvp.Value(g)).ToList();
            }
            return invitations;
        }
        static void Main(string[] args)
        {
            List<string> invitations = Console.ReadLine().Split().ToList();
            Dictionary<string, Func<string, bool>> filters = new Dictionary<string, Func<string, bool>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Print")
                {
                    invitations = ApplyFilters(invitations, filters);
                    Console.WriteLine(string.Join(" ", invitations));
                    break;
                }

                else
                {
                    string[] splitCommand = command.Split(';');
                    string action = splitCommand[0];

                    if (action == "Add filter")
                    {
                        filters = AddFilter(filters, splitCommand);
                    }

                    else if (action == "Remove filter")
                    {
                        filters = RemoveFilter(filters, splitCommand);
                    }
                }
            }
        }
    }
}