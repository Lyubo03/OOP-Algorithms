namespace Switch_Case
{
    using System;

    public class Program
    {
        public static long Factorial(int n)
        {
            
            long factorial = 1;

            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
        public static void PowerNumber(int a, ref int second, ref int third, ref int fourth)
        {
            second = a * a;
            third = a * a * a;
            fourth = a * a * a * a;
        }
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Func<int, long> Factoriel = n =>
            {
                long factorial = 1;

                for (int i = 2; i <= n; i++)
                {
                    factorial *= i;
                }

                return factorial;
            };

























            //int n = int.Parse(Console.ReadLine());
            //int day = 0;
            //int month = 0;
            //int year = 0;
            //int maxDay = 0;

            //switch (month)
            //{
            //    case 1: maxDay = 31; break;
            //    case 2:
            //        if (year % 4 == 0)
            //        {
            //            maxDay = 29; break;
            //        }
            //        else
            //        {
            //            maxDay = 28; break;
            //        }



            //    case 3: maxDay = 31; break;
            //    case 4: maxDay = 30; break;
            //    case 5: maxDay = 31; break;
            //    case 6: maxDay = 30; break;
            //    case 7: maxDay = 31; break;
            //    case 8: maxDay = 31; break;
            //    case 9: maxDay = 30; break;
            //    case 10: maxDay = 31; break;
            //    case 11: maxDay = 30; break;
            //    case 12: maxDay = 31; break;
            //    default: throw new ArgumentException("Invalid month");
            //}

            //if (day + n > maxDay)
            //{
            //    month +=;
            //    if (month)
            //    {

            //    }
            //}
        }
    }
}