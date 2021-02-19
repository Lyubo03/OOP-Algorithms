namespace CryptoMiningSystem.Components
{
    using System;
    public abstract class Component : IComponent
    {
        private string model;
        private double generation;
        private double price;
        public Component(string model, double price, double generation)
        {
            Model = model;
            Price = price;
            Generation = generation;
        }

        public string Model
        {
            get => model;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be null or empty!");
                }
                model = value;
            }
        }

        public double Price
        {
            get => price;
            private set
            {
                if (value <= 0 || value > 10000)
                {
                    throw new ArgumentException("Price cannot be less or equal to 0 and more than 10000");
                }
                price = value;
            }
        }

        public virtual double Generation
        {
            get => generation;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Generation cannot be 0 or negative!");
                }
                generation = value;
            }
        }

        public int LifeWorkingHours { get; set; }
    }
}