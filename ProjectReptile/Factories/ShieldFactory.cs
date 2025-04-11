using ProjectReptile.AbstractClasses;
using ProjectReptile.Armor;
using ProjectReptile.Shields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Factories
{
    class ShieldFactory
    {
        public static Shield CreateShield()
        {
            Random random = new Random();

            int shield = random.Next(1, 5);

            switch (shield)
            {
                case 1:
                    return new SmallShield();

                case 2:
                    return new StandardShield();

                case 3:
                    return new GreatShield();

                case 4:
                    return new DragonShield();
            }
            return null;
        }
    }
}
