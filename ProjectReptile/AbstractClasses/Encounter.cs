using ProjectReptile.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.AbstractClasses
{
    public abstract class Encounter
    {

        public int LocationX;
        public int LocationY;

        public abstract void EncounterCheck(Player player); 

        void ResetForNewGame() { }

        public Tuple<int, int> GetLocation()
        {
            int x = LocationX;
            int y = LocationY;

            return Tuple.Create(x, y);
        }

        public void SetLocation(int x, int y)
        {
            LocationX = x;
            LocationY = y;
        }
    }
}
