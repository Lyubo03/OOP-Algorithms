namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double AirConditionerConsumpt = 1.4;
        public Bus(double tankCapacity, double fuelQuantity, double fuelConsumption)
           : base(tankCapacity, fuelQuantity, fuelConsumption)
        {
        }
        public override string Drive(double distance)
        {
            FuelConsumption += AirConditionerConsumpt;
            string output = base.Drive(distance);
            FuelConsumption -= AirConditionerConsumpt;
            return output;
        }
        public string DriveEmpty(double distance)
        {
            return base.Drive(distance);
        }

    }
}