namespace Wild_Farm.Animals
{
    using Food;
    using System;

    public class Mouse : Mammal
    {
        private const double gainPerPortion = 0.10;
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override string AskForFood()
        {
            return "Squeak";
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Vegetable" || food.GetType().Name == "Fruit")
            {
                Weight += gainPerPortion * food.Quantity;
                this.FoodEaten += food.Quantity;
                return;
            }

            throw new ArgumentException($"{GetType().Name} does not eat {food.GetType().Name}!");
        }

        public override string ToString()
        {
            return $"{base.ToString()} {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}