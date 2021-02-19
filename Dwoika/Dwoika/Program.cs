namespace Dwoika
{
    using System;

    public class Program
    {
        public static double Value(double x, int n)
        {
            double value = 1;

            for (int i = 0; i < n; i++)
            {
                value = 1 + (x / value);
            }

            return value;
        }
        public static void Main()
        {
            //double x = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            for (double i = 2; i < 3.1; i += 0.1)
            {
                Console.WriteLine($"{count} {Value(i, n)}");
                count++;
            }
        }
    }
}