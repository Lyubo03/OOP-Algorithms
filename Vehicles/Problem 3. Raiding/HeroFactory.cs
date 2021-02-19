namespace Raiding
{
    using Heroes;

    public class HeroFactory
    {
        public HeroFactory()
        {

        }
        public BaseHero CreateHero(string type, string name)
        {

            if (type == "Paladin")
            {
                return new Paladin(name);
            }
            else if (type == "Warrior")
            {
                return new Warrior(name);
            }
            else if (type == "Rogue")
            {
                return new Rogue(name);
            }
            else if (type == "Druid")
            {
                return new Druid(name);
            }
            
            throw new System.ArgumentException("Invalid hero!");
        }
    }
}