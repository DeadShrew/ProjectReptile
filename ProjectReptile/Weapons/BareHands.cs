using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;

namespace ProjectReptile.Weapons
{
    public class BareHands : Weapon
    {
        public static BareHands instance;

        public BareHands()
        {
            this.Power = 0;
            this.TwoHanded = false;
            this.Name = "bare hands";
        }

        public static BareHands GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BareHands();
                }
                return instance;
            }
        }
    }
}