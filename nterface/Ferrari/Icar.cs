using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public interface Icar
    {
        public string Model { get; }
        public string Driver { get; }
        public string Gas();
        public string Brakes();
    }
}
