namespace CarsAndTheirCargo
{
    class Tire
    {
        private double tirePressure;
        private int tireAge;
        public Tire(double tirePressure, int tireAge)
        {
            this.tirePressure = tirePressure;
            this.tireAge = tireAge;
        }
        public double GetTirePressure()
        {
            return this.tirePressure;
        }
        public int GetTireAge()
        {
            return this.tireAge;
        }
    }
}
