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
            
        }
    }
}
