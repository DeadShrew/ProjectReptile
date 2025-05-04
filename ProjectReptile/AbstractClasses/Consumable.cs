using ProjectReptile.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.AbstractClasses
{
    public abstract class Consumable : Item
    {
        public abstract void ConsumeItem(Player player);

        public override string ToString()
        {
            //return Name;
            if (GlobalStateManager.LensEquipped == false)
            {
                return Name;
            }
            else
            {
                return TrueName;
            }
        }
    }
}
