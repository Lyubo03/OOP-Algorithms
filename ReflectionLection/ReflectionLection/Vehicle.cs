namespace ReflectionLection
{
    public abstract class Vehicle
    {
        protected Vehicle(string model)
        {
            Model = model;
        }

        public string Model { get; set; }
        public string AddTypeToAModel()
        {
            return $"Car: {Model}";
        }
        public int addPlateNumber()
        {
            return Model.GetHashCode();
        }
    }
}
