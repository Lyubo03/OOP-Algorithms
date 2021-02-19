namespace ConsoleApp16
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(solve(input));
        }

        private static string solve(string input)
        {
            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                int counter = 0;
                int w = i;
                while (w < input.Length)
                {
                   
                    if (input[i] == input[w])
                    {
                        counter++;
                        w++;
                    }
                    else
                    {
                        result += $"{counter}{input[i]}";
                        i = w;
                        break;
                    }
                }
            }

            return result;
        }

        private static bool DoesContains(int i)
        {
            return true;
        }
    }
}