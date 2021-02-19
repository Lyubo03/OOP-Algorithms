using System;
using System.Collections.Generic;
using System.Linq;

namespace StarWars
{
    class Planet
    {

        private string name;
        private int metal;
        private int mineral;
        private Dictionary<string, int> buildedShips = new Dictionary<string, int>() {
            { "BattleShip", 0 },
            {"Fighter",0 },
            {"Transporter", 0 } };
        private Dictionary<string, int> buildedBuildings = new Dictionary<string, int>() {
            { "MineralMine", 0 },
            {"YardShip",0 },
            {"MetalMine", 0 } };

        public Planet(string name, int metal, int mineral)
        {
            if (name == string.Empty)
            {
                throw new Exception("Set a proper name!");
            }
            this.name = name;
            if (metal < 0 || mineral < 0)
            {
                throw new Exception("It can not be negative number!");
            }
            this.metal = metal;
            this.mineral = mineral;
        }
        public int Metal
        {
            get { return metal; }
            set { metal = value; }
        }
        public int Minerals
        {
            get { return metal; }
            set { metal = value; }
        }
        public void SetShip(Ship ship, int units)
        {
            if (buildedShips.ContainsKey(ship.Name))
            {
                buildedShips[ship.Name] += units;
            }
        }
        public void SetBuilding(Building building)
        {
            if (buildedBuildings.ContainsKey(building.Name))
            {
                buildedBuildings[building.Name]++;
            }
        }
        public void printResources()
        {
            Console.WriteLine($"{name} Metal: {metal} Minerals {mineral}");
        }
        public string PrintBuildings()
        {
            string result = string.Empty;
            bool any = false;
            result += name + " ";
            foreach (var building in buildedBuildings.OrderByDescending(x => x.Value))
            {
                if (building.Value > 0)
                {
                    any = true;
                }
                result += $" {building.Key} {building.Value} ";
            }
            if (!any)
            {
                result = $"On {name} there are not buildings";
            }
            return result;
        }
        public string PrintShips()
        {
            string result = string.Empty;
            bool any = false;
            result += $"{name} ";
            foreach (var ships in buildedShips.OrderByDescending(x => x.Value))
            {
                if (ships.Value > 0)
                {
                    any = true;
                }
                result += $" {ships.Key} {ships.Value} ";
            }
            if (!any)
            {
                result = $"On {name} there are not ships";
            }
            return result;
        }
    }
}
