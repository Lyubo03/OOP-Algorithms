using System;
using System.Collections.Generic;

namespace CarsAndTheirCargo
{
    class Program
    {
        static void Main(string[] args)
        {
            int nOfInputs = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < nOfInputs; i++)
            {
                List<Tire> tires = new List<Tire>();
                string[] input = Console.ReadLine().Split();
                string model = input[0]; int engineSpeed = int.Parse(input[1]); int enginePower = int.Parse(input[2]); int cargoWeigth = int.Parse(input[3]);
                string cargoType = input[4];
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeigth, cargoType);
                for (int tiresInfo = 5; tiresInfo < input.Length - 1; tiresInfo+=2)
                {
                    double tirePressure = double.Parse(input[tiresInfo]);
                    int tireAge = int.Parse(input[tiresInfo + 1]);
                    Tire tire = new Tire(tirePressure, tireAge);
                    tires.Add(tire);
                }
                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }
            string lastInput = Console.ReadLine();
            bool canPrint = false;
            if (lastInput == "fragile")
            {
                foreach (var car in cars)
                {
                    if (car.GetCargo.GetCargoType() == "fragile")
                    {
                        foreach (var tire in car.GetTires)
                        {
                            if (tire.GetTirePressure() < 1)
                            {
                                canPrint = true;
                                break;
                            }
                        }
                    }
                    if (canPrint)
                    {
                        Console.WriteLine(car.Model());
                    }
                }
            }
            if (lastInput == "flamable")
            {
                foreach (var car in cars)
                {
                    if (car.GetCargo.GetCargoType() == "flamable")
                    {
                        if (car.GetEngine.EnginePower() >250)
                        {
                            Console.WriteLine(car.Model());
                        }
                    }
                }
            }
        }
    }
}