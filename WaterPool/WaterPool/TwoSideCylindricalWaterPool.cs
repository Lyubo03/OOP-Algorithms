namespace WaterPool
{
    using System;

    public class TwoSideCylindricalWaterPool : Pool
    {
        public TwoSideCylindricalWaterPool(double R, double r, double h)
            : base(R, r, h)
        {
        }

        public override double Volume() =>
            Math.PI * this.H * (R * R - SmallR * SmallR);
    }
}