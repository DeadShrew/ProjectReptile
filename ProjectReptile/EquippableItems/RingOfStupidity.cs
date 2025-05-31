using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.EquippableItems
{
    class RingOfStupidity : EquippableItem
    {
        public RingOfStupidity()
        {
            this.Name = "silver ring";
            this.TrueName = "ring of stupidity";
            this.IsCursed = true;
        }

        public override void EquipItem(Player player)
        {
            this.IsEquipped = true;
            player.Intelligence -= 1;
            player.ModifiedInt -= 1;
            player.IsCursed = true;
            MessageBox.Show("You have equipped a Ring of Stupidity. Your maximum intelligence decreases.");
        }

        public override void UnEquipItem(Player player)
        {
            this.IsEquipped = false;
            player.Intelligence += 1;
            player.ModifiedInt += 1;
            MessageBox.Show("You have unequipped a Ring of Stupidity. Your maximum intelligence increases.");
        }
    }
}
