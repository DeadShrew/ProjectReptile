using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.MiscGameObjects
{
    class BossRoom : Encounter
    {
        public BossRoom(int x, int y)
        {
            this.LocationX = x;
            this.LocationY = y;
            Console.WriteLine("BossRoom Location = " + x + y);
        }

        public override void EncounterCheck(Player player)
        {
            if (this.LocationX == player.LocationX && this.LocationY == player.LocationY && player.GoldKeyFound != true)
            {
                MessageBox.Show("You have found the entrance to the inner sanctum. Find the gold key to enter.");
            }
            else if (this.LocationX == player.LocationX && this.LocationY == player.LocationY && player.GoldKeyFound == true)
            {
                DialogResult result = MessageBox.Show("The entrance to the inner sanctum is here. Do you wish to enter?", "Question", MessageBoxButtons.YesNo);

            }
        }
    }
}
