using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Weapons
{
    internal class Torch : Weapon
    {
        public Torch() 
        {
            this.Power = 1; 
            this.TwoHanded = false;
            this.Name = "torch";
        }
    }
}
