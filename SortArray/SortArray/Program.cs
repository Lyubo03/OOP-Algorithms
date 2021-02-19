using System;
using System.Linq;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < elements.Length; i++)
            {
                for (int w = 0; w < elements.Length - 1; w++)
                {
                    if (elements[w] > elements[w + 1])
                    {
                        int temp = elements[w];
                        elements[w] = elements[w + 1];
                        elements[w + 1] = temp;
                    }
                }
            }
        }
    }
}
