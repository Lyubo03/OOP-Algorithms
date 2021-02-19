using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class SprotCar : Car
    {
        private const double DefaultFuelConsumption = 10;
        public SprotCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }        
        public override double FuelConsumption => DefaultFuelConsumtion;
    }
}
