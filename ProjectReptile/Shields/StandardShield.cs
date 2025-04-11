using ProjectReptile.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Shields
{
    public class StandardShield : Shield
    {
        public StandardShield()
        {
            this.Armor = 1;
            this.Name = "shield"; 
        }
    }
}
