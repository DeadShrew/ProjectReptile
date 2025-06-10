using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;

namespace ProjectReptile.Enemies
{
    public class NightGaunt : Enemy
    {
        public NightGaunt()
        {
            Random random = new Random();

            string relativePath = "QC_Assets\\NightGaunt.png";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            this.enemyIcon = Image.FromFile(fullPath);
            this.Power = 1;
            this.Strength = 2 + random.Next(-1, 1);
            this.MaxStrength = this.Strength;
            this.Dexterity = 13;
            this.Armor = 0;
            this.Gold = 0 + random.Next(0, 2);
            this.ThreatLevel = 0;
            this.Name = "night-gaunt";
        }
    }
}
