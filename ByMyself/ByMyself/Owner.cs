using System;
using System.Collections.Generic;
using System.Text;

namespace ByMyself
{
    class Owner
    {
        private string familyname;
        public Owner(string name, string familyname)
        {
            this.name = name;
            this.familyname = familyname;
        }
        public string name { get; set; }
        public void SetFamilyName(string familyname)
        {
            this.familyname = familyname;
        }
        public List<Cats> OwnersCats { get; set; }
        public void GetListOfCats()
        {
            foreach (Cats item in OwnersCats)
            {
                Console.WriteLine($"{item.name} {item.color} {item.years}");
            }
        }

    }
}
