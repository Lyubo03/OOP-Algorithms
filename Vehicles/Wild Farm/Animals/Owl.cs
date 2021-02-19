namespace Wild_Farm.Animals
{
    using Food;
    using System;

    public class Owl : Bird
    {
        private const double gainPerPortion = 0.25;
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }
        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Meat")
            {
                Weight += gainPerPortion * food.Quantity;
                this.FoodEaten += food.Quantity;
                return;
            }

            throw new ArgumentException($"{GetType().Name} does not eat {food.GetType().Name}!");
        }
        public override string AskForFood()
        {
            return "Hoot Hoot";
        }
    }
}
