using ProjectReptile.AbstractClasses;
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
            foreach (Enemy enemy in _mainForm.gameState.EnemyList)
            {
                enemy.Strength = enemy.MaxStrength;
            }

            foreach (Landmark landmark in _mainForm.gameState.LandmarkList)
            {
                landmark.Searched = false;
            }

            _mainForm.gameState.ParcelList.Clear();

            _mainForm.gameState.player.Strength = 20;

            GlobalStateManager.LensEquipped = false;

            _mainForm.gameState.player.LocationX = GlobalStateManager.StartingLocationX;
            _mainForm.gameState.player.LocationY = GlobalStateManager.StartingLocationY;

            _mainForm.ToggleMovementButtonsForCombat();

            _mainForm.Invoke((MethodInvoker)(() => _mainForm.NewGameFormRefresh()));
            this.Refresh();
            this.Dispose();
        }
    }
}
