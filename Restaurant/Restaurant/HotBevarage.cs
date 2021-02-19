using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class HotBevarage:Bevarage
    {
        public HotBevarage(string name, decimal price, double mililitres)
        : base(name, price, mililitres)
        {
            this.mililitres = mililitres;
        }
    }
}
