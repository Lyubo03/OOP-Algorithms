using System;
using System.Linq;
using System.Collections.Generic;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            int n = int.Parse(Console.ReadLine());
            HashSet<Car> cars = new HashSet<Car>();
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();
                string model = input[0]; double fuelAmount = double.Parse(input[1]); double fuelConsumption = double.Parse(input[2]);
                Car car = new Car(model);
                if (!cars.Add(car))
                {
                    throw new InvalidOperationException("error");
                }
                else
                {
                    cars.Add(car);
                    car.fuelAmount = fuelAmount;
                    car.fuelConsumption = fuelConsumption;
                }
            }
            input = Console.ReadLine().Split();
            while (input[0] != "End")
            {
                string carModel = input[1]; double amountOfKm = double.Parse(input[2]);
                foreach (var item in cars)
                {
                    if (item.GetModel() == carModel)
                    {
                        item.IsEnoughFuel(amountOfKm);
                    }
                }
                input = Console.ReadLine().Split();
            }
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.GetModel()} {item.GetFuelAmount():F2} {item.GetTraveledDistance()}");
            }
        }
    }
}
