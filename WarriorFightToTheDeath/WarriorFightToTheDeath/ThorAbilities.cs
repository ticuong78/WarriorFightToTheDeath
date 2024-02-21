using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorFightToTheDeath
{
    struct ThorAbilities : IAbility
    {
        public double AutoAttack { get; set; }
        public double SkillAttack { get; set; }
        public double UltimateSkill { get; set; }

        public ThorAbilities(int baseAtk = 100)
        {
            AutoAttack = 100;
            SkillAttack = 450;
            AutoAttack = 800;
        }
    }
}
