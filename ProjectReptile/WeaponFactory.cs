using ProjectReptile.Weapons;
using ProjectReptile.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile
{
    internal class WeaponFactory
    {
        public static Weapon CreateWeapon()
        {
            Random random = new Random();

            int enemy = random.Next(1, 6);

            switch (enemy)
            {
                case 1:
                    return new Torch();
                    break;

                case 2:
                    return new Pitchfork();
                    break;

                case 3:
                    return new Machete();
                    break;

                case 4:
                    return new Club();
                    break;

                case 5:
                    return new Whip();
                    break;
            }
            return null;
        }
    }
}
