namespace Generics_Exercise
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();

            for (int i = 0; i < n; i++)
            {
                box.Add(double.Parse(Console.ReadLine()));

            }
            
            double element = double.Parse(Console.ReadLine()   );

            int result = box.Compare(element);

            Console.Write(result);
        }
    }
}