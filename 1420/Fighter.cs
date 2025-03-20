

namespace BattleArenaNP
{
    public abstract class Fighter
    {
        public string Name { get; }
        public int Health { get; protected set; }
        public int AttackPower { get; }

        public Fighter(string name, int health, int attackPower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }

        public abstract int Attack();

        public void TakeDamage(int damage)
        {
            if (Health - damage < 0)
            {
                Health = 0;
                return;
            }

            Health -= damage;
        }
    }
}