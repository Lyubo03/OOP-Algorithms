namespace MilitaryElite.Interfaces
{
    using Tools;
    using System.Collections.Generic;

    public interface ICommando : ISpecialisedSoldier
    {
        public ICollection<IMission> Missions { get; }
    }
}