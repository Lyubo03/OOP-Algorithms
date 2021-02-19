using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Market
{
    class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag = new List<Product>();

        public Person(string name, decimal money)
        {
            if (name == null)
            {
                throw new Exception("Name cannot be Empty!");
            }
            else
            {
                this.name = name;
            }
            if (money < 0)
            {
               throw new Exception("Money cannot be negative!");
            }
            else
            {
                this.money = money;
            }
        }
        public decimal Money
        {
            get { return this.money; }
        }
        public string Name
        {
            get { return name; }
        }
        public List<Product> Bag
        {
            set { bag = value; }
            get { return bag; }
        }
        public void DoesTheMoneyEnough(decimal productPrice, Product product)
        {
            if (productPrice > money)
            {
                Console.WriteLine($"{Name} can't afford {product.NameOfProduct}");
            }
            else
            {
                Console.WriteLine($"{Name} bought {product.NameOfProduct}");
                this.money -= productPrice;
                bag.Add(product);
            }
        }
        public string PrintProducts()
        {
            string items = string.Empty;
            if (!bag.Any())
            {
                items = "Nothing bought";

            }
            else
            {
                foreach (var item in bag)
                {
                    items += item.NameOfProduct + ", ";
                }
            }
            return items;
        }
    }
}
