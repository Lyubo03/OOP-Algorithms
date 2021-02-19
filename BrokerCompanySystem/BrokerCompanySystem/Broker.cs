    using System;
    using System.Collections.Generic;
using BrokerCompanySystem;
namespace BrokerCompanySystem
{

    public class Broker
    {
        private string name;
        private int age;
        private string city;
        private double bonus = 0;
        private List<Building> rentedBuildings;
        public Broker(string name, int age, string city)
        {
            Name = name;
            City = city;
            Age = age;
            rentedBuildings = new List<Building>();
        }
        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Broker name must not be null or empty!");
                }
                name = value;
            }
        }
        public int Age
        {
            get => age;
            private set 
            {
                if (value < 16 || value>70)
                {
                    throw new ArgumentException("Broker's age cannot be less than 16 or above 70!");
                }
                age = value;
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
        public double Bonus => bonus;
        public double ReceiveBonus(Building building)
        {
            rentedBuildings.Add(building);

            double calculateBonus = building.RentAmount * 2 * building.Stars / 100;

            bonus += calculateBonus;
            return calculateBonus;
        }

        public void AddToRentedBuildings(Building building)
        {
            rentedBuildings.Add(building);
        }

        public override string ToString()
        {
            string s = $"****Broker: {this.Name} <{this.Age}>{Environment.NewLine}****Location: {this.City}{Environment.NewLine}****Bonus: {this.Bonus}\n";
            foreach (var b in this.rentedBuildings)
            {
                s += $"****** {b.Name}{Environment.NewLine}";
            }
            return s.Trim();


        }
    }
}