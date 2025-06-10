using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;

namespace ProjectReptile.Enemies
{
    public class ToadFamiliar : PoisonEnemy
    {
        public ToadFamiliar()
        {
            Random random = new Random();

            string relativePath = "QC_Assets\\ToadFamiliar.png";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            this.enemyIcon = Image.FromFile(fullPath);
            this.Power = 4;
            this.Strength = 5 + random.Next(-2, 2);
            this.MaxStrength = this.Strength;
            this.Dexterity = 13;
            this.Armor = 0;
            this.Gold = 0 + random.Next(0, 2);
            this.ThreatLevel = 0;
            this.Name = "toad familiar";
        }
    }
}
