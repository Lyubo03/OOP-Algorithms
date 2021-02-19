namespace Wild_Farm.Animals
{
    using Food;
    using System;

    public class Cat : Feline
    {
        public const double gainPerPortion = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }
        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Meat"|| food.GetType().Name == "Vegetable")
            {
                Weight += gainPerPortion * food.Quantity;
                this.FoodEaten += food.Quantity;
                return;
            }

            throw new ArgumentException($"{GetType().Name} does not eat {food.GetType().Name}!");
        }
        public override string AskForFood()
        {
            return "Meow";
        }
    }
}
