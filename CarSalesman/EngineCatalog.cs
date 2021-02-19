namespace CarsSalesman
{
    using System.Collections.Generic;
    public class EngineCatalog
    {
        public List<Engine> engines;
        public EngineCatalog()
        {
            this.engines = new List<Engine>();
        }
        public void Add(string[] parameters)
        {
            string model = parameters[0];
            int power = int.Parse(parameters[1]);
            Engine engine = new Engine(model, power);
            int displacement = -1;

            if (parameters.Length == 3 && int.TryParse(parameters[2], out displacement))
            {
                engine.Displacement = displacement;
            }
            else if (parameters.Length == 3)
            {
                string efficiency = parameters[2];
                engine.Efficiency = efficiency;
            }
            else if (parameters.Length == 4)
            {
                string efficiency = parameters[3];
                displacement = int.Parse(parameters[2]);
                engine.Displacement = displacement;
                engine.Efficiency = efficiency;
            }
            engines.Add(engine);
        }
        public List<Engine> Engine { get { return engines; } }
    }
}