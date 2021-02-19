using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int length = 1;
            int[][] pascalTriangle = new int[n][];
            for (int row = 0; row < n; row++)
            {
                int[] inputArray = new int[length];
                for (int col = 0; col <length; col++)
                {
                    if (col < length - 1 && row > 1 && col>0)
                    {
                        inputArray[col] = pascalTriangle[row - 1][col] + pascalTriangle[row - 1][col - 1];
                    }
                    else
                    {
                        inputArray[col] = 1;
                    }
                }
                length++;
                pascalTriangle[row] = inputArray;
            }
            n= n*2 -2;
            for (int row = 0; row < pascalTriangle.Length; row++)
            {
                Console.Write(new string(' ', n));
                for (int col = 0; col < pascalTriangle[row].Length; col++)
                {
                    Console.Write(pascalTriangle[row][col] + "   "); 
                }
                Console.WriteLine();
                n -= 2;
            }
        }
    }
}