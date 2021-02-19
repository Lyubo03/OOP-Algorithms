namespace Test
{
    using System;
    public class Program
    {
        public static int CalculateDaysInMonth(int month, int year)
        {
            switch (month)
            {
                case 1: return 31;
                case 2:
                    if (year % 4 == 0)
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }

                case 3: return 31;
                case 4: return 30;
                case 5: return 31;
                case 6: return 30;
                case 7: return 31;
                case 8: return 31;
                case 9: return 30;
                case 10: return 31;
                case 11: return 30;
                case 12: return 31;
                default: throw new ArgumentException("Invalid month");
            }
        }
        public static void Main()
        {
            int i = 0;
            int w = 0;
            for ( ; i < 10; ++i, w++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("res");
            Console.WriteLine(i);
            Console.WriteLine(w);
        }
    }
}
//int n = int.Parse(Console.ReadLine());
//int neededDays = int.Parse(Console.ReadLine());
//int day = int.Parse(Console.ReadLine());
//int month = int.Parse(Console.ReadLine());
//int year = int.Parse(Console.ReadLine());

//int daysOfWalking = n * neededDays + n * (neededDays - 1) + 1;
//int daysInMonth = CalculateDaysInMonth(month, year);

//daysOfWalking += day;
//if (daysInMonth < daysOfWalking)
//{
//    month += 1;
//    daysOfWalking -= daysInMonth;

//    if (month > 12)
//    {
//        month -= 12;
//        year++;
//    }
//}

//Console.WriteLine($"{daysOfWalking}.{month}.{year}");