using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;

namespace ProjectReptile.Weapons
{
    internal class Machete : Weapon
    {
        public Machete()
        {
            this.Power = 5;
            this.TwoHanded = false;
            this.Name = "machete";
        }
    }
}
