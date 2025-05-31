using ProjectReptile.AbstractClasses;
using ProjectReptile.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Landmarks
{
    public class Chest : Landmark
    {
        public Chest()
        {
            this.Name = "chest";
            string relativePath = "QC_Assets\\Chest.png";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            this.landmarkIcon = Image.FromFile(fullPath);

            Random random = new Random();

            int roll = random.Next(1, 6); 

            if (roll == 1)
            {
                item = ItemFactory.CreateConsumable();
            }

            if (roll == 2)
            {
                item = WeaponFactory.CreateWeapon();
            }

            if (roll == 3)
            {
                item = ShieldFactory.CreateShield();
            }

            if (roll == 4)
            {
                item = ArmourFactory.CreateArmor();
            }

            if (roll == 5)
            {
                item = ItemFactory.CreateEquippableItem();
            }
        }
    }
}
