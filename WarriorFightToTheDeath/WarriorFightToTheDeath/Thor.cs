﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorFightToTheDeath
{
    internal class Thor: Warrior
    {
        public Thor() 
        {
            this.Name = "Thor";
            this.Health = 300;
            this.BaseAtk = 100;
            this.BaseBlock = 200;
        }
    }
}
