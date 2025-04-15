using ProjectReptile.AbstractClasses;
using ProjectReptile.Factories;
using ProjectReptile.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Enemies; 

public class Cultist : Enemy
{
    public Cultist()
    {
        Random random = new Random();

        this.equippedWeapon = WeaponFactory.CreateWeaponForCultist();
        if (equippedWeapon.TwoHanded == false)
        {
            this.equippedShield = ShieldFactory.CreateShield(); 
        }
        this.equippedArmour = ArmourFactory.CreateArmor();
        this.IsIntelligent = true;
        this.IsNegotiable = true; 
        this.Power = 15 + equippedWeapon.Power;
        this.Strength = 15 + random.Next(-2, 2);
        this.Dexterity = 15;
        this.Armor = 15;
        this.Gold = 0 + random.Next(0, 1);
        this.ThreatLevel = 0;
        this.Name = "cultist";
    }  
}
