using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;

namespace ProjectReptile.Enemies
{
    public class ProtoShoggoth : Enemy
    {
        public ProtoShoggoth()
        {
            Random random = new Random();

            string relativePath = "Images\\Proto-Shoggoth Test Image.png";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            this.enemyIcon = Image.FromFile(fullPath);
            this.Power = 2;
            this.Strength = 4 + random.Next(-2, 2);
            this.Dexterity = 15;
            this.Armor = 15;
            this.Gold = 0 + random.Next(0, 1);
            this.ThreatLevel = 0;
            this.Name = "proto-shoggoth";
        }
    }
}
