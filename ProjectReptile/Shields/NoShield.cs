using ProjectReptile.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Shields
{
    public class NoShield : Shield
    {
        private static NoShield instance;

        public NoShield()
        {
            this.Armor = 0;
            this.Name = "";
        }

        public static NoShield GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NoShield();
                }
                return instance;
            }
        }
    }
}
