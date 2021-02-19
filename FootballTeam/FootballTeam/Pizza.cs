using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    class Pizza
    {
        private string name;
        private List<Topping> toppings = new List<Topping>();
        private Dough dough;
        private double calories = 0;
        public string Name
        {
            set { name = value; }
        }
        public Dough Dough
        {
            set { this.dough = value; }
        }
        public List<Topping> Toppings
        {
            set { this.toppings = value; }
        }
        public void AddCalories(double cal)
        {
            calories += cal;
        }
        public string Print()
        {
            string result = $"{name} - {calories:F2} Calories.";
            return result;
        }
    }
}
