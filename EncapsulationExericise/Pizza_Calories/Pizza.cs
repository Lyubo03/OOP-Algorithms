namespace Pizza_Calories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;

    public class Pizza
    {
        private List<Topping> toppings;
        private string name;

        public Pizza(string name)
        {
            Name = name;
            toppings = new List<Topping>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }
        public Dough Dough
        {
            get;
            set;
        }
        public void AddTopping(Topping topping)
        {
            if (toppings.Count == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            toppings.Add(topping);
        }
        private double Calories => Calculate();
        private double Calculate()
        {
            double doughCalories = Dough.DoughCalories;
            double toppingCalories = toppings.Sum(t => t.Calories);

            return doughCalories + toppingCalories;
        }
        public override string ToString()
        {
            return $"{name} - {Calories:F2} Calories.";
        }
    }
}