using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorFightToTheDeath
{
    class Warrior
    {
        private static int numberOfWarrior = 0;
        private Random critRate { get; } = new Random();
        public string Name { get; set; } = $"Warrior {++numberOfWarrior}";
        public double Health { get; set; }
        public int BaseAtk { get; set;  }
        public int BaseBlock { get; set; }
        public double Attack(Warrior warrior, string abiName = "Auto Attack")
        {
            double damage = 0;
            Abilities thorAbilities = new Abilities(warrior);
            switch (abiName)
            {
                case "Auto Attack":
                    {
                        damage = thorAbilities.AutoAttack;
                        break;
                    }
                case "Skill Attack":
                    {
                        damage = thorAbilities.SkillAttack;
                        break;
                    }
                case "Ultimate Skill":
                    {
                        damage = thorAbilities.UltimateSkill;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Cannot find abilities fit your demand");
                        break;
                    }
            }

            return ((double)critRate.Next(1, 200) / 100) * Convert.ToDouble(damage);
        }

        public double Block()
        {
            return BaseBlock;
        }
    }
}
