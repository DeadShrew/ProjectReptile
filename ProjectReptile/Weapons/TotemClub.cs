using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;

namespace ProjectReptile.Weapons
{
    internal class TotemClub : Weapon
    {
        public TotemClub()
        {
            this.Power = 6;
            this.TwoHanded = true;
            this.Name = "totem club";
        }
    }
}
