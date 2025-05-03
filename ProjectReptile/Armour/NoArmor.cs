using ProjectReptile.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Armor
{
    class NoArmor : Armour
    {
        public NoArmor()
        {
            this.Armor = 0;
            this.Name = "";
        }
    }
}

