using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;

namespace ProjectReptile.Enemies
{
    public class SpiderFamiliar : PoisonEnemy
    {
        public SpiderFamiliar()
        {
            Random random = new Random();

            string relativePath = "QC_Assets\\SpiderFamiliar.png";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            this.enemyIcon = Image.FromFile(fullPath);
            this.Power = 1;
            this.Strength = 1 + random.Next(0, 2);
            this.MaxStrength = this.Strength;
            this.Dexterity = 11;
            this.Armor = 0;
            this.Gold = 0 + random.Next(0, 2);
            this.ThreatLevel = 0;
            this.Name = "spider familiar";
        }
    }
}
