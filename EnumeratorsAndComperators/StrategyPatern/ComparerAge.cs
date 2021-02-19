namespace StrategyPatern
{
    using System.Collections.Generic;
    public class ComparerAge : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            return first.Age.CompareTo(second.Age);
        }
    }
}