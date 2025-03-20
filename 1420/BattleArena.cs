using System.Threading;

namespace BattleArenaNP
{
    public class BattleArena
    {
        public Fighter FighterOne { get; set; }
        public Fighter FighterTwo { get; set; }

        public BattleArena(Fighter fighterOne, Fighter fighterTwo)
        {
            FighterOne = fighterOne;
            FighterTwo = fighterTwo;
        }

        
        public void Fight()
        {
            Console.WriteLine($"The battle begins! {FighterOne.Name} will be fighting {FighterTwo.Name}.");

            bool haveWinner = false;
            while (!haveWinner)
            {
                if (FighterOne.Health != 0)
                {
                    FighterOne.TakeDamage(FighterOne.Attack());
                    Console.WriteLine($"{FighterOne.Name} attacks with a power of {FighterOne.AttackPower}. {FighterTwo.Name} has {FighterTwo.Health} health left.");
                }

                if (FighterOne.Health != 0)
                {
                    FighterOne.TakeDamage(FighterTwo.Attack());
                    Console.WriteLine($"{FighterTwo.Name} attacks with a power of {FighterTwo.AttackPower}. {FighterOne.Name} has {FighterOne.Health} health left.");
                }

                if (FighterOne.Health == 0)
                {
                    Console.WriteLine($"{FighterTwo.Name} is the winner and has {FighterTwo.Health} health left.");
                    haveWinner = true;
                }
                else if (FighterTwo.Health == 0)
                {
                    Console.WriteLine($"{FighterOne.Name} is the winner and has {FighterOne.Health} health left.");
                    haveWinner = true;
                }
            }
        }
    }
}
