using System;
using System.Collections.Generic;
using System.Text;

namespace StarWars
{
    class Ship
    {
        private string name;
        private int metal;
        private int mineral;
        public Ship(string name, int metal, int mineral)
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

        public string Name { get => name; }
        public int Metal { get => metal;}
        public int Mineral { get => mineral;}
    }
}
