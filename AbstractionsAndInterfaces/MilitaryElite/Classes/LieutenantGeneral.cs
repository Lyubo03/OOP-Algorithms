namespace MilitaryElite.Classes
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(string firstName, string lastName, int id, decimal salary)
            : base(firstName, lastName, id, salary)
        {
            PrivatesCollection = new List<IPrivate>();
        }

        public ICollection<IPrivate> PrivatesCollection { get; private set; }
        public void AddPrivate(IPrivate toBeAdd)
        {
            PrivatesCollection.Add(toBeAdd);
        }
        public sealed override string ToString()
        {
            string info = $"{base.ToString()}{Environment.NewLine}Privates:";
            if (PrivatesCollection.Any())
            {
                info += Environment.NewLine;
            }
            foreach (var privates in PrivatesCollection)
            {
                info += $"  {privates}{Environment.NewLine}";
            }
            return info;
        }
    }
}