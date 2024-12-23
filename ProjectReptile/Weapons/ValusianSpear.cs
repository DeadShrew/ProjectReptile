using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;

namespace ProjectReptile.Weapons
{
    internal class ValusianSpear : Weapon
    {
        public ValusianSpear()
        {
            this.Power = 8;
            this.TwoHanded = true;
            this.Name = "Valusian spear";
        }
    }
}
