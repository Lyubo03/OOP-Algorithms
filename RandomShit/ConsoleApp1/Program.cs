using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        public static bool solve(string s)
        {
            Dictionary<char, int> check = new Dictionary<char, int>();
            bool wheather = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (!check.ContainsKey(s[i]))
                {
                    check[s[i]] = 0;
                }
                check[s[i]]++;
            }
            int count = check[s[0]];
            foreach (var item in check)
            {
                if (item.Value != count)
                {
                    wheather = false;
                    break;
                }
            }
            return wheather;
        }
        static void Main()
        {
            string n = Console.ReadLine();
            Console.WriteLine(solve(n));
        }
    }
}
