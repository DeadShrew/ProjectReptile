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
                this.ArmourWormLabel.Text = "Armour Worn: " + gameState.player.equippedArmour.Name;
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

                } else if (equipment.IsEquipped == false) 
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
                gameState.player.equippedWeapon = weapon;
                weapon.IsEquipped = true;
            }

            if (item is Shield)
            {
                Shield shield = (Shield)item;
                gameState.player.equippedShield = shield;
                shield.IsEquipped = true;
            }

            if (item is Armour)
            {
                Armour armour = (Armour)item;
                gameState.player.equippedArmour = armour;
                armour.IsEquipped = true;
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
    }
}
