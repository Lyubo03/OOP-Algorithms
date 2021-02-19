using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBevarage
    {
        private const decimal CoffeePrice = 3.50m;
        private const double CoffeeMililitres = 50;
        public Coffee(string name, double caffeine)
            : base(name, CoffeePrice, CoffeeMililitres)
        {
            this.Caffeine = caffeine;
        }
        public double Caffeine {get;set;}
    }
}
