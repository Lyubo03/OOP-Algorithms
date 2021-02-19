namespace Cars
{
    using System;
    public class ElectricCar : Car, IElectricCar
    {
        private int batteries;

        public ElectricCar(string model, string color, int batteries)
            : base(model, color)
        {
            this.batteries = batteries;
        }

        public int Batteries
        {
            get => this.batteries;
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Your son's car has more batteries :D");
                }
                this.batteries = value;
            }
        }
    }
}