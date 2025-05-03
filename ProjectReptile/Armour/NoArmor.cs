using ProjectReptile.AbstractClasses;
using ProjectReptile.Shields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Armor
{
    public class NoArmor : Armour
    {
        public static NoArmor instance;

        public NoArmor()
        {
            this.Armor = 0;
            this.Name = "";
        }

        public static NoArmor GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NoArmor();
                }
                return instance;
            }
        }
    }
}

