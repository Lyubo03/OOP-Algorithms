namespace Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;
        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bag = new List<Product>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public decimal Money
        {
            get => this.money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }
        public string AddProduct(Product product)
        {
            if (product.Price > this.money)
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
            }

            bag.Add(product);
            this.money -= product.Price;
            return $"{this.Name} bought {product.Name}";
        }
        public override string ToString()
        {
            if (bag.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }
            return $"{this.Name} - {string.Join(", ", bag.Select(x => x.Name))}";
        }
    }
}