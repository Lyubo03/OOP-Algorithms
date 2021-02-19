using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public abstract class Product
    {
        private string name { get; set; }
        private decimal price { get; set; }
        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
