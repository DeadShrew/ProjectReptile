using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;

namespace ProjectReptile.Items
{
    public class DexterityPotion : Consumable
    {
        public DexterityPotion()
        {
            this.Name = "White Potion";
            this.TrueName = "Dexterity Potion";

        }

        public override void ConsumeItem(Player player)
        {
            player.Dexterity += 1;
            player.MaxDexterity += 1;
            MessageBox.Show("You have drank a dexterity potion. You feel light and nimble.");
        }
    }
}
