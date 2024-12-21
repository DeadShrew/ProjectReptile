using ProjectReptile;
using ProjectReptile.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFactory.Monsters
{
    public class Cultist_1 : Enemy
    {
        public Cultist_1()
        {
            Random random = new Random();

            this.Power = 15;
            this.Constitution = 15 + random.Next(-2, 2);
            this.Dexterity = 15;
            this.Armor = 15;
            this.Gold = 0 + random.Next(0, 1);
            this.ThreatLevel = 0;
            this.EnemyName = "cultist";
        }  
    }
}
