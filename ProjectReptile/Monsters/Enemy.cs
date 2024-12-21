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
        public int LocationX;
        public int LocationY;
        public bool IsIntelligent;
        public bool IsNegotiable;
        public string EnemyName;

        public Tuple<int, int> GetEnemyLocation()
        {
            int x = LocationX;
            int y = LocationY;

            return Tuple.Create(x, y);
        }

        public void SetEnemyLocation(int x, int y)
        {
            LocationX = x;
            LocationY = y;
        }

    }
}
