using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Weapons
{
    internal class Club : Weapon
    {
        public Club()
        {
            this.Power = 1;
            this.TwoHanded = true;
            this.Name = "club";
        }
    }
}
