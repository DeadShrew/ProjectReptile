using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;

namespace ProjectReptile.Enemies
{
    public class ManEatingPlant : Enemy
    {
        public ManEatingPlant()
        {
            Random random = new Random();

            string relativePath = "QC_Assets\\ManEatingPlant.png";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            this.enemyIcon = Image.FromFile(fullPath);
            this.Power = 3;
            this.Strength = 11 + random.Next(-2, 2);
            this.MaxStrength = this.Strength;
            this.Dexterity = 5;
            this.Armor = 3;
            this.Gold = 0 + random.Next(0, 2);
            this.ThreatLevel = 0;
            this.Name = "man-eating plant";
        }
    }
}
