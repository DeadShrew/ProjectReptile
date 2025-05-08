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


        public DefeatForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            _mainForm.gameState = new GameStateModel();
            _mainForm.Invoke((MethodInvoker)(() => _mainForm.NewGameFormRefresh()));
            this.Refresh();
            this.Dispose();
        }
    }
}
