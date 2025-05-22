using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;

namespace ProjectReptile.Items
{
    public class PotionOfWeakness : Consumable
    {
        public PotionOfWeakness()
        {
            this.Name = "Blue Potion";
            this.TrueName = "Potion of Weakness";

        }

        public override void ConsumeItem(Player player)
        {
            player.Strength -= 1;
            player.MaxStrength -= 1;

            MessageBox.Show("You have drank a potion of weakness. You feel your lifeforce sapped.");
        }
    }
}
