using System;
using System.Linq;

namespace ConsoleApp11
{
    class Program
    {
        // 5 23 6
        // 123 456786 123
        // 12 3456 78
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] leftRow = TakeLeftElements(elements).Reverse().ToArray();
            int[] rightRow = TakeRightElements(elements).Reverse().ToArray();
            int[] middleElements = TakeMiddleElements(elements).ToArray();
            int[] sum = Sum(leftRow, middleElements, rightRow);
            Console.WriteLine(string.Join(", ", sum));
        }
        static int[] Sum(int[] leftRow, int[] middleRow, int[] rightRow)
        {
            int[] sum = new int[middleRow.Length];
            for (int i = 0, counter = 0; i < middleRow.Length; i++)
            {
                if (middleRow.Length / 2 > i)
                {
                    sum[i] = leftRow[i] + middleRow[i];
                }
                else
                {
                    sum[i] = middleRow[i] + rightRow[counter];
                    counter++;
                }
            }
            return sum;
        }
        static int[] TakeMiddleElements(int[] elements)
        {
            int[] middleElements = new int[elements.Length - (elements.Length / 4) * 2];
            for (int i = elements.Length / 4, counter = 0; i < elements.Length - elements.Length / 4; i++, counter++)
            {
                middleElements[counter] = elements[i];
            }
            return middleElements;
        }
        static int[] TakeLeftElements(int[] elements)
        {
            int[] leftElements = new int[elements.Length / 4];
            for (int i = 0; i < elements.Length / 4; i++)
            {
                leftElements[i] = elements[i];
            }
            return leftElements;
        }
        static int[] TakeRightElements(int[] elements)
        {
            int[] rightElements = new int[elements.Length / 4];
            for (int i = elements.Length - (elements.Length / 4), counter = 0; i < elements.Length; i++)
            {
                rightElements[counter] = elements[i];
                counter++;
            }
            return rightElements;
        }
    }
}
