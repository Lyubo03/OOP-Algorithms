﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Tea : HotBevarage
    {
        public Tea(string name, decimal price, double mililitres) 
            : base(name, price, mililitres)
        {
        }
    }
}
