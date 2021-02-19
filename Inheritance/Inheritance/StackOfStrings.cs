using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class StackOfStrings: Stack<string>
    {
        public bool isEmpty { get; private set; }
        public bool IsEmpty()
        {
            if (this.Count ==0)
            {
                isEmpty = false;
            }
            else
            {
                isEmpty = true;
            }
            return isEmpty;
        }
    }
}
