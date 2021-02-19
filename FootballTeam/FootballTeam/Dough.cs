using System;

namespace PizzaCalories
{
    class Dough
    {
        private string typeOfDought;
        private string modificator;
        private double grams;
        private double calories;
        private int baseCalories = 2;
        public Dough(string typeOfDought, string modificator, double grams)
        {
            calories = grams * baseCalories;
            this.typeOfDought = typeOfDought;
            switch (typeOfDought.ToLower())
            {
                case "wholegrain": calories *= 1.0; break;
                case "white": calories *= 1.5; break;
                default: throw new Exception("Invalid type of dough.");

            }
            this.modificator = modificator;
            switch (modificator.ToLower())
            {
                case "chewy": calories *= 1.1; break;
                case "crispy": calories *= 0.9; break;
                case "homemade": calories *= 1.0; break;
                default: throw new Exception("Invalid type of modificator.");
            }
            if (grams > 200 || grams < 1)
            {
                throw new Exception("Dough weight should be in the range [1..200].");
            }
            else
            {
                this.grams = grams;
            }
        }
        public double Calories
        {
            get { return calories; }
        }
    }
}
