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

namespace ProjectReptile
{
    public partial class StatsAndInvForm : Form
    {
        GameStateModel gameState;

        //private static StatsAndInvForm instance;

        /*public static StatsAndInvForm GetInstance()
        {
            {
                if (instance == null || instance.IsDisposed)
                    instance = new StatsAndInvForm();
                return instance;
            }
        }*/

        public StatsAndInvForm(GameStateModel gameState)
        {
            InitializeComponent();
            this.gameState = gameState;
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

        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
