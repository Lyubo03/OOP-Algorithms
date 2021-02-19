using System;
using System.Linq;

namespace BasicProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == x)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
