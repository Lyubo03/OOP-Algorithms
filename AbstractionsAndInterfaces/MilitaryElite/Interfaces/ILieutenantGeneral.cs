namespace MilitaryElite.Interfaces
{
    using System.Collections.Generic;
    public interface ILieutenantGeneral : IPrivate
    {
        public ICollection<IPrivate> PrivatesCollection { get; }
    }
}