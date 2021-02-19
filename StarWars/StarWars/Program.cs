using System;
using System.Collections.Generic;

namespace StarWars
{
    class Program
    {
        static void InsertPlanets(Dictionary<string, Planet> planets)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length - 2; i += 3)
            {
                string name = input[i]; int metal = int.Parse(input[i + 1]); int minerals = int.Parse(input[i + 2]);
                Planet planet = new Planet(name, metal, minerals);
                if (!planets.ContainsKey(name))
                {
                    planets[name] = planet;
                }
            }
        }
        static void InsertShips(Dictionary<string, Ship> ships)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length - 2; i += 3)
            {
                string name = input[i]; int metal = int.Parse(input[i + 1]); int minerals = int.Parse(input[i + 2]);
                Ship ship = new Ship(name, metal, minerals);
                if (!ships.ContainsKey(name))
                {
                    ships[name] = ship;
                }
            }
        }
        static void InsertBuildings(Dictionary<string, Building> buildings)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length - 2; i += 3)
            {
                string name = input[i]; int metal = int.Parse(input[i + 1]); int minerals = int.Parse(input[i + 2]);
                Building building = new Building(name, metal, minerals);
                if (!buildings.ContainsKey(name))
                {
                    buildings[name] = building;
                }
            }
        }
        static void BuildOnPlanets(Dictionary<string, Planet> planets, Dictionary<string, Ship> ships, Dictionary<string, Building> buildings)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (input[0].ToLower() != "end")
            {
                string planet = input[0]; string sthToBuild = input[1];
                int planetMinerals = planets[planet].Minerals; int planetMetals = planets[planet].Metal;
                int constructorMinerals = 0; int constructorMetals = 0;
                if (input.Length == 2)
                {
                    constructorMetals = buildings[sthToBuild].Metal; constructorMinerals = buildings[sthToBuild].Mineral;
                    if (planetMetals >= constructorMetals && planetMinerals >= constructorMinerals)
                    {
                        planets[planet].Metal = planetMetals - constructorMetals;
                        planets[planet].Minerals = planetMinerals - constructorMetals;
                        planets[planet].SetBuilding(buildings[sthToBuild]);
                        Console.WriteLine($"On {planet} was builded a {sthToBuild}");
                    }
                }
                else if (input.Length == 3)
                {
                    int units = int.Parse(input[2]);
                    constructorMetals = ships[sthToBuild].Metal * units; constructorMinerals = ships[sthToBuild].Mineral * units;
                    if (planetMetals >= constructorMetals && planetMinerals >= constructorMinerals)
                    {
                        planets[planet].Metal = planetMetals - constructorMetals;
                        planets[planet].Minerals = planetMinerals - constructorMinerals;
                        planets[planet].SetShip(ships[sthToBuild], units);
                        Console.WriteLine($"On {planet} was builded a {sthToBuild} {units} units");
                    }
                    else
                    {
                        Console.WriteLine($"On {planet} can not  to build {sthToBuild} {units} units");
                    }
                }
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, Planet> planets = new Dictionary<string, Planet>();
            Dictionary<string, Ship> ships = new Dictionary<string, Ship>();
            Dictionary<string, Building> buildings = new Dictionary<string, Building>();
            InsertPlanets(planets);
            InsertBuildings(buildings);
            InsertShips(ships);
            BuildOnPlanets(planets, ships, buildings);
            Console.WriteLine("Resources");
            foreach (var planet in planets)
            {
                planet.Value.printResources();
            }
            Console.WriteLine("Buildings:");
            foreach (var planet in planets)
            {
                Console.WriteLine(planet.Value.PrintBuildings());
            }
            Console.WriteLine("Ships:");
            foreach (var planet in planets)
            {
                Console.WriteLine(planet.Value.PrintShips());
            }
        }
    }
}
