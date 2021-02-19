using System;

namespace Car_Salesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int nOfInputs = int.Parse(Console.ReadLine());
            string[] input; Engine[] engines = new Engine[nOfInputs];
            for (int i = 0; i < nOfInputs; i++)
            {
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int displacement; string efficiency;
                string model = input[0]; int power = int.Parse(input[1]);
                Engine engine = new Engine();
                engine.Model = model; engine.Power = power;
                if (input.Length == 3)
                {
                    if (int.TryParse(input[2], out displacement))
                    {
                        engine.Displacement = displacement;
                    }
                    else
                    {
                        efficiency = input[2];
                        engine.Efficiency = efficiency;
                    }
                }
                else if (input.Length == 4)
                {
                    displacement = int.Parse(input[2]);
                    engine.Displacement = displacement;
                    efficiency = input[3];
                    engine.Efficiency = efficiency;
                }
                engines[i] = engine;
            }
            nOfInputs = int.Parse(Console.ReadLine());
            Car[] cars = new Car[nOfInputs];
            for (int i = 0; i < nOfInputs; i++)
            {
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car();
                string model = input[0]; string engineName = input[1];
                car.Model = model;
                foreach (var eng in engines)
                {
                    if (eng.Model == engineName)
                    {
                        car.Engine = eng;
                        break;
                    }
                }
                int weight; string color;
                if (input.Length == 3)
                {
                    if (int.TryParse(input[2], out weight))
                    {
                        car.Weight = weight;
                    }
                    else
                    {
                        color = input[2];
                        car.Color = color;
                    }
                }
                else if (input.Length == 4)
                {
                    weight = int.Parse(input[2]);
                    color = input[3];
                    car.Weight = weight;
                    car.Color = color;
                }
                cars[i] = car;
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car.Model);
                Console.WriteLine($"  {car.Engine.Model}\r\n    Power: {car.Engine.Power}");
                if (car.Engine.Displacement == 0)
                {
                    Console.WriteLine("    Displacement: n/a");
                }
                else
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                if (car.Weight == 0)
                {
                    Console.WriteLine("  Weight: n/a");
                }
                else
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
