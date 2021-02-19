namespace CarsSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class CarSalesman
    {
        static void Main(string[] args)
        {
            EngineCatalog engineCatalog = new EngineCatalog();
            int engineCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < engineCount; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                engineCatalog.Add(parameters);
            }

            int carCount = int.Parse(Console.ReadLine());
            CarCatalog carCatalog = new CarCatalog();
            for (int i = 0; i < carCount; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                carCatalog.Add(parameters, engineCatalog);
            }

            Console.WriteLine(carCatalog.RewievCatalog());
        }
    }
}