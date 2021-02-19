namespace Wild_Farm.Animals
{
    public abstract class Bird : Animal
    {
        public Bird(string name, double weight,double wingSize) 
            : base(name, weight)
        {
            WingSize = wingSize;
        }
        public double WingSize { get; private set; }
        public override string ToString()
        {
            return $"{base.ToString()} {this.WingSize}, {Weight}, {FoodEaten}]"; 
        }
    }
}