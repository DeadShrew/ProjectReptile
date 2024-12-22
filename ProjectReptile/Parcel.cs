using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile
{
    public class Parcel : Encounter
    {
        public int LocationX;
        public int LocationY;
        public LinkedList<Item> ItemList; 

        public Parcel(int x, int y) 
        {
            LocationX = x;
            LocationY = y;
            ItemList = new LinkedList<Item>();

            Console.WriteLine("My location is " + LocationX  + ", " + LocationY);
        }
    }
}
