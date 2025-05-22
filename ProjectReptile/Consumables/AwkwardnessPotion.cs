using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;

namespace ProjectReptile.Items
{
    public class AwkwardnessPotion : Consumable
    {
        public AwkwardnessPotion()
        {
            this.Name = "White Potion";
            this.TrueName = "Awkwardness Potion";

        }

        public override void ConsumeItem(Player player)
        {
            player.Dexterity -= 1;
            player.MaxDexterity -= 1;
            MessageBox.Show("You have drank a potion of awkwardness. You feel clumsy and sluggish.");
        }
    }
}
