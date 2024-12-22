using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Weapons
{
    internal class RitualMace : Weapon
    {
        public RitualMace()
        {
            this.Power = 5;
            this.TwoHanded = false;
            this.Name = "ritual mace";
        }
    }
}
