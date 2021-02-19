using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyMembersOverThirty
{
    class Member
    {
        private string name;
        private int age;
        public Member(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public int GetAge()
        {
            return age;
        }
        public string GetName()
        {
            return name;
        }
    }
}
