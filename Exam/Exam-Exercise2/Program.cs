using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_Exercise2
{
    class Program
    {
        static void EndingOnEightOrFour(List<int> digits, List<int> fourOrEight)
        {
            for (int i = 0; i < digits.Count; i++)
            {
                if (digits[i] % 10 == 8 || digits[i] % 10 == 4)
                {
                    fourOrEight.Add(digits[i]);
                }
            }
        }
        static void EndingOnFiveOrSeven(List<int> digits, List<int> fiveOrSeven)
        {
            for (int i = 0; i < digits.Count; i++)
            {
                if (digits[i] % 10 == 7 || digits[i] % 10 == 5)
                {
                    fiveOrSeven.Add(digits[i]);
                }
            }
        }
        static void SumOfDigits(List<int> digits, List<int> fiveOrSeven)
        {
            for (int i = 0; i < digits.Count; i++)
            {
                int sum = 0;
                int num = digits[i];
                while (num != 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                if (sum == 15)
                {
                    fiveOrSeven.Add(digits[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            //58,87,96,45,14
            List<int> digits = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            List<int> fourOrEight = new List<int>();
            EndingOnEightOrFour(digits, fourOrEight);
            List<int> fiveOrSeven = new List<int>();
            EndingOnFiveOrSeven(digits, fiveOrSeven);
            List<int> sum = new List<int>();
            SumOfDigits(digits, sum);
            Console.WriteLine(string.Join(", ", fourOrEight));
            Console.WriteLine(string.Join(", ", fiveOrSeven));
            Console.WriteLine(string.Join(", ", sum));
        }
    }
}