using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class ColdBevarage : Bevarage
    {
        public ColdBevarage(string name, decimal price, double mililitres)
            : base(name, price, mililitres)
        {
        }
    }
}
