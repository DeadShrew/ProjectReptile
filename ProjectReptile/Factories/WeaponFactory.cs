﻿using ProjectReptile.Weapons;
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

            int weapon = random.Next(1, 8);

            switch (weapon)
            {
                case 1:
                    return new Torch();

                case 2:
                    return new Pitchfork();

                case 3:
                    return new Machete();

                case 4:
                    return new RitualMace();

                case 5:
                    return new Whip();

                case 6:
                    return new TotemClub();

                case 7:
                    return new Whip();
            }

            return null;
        }
        public static Weapon CreateWeapon()
        {
            Random random = new Random();

            int weapon = random.Next(1, 6);

            switch (weapon)
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
