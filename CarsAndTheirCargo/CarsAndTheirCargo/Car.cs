using System.Collections.Generic;

namespace CarsAndTheirCargo
{
    class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires;

        public Car(string model, Engine Engine, Cargo cargo, List<Tire> tires)
        {
            this.model = model;
            this.engine = Engine;
            this.cargo = cargo;
            this.tires = tires;
        }
        public string Model()
        {
            return model;
        }
        public Cargo GetCargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public Engine GetEngine
        {
            get { return engine; }
            set { engine = value; }
        }
        public List<Tire> GetTires
        {
            get { return tires; }
            set { tires = value; }
        }
    }
}
