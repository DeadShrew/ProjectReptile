using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;

namespace ProjectReptile
{
    internal class Trap : Encounter
    {

        public int AdjacentTraps; 

        public Trap()
        {
        }
        
        public void TrapCheck(LinkedList<Trap> trapList) //<-Needs work
        {
            foreach (Trap trap in trapList)
            {
                if (this.LocationY == (trap.LocationY +- 1)) {

                }
            }
        }

        public override void EncounterCheck(Player player)
        {
            if (player.LocationX == LocationX && player.LocationY == LocationY)
            {
                Console.WriteLine("The player has encountered a trap. Boom!");
            }
        }
    }
}
