using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorFightToTheDeath
{
    internal interface IWarrior
    {
        class Ability;
        Random critRate { get; }
        string Name { get; }
        double Health { get; }
        int BaseAtk { get; }
        int BaseBlock { get; }
        double Attack(string abiName);
        double Block();
    }
}
