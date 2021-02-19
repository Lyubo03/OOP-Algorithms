using System;
using System.Collections.Generic;
using System.Text;

namespace Curses
{
    class Person
    {
        private string name;
        private int age;
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
        public void IntroduceYourself()
        {
            string result = $"Hello {name}. I am {age} years old.";
            Console.WriteLine(result);
        }
    }
}
