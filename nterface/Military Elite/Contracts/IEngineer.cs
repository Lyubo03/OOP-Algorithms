using System.Collections.Generic;

namespace Military_Elite.Contracts
{
    public interface IEngineer : ISpecialisedSoldier
    {
        public ICollection<IRepair> Repairs { get; }
    }
}