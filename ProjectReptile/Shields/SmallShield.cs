using ProjectReptile.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Shields
{
    class SmallShield : Shield
    {
        public SmallShield()
        {
            this.Armor = 1;
            this.Name = "small shield"; 
        }
    }
}
