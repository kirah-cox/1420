

namespace BattleArenaNP
{
    public class Warrior : Fighter
    {
        public Warrior(string name, int health, int attackPower) : base(name, health, attackPower) { }

        public override int Attack()
        {
            return AttackPower;
        }
    }
}