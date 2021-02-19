namespace MilitaryElite.Interfaces
{
    using MilitaryElite.Tools;
    using System.Collections.Generic;

    public interface IEngineer : ISpecialisedSoldier
    {
        public ICollection<Repair> Repairs { get; }
    }
}