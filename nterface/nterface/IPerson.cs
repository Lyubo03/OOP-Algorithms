using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public interface IPerson : Ibirthable
    {
        public string name { get; }
        public int age { get;}
    }
}
