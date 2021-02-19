namespace CarsSalesman
{
    using System.Collections.Generic;
    using System.Linq;

    public class CarCatalog
    {
        private List<Car> carCatalog;
        public CarCatalog()
        {
            carCatalog = new List<Car>();
        }
        public void Add(string[] parameters, EngineCatalog engineCatalog)
        {
            string model = parameters[0];
            string engineModel = parameters[1];
            Engine engine = engineCatalog.Engine.FirstOrDefault(x => x.Model == engineModel);
            Car car = new Car(model, engine);

            int weight = -1;

            if (parameters.Length == 3 && int.TryParse(parameters[2], out weight))
            {
                car.Weight = weight;
            }
            else if (parameters.Length == 3)
            {
                string color = parameters[2];
                car.Color = color;
            }
            else if (parameters.Length == 4)
            {
                string color = parameters[3];
                weight = int.Parse(parameters[2]);
                car.Weight = weight;
            }
            carCatalog.Add(car);
        }
        public string RewievCatalog()
        {
            string result = string.Empty;
            foreach (var car in carCatalog)
            {
                result += car.ToString();
            }
            return result;
        }
    }
}
