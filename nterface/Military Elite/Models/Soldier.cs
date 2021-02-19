using Military_Elite.Contracts;

namespace Military_Elite.Models
{
    public abstract class Soldier : ISoldier
    {
        protected Soldier(string name, string lastName, string id)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string LastName { get; private set; }
    }
}