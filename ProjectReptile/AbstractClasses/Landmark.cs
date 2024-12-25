using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.AbstractClasses
{
    public abstract class Landmark : Encounter
    {
        public string Name;

        public override void EncounterCheck(Player player)
        {
            if (player.LocationX == this.LocationX && player.LocationY == this.LocationY)
            {
                Console.WriteLine("The player has encountered a " + this.Name);
            }
        }
    }
}

