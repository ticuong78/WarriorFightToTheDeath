using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorFightToTheDeath
{
    internal class Hulk: Warrior
    {
        public Hulk()
        {
            this.Name = "Hulk";
            this.Health = 1000;
            this.BaseAtk = 100;
            this.BaseBlock = 300;
        }
    }
}
