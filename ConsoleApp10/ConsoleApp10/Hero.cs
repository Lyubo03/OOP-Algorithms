using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class Hero
    {
        private int health = 100;
        private int coins = 0;
        public int Coins
        {
            get { return coins; }
            set { coins += value; }
        }
        public int Health
        {
            get { return health; }
            set { health -= value; }
        }
        public string Potion(int potion)
        {
            if (health < 100)
            {
                health += potion;
                if (health > 100)
                {
                    potion -= health - 100;
                    health = 100;
                }
            }
            else if (health == 100)
            {
                potion = 0;
            }
            string result = $"You healed for {potion} hp.\r\nCurrent health {health} hp.";
            return result;
        }
    }
}
