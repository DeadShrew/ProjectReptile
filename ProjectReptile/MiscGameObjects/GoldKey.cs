using ProjectReptile.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile
{
    class GoldKey : AbstractClasses.Encounter
    {
        public GoldKey(int x, int y)
        {
            this.LocationX = x;
            this.LocationY = y;
        }

        public override void EncounterCheck(Player player)
        {
            if (this.LocationX == player.LocationX && this.LocationY == player.LocationY && player.GoldKeyFound != true)
            {
                player.GoldKeyFound = true;
                MessageBox.Show("You have found the gold key to the boss!"); 
            }
        }
    }
}
