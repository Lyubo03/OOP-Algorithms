using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Dessert : Food
    {
        private double calories { get; set; }
        public Dessert(string name, decimal price, double grams, double calories)
            : base(name, price, grams)
        {
            this.calories = calories;
        }
    }
}
