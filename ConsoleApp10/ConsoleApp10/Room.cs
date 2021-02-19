using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class Room
    {
        private string name;
        private int points = 0;
        public Room(string name, int points)
        {
            this.name = name;
            this.points = points;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Points
        {
            get { return points; }
            set { points = value; }
        }
    }
}
