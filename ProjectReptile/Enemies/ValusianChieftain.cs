using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;
using ProjectReptile.Factories;

namespace ProjectReptile.Enemies
{
    public class ValusianChieftain : PoisonEnemy
    {
        public ValusianChieftain()
        {
            Random random = new Random();

            string relativePath = "QC_Assets\\ValusianChieftan.png";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            this.enemyIcon = Image.FromFile(fullPath);
            this.equippedWeapon = WeaponFactory.CreateWeaponForCultist();
            this.IsIntelligent = true;
            this.IsNegotiable = true;
            this.Power = 5;
            this.Strength = 9 + random.Next(-2, 2);
            this.MaxStrength = this.Strength;
            this.Dexterity = 5;
            this.Armor = 1;
            this.Gold = 3 + random.Next(0, 2);
            this.ThreatLevel = 0;
            this.Name = "valusian chieftain";
        }
    }
}
