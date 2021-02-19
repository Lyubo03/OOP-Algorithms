namespace AfterMonth
{
    using System;
    public class Car : Vehicle
    {

        private const double airCondtConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsump)
            : base(fuelQuantity, fuelConsump)
        {

        }

        public override void Drive(double distance)
        {
            if (distance <= 0)
            {
                throw new ArgumentException("The fuel cannot be a negative number");
            }

            double neededFuel = distance * (airCondtConsumption + FuelConsump);

            if (neededFuel > FuelQuantity)
            {
                Console.WriteLine("Car needs refueling");
            }
            else
            {
                FuelQuantity -= neededFuel;
                Console.WriteLine($"Car travelled {distance} km");
            }
        }


        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("The fuel cannot be a negative number");
            }
            FuelQuantity += liters;
        }
        public override string ToString()
        {
            return "Car: " + base.ToString();
        }
    }
}