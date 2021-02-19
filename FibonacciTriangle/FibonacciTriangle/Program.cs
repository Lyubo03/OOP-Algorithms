namespace FibonacciTriangle
{
    using System;
    using System.Buffers;
    using System.Xml;

    public class Program
    {
        static void Main(string[] args)
        {
            Action<int[][]> PrintTriangle = arr =>
            {
                for (int i = 0, spaces = arr.Length-1; i < arr.Length; i++, spaces--)
                {
                    Console.Write(new string(' ', spaces));
                    Console.WriteLine(string.Join("  ", arr[i]));
                }
            };
            int n = int.Parse(Console.ReadLine());
            int[][] triangle = new int[n][];
            triangle[0] = new int[] { 1 };

            for (int indexOfArray = 1; indexOfArray < n; indexOfArray++)
            {
                triangle[indexOfArray] = new int[indexOfArray + 1];
                triangle[indexOfArray][0] = 1;
                triangle[indexOfArray][triangle[indexOfArray].Length - 1] = 1;

                for (int indexInArray = 1; indexInArray < triangle[indexOfArray].Length - 1; indexInArray++)
                {
                    triangle[indexOfArray][indexInArray] =
                        triangle[indexOfArray - 1][indexInArray - 1]
                        + triangle[indexOfArray - 1][indexInArray];
                }
            }

            PrintTriangle(triangle);
        }
    }
}
