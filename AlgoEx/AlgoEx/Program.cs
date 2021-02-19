namespace AlgoEx
{
    using System;
    class Program
    {
        static int Count(string str, char symbol)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == symbol)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int maxTimes = 0;

            for (int i = 0; i < strings.Length; i++)
            {
                int countA = Count(strings[i], 'A');
                int countB = Count(strings[i], 'B');
                if (countA >)
                {
                    for (int w = i + 1; w < strings.Length; w++)
                    {

                    }
                }
            }
        }
    }
}