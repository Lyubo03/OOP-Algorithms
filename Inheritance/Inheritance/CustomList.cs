using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class CustomList : List<int>
    {
        public int RemoveRandom()
        {
            Random random = new Random();
            int index = random.Next(0, this.Count);
            int element = this[index];
            this.Remove(index);
            return element;
        }
    }
}
