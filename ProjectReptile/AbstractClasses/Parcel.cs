using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.AbstractClasses
{
    public class Parcel : Encounter
    {
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
            
        }
    }
}
