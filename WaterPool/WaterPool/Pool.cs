namespace WaterPool
{
    public abstract class Pool
    {
        private double bigR;
        private double r;
        private double h;

        public Pool(double R, double r, double h)
        {
            this.bigR = R;
            this.r = r;
            this.h = h;
        }

        public double R => this.bigR;
        public double SmallR => this.r;
        public double H => this.h;
        public double CalculatePrice(double priceForCubicMetre, double DDS)
        {
            return Volume() * priceForCubicMetre * (1 + DDS / 100);
        }

        public abstract double Volume();

    }
}