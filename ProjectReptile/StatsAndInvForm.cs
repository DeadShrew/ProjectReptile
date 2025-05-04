using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ProjectReptile.AbstractClasses;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using ProjectReptile.GameObjects;
using ProjectReptile.Weapons;
using ProjectReptile.Shields;
using ProjectReptile.Armor;

namespace ProjectReptile
{
    public partial class StatsAndInvForm : Form
    {
        GameStateModel gameState;

        public StatsAndInvForm(GameStateModel gameState)
        {
            InitializeComponent();
            this.gameState = gameState;
            UpdateStatsForm();
        }

        private void UpdateStatsForm()
        {
            this.MaxStrengthTextBoxLabel.Text = gameState.player.MaxStrength.ToString();
            this.MaxDexTextBoxLabel.Text = gameState.player.MaxDexterity.ToString();
            this.IntelligenceTextBoxLabel.Text = gameState.player.Intelligence.ToString();
            this.CurrentStrengthTextBoxLabel.Text = gameState.player.Strength.ToString();
            this.ModifiedTextBoxLabel.Text = gameState.player.Dexterity.ToString();
            this.ModifiedIntTextBoxLabel.Text = gameState.player.ModifiedInt.ToString();
            this.GoldTextBoxLabel.Text = gameState.player.Gold.ToString();
            this.WeaponTextBoxLabel.Text = gameState.player.Weapon.ToString();
            this.ArmourTextBoxLabel.Text = gameState.player.Armor.ToString();
            if (gameState.player.equippedWeapon != null)
            {
                this.ReadyWeaponLabel.Text = "Ready Weapon: " + gameState.player.equippedWeapon.Name;
            }
            if (gameState.player.equippedShield != null)
            {
                this.ReadyShieldLabel.Text = "Ready Shield: " + gameState.player.equippedShield.Name;
            }
            if (gameState.player.equippedArmour != null)
            {
                this.ArmourWornLabel.Text = "Armour Worn: " + gameState.player.equippedArmour.Name;
            }
            if (gameState.player.GoldKeyFound == true)
            {
                this.GoldKeyLabel.Text = "Gold Key found.";
            }
        }

        private void StatsAndInvForm_Load(object sender, EventArgs e)
        {
            GetPlayerInventory(gameState.player);
        }

        private void GetPlayerInventory(Player player)
        {
            foreach (Item item in player.ItemList)
            {
                PlayerInventoryListbox.Items.Add(item);
            }
        }
        private void PlayerInventoryListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = PlayerInventoryListbox.SelectedItem;

            if (item is Equipment)
            {
                Equipment equipment = (Equipment)item;

                if (equipment.IsEquipped == true)
                {
                    ItemStatusLabel.Text = "In Use";

                }
                else if (equipment.IsEquipped == false)
                {
                    ItemStatusLabel.Text = "";
                }
            }

            this.Refresh();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UseItemButton_Click(object sender, EventArgs e)
        {
            var item = PlayerInventoryListbox.SelectedItem;

            if (item is Weapon)
            {
                Weapon weapon = (Weapon)item;
                if (weapon.TwoHanded == false)
                {
                    gameState.player.equippedWeapon.IsEquipped = false;
                    gameState.player.equippedWeapon = weapon;
                    weapon.IsEquipped = true;
                    ReadyWeaponLabel.Text = "Ready Weapon: " + gameState.player.equippedWeapon.Name;
                } else if (weapon.TwoHanded == true && gameState.player.equippedShield is NoShield)
                {
                    gameState.player.equippedWeapon.IsEquipped = false;
                    gameState.player.equippedWeapon = weapon;
                    weapon.IsEquipped = true;
                    ReadyWeaponLabel.Text = "Ready Weapon: " + gameState.player.equippedWeapon.Name;
                } else
                {
                    MessageBox.Show("You cannot equip a two-handed weapon while using a shield.");
                }          
            }

            if (item is Shield)
            {
                Shield shield = (Shield)item;
                if (gameState.player.equippedWeapon.TwoHanded == false)
                {
                    gameState.player.equippedShield.IsEquipped = false;
                    gameState.player.equippedShield = shield;
                    shield.IsEquipped = true;
                    ReadyShieldLabel.Text = "Ready Shield: " + gameState.player.equippedShield.Name;
                } else if (gameState.player.equippedWeapon.TwoHanded == true)
                {
                    MessageBox.Show("You cannot equip a shield while using a two-handed weapon.");
                }
                
            }

            if (item is Armour)
            {
                Armour armour = (Armour)item;
                gameState.player.equippedArmour.IsEquipped = false;
                gameState.player.equippedArmour = armour;
                armour.IsEquipped = true;
                ArmourWornLabel.Text = "Armour Worn: " + gameState.player.equippedArmour.Name;
            }

            if (item is EquippableItem)
            {
                EquippableItem equippableItem = (EquippableItem)item;
                equippableItem.IsEquipped = true;
                equippableItem.EquipItem(gameState.player);
                PlayerInventoryListbox.Items.Clear();
                GetPlayerInventory(gameState.player);
            }

            if (item is Consumable)
            {
                Consumable consumable = (Consumable)item;
                consumable.ConsumeItem(gameState.player);
                gameState.player.ItemList.Remove(consumable);
                PlayerInventoryListbox.Items.Clear(); 
                GetPlayerInventory(gameState.player);  
            }

            if (item is Equipment)
            {
                Equipment equipment = (Equipment)item;

                if (equipment.IsEquipped == true)
                {
                    ItemStatusLabel.Text = "In Use";
                }
            }

            gameState.player.UpdatePlayerAfterEquipmentChange();
            UpdateStatsForm();
            this.Refresh();           
        }

        private void UnuseItemButton_Click(object sender, EventArgs e)
        {
            var item = PlayerInventoryListbox.SelectedItem;

            if (item is Weapon && gameState.player.equippedWeapon.IsEquipped == true)
            {
                gameState.player.equippedWeapon.IsEquipped = false;
                Weapon weapon = (Weapon)item;                
                gameState.player.equippedWeapon = BareHands.GetInstance;
            }

            if (item is Shield && gameState.player.equippedShield.IsEquipped == true)
            {
                gameState.player.equippedShield.IsEquipped = false;
                Shield shield = (Shield)item;
                gameState.player.equippedShield = NoShield.GetInstance;
            }

            if (item is Armour && gameState.player.equippedArmour.IsEquipped == true)
            {
                gameState.player.equippedArmour.IsEquipped = false;
                Armour armour = (Armour)item;
                gameState.player.equippedArmour = NoArmor.GetInstance;
            }

            if (item is EquippableItem)
            {
                EquippableItem equippableItem = (EquippableItem)item;
                equippableItem.IsEquipped = false;
                equippableItem.UnEquipItem(gameState.player);
            }

            if (item is Equipment)
            {
                Equipment equipment = (Equipment)item;

                if (equipment.IsEquipped == true)
                {
                    ItemStatusLabel.Text = "In Use";
                } 
                else if (equipment.IsEquipped == false)
                {
                    ItemStatusLabel.Text = "";
                }
            }

            gameState.player.UpdatePlayerAfterEquipmentChange();
            UpdateStatsForm();
            this.Refresh();
        }
    }
}
