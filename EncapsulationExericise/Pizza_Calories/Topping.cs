namespace Pizza_Calories
{
    using System;
    public class Topping
    {
        private const double meat = 1.2;
        private const double veggies = 0.8;
        private const double cheese = 1.1;
        private const double sauce = 0.9;
        private int grams;
        private string type;
        private const double baseCalories = 2;

        public Topping(string type, int grams)
        {
            Grams = grams;
            Type = type;
        }
        public int Grams
        {
            get => this.grams;
            private set
            {
                if (value > 50 || value < 1)
                {
                    throw new ArgumentException($"{type} weight should be in the range [1..50].");
                }
                this.grams = value;
            }
        }
        public string Type
        {
            get => this.type;
            private set
            {
                string ingridient = value.ToLower();

                if (ingridient != "meat" && ingridient != "veggies" && ingridient != "cheese" && ingridient != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.type = value;
            }
        }
        public double Calories => Calculate();
        private double Calculate()
        {
            double calories = baseCalories;
            calories *= grams;
            string ingridient = type.ToLower();
            if (ingridient == "meat")
            {
                calories *= meat;
            }
            else if (ingridient == "veggies")
            {
                calories *= veggies;
            }
            else if (ingridient == "cheese")
            {
                calories *= cheese;
            }
            else if (ingridient == "sauce")
            {
                calories *= sauce;
            }

            return calories;
        }
    }
}