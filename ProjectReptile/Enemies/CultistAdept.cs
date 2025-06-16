using ProjectReptile.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Enemies
{
    class CultistAdept : Boss
    {
        public CultistAdept()
        {
            Random random = new Random();

            string relativePath = "QC_Assets\\CultistAdept.png";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            enemyIcon = Image.FromFile(fullPath);
            Power = 2;
            Strength = 4 + random.Next(-2, 2);
            MaxStrength = Strength;
            Dexterity = 15;
            Armor = 15;
            Gold = 0 + random.Next(0, 2);
            ThreatLevel = 0;
            Name = "cultist adept";
            LocationX = 10;
            LocationY = 10;

        }
    }
}
