using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.AbstractClasses
{
    public abstract class Enemy : Encounter
    {
        public Weapon equippedWeapon;
        public Shield equippedShield;
        public Armour equippedArmour;

        public int Power;
        public int Strength;
        public int Dexterity;
        public int Armor;
        public int Gold;
        public int ThreatLevel;
        public bool IsIntelligent;
        public bool IsNegotiable;
        public bool IsAlive = true;
        public string Name;

        public override void EncounterCheck(Player player)
        {
            if(player.LocationX == this.LocationX && player.LocationY == this.LocationY)
                {
                Console.WriteLine("The player has encountered a " + this.Name);
                player.InCombat = true;
            }
        }
    }
}
