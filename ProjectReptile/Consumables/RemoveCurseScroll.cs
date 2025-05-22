using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;

namespace ProjectReptile.Items
{
    public class RemoveCurseScroll : Consumable
    {
        public RemoveCurseScroll()
        {
            this.Name = "Scroll";
            this.TrueName = "Remove Curse Scroll";

        }

        public override void ConsumeItem(Player player)
        {
            player.IsCursed = false;

            MessageBox.Show("You have used a remove curse scroll You are cleansed of maleficent forces.");
        }
    }
}
