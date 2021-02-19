using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        private static int[] ascii = new int[] { 48, 49, 50, 51, 52, 53, 54, 55, 56, 57 };
        static int[] SumOfString(string value1, string value2)
        {
            List<int> number1 = convertToInt(value1);
            List<int> number2 = convertToInt(value2);
            if (number1.Count > number2.Count)
            {
                number2.Reverse();
                while (number1.Count != number2.Count)
                {
                    number2.Add(0);
                }
                number2.Reverse();
            }
            if (number1.Count < number2.Count)
            {
                number1.Reverse();
                while (number1.Count != number2.Count)
                {
                    number1.Add(0);
                }
                number1.Reverse();
            }
            int[] result = new int[number1.Count];
            int helper;
            for (int i = number1.Count - 1; i >= 0; i--)
            {
                helper = number1[i] + number2[i];
                if (helper > 9)
                {
                    if (i == 0)
                    {
                        result[i] += helper;
                    }
                    else
                    {
                        result[i] += helper % 10;
                        helper /= 10;
                        result[i - 1] += helper;
                    }
                }
                else
                {
                    int res = result[i] + helper;
                    if (res <= 9)
                    {
                        result[i] += helper;
                    }
                    else if (res > 9 && i == 0)
                    {
                        result[i] = res;
                    }
                    else if (res > 9 && i != 0)
                    {
                        result[i] = res % 10;
                        res /= 10;
                        result[i - 1] += res;
                    }

                }
            }
            return result;
        }
        static List<int> convertToInt(string value)
        {
            char[] digitsOfNum = value.ToCharArray();
            List<int> number = new List<int>();
            for (int i = 0; i < digitsOfNum.Length; i++)
            {
                for (int w = 0; w < ascii.Length; w++)
                {
                    if (Convert.ToInt32(digitsOfNum[i]) == ascii[w])
                    {
                        number.Add(w);
                        break;
                    }
                }
            }
            return number;
        }
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            int[] final = SumOfString(num1, num2);
            for (int i = 0; i < final.Length; i++)
            {
                Console.Write(final[i]);
            }
            Console.WriteLine();
        }
    }
}
