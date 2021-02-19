namespace Telephony
{
    using System;
    using System.Linq;
    public class Smartphone : ISmartphone
    {
        public Smartphone()
        {

        }
        private char[] digits = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public string Browsing(string URL)
        {
            //char[] toChar = URL.ToCharArray();
            //Func<char[], char[], bool> ContainsDigits = (arr, digits) =>
            // {
            //     for (int i = 0; i < arr.Length; i++)
            //     {
            //         for (int w = 0; w < digits.Length; w++)
            //         {
            //             if (arr[i] == digits[w])
            //             {
            //                 return true;
            //             }
            //         }
            //     }
            //     return false;
            // };
            if (URL.Any(ch => char.IsDigit(ch)))
            {
                throw new ArgumentException("Invalid URL!");
            }
            return $"Browsing: {URL}!";
        }

        public string Calling(string number)
        {
            if (number.Any(ch => char.IsLetter(ch)))
            {
                throw new ArgumentException("Invalid number!");
            }
            return $"Calling... {number}";
        }
    }
}