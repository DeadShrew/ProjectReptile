using ProjectReptile.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Monsters
{
    public abstract class Enemy : Encounter
    {
        public Weapon equippedWeapon;
        
        public int Power;
        public int Constitution;
        public int Dexterity;
        public int Armor;
        public int Gold;
        public int ThreatLevel;
        public bool IsIntelligent;
        public bool IsNegotiable;
        public string EnemyName;

    }
}
