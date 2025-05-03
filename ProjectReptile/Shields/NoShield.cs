using ProjectReptile.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Shields
{
    class NoShield : Shield
    {
        public NoShield()
        {
            this.Armor = 0;
            this.Name = "";
        }
    }
}
