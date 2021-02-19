using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Practise
{
    public class Truck
    {
        private string name;
        private int capacity;
        private List<Freight> freights = new List<Freight>();
        public Truck(string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
        }
        public string Name { get { return name; } }
        public int Capacity { get { return capacity; } }
        public Freight Freight { get; }
        public void EnoughCapacity(Truck truck, Freight freight)
        {
            if (truck.Capacity < freight.Mass)
            {
                Console.WriteLine($"{truck.Name} can not load Water");
            }
            else
            {
                freights.Add(freight);
                Console.WriteLine($"{truck.Name} loaded {freight.Name}");
            }
        }
        public string TruckReview(Truck truck)
        {
            string result = string.Empty;
            if (truck.freights.Any())
            {
                result = $"{truck.Name} - ";
                foreach (var freight in truck.freights)
                {
                    result += $"{freight.Name}, ";
                }
            }
            else
            {
                result = $"{truck.Name} - Nothing loaded";
            }
            return result.TrimEnd(' ',',');
        }
    }
}
