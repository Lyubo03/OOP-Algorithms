using System;

namespace Ferrari
{
   public class StartUp
    {
        private const string Model = "488-Spider";
        public static void Main(string[] args)
        {
            var driver = Console.ReadLine();
            var car = new Ferrari(driver, Model);
            Console.WriteLine(car);
            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(Icar).Name;
            Console.WriteLine(car.ToString());
        }
    }
}
