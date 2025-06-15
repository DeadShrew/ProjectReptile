using ProjectReptile.AbstractClasses;
using ProjectReptile.Enemies;
using ProjectReptile.EquippableItems;
using ProjectReptile.Items;
using ProjectReptile.Tomes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Factories
{
    internal class ItemFactory
    {
        
        public static Item CreateConsumable()
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

            int item = random.Next(1, 8);

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

        public static Item CreateEquippableItem()
        {
            Random random = new Random();

            int item = random.Next(1, 12);

            switch (item)
            {
                case 1:
                    return new RingOfStrength();

                case 2:
                    return new RingOfWeakness();

                case 3:
                    return new RingOfWisdom();

                case 4:
                    return new RingOfStupidity();

                case 5:
                    return new RingOfDexterity();

                case 6:
                    return new RingOfClumsiness();

                case 7:
                    return new RingOfProtection();

                case 8:
                    return new RingOfVulnerability();

                case 9:
                    return new AmuletOfLife();

                case 10:
                    return new AmuletOfShielding();

                case 11:
                    return new AmuletOfTheLifeDrain();
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

        public static Item CreateTome()
        {
            Random random = new Random();

            int item = random.Next(1, 4);

            switch (item)
            {
                case 1:
                    return new BlackBookOfValusia();

                case 2:
                    return new Necronomicon();

                case 3:
                    return new BookOfDagon();
            }
            return null;
        }
    }
}
    

