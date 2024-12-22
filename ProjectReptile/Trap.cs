using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile
{
    internal class Trap : Encounter
    {
        public Trap (int x, int y)
        {
           LocationX = x;
           LocationY = y;

            Console.WriteLine("I am a trap and my location is " + LocationX + ", " + LocationY);
        }
        
    }
}
