using System;

namespace HappyNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int length = n;
            if (length >= 10)
            {
                length = 10;
            }
            for (int first = 1; first < length; first++)
            {
                for (int second = 0; second < length; second++)
                {
                    if (n % (first + second) == 0)
                    {
                        for (int third = 0; third < length; third++)
                        {
                            for (int fourth = 0; fourth < length; fourth++)
                            {
                                if (first + second == third + fourth)
                                {
                                    Console.Write($"{first}{second}{third}{fourth} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}