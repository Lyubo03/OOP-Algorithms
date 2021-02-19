namespace Polymorphism
{
    using System;
    public class Engine
    {
        public Engine()
        {
        }
        public string Run()
        {
            int n = int.Parse(Console.ReadLine());
            HeroFactory factory = new HeroFactory();
            BaseHero[] raid = new BaseHero[n];

            for (int i = 0; i < n;)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                try
                {
                    BaseHero hero = factory.Create(type, name);
                    raid[i] = hero;
                    i++;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }

            int bossHealth = int.Parse(Console.ReadLine());
            int madeDamage = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(raid[i].CastAbility());
                madeDamage += raid[i].Power;
            }

            if (madeDamage >= bossHealth)
            {
                return "Victory!";
            }
            return "Defeat...";
        }
    }
}