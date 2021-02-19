using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class TomCat : Cat
    {
        private const string TomsGender = "Male";
        public TomCat(string name, int age)
            : base(name, age, TomsGender)
        {
        }
        public sealed override void ProduceSound()
        {
            Console.WriteLine("MEOW");
        }
    }
}
