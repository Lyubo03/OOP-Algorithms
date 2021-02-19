namespace Exceptions
{
    using System;
    public class Engine : IEngine
    {
        private int x1;
        private int y1;
        private int a;
        public Engine()
        {
        }

        public void Run()
        {
            try
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());

                if (a + b > c && b + c > a && a + c > b)
                {
                    Console.WriteLine("Може да съществува такъв триъгълник");

                    double P = a + b + c;
                    double p = P / 2;
                    double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                    if (a != b && b != c && c != a)
                    {
                        Console.WriteLine("Разностранен");
                    }
                    else if (a == b && c != a || b == c && c != a || c == a && b != a)
                    {
                        Console.WriteLine("Равнобедрен");
                    }
                    else
                    {
                        Console.WriteLine("Равностранен");
                    }

                    Console.WriteLine($"S = {s:F2}{Environment.NewLine}P = {P:F2}");
                }
                else
                {
                    Console.WriteLine("Не може да съществува");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
//try
//{
//    a = int.Parse(Console.ReadLine());
//    while (b == 0)
//    {
//        try
//        {
//            b = int.Parse(Console.ReadLine());

//            if (b == 0)
//            {
//                throw new ArgumentException("Can't be null!");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }

//    int c = a / b;
//    Console.WriteLine(@$"{a} \ {b} = {c}");
//}
//catch (FormatException argException)
//{

//    Console.WriteLine($"Въведете цяло число!");
//}
//catch (OverflowException overFlowExc)
//{
//    Console.WriteLine(overFlowExc.Message);
//}
// zad 2
//try
//            {
//                int x1 = int.Parse(Console.ReadLine());
//int y1 = int.Parse(Console.ReadLine());
//int a = int.Parse(Console.ReadLine());

//                if (a <= 0)
//                {
//                    throw new ArgumentException("a can't be negative or null!");
//                }

//                int x = int.Parse(Console.ReadLine());
//int y = int.Parse(Console.ReadLine());

//                if (x >= a + x1 || x <= x1 || y1 >= y || y1 + a <= y)
//                {
//                    //throw new ArgumentException("Извън границите на квадрата");
//                    Console.WriteLine("Извън границите на квадрата!");
//                }

//                else
//                {
//                    Console.WriteLine("В границите");
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }