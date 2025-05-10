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

                Random random = new Random();
                int trapDamage = random.Next(1, 13);

                player.Strength = player.Strength - trapDamage;
                
                GUIOutputManager.PlayerConsoleOutputList.AddLast("You entered a magic shock trap which deals " + trapDamage + " damage.");
            }
        }
    }
}
