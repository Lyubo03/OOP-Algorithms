namespace Polymorphism
{
    using System;
    public class HeroFactory
    {
        public HeroFactory()
        {
        }

        public BaseHero Create(string type, string name)
        {
            if (type == "Paladin")
            {
                return new Paladin(name);
            }
            else if (type == "Rogue")
            {
                return new Rogue(name);
            }
            else if (type == "Druid")
            {
                return new Druid(name);
            }
            else if (type == "Warrior")
            {
                return new Warrior(name);
            }

            throw new ArgumentException("Invalid hero!");
        }
    }
}