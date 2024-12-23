using ProjectReptile.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;

namespace ProjectReptile.Factories
{
    internal class WeaponFactory
    {
        public static Weapon CreateWeaponForCultist()
        {
            Random random = new Random();

            int enemy = random.Next(1, 8);

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
                    return new RitualMace();
                    break;

                case 5:
                    return new Whip();
                    break;

                case 6:
                    return new TotemClub();
                    break;

                case 7:
                    return new Whip();
                    break;
            }

            return null;
        }
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
                    return new RitualMace();
                    break;

                case 5:
                    return new Whip();
                    break;

                case 6:
                    return new TotemClub();
                    break;

                case 7:
                    return new Whip();
                    break;
            }

            return null;
        }
    }
}
