using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Freight
    {
        private string name;
        private int mass;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public int Mass
        {
            get { return mass; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Weight cannot be negative");
                }
                this.mass = value;
            }
        }
    }
}
