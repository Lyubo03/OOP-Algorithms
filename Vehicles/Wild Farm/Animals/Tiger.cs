namespace Wild_Farm.Animals
{
    using Food;
    using System;

    public class Tiger : Feline
    {
        private const double gainPerPortion = 1;
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
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
            return "ROAR!!!";
        }
    }
}