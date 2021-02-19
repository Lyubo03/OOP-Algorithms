using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExamPrep
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^!([A-Z][a-z]{2,})\!{1}\:\[([a-zA-Z]{8,})\]";
            Regex regex = new Regex(pattern);
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match isMatch = regex.Match(input);
                if (isMatch.Success)
                {
                    string result = isMatch.Groups[1].Value + ':';
                    char[] inputSeparator = isMatch.Groups[2].Value.ToCharArray();
                    foreach (var letter in inputSeparator)
                    {
                        result += " ";
                        result += letter + 0;
                    }
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
