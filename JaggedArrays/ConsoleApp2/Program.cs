using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        public static char[] map = GetAlphabet(map);
        public static char[] GetAlphabet(char[] alphabet)
        {
            char[] arr = new char[27];
            int counter = 1;
            for (char i = 'a'; i <= 'z'; i++)
            {
                arr[counter] = i;
                counter++;
            }
            return arr;
        }
        //{ 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o','p','q','r','s','t','u','v','w','x','y','z' };
        public static int solve(string message)
        {
            if (message.Length == 0)
            {
                return 0;
            }
            int repeated = 0;
            int digits = 0;
            int.TryParse(message, out digits);
            for (int i = message.Length - 1; i >= 0; i++)
            {
                int ten = 1;
                int k = digits;
                while (k != 0)
                {

                }
                ten *= 10;
            }
            return repeated;
        }
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            Console.WriteLine(solve(message));
        }
    }
}

