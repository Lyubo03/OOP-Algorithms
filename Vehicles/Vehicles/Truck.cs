namespace Vehicles
{
    using System;
    public class Truck : Vehicle
    {
        private const double AirConditionerFuelConsump = 1.6;
        private const double ProblemWithTank = 0.05;

        public Truck(double tankCapacity,double fuelQuantity, double fuelConsumption)
            : base(tankCapacity,fuelQuantity, fuelConsumption)
        {
            FuelConsumption += AirConditionerFuelConsump;
        }
        public override string Drive(double distance)
        {
            return base.Drive(distance);
        }
        public override void Refuel(double quantity)
        {
            
            if (quantity <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (quantity > TankCapacity - FuelQuantity)
            {
                throw new ArgumentException($"Cannot fit {quantity} fuel in the tank");
            }
            quantity -= quantity * ProblemWithTank;
            FuelQuantity+= quantity;
        }
    }
}