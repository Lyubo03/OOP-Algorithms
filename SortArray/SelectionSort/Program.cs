using System;
using System.Linq;

namespace SelectionSort
{
    public class Program
    {
        static void SortArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int w = i + 1; w < array.Length; w++)
                {
                    if (array[i] > array[w])
                    {
                        int temp = array[i];
                        array[i] = array[w];
                        array[w] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // 1 3 2 4 6 5 8 10 9
            // 9 8 7 6 5 4 3 2 1
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SortArray(array);
            Console.WriteLine(string.Join(", ", array));
        }
    }
}