using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;
using ProjectReptile.Factories;

namespace ProjectReptile.Enemies
{
    public class DeepOne : Enemy
    {
        public DeepOne()
        {
            Random random = new Random();

            string relativePath = "QC_Assets\\DeepOne.png";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            this.IsIntelligent = true;
            this.IsNegotiable = true;
            this.Power = equippedWeapon.Power;
            this.Strength = 4 + random.Next(-2, 2);
            this.MaxStrength = this.Strength;
            this.Dexterity = 15;
            this.Armor = 15;
            this.Gold = 3 + random.Next(-2, 2);
            this.ThreatLevel = 0;
            this.Name = "deep one";
        }
    }
}
