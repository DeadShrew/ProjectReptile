
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

            int enemy = random.Next(1, 6);

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
            }

            return null;
            }
        }
    }

