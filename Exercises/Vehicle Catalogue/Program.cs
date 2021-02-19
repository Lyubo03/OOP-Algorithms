using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace Vehicle_Catalogue
{
    public class Program
    {
        public static void Input(Dictionary<string, List<Vehicle>> vehicles)
        {
            string[] input = Console.ReadLine().Split();
            while (input[0].ToLower() != "end")
            {
                string type = input[0], model = input[1], color = input[2]; int horsePower = int.Parse(input[3]);
                Vehicle vehicle = new Vehicle(type, model, color, horsePower);
                if (!vehicles.ContainsKey(type))
                {
                    vehicles[type] = new List<Vehicle>();
                }
                vehicles[type].Add(vehicle);
                input = Console.ReadLine().Split();
            }
        }
        public static void ViewCatalog(Dictionary<string, List<Vehicle>> vehicles)
        {
            string input = Console.ReadLine();
            while (input.ToLower() != "close the catalogue")
            {
                foreach (var kvp in vehicles)
                {
                    foreach (var vehicle in kvp.Value)
                    {
                        if (input==vehicle.Model)
                        {
                            Console.WriteLine(vehicle.ToString());
                            break;
                        }

                    }
                }
                input = Console.ReadLine();
            }
        }
        static string GetHorsePower(Dictionary<string, List<Vehicle>> vehicles)
        {
            int truckHp = 0;
            int carHp = 0;
            foreach (var kvp in vehicles)
            {
                foreach (var vehicle in kvp.Value)
                {
                    if (kvp.Key == "truck")
                    {
                        truckHp += vehicle.HorsePower;
                    }
                    else
                    {
                        carHp += vehicle.HorsePower;
                    }
                }
            }
            string result = $"Cars have average horsepower of: {carHp / vehicles["car"].Count}.\n" +
                $"Trucks have average horsepower of: {truckHp / vehicles["truck"].Count}.";
            return result;
        }
        public static void Main()
        {
            Dictionary<string, List<Vehicle>> vehicles = new Dictionary<string, List<Vehicle>>();
            Input(vehicles);
            ViewCatalog(vehicles);
            Console.WriteLine(GetHorsePower(vehicles));
        }
    }
}