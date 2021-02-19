using System;
using System.Collections.Generic;
using System.Text;

namespace StarWars
{
    class Building
    {
        private string name;
        private int metal;
        private int mineral;
        public Building(string name, int metal, int mineral)
        {
            if (name == string.Empty)
            {
                throw new Exception("Set a proper name!");
            }
            this.Name = name;
            if (metal < 0 || mineral < 0)
            {
                throw new Exception("It can not be negative number!");
            }
            this.Metal = metal;
            this.Mineral = mineral;
        }

        public string Name { get => name; set => name = value; }
        public int Metal { get => metal; set => metal = value; }
        public int Mineral { get => mineral; set => mineral = value; }
    }
}
