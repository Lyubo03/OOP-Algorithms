namespace WaterPool
{
    using System;

    public class CylindricPool : Pool
    {
        public CylindricPool(double R, double r, double h) 
            : base(R, r, h)
        {
        }

        public override double Volume() =>
            Math.PI * this.R * this.R * this.H;
    }
}