namespace Wild_Farm.Animals
{
    using Food;
    public class Hen : Bird
    {
        private const double gainPerPortion = 0.35;
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }
        public override void Eat(Food food)
        {
            Weight += gainPerPortion * food.Quantity;
            this.FoodEaten += food.Quantity;
        }
        public override string AskForFood()
        {
            return "Cluck";
        }
    }
}