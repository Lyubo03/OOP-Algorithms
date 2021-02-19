using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Truck
    {
        private string name;
        private int capacity;
        List<Freight> freights = new List<Freight>();
        private static int counter;
        public Truck(string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
        }
        public List<Freight> GetFreights
        {
            get { return freights; }
        }
        public string Name
        {
            get { return name; }
        }
        public int Capacity
        {
            get { return capacity; }
        }
        public void GetFreight(Freight freight)
        {
            if (freight.Mass > capacity)
            {
                Console.WriteLine($"{name} can't loaded {freight.Name}");
            }
            else
            {
                freights.Add(freight);
                Console.WriteLine($"{name} loaded {freight.Name}");
                counter++;
            }
        }
    }
}
