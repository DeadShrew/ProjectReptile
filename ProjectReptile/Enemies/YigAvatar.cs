using ProjectReptile.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Enemies
{
    class YigAvatar : MiniBoss
    {
        public YigAvatar()
        {
            Random random = new Random();

            string relativePath = "QC_Assets\\YigAvatar.png";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            this.enemyIcon = Image.FromFile(fullPath);
            this.Power = 1;
            this.Strength = 20 + random.Next(-2, 2);
            this.MaxStrength = this.Strength;
            this.Dexterity = 10;
            this.Armor = 4;
            this.Gold = 0 + random.Next(0, 2);
            this.ThreatLevel = 0;
            this.Name = "Avatar of Yig";
            this.LocationX = 9;
            this.LocationY = 10;

            Console.WriteLine("I am an Avatar of Yig and my location is " + LocationX + "," + LocationY);
        }
    }
}
