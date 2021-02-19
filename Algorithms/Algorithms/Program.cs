namespace Algorithms
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading;

    public class Program
    {
        static void SelectionSort<T>(T[] arr)
            where T : IComparable
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int index = i;
                for (int w = i + 1; w < arr.Length; w++)
                {
                    if (arr[i].CompareTo(arr[w]) > 0)
                    {
                        index = w;
                    }
                }
                if (arr[index].CompareTo(arr[i]) < 0)
                {
                    T temp = arr[i];
                    arr[i] = arr[index];
                    arr[index] = temp;
                }
            }
        }
        public static int Sum(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                return 0;
            }
            int current = arr[index] + Sum(arr, index + 1);
            return current;
        }
        public static int Factoriel(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            return num * Factoriel(num - 1);
        }
        public static void Print(int num)
        {
            if (num == 0)
            {
                return;
            }

            Console.WriteLine(new string('*', num));
            Print(num - 1);

            Console.WriteLine(new string('#', num));
        }
        public static void Generate(int index, int[] arr)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(string.Join(' ', arr));
                return;
            }
            for (int i = 0; i < 2; i++)
            {
                arr[index] = i;
                Generate(index + 1, arr);
            }
        }
        public static void Combinations(int[] arr, int[] vector, int border, int index)
        {
            if (index >= vector.Length)
            {
                Console.WriteLine(string.Join(' ', vector));
            }
            else
            {
                for (int i = border + 1; i < arr.Length; i++)
                {
                    vector[index] = arr[i];
                    Combinations(arr, vector, i, index + 1);
                }
            }
        }
        static int FibonacciNumbers(int f1, int f2, int counter, int n)
        {
            if (counter == n)
            {
                return f2;
            }

            return f2 + FibonacciNumbers(f1 + f2, f1, counter + 1, n);
        }
        static void PrintArray(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                return;
            }
            Console.WriteLine(arr[index]);
            PrintArray(arr, index + 1);
        }
        static int DigitsCounter(int num, int count)
        {
            if (num == 0)
            {
                return 0;
            }
            return count + 1 + DigitsCounter(num / 10, count);
        }
        static int DigitsSum(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            return num % 10 + DigitsSum(num / 10);
        }
        static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return GCD(b, a % b);
        }
        static void MaxElement(int[] arr, int max, int counter)
        {
            if (counter == arr.Length)
            {
                Console.WriteLine(max);
                return;
            }
            if (arr[counter] > max)
            {
                max = arr[counter];
            }
            MaxElement(arr, max, counter + 1);
        }
        static void DrawTriangle(int n)
        {
            if (n == 0)
            {

                return;
            }
            Console.WriteLine(new string('*', n));
            DrawTriangle(n - 1);
            Console.WriteLine(new string('@', n));
        }
        static void PrintEvenAndOdd(int[] arr, int counter)
        {
            if (arr.Length == counter)
            {
                Console.WriteLine();
                return;
            }

            else if (arr[counter] % 2 == 0)
            {
                Console.Write($"{arr[counter]} ");
            }
            PrintEvenAndOdd(arr, counter + 1);

            if (arr[counter] % 2 != 0)
            {
                Console.Write($"{arr[counter]} ");
            }
        }
        static void GenerateCombinations(int[] arr, int[] vector, int index, int border)
        {
            if (index == vector.Length)
            {
                Console.WriteLine(string.Join(' ', vector));
                return;
            }
            for (int i = border; i < arr.Length; i++)
            {
                vector[index] = arr[i];
                GenerateCombinations(arr, vector, index+1, i+1);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] vector = new int[k];
            GenerateCombinations(arr, vector, 0, 0);
        }
    }
}