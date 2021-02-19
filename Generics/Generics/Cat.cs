using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Cat : Animal
    {
        private string name;
        private int age;

        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
