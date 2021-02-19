using System;
using System.Collections.Generic;

namespace Students
{
    class StartUp
    {
        static void EnterTrucks(List<Truck> trucks, string[] input)
        {
            for (int i = 0; i < input.Length - 1; i += 2)
            {
                string name = input[i]; int capacity = int.Parse(input[i + 1]);
                Truck truck = new Truck(name, capacity);
                trucks.Add(truck);
            }
        }
        static void EnterFreights(List<Freight> freights, string[] input)
        {
            for (int i = 0; i < input.Length - 1; i += 2)
            {
                string name = input[i]; int capacity = int.Parse(input[i + 1]);
                Freight freight = new Freight(); freight.Mass = capacity; freight.Name = name;
                freights.Add(freight);
            }
        }
        static void LoadTrucksWithFreights(List<Freight> freights, List<Truck> trucks, string[] input)
        {
            string truckName = input[0]; string freightName = input[1];
            foreach (var item in freights)
            {
                if (item.Name == freightName)
                {
                    foreach (var truck in trucks)
                    {
                        if (truck.Name == truckName)
                        {
                            truck.GetFreight(item);
                            break;
                        }
                    }
                    break;
                }
            }
        }
        static void Print(List<Freight> freights, List<Truck> trucks)
        {
            foreach (var truck in trucks)
            {
                if (truck.GetFreights.Count > 0)
                {
                    string result = null;
                    foreach (var item in truck.GetFreights)
                    {
                        result += item.Name + ", ";
                    }
                    Console.WriteLine($"{truck.Name} - {result.TrimEnd(',', ' ')}");
                }
                else
                {
                    Console.WriteLine($"{truck.Name} - Nothing loaded");
                }
            }
        }
        static void Main(string[] args)
        {
            List<Truck> trucks = new List<Truck>();
            List<Freight> freights = new List<Freight>();
            string[] input = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
            EnterTrucks(trucks, input);
            input = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
            EnterFreights(freights, input);
            input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (input[0].ToLower() != "end")
            {
                LoadTrucksWithFreights(freights, trucks, input);
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            Print(freights, trucks);
        }
    }
}
