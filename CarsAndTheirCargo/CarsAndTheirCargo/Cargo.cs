namespace CarsAndTheirCargo
{
    class Cargo
    {
        private int cargoCapacity;
        private string cargoType;
        public Cargo(int cargoCapacity, string cargoType)
        {
            this.cargoCapacity = cargoCapacity;
            this.cargoType = cargoType;
        }
        public int GetcargoCapacity()
        {
            return this.cargoCapacity;
        }
        public string GetCargoType()
        {
            return this.cargoType;
        }
    }
}
