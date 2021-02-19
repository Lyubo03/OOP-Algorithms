using System;
using BrokerCompanySystem;
namespace BrokerCompanySystem
{


    public abstract class Building
    {
        private string name;
        private string city;
        private int stars;
        private double rentAmount;
        public Building(string name, string city, int stars, double rentAmount)
        {
            Name = name;
            City = city;
            Stars = stars;
            RentAmount = rentAmount;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Building name must not be null or empty!");
                }
                name = value;
            }
        }

        public string City
        {
            get => city;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("City must not be null or empty!");
                }
                city = value;
            }
        }

        public int Stars
        {
            get => stars;
            private set
            {
                if (value < 0 || value > 5)
                {
                    throw new ArgumentException("Stars cannot be less than 0 or above 5!");
                }
                stars = value;
            }
        }

        public double RentAmount
        {
            get => rentAmount;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Rent amount cannot be less or equal to 0!");
                }
                rentAmount = value;
            }
        }

        public bool IsAvailable { get; set; }

        public override string ToString()
        {
            return $"****Building: {this.Name} <{this.Stars}>{Environment.NewLine}****Location: {this.City}{Environment.NewLine}****RentAmount: {this.RentAmount}{Environment.NewLine}****Is Available: {this.IsAvailable}";
        }
    }
}