using System;
using BrokerCompanySystem;
namespace BrokerCompanySystem
{
    public class Business : Building
    {
        public Business(string name, string city, int stars, double rentAmount) 
            : base(name, city, stars, rentAmount)
        {
            if (!name.EndsWith("Business"))
            {
                throw new ArgumentException("Name of business buildings should end on Business!");
            }
        }
    }
}