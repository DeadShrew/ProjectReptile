using ProjectReptile.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.AbstractClasses
{
    public abstract class EquippableItem : Equipment
    {

        public bool IsCursed = false;

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


        public abstract void EquipItem(Player player);

        public abstract void UnEquipItem(Player player);
    }
}

