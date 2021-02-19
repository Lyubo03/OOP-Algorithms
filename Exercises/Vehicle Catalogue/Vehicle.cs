namespace Vehicle_Catalogue
{
    public class Vehicle
    {
        private string type;
        private string model;
        private string color;
        private int horsePower;
        public Vehicle(string type, string mode, string color, int horsepower)
        {
            this.type = type;
            this.model = mode;
            this.color = color;
            this.horsePower = horsepower;
        }
        public string Type{ get { return this.type;} }
        public string Model { get { return model; } }
        public string Color { get { return color; } }
        public int HorsePower { get { return this.horsePower; } }
        public override string ToString()
        {
            return $"Type: {type}\nModel: {model}\nColor: {color}\nHorsepower: {horsePower}";
        }
    }
}