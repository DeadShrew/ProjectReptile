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
        public string Name;
        public string TrueName;

        public abstract void EquipItem(Player player);

    }
}

