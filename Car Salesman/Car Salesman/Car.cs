namespace Car_Salesman
{
    class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color = "n/a";

        public string Model
        {
            set { model = value; }
            get { return model; }
        }
        public Engine Engine
        {
            set { engine = value; }
            get { return engine; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
