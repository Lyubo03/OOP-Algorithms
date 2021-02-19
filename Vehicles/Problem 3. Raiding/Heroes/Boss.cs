namespace Raiding.Heroes
{
    public class Boss
    {
        private int health;

        public Boss(int health)
        {
            this.health = health;
        }

        public void AttackBoss(int attack)
        {
            this.health -= attack;
        }
        public string IsDefeated()
        {
            if (this.health >    0)
            {
                return "Defeat...";
            }
            return "Victory!";
        }
    }
}