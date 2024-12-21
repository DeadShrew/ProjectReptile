using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Weapons
{
    internal class Whip : Weapon
    {
        public Whip()
        {
            this.Power = 1;
            this.TwoHanded = true;
            this.Name = "pitchfork";
        }
    }
}
