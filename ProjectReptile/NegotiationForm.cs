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
    public partial class NegotiationForm : Form
    {
        MainForm _mainForm;

        public NegotiationForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            ComboBoxInitialization();
        }


        private void ComboBoxInitialization()
        {
            for (int i = 0; i < _mainForm.gameState.player.Gold; i++)
                BribeAmountComboBox.Items.Add(i);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Player player = _mainForm.gameState.player;
            Enemy enemy = _mainForm.gameState.GetEnemyByCoordinates(player.LocationX, player.LocationY);
            int bribeAmount;  int.TryParse(BribeAmountComboBox.Text, out bribeAmount);  

            if (int.TryParse(BribeAmountComboBox.Text, out bribeAmount))
            {
                if (bribeAmount >= enemy.Gold)
                {
                    player.Gold -= bribeAmount;
                    enemy.Gold += bribeAmount;
                    player.InCombat = false;
                    GUIOutputManager.PlayerConsoleOutputList.AddLast("You have successfully negotiated with the enemy.");
                    _mainForm.EnableMovementButtons();
                }
                else
                {
                    enemy.IsNegotiable = false;
                    GUIOutputManager.PlayerConsoleOutputList.AddLast("The enemy is disgusted with your paltry offer.");
                }
            }

            _mainForm.UpdatePlayerInfoLabelsAndGUI();
            _mainForm.UpdatePlayerConsole();
            _mainForm.DisableActionButtons();
            _mainForm.EnableActionButtons();
            _mainForm.Refresh(); 
            this.Dispose(); 
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
