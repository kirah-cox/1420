
namespace BattleArenaNP
{
    public class Wizard : Fighter
    {
        public Wizard(string name, int health, int attackPower) : base(name, health, attackPower) { }

        public override int Attack()
        {
            return AttackPower;
        }
    }
}
