
using ProjectReptile.AbstractClasses;
using ProjectReptile.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Factories
{
    internal class EnemyFactory
    {
        public static Enemy CreateEnemy()
        {
            Random random = new Random();

            int enemy = random.Next(1, 20);

            switch (enemy)
            {
                case 1:
                    return new Cultist();

                case 2:
                    return new ProtoShoggoth();

                case 3:
                    return new CosmicColor();

                case 4:
                    return new SnakeFamiliar();

                case 5:
                    return new FireVampire();

                case 6:
                    return new Shoggoth();

                case 7:
                    return new Abomination();

                case 8:
                    return new DimensionalShambler();

                case 9:
                    return new Ghoul();

                case 10:
                    return new ManEatingPlant();

                case 11:
                    return new ManFacedRat();

                case 12:
                    return new NightGaunt();

                case 13:
                    return new ProtoShoggoth();

                case 14:
                    return new SpiderFamiliar();

                case 15:
                    return new ToadFamiliar();

                case 16:
                    return new ValusianChieftain();

                case 17:
                    return new ValusianFootsoldier();

                case 18:
                    return new Werewolf();

                case 19:
                    return new Zombie();
            }

            return null;
        }

        public static Enemy CreateMiniBoss()
        {
            Random random = new Random();

            int enemy = random.Next(1, 5);

            switch (enemy)
            {
                case 1:
                    return new Dagon();

                case 2:
                    return new YigAvatar();

                case 3:
                    return new StarSpawn();

                case 4:
                    return new HaunterOfTheDark();
            }

            return null;
        }
    }
}

