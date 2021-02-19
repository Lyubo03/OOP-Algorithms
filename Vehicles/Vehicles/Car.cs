namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double AirConditionerFuelConsump = 0.9;
        public Car(double tankCapacity,double fuelQuantity, double fuelConsumption) 
            : base(tankCapacity, fuelQuantity, fuelConsumption)
        {
            this.FuelConsumption += AirConditionerFuelConsump;
        }
        public override string Drive(double distance)
        {
            return base.Drive(distance);
        }
    }
}