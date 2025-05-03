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
        
        public static Consumable CreateItem()
        {
            Random random = new Random();

            int item = random.Next(1, 3);

            switch (item)
            {
                case 1:
                    return new RestorationPotion();

                case 2:
                    return new BottleOfWater();
            }
            return null;
        }
    }
}
    

