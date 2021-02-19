using System;
using System.Linq;
using System.Text;

namespace exercisesSunday
{
    class Program
    {
        static string solve(int n)
        {
            char[] letters = new char[27];
            int counter = 1;
            for (char i = 'A'; i <= 'Z'; i++, counter++)
            {
                letters[counter] = i;
            }
            if (n<27)
            {
                return letters[n].ToString();
            }
            string letter = string.Empty;
            if(n>=27)
            {
                while (n != 0)
                {
                    letter+=letters[n % 26];
                    n = n / 26;
                }
            }
            return new string(letter.Reverse().ToArray());
        }
        static void Main(string[] args)
        {
            int prices = int.Parse(Console.ReadLine());
            Console.WriteLine(solve(prices));            
        }
    }
}
