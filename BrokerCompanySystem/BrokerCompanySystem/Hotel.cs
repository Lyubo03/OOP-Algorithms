using System;
using BrokerCompanySystem;
namespace BrokerCompanySystem
{
    public class Hotel : Building
    {
        public Hotel(string name, string city, int stars, double rentAmount) 
            : base(name, city, stars, rentAmount)
        {
            if (!name.EndsWith("Hotel"))
            {
                throw new ArgumentException("Name of hotel buildings should end on Hotel!");
            }
        }
    }
}