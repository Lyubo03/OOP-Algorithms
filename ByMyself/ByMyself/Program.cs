using System;
using System.Collections.Generic;

namespace ByMyself
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner pehso = new Owner("Pesho", "Stamatow");
            Cats cat1 = new Cats("Purko","Black",3);
            Cats cat2 = new Cats("Miau", "Green", 4);
            List<Cats> ownersCats = new List<Cats>();
            ownersCats.Add(cat1);
            ownersCats.Add(cat2);
            pehso.OwnersCats = ownersCats;
            pehso.GetListOfCats();
        }
    }
}
