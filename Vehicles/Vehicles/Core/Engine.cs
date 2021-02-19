using System;

namespace Vehicles.Core
{
    public class Engine : IEngine
    {
        public string FinalInput { get; protected set; }
        public Engine()
        {

        }
        public void Run()
        {

            Car car = CreateCar();
            Truck truck = CreateTruck();
            Bus bus = CreateBus();

            PerformCommands(car, truck, bus);
            FinalInput = $"Car: {car.FuelQuantity:F2}{Environment.NewLine}Truck: {truck.FuelQuantity:F2}{Environment.NewLine}Bus: {bus.FuelQuantity:F2}";
        }
        public static Car CreateCar()
        {
            string[] info = Console.ReadLine().Split();
            double fuelQuantity = double.Parse(info[1]);
            double fuelConsumption = double.Parse(info[2]);
            double tankCapacity = double.Parse(info[3]);

            try
            {
                return new Car(tankCapacity, fuelQuantity, fuelConsumption);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            return new Car(tankCapacity, 0, fuelConsumption);

        }
        public static Truck CreateTruck()
        {
            string[] info = Console.ReadLine().Split();
            double fuelQuantity = double.Parse(info[1]);
            double fuelConsumption = double.Parse(info[2]);
            double tankCapacity = double.Parse(info[3]);
            try
            {
                return new Truck(tankCapacity, fuelQuantity, fuelConsumption);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new Truck(tankCapacity, 0, fuelConsumption);
        }
        public static Bus CreateBus()
        {
            string[] info = Console.ReadLine().Split();
            double fuelQuantity = double.Parse(info[1]);
            double fuelConsumption = double.Parse(info[2]);
            double tankCapacity = double.Parse(info[3]);

            try
            {
                return new Bus(tankCapacity, fuelQuantity, fuelConsumption);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new Bus(tankCapacity, 0, fuelConsumption);
        }
        public static void PerformCommands(Car car, Truck truck, Bus bus)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();

                string command = commands[0];
                string vehicle = commands[1];
                double quantity = double.Parse(commands[2]);

                if (command == "Drive")
                {
                    if (vehicle == "Car")
                    {
                        Console.WriteLine(car.Drive(quantity));
                    }
                    else if (vehicle == "Truck")
                    {
                        Console.WriteLine(truck.Drive(quantity));
                    }
                    else if (vehicle == "Bus")
                    {
                        Console.WriteLine(bus.Drive(quantity));
                    }
                }
                else if (command == "DriveEmpty")
                {
                    Console.WriteLine(bus.DriveEmpty(quantity));
                }
                else if (command == "Refuel")
                {
                    try
                    {
                        if (vehicle == "Car")
                        {
                            car.Refuel(quantity);
                        }
                        else if (vehicle == "Truck")
                        {
                            truck.Refuel(quantity);
                        }
                        else if (vehicle == "Bus")
                        {
                            truck.Refuel(quantity);
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }
            }

        }
    }
}