namespace Wild_Farm.Animals
{
    using Food;
    public abstract class Animal
    {
        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; private set; }
        public double Weight { get; protected set; }
        public int FoodEaten { get; protected set; }
        public abstract string AskForFood();
        public abstract void Eat(Food food);
        public override string ToString()
        {
            return $"{GetType().Name} [{this.Name},";
        }
    }
}