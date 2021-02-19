using System;

namespace AfterMonth
{
    public abstract class Vehicle
    {

        public Vehicle (double fuelQuantity, double fuelConsump)
        {
            FuelConsump = fuelConsump;
            FuelQuantity = fuelQuantity;
        }
        protected double FuelQuantity { get; set; }
        protected double FuelConsump { get; set; }

        public abstract void Drive(double distance);
        public abstract void Refuel(double liters);
        public override string ToString()
        {
            double result=  Math.Round(FuelQuantity,2);
            return result.ToString();
        }
    }
}