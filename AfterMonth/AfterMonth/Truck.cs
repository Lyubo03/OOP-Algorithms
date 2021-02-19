namespace AfterMonth
{
    using System;
    public class Truck : Vehicle
    {
        private const double airCondtConsumpt = 1.6;

        public Truck(double fuelQuantity, double fuelConsump)
            : base(fuelQuantity, fuelConsump)
        {
        }

        public override void Drive(double distance)
        {
            if (distance <= 0)
            {
                throw new ArgumentException("The fuel cannot be a negative number");
            }

            double neededFuel = distance*(airCondtConsumpt + FuelConsump);

            if (neededFuel > FuelQuantity)
            {
                Console.WriteLine("Truck needs refueling");
            }

            else
            {
                FuelQuantity -= neededFuel;
                Console.WriteLine($"Truck travelled {distance} km");
            }
        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("The fuel cannot be a negative number");
            }

            FuelQuantity += liters * 95 / 100;
        }

        public override string ToString()
        {
            return "Truck: " + base.ToString();
        }
    }
}