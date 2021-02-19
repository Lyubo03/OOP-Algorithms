namespace Wild_Farm.Animals
{
    using Food;
    using System;

    public class Dog : Mammal
    {
        private const double gainPerPortion = 0.40;
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override string AskForFood()
        {
            return "Woof!";
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

        public override string ToString()
        {
            return $"{base.ToString()} {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}