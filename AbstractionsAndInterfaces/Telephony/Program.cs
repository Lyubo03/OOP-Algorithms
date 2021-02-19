namespace Telephony
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            for (int i = 0; i < numbers.Length; i++)
            {
                try
                {

                    if (numbers[i].Length == 10)
                    {
                        Console.WriteLine(smartphone.Calling(numbers[i]));
                    }

                    else if (numbers[i].Length == 7)
                    {
                        Console.WriteLine(stationaryPhone.Dialing(numbers[i]));
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            for (int i = 0; i < urls.Length; i++)
            {
                try
                {
                    Console.WriteLine(smartphone.Browsing(urls[i]));
                }

                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}