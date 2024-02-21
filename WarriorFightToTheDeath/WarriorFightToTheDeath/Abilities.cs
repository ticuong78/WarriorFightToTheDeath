using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorFightToTheDeath
{
    struct Abilities : IAbility
    {
        public double AutoAttack { get; set; }
        public double SkillAttack { get; set; }
        public double UltimateSkill { get; set; }

        public Abilities(Warrior warrior)
        {
            double baseAtk = warrior.BaseAtk;
            if (warrior.Name == "Thor")
            {
                AutoAttack = baseAtk;
                SkillAttack = baseAtk * 4.5;
                UltimateSkill = baseAtk * 8;
            }
            else if (warrior.Name == "Hulk")
            {
                AutoAttack = baseAtk;
                SkillAttack = baseAtk * 3;
                UltimateSkill = baseAtk * 5;
            }
        }
    }
}
