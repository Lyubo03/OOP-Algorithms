namespace StrategyPatern
{
    using System.Collections.Generic;

    public class ComparerName : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            int lengthComparer = first.Name.Length.CompareTo(second.Name.Length);
            if (lengthComparer == 0)
            {
                return first.Name[0].CompareTo(second.Name[0]);
            }
            return lengthComparer;
        }
    }
}