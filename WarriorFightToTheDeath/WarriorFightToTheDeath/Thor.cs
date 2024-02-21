using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorFightToTheDeath
{
    internal class Thor: IWarrior
    {
        public Random critRate { get; set; } = new Random();
        public string Name { get; set; } = "Thor";
        public double Health { get; } = 300;
        public int BaseAtk { get; } = 100;
        public int BaseBlock { get; } = 200;

        public Thor() { }

        public double Attack(string abiName = "Auto Attack")
        {
            double damage = 0;
            ThorAbilities thorAbilities = new ThorAbilities(BaseAtk);
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

            return ((double) critRate.Next(1, 200) / 100) * Convert.ToDouble(damage);
        }

        public double Block()
        {
            return BaseBlock;
        }
    }
}
