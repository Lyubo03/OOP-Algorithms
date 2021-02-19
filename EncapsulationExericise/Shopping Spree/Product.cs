namespace Shopping_Spree
{
    using System;
    public class Product
    {
        public string name;
        public decimal price;
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
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
        public decimal Price 
        { 
            get => this.price;
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.price = value;
            }
        }
    }
}