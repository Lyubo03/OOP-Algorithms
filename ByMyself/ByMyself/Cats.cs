using System;
using System.Collections.Generic;
using System.Text;

namespace ByMyself
{
    class Cats
    {
        public Cats(string name, string color, int years)
        {
            this.name = name;
            this.color = color;
            this.years = years;
        }
        public string name { get; set; }
        public string color { get; set; }
        public int years { get; set; }
    }
}
