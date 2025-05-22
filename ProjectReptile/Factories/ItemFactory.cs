using ProjectReptile.AbstractClasses;
using ProjectReptile.Enemies;
using ProjectReptile.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Factories
{
    internal class ItemFactory
    {
        
        public static Item CreateItem()
        {
            Random random = new Random();

            int item = random.Next(1, 12);

            switch (item)
            {
                case 1:
                    return new RestorationPotion();

                case 2:
                    return new BottleOfWater();

                case 3:
                    return new Antidote();

                case 4:
                    return new AwkwardnessPotion();

                case 5:
                    return new DexterityPotion();

                case 6:
                    return new HealingPotion();

                case 7:
                    return new PoisonPotion();

                case 8:
                    return new RemoveCurseScroll();

                case 9:
                    return new ScrollOfHealing();

                case 10:
                    return new ScrollOfStrength();

                case 11:
                    return (WeaponFactory.CreateWeapon());
            }
            return null;
        }

        public static Item CreatePotion()
        {
            Random random = new Random();

            int item = random.Next(1, 12);

            switch (item)
            {
                case 1:
                    return new RestorationPotion();

                case 2:
                    return new BottleOfWater();

                case 3:
                    return new Antidote();

                case 4:
                    return new AwkwardnessPotion();

                case 5:
                    return new DexterityPotion();

                case 6:
                    return new HealingPotion();

                case 7:
                    return new PoisonPotion();
            }
            return null;
        }

        public static Item CreateScroll()
        {
            Random random = new Random();

            int item = random.Next(1, 4);

            switch (item)
            {
                case 1:
                    return new RemoveCurseScroll();

                case 2:
                    return new ScrollOfHealing();

                case 3:
                    return new ScrollOfStrength();
            }
            return null;
        }
    }
}
    

