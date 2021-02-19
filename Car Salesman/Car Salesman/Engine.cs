namespace Car_Salesman
{
    class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency = "n/a";

        public string Model
        {
            set { this.model = value; }
            get { return model; }
        }
        public int Power
        {
            set { this.power = value; }
            get { return power; }
        }
        public int Displacement
        {
            set { this.displacement = value; }
            get { return displacement; }
        }
        public string Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }
    }
}

