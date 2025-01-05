using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ProjectReptile
{
    public partial class StatsAndInvForm : Form
    {
        private static StatsAndInvForm instance;
        public static StatsAndInvForm GetInstance()
        {
            {
                if (instance == null || instance.IsDisposed)
                    instance = new StatsAndInvForm();
                return instance;
            }
        }

        public StatsAndInvForm()
        {
            InitializeComponent();
        }

        private void StatsAndInvForm_Load(object sender, EventArgs e)
        {

        }

        private void PlayerInventoryListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
