using System.Collections.Generic;

namespace Military_Elite.Contracts
{
    public interface ICommando : ISpecialisedSoldier
    {
        public ICollection<IMission> Missions { get; }
    }
}