using System;
using System.Data;
using System.Linq;
using System.Numerics;

namespace Binary
{
    class Program
    {
        static int[][] solve(int[][] matrix)
        {
            int[][] newMatrix = new int[matrix.Length][];
            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i].Contains(0))
                {
                    newMatrix[i] = new int[matrix[i].Length];
                    for (int w = 0; w < matrix[i].Length; w++)
                    {
                        newMatrix[i][w] = 0;
                    }
                }
                else
                {
                    newMatrix[i] = matrix[i];
                }
            }
            for (int i = 0; i < matrix[0].Length; i++)
            {
                for (int w = 0; w < matrix.Length; w++)
                {
                    if (matrix[i][w] == 0)
                    {
                        for (int k = 0; k < matrix.Length; k++)
                        {
                            newMatrix[k][w] = 0;
                        }
                    }
                }
            }
            return newMatrix;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] array = new int[n][];
            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                array[i] = arr;
            }
            Console.WriteLine();
            array = solve(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(string.Join(" ", array[i]));
            }
        }
    }
}
