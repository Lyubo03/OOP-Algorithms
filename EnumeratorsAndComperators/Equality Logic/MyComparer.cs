namespace Equality_Logic
{
    using System.Collections.Generic;
    public class MyComparer : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            if (first.Name.CompareTo(second.Name) == 0)
            {
                return first.Age.CompareTo(second.Age);
            }
            return first.Name.CompareTo(second.Name);
        }
    }
}