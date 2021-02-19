using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    public class Hero
    {
        private int health = 100;
        private int coins = 0;
        public int Coins { get { return coins; } }
        public int Health { get{ return health; } }
        public void Heal(int number)
        {
            int healed = 0;
            if (health<100)
            {
                while (health<100)
                {
                    number--;
                    healed++;
                    health++;
                    if (number == 0 || health == 100)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"You healed for {healed} hp.");
            Console.WriteLine($"Current health: { this.health} hp.");
        }
        public void FindedCoins(int num)
        {
            Console.WriteLine($"You found {num} coins.");
            coins += num;
        }
        public bool Battle(int attack, string monster)
        {
            if (attack <= health)
            {
                health -= attack;
                Console.WriteLine($"You slayed {monster}");
                return true;
            }
            else
            {
                Console.WriteLine($"You died! Killed by {monster}.");
                return false;
            }
        }
    }
}