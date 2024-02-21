using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WarriorFightToTheDeath
{
    class Battle
    {
        public void StartFight(Warrior warriorOne, Warrior warriorTwo)
        {
            Console.WriteLine("Getting in here");
            while(true)
            {
                if(GetBattleResult(warriorOne, warriorTwo) == false)
                {
                    Console.WriteLine($"{warriorOne.Name} wins!");
                    break;
                } 
                if(GetBattleResult(warriorTwo, warriorOne) == false)
                {
                    Console.WriteLine($"{warriorTwo.Name} wins!"); 
                    break;
                }
            }
        }

        public bool GetBattleResult(Warrior warriorOne, Warrior warriorTwo)
        {
            double damage = warriorOne.Attack(warriorOne, "Ultimate Skill") - warriorTwo.Block();
            warriorTwo.Health -= damage > 0 ? damage : 0;
            Console.WriteLine($"{warriorOne.Name} attacks {warriorTwo.Name}.");
            Console.WriteLine($"{warriorTwo.Name} has remain health of {warriorTwo.Health}.");
            if (warriorTwo.Health <= 0) return false;
            return true;
        }
    }
}
