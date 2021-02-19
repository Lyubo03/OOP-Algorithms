using System;
using System.Collections.Generic;
using System.Net;

namespace Practise
{
    class Program
    {
        static void InputTrucks(Dictionary<string, Truck> trucks)
        {
            string[] input = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length - 1; i += 2)
            {
                string name = input[i];
                int weight = int.Parse(input[i + 1]);
                Truck truck = new Truck(name, weight);
                if (!trucks.ContainsKey(name))
                {
                    trucks[name] = truck;
                }
            }
        }
        static void InputFreights(Dictionary<string, Freight> freights)
        {
            string[] input = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length - 1; i += 2)
            {
                string name = input[i];
                int weight = int.Parse(input[i + 1]);
                Freight freight = new Freight(name, weight);
                if (!freights.ContainsKey(name))
                {
                    freights[name] = freight;
                }
            }
        }
        static void Input(Dictionary<string, Truck> trucks, Dictionary<string, Freight> freights)
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0].ToLower() == "end")
                {
                    break;
                }
                string truckName = input[0]; string freightName = input[1];
                trucks[truckName].EnoughCapacity(trucks[truckName], freights[freightName]);
            }
        }
        static void TruckRewiev(Dictionary<string, Truck> trucks)
        {
            foreach (var truck in trucks)
            {
                Console.WriteLine(truck.Value.TruckReview(truck.Value));
            }
        }
        public static void Main(string[] args)
        {
            Dictionary<string, Truck> trucks = new Dictionary<string, Truck>();
            Dictionary<string, Freight> freights = new Dictionary<string, Freight>();
            InputTrucks(trucks);
            InputFreights(freights);
            Input(trucks, freights);
            TruckRewiev(trucks);
        }
    }
}