using ProjectReptile.AbstractClasses;
using ProjectReptile.Armor;
using ProjectReptile.EquippableItems;
using ProjectReptile.Items;
using ProjectReptile.Shields;
using ProjectReptile.Tomes;
using ProjectReptile.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.GameObjects
{
    public class Player 
    {
        public int LocationX;
        public int LocationY;
        public int Strength = 14;
        public int MaxStrength = 14;
        public int Weapon = 0;
        public int Armor = 0;
        public int Dexterity = 10;
        public int MaxDexterity = 18;
        public int Intelligence = 10;
        public int ModifiedInt = 10;
        public int Gold = 10;
        public int CarryAmount = 15;
        public bool InCombat;
        public bool AtLandmark;
        public bool GoldKeyFound = false;
        public bool IsPoisoned = false;
        public bool IsBurning = false;
        public bool IsCursed = false;
        public string MovedDir;
        public Weapon equippedWeapon;
        public Shield equippedShield;
        public Armour equippedArmour;
        public Tome equippedTome;

        public LinkedList<Item> ItemList;

        Random random = new Random();
        public Player()
        {
            if (equippedWeapon != null)
            {
                this.Weapon = Weapon + equippedWeapon.Power;
            } else
            {
                this.Weapon = 0; 
            }

            if (equippedShield != null)
            {
                this.Armor = Armor + equippedShield.Armor;
            } else if (equippedArmour != null)
            {
                this.Armor = equippedArmour.Armor;    
            } else
            {
                this.Armor = 0;
            }

            if (equippedArmour != null)
            {
                this.Armor = Armor + equippedArmour.Armor;
            } else if (equippedShield != null)
            {
                this.Armor = equippedShield.Armor;
            } else
            {
                this.Armor = 0;
            }

            LocationX = GlobalStateManager.StartingLocationX;
            LocationY = GlobalStateManager.StartingLocationY;

            ItemList = new LinkedList<Item>();

            ItemList.AddLast(new Machete()); 
            ItemList.AddLast(new SmallShield());
            ItemList.AddLast(new LeatherArmor());
            ItemList.AddLast(new RestorationPotion());
            ItemList.AddLast(new Antidote());

            this.equippedWeapon = (Weapon?)ItemList.FirstOrDefault(i => i is Machete); 
            this.equippedShield = (Shield?)ItemList.FirstOrDefault(i => i is SmallShield);
            this.equippedArmour = (Armour?)ItemList.FirstOrDefault(i => i is LeatherArmor);

            this.equippedWeapon.IsEquipped = true;
            this.equippedShield.IsEquipped = true;
            this.equippedArmour.IsEquipped = true;

            UpdatePlayerAfterEquipmentChange();
        }

        public void UpdatePlayerAfterEquipmentChange()
        {
            this.Weapon = 0;
            this.Armor = 0;

            if (equippedWeapon != null)
            {
                this.Weapon = Weapon + equippedWeapon.Power;
            }
            if (equippedShield != null)
            {
                this.Armor = Armor + equippedShield.Armor;
            }
            if (equippedArmour != null)
            {
                this.Armor = Armor + equippedArmour.Armor;
            }
        }

        public void MovePlayerUp()
        {
            MovedDir = "N";

            if (LocationY > 0)
            {
                LocationY--;
            }
            else if (LocationY == 0)
            {
                LocationY = Settings.Rows -1;
            }
        }

        public void MovePlayerDown()
        {
            MovedDir = "S";

            if (LocationY < Settings.Rows -1)
            {
                LocationY++;
            }
            else if (LocationY == Settings.Rows - 1)
            {
                LocationY = 0;
            }
        }

        public void MovePlayerLeft()
        {
            MovedDir = "W";

            if (LocationX > 0)
            {
                LocationX--;
            }
            else if (LocationX == 0)
            {
                LocationX = Settings.Columns -1;
            }
        }

        public void MovePlayerRight()
        {
            MovedDir = "E";  

            if (LocationX < Settings.Columns - 1)
            {
                LocationX++;
            }
            else if (LocationX >= Settings.Columns - 1)
            {
                LocationX = 0; 
            }
        }
    }
}
