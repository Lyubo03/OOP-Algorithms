namespace Raiding.Core
{
    using Heroes;
    using System;
    using System.Collections.Generic;
    public class Engine : IEngine
    {
        private List<BaseHero> raidGroup;
        public Engine()
        {
            raidGroup = new List<BaseHero>();
        }

        public void Run()
        {
            CreateGroupOfHeroes(raidGroup);

            Boss boss = CreateBoss();
            Attack(raidGroup, boss);

            Console.WriteLine(boss.IsDefeated());
        }
        static void Attack(List<BaseHero> raidGroup, Boss boss)
        {
            foreach (var hero in raidGroup)
            {
                boss.AttackBoss(hero.Power);
                Console.WriteLine(hero.CastAbility());
            }
        }
        static Boss CreateBoss()
        {
            int health = int.Parse(Console.ReadLine());

            return new Boss(health);
        }
        static void CreateGroupOfHeroes(List<BaseHero> raidGroup)
        {
            HeroFactory factory = new HeroFactory();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n;)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                try
                {
                    raidGroup.Add(factory.CreateHero(type, name));
                    i++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}