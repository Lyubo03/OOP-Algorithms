namespace NeedForSpeed
{
    public class Vehicle
    {
        private int horsePower;
        private double fuel;
        private const double defaultFuelConsumption = 1.25;
        public Vehicle(int horsePower, double fuel)
        {
            this.horsePower = horsePower;
            this.fuel = fuel;
        }

        public virtual double FuelConsumption => defaultFuelConsumption;

        public double Fuel { get { return this.fuel; } set { this.fuel = value; } }
        public int HorsePower { get { return this.horsePower; } }
        public virtual void Drive(double kilometres)
        {
            if (kilometres * this.FuelConsumption <= fuel)
            {
                this.Fuel -= kilometres * this.FuelConsumption;
            }

        }
    }
}