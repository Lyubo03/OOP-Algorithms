using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        private static char[] alphabetSmall = new char[] { ' ','a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i','j', 'k', 'l', 'm', 'n', 'o',
                'p', 'q', 'r', 's', 't', 'u', 'v','w','x', 'y', 'z'};
        private static char[] alphabetCaps = new char[] { ' ','A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
                'Q', 'R', 'S', 'T', 'U', 'V','W', 'X', 'Y', 'Z' };
        private static int[] ascii = new int[] { 48, 49, 50, 51, 52, 53, 54, 55, 56, 57 };
        static double Digits(char[] word)
        {
            double num = 0;
            for (int i = 1; i < word.Length - 1; i++)
            {
                num *= 10;
                for (int w = 0; w < ascii.Length; w++)
                {
                    if (Convert.ToInt32(word[i]) == ascii[w])
                    {
                        num += w;
                        break;
                    }
                }
            }
            return num;
        }
        static double firstLetter(char[] toChar)
        {
            double num = Digits(toChar);
            double digit = 0;
            for (int w = 1; w <= alphabetCaps.Length; w++)
            {
                if (Convert.ToInt32(toChar[0]) > 64 && Convert.ToInt32(toChar[0]) < 91)
                {
                    if (alphabetCaps[w] == toChar[0])
                    {
                        digit += num / w;
                        break;
                    }
                }
                if (Convert.ToInt32(toChar[0]) > 96 && Convert.ToInt32(toChar[0]) < 123)
                {
                    if (alphabetSmall[w] == toChar[0])
                    {
                        digit += num * w;
                        break;
                    }
                }
            }
            return digit;
        }
        static double lastLetter(char[] toChar)
        {
            double digit = 0;
            for (int k = 1; k <= alphabetCaps.Length; k++)
            {
                if (Convert.ToInt32(toChar[toChar.Length - 1]) > 64 && Convert.ToInt32(toChar[toChar.Length - 1]) < 91)
                {
                    if (alphabetCaps[k] == toChar[toChar.Length - 1])
                    {
                        digit -= k;
                        break;
                    }

                }
                if (Convert.ToInt32(toChar[toChar.Length - 1]) > 96 && Convert.ToInt32(toChar[toChar.Length - 1]) < 123)
                {
                    if (alphabetSmall[k] == toChar[toChar.Length - 1])
                    {
                        digit += k;
                        break;
                    }
                }
            }
            return digit;
        }
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(' ').ToArray();
            char[] toChar;
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                toChar = nums[i].ToCharArray();
                sum += firstLetter(toChar);
                sum += lastLetter(toChar);
            }
            Console.WriteLine(sum.ToString("0.00"));
        }
    }
}
