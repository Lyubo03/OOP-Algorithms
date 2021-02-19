namespace Vehicles
{
    using System;

    public class Vehicle : IVehicle
    {
        private double fuelQuantity;
        public Vehicle(double tankCapacity, double fuelQuantity, double fuelConsumption)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get => fuelQuantity;
            protected set
            {
                if (value > TankCapacity)
                {
                    fuelQuantity = 0;
                    throw new ArgumentException($"Cannot fit {value} fuel in the tank");
                }
                this.fuelQuantity = value;
            }
        }

        public double FuelConsumption { get; protected set; }

        public double TankCapacity { get; private set; }

        public virtual string Drive(double distance)
        {
            double fuelNeeded = distance * FuelConsumption;
            if (fuelNeeded <= FuelQuantity)
            {
                FuelQuantity -= fuelNeeded;
                return $"{this.GetType().Name} travelled {distance} km";
            }
            return $"{this.GetType().Name} needs refueling";
        }

        public virtual void Refuel(double quantity)
        {
            if (quantity<=0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (quantity +fuelQuantity> TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {quantity} fuel in the tank");
            }
            FuelQuantity += quantity;
        }
    }
}