using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;

namespace ProjectReptile.Items
{
    public class ScrollOfStrength : Consumable
    {
        public ScrollOfStrength()
        {
            this.Name = "Scroll";
            this.TrueName = "Scroll of Strength";

        }

        public override void ConsumeItem(Player player)
        {
            player.Strength += 1;
            player.MaxStrength += 1;

            MessageBox.Show("You have equipped a Ring of Strength. Your maximum health increases.");
        }
    }
}
