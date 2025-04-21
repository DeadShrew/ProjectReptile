using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;

namespace ProjectReptile.GameObjects
{
    public class Parcel : Encounter
    {
        public int AdjacentTraps;
        public LinkedList<Item> ItemList;
        public bool TrapsChecked;
        public string Description;
        public string LandmarkDescription;
        public string EnemyDescription;
        Random random = new Random();

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
                Console.WriteLine("My adjacent trap count is: " + AdjacentTraps); 
            }
                
        }

    }
}
