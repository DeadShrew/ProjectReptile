using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;

namespace ProjectReptile.Enemies
{
    public class DimensionalShambler : VampiricEnemy
    {
        public DimensionalShambler()
        {
            Random random = new Random();

            string relativePath = "QC_Assets\\DimensionalShambler.png";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            this.enemyIcon = Image.FromFile(fullPath);
            this.Power = 6;
            this.Strength = 8 + random.Next(-2, 2);
            this.MaxStrength = this.Strength;
            this.Dexterity = 5;
            this.Armor = 1;
            this.Gold = 0 + random.Next(0, 2);
            this.ThreatLevel = 0;
            this.Name = "dimensional shambler";
        }
    }
}
