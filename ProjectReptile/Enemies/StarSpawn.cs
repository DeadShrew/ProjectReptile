using ProjectReptile.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Enemies
{
    class StarSpawn : MiniBoss
    {
        public StarSpawn()
        {
            Random random = new Random();

            string relativePath = "QC_Assets\\StarSpawn.png";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            this.enemyIcon = Image.FromFile(fullPath);
            this.Power = 5;
            this.Strength = 16 + random.Next(-2, 2);
            this.MaxStrength = this.Strength;
            this.Dexterity = 10;
            this.Armor = 3;
            this.Gold = 0 + random.Next(0, 2);
            this.ThreatLevel = 0;
            this.Name = "star spawn";
            this.LocationX = 9;
            this.LocationY = 10;

            Console.WriteLine("I am a Star Spawn and my location is " + LocationX + "," + LocationY);
        }
    }
}
