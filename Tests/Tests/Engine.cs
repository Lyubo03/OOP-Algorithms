namespace Tests
{
    using System.Collections.Generic;
    using System;
    public class Engine
    {
        public Engine()
        { 
        }
        public int GetSumOfTheDigits(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                sum += (number % 10) * (number % 10);
                number /= 10;
            }

            return sum;
        }
        public void HappyNumbers()
        {
            int number = int.Parse(Console.ReadLine());
            int currentNumber = number;
            Dictionary<int, int> sequence = new Dictionary<int, int>();


            while (currentNumber != 1)
            {
                currentNumber = GetSumOfTheDigits(currentNumber);

                if (sequence.ContainsKey(currentNumber))
                {
                    Console.WriteLine("Sad");
                    return;
                }

                sequence[currentNumber] = currentNumber;
            }

            Console.WriteLine("Happy");
        }


    }
}