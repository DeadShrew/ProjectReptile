using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;

namespace ProjectReptile.Items
{
    public class StrengthPotion : Consumable
    {
        public StrengthPotion()
        {
            this.Name = "Blue Potion";
            this.TrueName = "Strength Potion";

        }

        public override void ConsumeItem(Player player)
        {
            player.Strength += 1;
            player.MaxStrength += 1;
            MessageBox.Show("You have drank potion of strength! You feel invigorated.");
        }
    }
}

