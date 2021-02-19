using System;

namespace Wild_Farm.Food
{
    public class FoodFactory
    {
        public FoodFactory()
        {
            
        }
        public Food CreateFood(params string[] args)
        {
            string type = args[0];
            int quantity = int.Parse(args[1]);

            if (type == "Vegetable")
            {
                return new Vegetable(quantity);
            }
            else if (type == "Meat")
            {
                return new Meat(quantity);
            }
            else if (type == "Seeds")
            {
                return new Seeds(quantity);
            }
            else if (type == "Fruit")
            {
                return new Fruit(quantity);
            }
            throw new ArgumentException("Invalid food");
        }
    }
}