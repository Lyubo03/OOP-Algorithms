using System;
using System.Linq;

namespace ConsoleApp13
{
    class Program
    {
        static int[] solve(int n)
        {
            int[] array = new int[n];
            for (int i = 1, counter = 0; counter < n; i++)
            {
                int num = i;
                array[counter] = num;
                counter++;
                num *= 10;
                int ten = 10;
                while (num <= n)
                {
                    if (!array.Contains(num))
                    {
                        array[counter] = num;
                        counter++;
                    }
                    ten *= 10;
                    num *= 10;
                }
                num++;
                while (!array.Contains(num) && num <= n)
                {

                    array[counter] = num;
                    counter++;
                    num++;
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(" ", solve(n)));
        }
    }
}
