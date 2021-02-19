namespace NeedForSpeed
{
    public class Vehicle
    {
        public const double DefaultFuelConsumtion = 1.25;
        public Vehicle(int horsePower, double fuel)
        {
            this.Fuel = fuel;
            this.HorsePower = horsePower;
        }
        public virtual double FuelConsumption => DefaultFuelConsumtion;
        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public void Drive(double kilometres)
        {
            if (Fuel - kilometres * FuelConsumption >= 0)
            {
                Fuel -= kilometres * FuelConsumption;
            }
        }
    }
}
