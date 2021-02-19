using System;

namespace PizzaCalories
{
    class Topping
    {
        private double grams;
        private double calories = 2;
        private string modificator;
        public Topping(string modificator, double grams)
        {
            if (grams > 50 || grams < 1)
            {
                throw new Exception($"{modificator} weight should be in the range [1..50].");
            }
            this.grams = grams;
            calories *= grams;
            this.modificator = modificator;
            switch (modificator.ToLower())
            {
                case "sauce": calories *= 0.9; break;
                case "meat": calories *= 1.2; break;
                case "cheese": calories *= 1.1; break;
                case "veggies": calories *= 0.8; break;
                default: throw new Exception($"Cannot place {modificator} on top of your pizza");
            }
        }
        public double Calories
        {
            get { return calories; }
        }
    }
}
