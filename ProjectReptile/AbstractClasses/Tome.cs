using ProjectReptile.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.AbstractClasses
{
    public abstract class Tome : Equipment
    {
        public bool NonCombative; 

        public override string ToString()
        {
            if (GlobalStateManager.LensEquipped == false)
            {
                return Name;
            }
            else
            {
                return TrueName;
            }
        }

        public abstract void CastSorcery(Player player, Enemy enemy);
    }
}
