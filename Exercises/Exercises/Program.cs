using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Advertisement adv = new Advertisement();
                Console.WriteLine(adv.GenerateAdv());
            }
        }
    }
}
