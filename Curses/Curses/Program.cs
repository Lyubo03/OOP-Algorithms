using System;
using System.Linq;
using System.Collections.Generic;

namespace Curses
{
    class Program
    {
        static void Main(string[] args)
        {
            BancAccount acc = new BancAccount();
            string[] command = Console.ReadLine().Split();
            while (command[0]!="END")
            {
                switch (command[0])
                {
                    case "Create":
                        acc.SetId(int.Parse(command[1]));
                        break;
                    default:
                        break;
                }
                //personOne.SetId(int.Parse(Console.ReadLine()));
                //personOne.SetBalance(double.Parse(Console.ReadLine()));
                //personOne.Whithdraw(double.Parse(Console.ReadLine()));
                //Console.WriteLine(personOne.ToString());
            }
        }
    }
}