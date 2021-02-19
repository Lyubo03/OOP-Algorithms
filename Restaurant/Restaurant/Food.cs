using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Food : Product
    {
        private string name;
        private decimal price;
        private double grams;
        public Food(string name, decimal price, double grams) 
            : base(name, price)
        {
            this.grams = grams;
        }
    }
}
