using System;
using System.Collections.Generic;
using System.Linq;
using BrokerCompanySystem;

namespace BrokerCompanySystem
{


    public class CompanyController
    {
        private Dictionary<string, Company> companies;
        public CompanyController()
        {
            companies = new Dictionary<string, Company>();
        }
        public string CreateCompany(List<string> args)
        {
            string name = args[0];
            Company company = new Company(name);

            if (!companies.ContainsKey(name))
            {
                companies[name] = company;
                return $"Company {name} was successfully registerd in the system!";
            }

            return $"Company {name} is already registered!";

        }

        public string RegisterBuilding(List<string> args)
        {
            string type = args[0];
            string name = args[1];
            string city = args[2];
            int stars = int.Parse(args[3]);
            double rentAmount = double.Parse(args[4]);
            string companyName = args[5];

            if (!companies.ContainsKey(companyName))
            {
                return $"Invalid Company: {companyName}. Cannot find it in system!";
            }

            else if (companies[companyName].GetBuildingByName(name) != null)
            {
                return $"{name} is already registered in {companyName}!";
            }
            Building building = null;
            if (type == "Hotel")
            {
                building = new Hotel(name, city, stars, rentAmount);
            }
            else if (type == "Residence")
            {
                building = new Residence(name, city, stars, rentAmount);
            }
            else if (type == "Business")
            {
                building = new Business(name, city, stars, rentAmount);
            }

            building.IsAvailable = true;
            companies[companyName].AddBuilding(building);
            return $"Building {name} was successfully registerd in {companyName} catalog!";
        }
        public string RegisterBroker(List<string> args)
        {
            string name = args[0];
            int age = int.Parse(args[1]);
            string city = args[2];
            string companyName = args[3];

            if (!companies.ContainsKey(companyName))
            {
                return $"Invalid Company: {companyName}. Cannot find it in system!";
            }

            else if (companies[companyName].GetBrokerByName(name) != null)
            {
                return $"Broker {name} is already part of {companyName}!";
            }

            companies[companyName].AddBroker(new Broker(name, age, city));

            return $"Broker {name} was successfully hired in {companyName}!";
        }

        public string RentBuilding(List<string> args)
        {
            string companyName = args[0];
            string buildingName = args[1];
            string brokerName = args[2];

            if (!companies.ContainsKey(companyName))
            {
                return $"Invalid Company: {companyName}. Cannot find it in system!";
            }

            if (companies[companyName].GetBuildingByName(buildingName) == null)
            {
                return $"Invalid Building: {buildingName}. Cannot find it in {companyName} catalog!";
            }

            if (!companies[companyName].GetBuildingByName(buildingName).IsAvailable)
            {
                return $"Building: {buildingName} cannot be rented!";
            }

            if (companies[companyName].GetBrokerByName(brokerName) == null)
            {
                return $"Invalid Broker: {brokerName}. Cannot find employee in {companyName}!";
            }

            Building building = companies[companyName].GetBuildingByName(buildingName);
            Broker broker = companies[companyName].GetBrokerByName(brokerName);
            companies[companyName].GetBuildingByName(buildingName).IsAvailable = false;
            double bonus = broker.ReceiveBonus(building);
            return $"Successfully rented {buildingName}!{Environment.NewLine}Broker {brokerName} earned {bonus}!";
        }
        public string CompanyInfo(List<string> args)
        {
            string companyName = args[0];
            if (!companies.ContainsKey(companyName))
            {
                return $"Invalid Company: {companyName}. Cannot find it in system!";
            }
            return companies[companyName].ToString();
        }
        public string Shutdown()
        {
            string s = $"Companies: {this.companies.Count}\n";
            foreach (var company in this.companies.OrderBy(x=> x.Key))
            {
                s += this.CompanyInfo(new List<string> { company.Value.Name }) + '\n';
            }
            return s.TrimEnd();

        }
    }
}