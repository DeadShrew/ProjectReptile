using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;

namespace ProjectReptile.Weapons
{
    internal class Pitchfork : Weapon
    {
        public Pitchfork()
        {
            this.Power = 6;
            this.TwoHanded = true;
            this.Name = "pitchfork"; 
        }
    }
}
