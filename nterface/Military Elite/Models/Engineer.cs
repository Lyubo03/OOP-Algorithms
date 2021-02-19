using Military_Elite.Contracts;
using Military_Elite.Enums;
using System.Collections.Generic;
namespace Military_Elite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string name, string lastName, string id, decimal salary, Corps corp, ICollection<Repair> repairs)
            : base(name, lastName, id, salary, corp)
        {
            this.RepairsCol = repairs;
        }
        public ICollection<IRepair> Repairs { get; }
        public ICollection<Repair> RepairsCol { get; }
    }
}

