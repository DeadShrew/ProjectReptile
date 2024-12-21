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

            int enemy = random.Next(1, 3);

            switch (enemy)
            {
                case 1:
                    return new Torch();
                    break;

                case 2:
                    return new Pitchfork();
                    break;
            }
            return null;
        }
    }
}
