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
using System.Collections;

namespace ProjectReptile
{
    public partial class StatsAndInvForm : Form
    {
        private static StatsAndInvForm _instance;
        private static readonly object _lock = new object();

        GameStateModel _gameState;
        MainForm _mainForm;

        private StatsAndInvForm(GameStateModel gameState, MainForm mainForm)
        {
            InitializeComponent();
            CharNameTextBoxLabel.Text = GlobalStateManager.PlayerName;
            this._gameState = gameState;
            this._mainForm = mainForm;
            UpdateStatsForm();
        }

        public static StatsAndInvForm GetInstance(GameStateModel gameState, MainForm mainForm)
        {
            lock (_lock)
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new StatsAndInvForm(gameState, mainForm);
                }
                return _instance;
            }
        }

        private void UpdateStatsForm()
        {
            this.MaxStrengthTextBoxLabel.Text = _gameState.player.MaxStrength.ToString();
            this.MaxDexTextBoxLabel.Text = _gameState.player.MaxDexterity.ToString();
            this.IntelligenceTextBoxLabel.Text = _gameState.player.Intelligence.ToString();
            this.CurrentStrengthTextBoxLabel.Text = _gameState.player.Strength.ToString();
            this.ModifiedTextBoxLabel.Text = _gameState.player.Dexterity.ToString();
            this.ModifiedIntTextBoxLabel.Text = _gameState.player.ModifiedInt.ToString();
            this.GoldTextBoxLabel.Text = _gameState.player.Gold.ToString();
            this.WeaponTextBoxLabel.Text = _gameState.player.Weapon.ToString();
            this.ArmourTextBoxLabel.Text = _gameState.player.Armor.ToString();
            if (_gameState.player.equippedWeapon != null)
            {
                this.ReadyWeaponLabel.Text = "Ready Weapon: " + _gameState.player.equippedWeapon.Name;
            }
            if (_gameState.player.equippedShield != null)
            {
                this.ReadyShieldLabel.Text = "Ready Shield: " + _gameState.player.equippedShield.Name;
            }
            if (_gameState.player.equippedArmour != null)
            {
                this.ArmourWornLabel.Text = "Armour Worn: " + _gameState.player.equippedArmour.Name;
            }
            if (_gameState.player.GoldKeyFound == true)
            {
                this.GoldKeyLabel.Text = "Gold Key found.";
            }
        }

        private void StatsAndInvForm_Load(object sender, EventArgs e)
        {
            GetPlayerInventory(_gameState.player);
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

                if (item is EquippableItem)
                {
                    EquippableItem equippableItem = (EquippableItem)item;

                    if (equippableItem.IsEquipped == true && equippableItem.IsCursed == true && _gameState.player.IsCursed == true)
                    {
                        ItemStatusLabel.Text = "Cursed";
                    }
                }
            }

            this.Refresh();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _mainForm.Refresh();
        }

        private void UseItemButton_Click(object sender, EventArgs e)
        {
            var item = PlayerInventoryListbox.SelectedItem;

            if (item is Weapon)
            {
                Weapon weapon = (Weapon)item;
                if (weapon.TwoHanded == false)
                {
                    _gameState.player.equippedWeapon.IsEquipped = false;
                    _gameState.player.equippedWeapon = weapon;
                    weapon.IsEquipped = true;
                    ReadyWeaponLabel.Text = "Ready Weapon: " + _gameState.player.equippedWeapon.Name;
                }
                else if (weapon.TwoHanded == true && _gameState.player.equippedShield is NoShield)
                {
                    _gameState.player.equippedWeapon.IsEquipped = false;
                    _gameState.player.equippedWeapon = weapon;
                    weapon.IsEquipped = true;
                    ReadyWeaponLabel.Text = "Ready Weapon: " + _gameState.player.equippedWeapon.Name;
                }
                else
                {
                    MessageBox.Show("You cannot equip a two-handed weapon while using a shield.");
                }
            }

            if (item is Shield)
            {
                Shield shield = (Shield)item;
                if (_gameState.player.equippedWeapon.TwoHanded == false)
                {
                    _gameState.player.equippedShield.IsEquipped = false;
                    _gameState.player.equippedShield = shield;
                    shield.IsEquipped = true;
                    ReadyShieldLabel.Text = "Ready Shield: " + _gameState.player.equippedShield.Name;
                }
                else if (_gameState.player.equippedWeapon.TwoHanded == true)
                {
                    MessageBox.Show("You cannot equip a shield while using a two-handed weapon.");
                }

            }

            if (item is Armour)
            {
                Armour armour = (Armour)item;
                _gameState.player.equippedArmour.IsEquipped = false;
                _gameState.player.equippedArmour = armour;
                armour.IsEquipped = true;
                ArmourWornLabel.Text = "Armour Worn: " + _gameState.player.equippedArmour.Name;
            }

            if (item is Tome)
            {
                Tome tome = (Tome)item;
                tome.IsEquipped = true;
                _gameState.player.equippedTome = tome;
                PlayerInventoryListbox.Items.Clear();
                GetPlayerInventory(_gameState.player);
            }

            if (item is EquippableItem)
            {
                EquippableItem equippableItem = (EquippableItem)item;
                equippableItem.IsEquipped = true;
                equippableItem.EquipItem(_gameState.player);
                PlayerInventoryListbox.Items.Clear();
                GetPlayerInventory(_gameState.player);
            }

            if (item is Consumable)
            {
                Consumable consumable = (Consumable)item;
                consumable.ConsumeItem(_gameState.player);
                _gameState.player.ItemList.Remove(consumable);
                PlayerInventoryListbox.Items.Clear();
                GetPlayerInventory(_gameState.player);
            }

            if (item is Equipment)
            {
                Equipment equipment = (Equipment)item;

                if (equipment.IsEquipped == true)
                {
                    ItemStatusLabel.Text = "In Use";
                }
            }

            if (item is EquippableItem)
            {
                EquippableItem equippableItem = (EquippableItem)item;

                if (equippableItem.IsEquipped == true && equippableItem.IsCursed == true && _gameState.player.IsCursed == true)
                {
                    ItemStatusLabel.Text = "Cursed";
                }
            }

            _gameState.player.UpdatePlayerAfterEquipmentChange();
            UpdateStatsForm();
            this.Refresh();
            _mainForm.Invoke((MethodInvoker)(() => _mainForm.UpdatePlayerInfoLabelsAndGUI()));
            _mainForm.Invoke((MethodInvoker)(() => _mainForm.NewGameFormRefresh()));
        }

        private void UnuseItemButton_Click(object sender, EventArgs e)
        {
            var item = PlayerInventoryListbox.SelectedItem;

            if (item is Weapon && _gameState.player.equippedWeapon.IsEquipped == true)
            {
                _gameState.player.equippedWeapon.IsEquipped = false;
                Weapon weapon = (Weapon)item;
                _gameState.player.equippedWeapon = BareHands.GetInstance;
            }

            if (item is Shield && _gameState.player.equippedShield.IsEquipped == true)
            {
                _gameState.player.equippedShield.IsEquipped = false;
                Shield shield = (Shield)item;
                _gameState.player.equippedShield = NoShield.GetInstance;
            }

            if (item is Armour && _gameState.player.equippedArmour.IsEquipped == true)
            {
                _gameState.player.equippedArmour.IsEquipped = false;
                Armour armour = (Armour)item;
                _gameState.player.equippedArmour = NoArmor.GetInstance;
            }

            if (item is Tome)
            {
                Tome tome = (Tome)item;
                tome.IsEquipped = false;
                _gameState.player.equippedTome = null;
                PlayerInventoryListbox.Items.Clear();
                GetPlayerInventory(_gameState.player);
            }

            if (item is EquippableItem)
            {
                EquippableItem equippableItem = (EquippableItem)item;

                if (equippableItem.IsCursed == true && _gameState.player.IsCursed == true)
                {
                    MessageBox.Show("You cannot unequip a cursed item until you are cleansed."); 

                } else
                {
                    equippableItem.IsEquipped = false;
                    equippableItem.UnEquipItem(_gameState.player);
                }
                
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

            if (item is EquippableItem)
            {
                EquippableItem equippableItem = (EquippableItem)item;

                if (equippableItem.IsEquipped == true && equippableItem.IsCursed == true && _gameState.player.IsCursed == true)
                {
                    ItemStatusLabel.Text = "Cursed";
                }
            }

            _gameState.player.UpdatePlayerAfterEquipmentChange();
            UpdateStatsForm();
            this.Refresh();
            _mainForm.Invoke((MethodInvoker)(() => _mainForm.UpdatePlayerInfoLabelsAndGUI()));
            _mainForm.Invoke((MethodInvoker)(() => _mainForm.NewGameFormRefresh()));
        }

        private void DropItemButton_Click(object sender, EventArgs e)
        {
            var selectedItem = PlayerInventoryListbox.SelectedItem as Item;

            if (selectedItem != null && selectedItem is Weapon)
            {
                if (selectedItem == _gameState.player.equippedWeapon)
                {
                    MessageBox.Show("You must unequip the selected weapon before it can be dropped. "); 
                } else
                {
                    var node = _gameState.player.ItemList.Find(selectedItem);
                    if (node != null)
                    {
                        _gameState.player.ItemList.Remove(node);

                    }
                }
            }

            if (selectedItem != null && selectedItem is Shield)
            {
                if (selectedItem == _gameState.player.equippedShield)
                {
                    MessageBox.Show("You must unequip the selected shield before it can be dropped. ");
                }
                else
                {
                    var node = _gameState.player.ItemList.Find(selectedItem);
                    if (node != null)
                    {
                        _gameState.player.ItemList.Remove(node);

                    }
                }
            }

            if (selectedItem != null && selectedItem is Armour)
            {
                if (selectedItem == _gameState.player.equippedArmour)
                {
                    MessageBox.Show("You must unequip the selected armour before it can be dropped. ");
                }
                else
                {
                    var node = _gameState.player.ItemList.Find(selectedItem);
                    if (node != null)
                    {
                        _gameState.player.ItemList.Remove(node);

                    }
                }
            }

            if (selectedItem != null && selectedItem is Tome tome)
            {
                if (tome.IsEquipped == true)
                {
                    MessageBox.Show("You must unequip the selected tome before it can be dropped. ");
                }
                else if (tome.IsEquipped == false)
                {
                    var node = _gameState.player.ItemList.Find(selectedItem);
                    if (node != null)
                    {
                        _gameState.player.ItemList.Remove(node);

                    }
                }
            }

            if (selectedItem != null && selectedItem is EquippableItem equippableItem)
            {
                if (equippableItem.IsEquipped == true)
                {
                    MessageBox.Show("You must unequip the selected item before it can be dropped. ");
                } else if (equippableItem.IsEquipped == false)
                {
                    var node = _gameState.player.ItemList.Find(selectedItem);
                    if (node != null)
                    {
                        _gameState.player.ItemList.Remove(node);

                    }
                } 
            }

            PlayerInventoryListbox.Items.Clear();
            GetPlayerInventory(_gameState.player);
            this.Refresh();
        }
    }
}
