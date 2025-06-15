using ProjectReptile.AbstractClasses;
using ProjectReptile.Armor;
using ProjectReptile.GameObjects;
using ProjectReptile.Items;
using ProjectReptile.Shields;
using ProjectReptile.Tomes;
using ProjectReptile.Weapons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace ProjectReptile
{
    public partial class VictoryForm : Form
    {
        private MainForm _mainForm;
        private static VictoryForm _instance;
        private static readonly object _lock = new object();

        public VictoryForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        public static VictoryForm GetInstance(GameStateModel gameState, MainForm mainForm)
        {
            lock (_lock)
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new VictoryForm(mainForm);
                }
                return _instance;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            _mainForm.gameState = new GameStateModel(_mainForm);
            _mainForm.Invoke((MethodInvoker)(() => _mainForm.NewGameFormRefresh()));
            GlobalStateManager.LensEquipped = false;
            this.Refresh();
            this.Dispose();
        }

        private void ReplayButton_Click(object sender, EventArgs e)
        {
            Player player = _mainForm.gameState.player;

            foreach (Enemy enemy in _mainForm.gameState.EnemyList)
            {
                enemy.Strength = enemy.MaxStrength;
                enemy.IsAlive = true;
            }

            foreach (Landmark landmark in _mainForm.gameState.LandmarkList)
            {
                landmark.Searched = false;
            }

            _mainForm.gameState.ParcelList.Clear();

            player.Strength = 14;

            player.ItemList.Clear();

            player.ItemList.AddLast(new Machete());
            player.ItemList.AddLast(new SmallShield());
            player.ItemList.AddLast(new LeatherArmor());
            player.ItemList.AddLast(new RestorationPotion());
            player.ItemList.AddLast(new Antidote());

            player.CarryAmount = 15;

            GlobalStateManager.LensEquipped = false;

            _mainForm.gameState.player.LocationX = GlobalStateManager.StartingLocationX;
            _mainForm.gameState.player.LocationY = GlobalStateManager.StartingLocationY;

            _mainForm.gameState.player.InCombat = false;

            _mainForm.ToggleMovementButtonsForCombat();

            _mainForm.Invoke((MethodInvoker)(() => _mainForm.NewGameFormRefresh()));
            this.Refresh();
            this.Dispose();
        }
    }
}
