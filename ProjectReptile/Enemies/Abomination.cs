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

public class Abomination : Enemy
{
    public Abomination()
    {
        Random random = new Random();

        string relativePath;

        int abominationRole = random.Next(1, 3);

        if (abominationRole == 1)
        {
            relativePath = "QC_Assets\\Abomination1.png";
        }

        else 
        {
            relativePath = "QC_Assets\\Abomination2.png";
        }

        string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

        this.enemyIcon = Image.FromFile(fullPath);
        this.equippedWeapon = WeaponFactory.CreateWeaponForCultist();
        this.IsIntelligent = true;
        this.IsNegotiable = true;
        this.Power = equippedWeapon.Power;
        this.Strength = 4 + random.Next(-2, 2);
        this.MaxStrength = this.Strength;
        this.Dexterity = 15;
        this.Armor = 15;
        this.Gold = 3 + random.Next(-2, 2);
        this.ThreatLevel = 0;
        this.Name = "abomination";
    }
}
