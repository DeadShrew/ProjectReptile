using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectReptile
{
    public partial class DefeatForm : Form
    {
        private MainForm _mainForm;
        private static DefeatForm _instance;
        private static readonly object _lock = new object();

        public DefeatForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        public static DefeatForm GetInstance(GameStateModel gameState, MainForm mainForm)
        {
            lock (_lock)
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new DefeatForm(mainForm);
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

            GlobalStateManager.LensEquipped = false;

            _mainForm.gameState.player.Strength = 20;  

            _mainForm.gameState.player.LocationX = GlobalStateManager.StartingLocationX;
            _mainForm.gameState.player.LocationY = GlobalStateManager.StartingLocationY;

            _mainForm.Invoke((MethodInvoker)(() => _mainForm.NewGameFormRefresh()));

            _mainForm.gameState.player.InCombat = false;

            _mainForm.ToggleMovementButtonsForCombat(); 

            this.Refresh();
            this.Dispose();
        }
    }
}
