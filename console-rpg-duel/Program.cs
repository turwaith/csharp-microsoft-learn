using System;

namespace console_rpg_duel
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroLife = 10;
            int monsterLife = 10;
            int heroAttack = 0;
            int monsterAttack = 0;
            Random dice = new Random();

            while (heroLife > 0 && monsterLife > 0)
            {
                Console.WriteLine($"\n{"Hero HP",-10}: {heroLife,2}\n{"Monster HP",-10}: {monsterLife,2}\n");

                heroAttack = dice.Next(1, 11);
                Console.WriteLine($"The hero attacks the monster and hit for {heroAttack,2} point{(heroAttack > 1 ? "s" : "")}");
                monsterLife -= heroAttack;

                if (monsterLife > 0)
                {
                    monsterAttack = dice.Next(1, 11);
                    Console.WriteLine($"The monster attacks the hero and hit for {monsterAttack,2} point{(monsterAttack > 1 ? "s" : "")}");
                    heroLife -= monsterAttack;
                }
            }
            Console.WriteLine(heroLife > monsterLife ? "The hero has killed the monster\n" : "The monster has killed the hero\n");
        }
    }
}
