using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;

namespace ProjectReptile.Weapons
{
    internal class BareHands : Weapon
    {
        public BareHands()
        {
            this.Power = 0;
            this.TwoHanded = false;
            this.Name = "bare hands";
        }
    }
}