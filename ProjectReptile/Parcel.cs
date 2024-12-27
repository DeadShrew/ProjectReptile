using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;

namespace ProjectReptile
{
    public class Parcel : Encounter
    {
        public bool IsRevealed = false; 
        public LinkedList<Item> ItemList;

        public Parcel(int x, int y)
        {
            LocationX = x;
            LocationY = y;
            ItemList = new LinkedList<Item>();

            Console.WriteLine("I am a parcel and my location is " + LocationX + ", " + LocationY);
        }

        public override void EncounterCheck(Player player)
        {
            if (player.LocationX == LocationX && player.LocationY == LocationY)
                {
                    Console.WriteLine("Parcel :" + LocationY + ", " + LocationX + "has been occupied. Revealed = " + IsRevealed);
                    this.IsRevealed = true;
                }
        }
    }
}
