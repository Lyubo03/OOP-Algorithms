namespace Practise
{
    public class Freight
    {
        private string name;
        private int mass;
        public Freight(string name, int mass)
        {
            this.name = name;
            this.mass = mass;
        }
        public string Name { get { return name; } }
        public int Mass { get { return mass; } }
        public Freight freight
        {
            get;
            set;
        }
    }
}