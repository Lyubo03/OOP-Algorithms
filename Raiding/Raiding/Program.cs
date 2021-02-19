using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Tesla tesla = new Tesla("X", 2 ,"Gray");
            Console.WriteLine(tesla.Start());
            Console.WriteLine(tesla.IntroduceYourself());
            Console.WriteLine(tesla.Stop());
        }
    }
}
