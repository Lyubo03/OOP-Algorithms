using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Car
    {
        private string model;
        private double traveledDistance;
        public Car(string model)
        {
            this.model = model;
        }
        public string GetModel()
        {
            return this.model;
        }
        public double fuelAmount { get; set; }
        public double fuelConsumption { get; set; }
        public double GetFuelAmount()
        {
            return this.fuelAmount;
        }
        public double GetTraveledDistance()
        {
            return this.traveledDistance;
        }
        public void IsEnoughFuel(double amountOfKm)
        {
            double litresNeeded = amountOfKm * fuelConsumption;
            if (fuelAmount >= litresNeeded)
            {
                traveledDistance += amountOfKm;
                fuelAmount -= litresNeeded;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
