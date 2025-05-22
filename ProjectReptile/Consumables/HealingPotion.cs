using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;

namespace ProjectReptile.Items
{
    public class HealingPotion : Consumable
    {
        public HealingPotion()
        {
            this.Name = "Pink Potion";
            this.TrueName = "Healing Potion";

        }

        public override void ConsumeItem(Player player)
        {
            Random random = new Random();

            random.Next(1, 5);

            if (player.Strength < player.MaxStrength)
            {
                player.Strength += 1;
            }
                      
            MessageBox.Show("You have drank a healing potion. You can feel your strength returning.");
        }
    }
}
