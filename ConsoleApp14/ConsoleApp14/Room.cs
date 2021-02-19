using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    public class Room
    {
        private string name;
        private int range;
        public Room(string name, int range)
        {
            this.name = name;
            this.range = range;
        }
        public string Name {get { return name; }}
        public int Range { get { return range; } }
    }
}
