using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;

namespace ProjectReptile
{
    public class Trap : Encounter
    {
        public int AdjacentTraps; 

        public Trap() { }
       
        public override void EncounterCheck(Player player)
        {
            if (player.LocationX == LocationX && player.LocationY == LocationY)
            {
                GUIOutputManager.PlayerConsoleOutputList.AddLast("You have entered a magic shock trap.");
            }
        }
    }
}
