using ProjectReptile.AbstractClasses;
using ProjectReptile.Armor;
using ProjectReptile.Enemies;
using ProjectReptile.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Factories
{
    internal class ArmourFactory
    {
        public static Armour CreateArmor()
        {
            Random random = new Random();

            int armor = random.Next(1, 5);

            switch (armor)
            {
                case 1:
                    return new LeatherArmor();

                case 2:
                    return new ChainmailArmor();

                case 3:
                    return new PartialPlateArmor();

                case 4:
                    return new PlateArmor();
            }
            return null;
        }
    }
}


