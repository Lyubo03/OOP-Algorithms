using System;
using System.Collections.Generic;
using System.Text;

namespace CarsAndTheirCargo
{
    class Engine
    {
        private string model;
        private int engineSpeed;
        private int enginePower;
        public Engine(int engineSpeed, int enginePower)
        {
            this.engineSpeed = engineSpeed;
            this.enginePower = enginePower;
        }
        public int EngineSpeed()
        { return engineSpeed; }
        public int EnginePower()
        { return enginePower; }
    }
}
