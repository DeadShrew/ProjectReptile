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

        string relativePath;

        int cultistRole = random.Next(1, 5);

        if (cultistRole == 1)
        {
            relativePath = "QC_Assets\\Cultist1Dagon.png";
        } 
        
        else if (cultistRole == 2)
        {
            relativePath = "QC_Assets\\Cultist2Cthulu.png";
        }

        else if (cultistRole == 3)
        {
            relativePath = "QC_Assets\\CultPriest.png"; 
        } 
        else
        {
            relativePath = "QC_Assets\\Cultist4Occult.png";
        }


            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

        this.enemyIcon = Image.FromFile(fullPath);
        this.equippedWeapon = WeaponFactory.CreateWeaponForCultist();
        if (equippedWeapon.TwoHanded == false)
        {
            this.equippedShield = ShieldFactory.CreateShield(); 
        }
        this.equippedArmour = ArmourFactory.CreateArmor();
        this.IsIntelligent = true;
        this.IsNegotiable = true; 
        this.Power = equippedWeapon.Power;
        this.Strength = 4 + random.Next(-2, 2);
        this.MaxStrength = this.Strength; 
        this.Dexterity = 15;
        this.Armor = 15;
        this.Gold = 3 + random.Next(-2, 2);
        this.ThreatLevel = 0;
        this.Name = "cultist";
    }  
}
