using System;
using System.Collections.Generic;
using System.Text;
using BrokerCompanySystem;
namespace BrokerCompanySystem
{


    public class Company
    {
        private string name;
        private readonly Dictionary<string, Building> buildings;
        private readonly Dictionary<string, Broker> brokers;
        public Company(string name)
        {
            Name = name;
            buildings = new Dictionary<string, Building>();
            brokers = new Dictionary<string, Broker>();
        }
        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Company name must not be null or empty!");
                }
                name = value;
            }
        }
        public void AddBroker(Broker broker)
        {
            if (!brokers.ContainsKey(broker.Name))
            {
                brokers[broker.Name] = broker;
            }
        }
        public void AddBuilding(Building building)
        {
            if (!buildings.ContainsKey(building.Name))
            {
                buildings[building.Name] = building;
            }
        }
        public Broker GetBrokerByName(string name)
        {
            if (brokers.ContainsKey(name))
            {
                return brokers[name];
            }

            return null;
        }
        public Building GetBuildingByName(string name)
        {
            if (buildings.ContainsKey(name))
            {
                return buildings[name];
            }
            return null;
        }
        public override string ToString()
        {
            string s = $"Company: {this.Name}{Environment.NewLine}##Brokers: {this.brokers.Count}\n";
            foreach (var b in this.brokers)
            {
                s += $"{b.Value.ToString()}\n";
            }

            s += $"##Buildings: {this.buildings.Count}{Environment.NewLine}";
            foreach (var b in this.buildings)
            {
                s += $"{b.Value.ToString()}{Environment.NewLine}";
            }
            return s.Trim();

        }
    }
}