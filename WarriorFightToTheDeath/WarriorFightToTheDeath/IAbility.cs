using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorFightToTheDeath
{
    interface IAbility
    {
        double AutoAttack { get; set; }
        double SkillAttack { get; set; }
        double UltimateSkill { get; set; }
    }
}
