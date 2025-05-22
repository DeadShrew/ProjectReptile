using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;

namespace ProjectReptile.Items
{
    public class ScrollOfHealing : Consumable
    {
        public ScrollOfHealing()
        {
            this.Name = "Scroll";
            this.TrueName = "Scroll of Healing";

        }

        public override void ConsumeItem(Player player)
        {
            Random random = new Random();

            random.Next(1, 5);

            if (player.Strength < player.MaxStrength)
            {
                player.Strength += 1;
            }

            MessageBox.Show("You have used a healing scroll. You feel your strength returning.");
        }
    }
}
