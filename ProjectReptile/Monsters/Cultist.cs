using ProjectReptile;
using ProjectReptile.Monsters;
using ProjectReptile.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFactory.Monsters
{
    public class Cultist : Enemy
    {
        public Cultist()
        {
            Random random = new Random();

            this.equippedWeapon = WeaponFactory.CreateWeapon();
            this.Power = 15 + equippedWeapon.Power;
            this.Constitution = 15 + random.Next(-2, 2);
            this.Dexterity = 15;
            this.Armor = 15;
            this.Gold = 0 + random.Next(0, 1);
            this.ThreatLevel = 0;
            this.EnemyName = "cultist";
        }  
    }
}
