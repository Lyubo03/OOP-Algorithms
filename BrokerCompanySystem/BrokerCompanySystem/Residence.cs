    using System;
using BrokerCompanySystem;
namespace BrokerCompanySystem
{
    public class Residence : Building
    {
        public Residence(string name, string city, int stars, double rentAmount)
            : base(name, city, stars, rentAmount)
        {
            if (!name.EndsWith("Residence"))
            {
                throw new ArgumentException("Name of residence buildings should end on Residence!");
            }
        }
    }
}