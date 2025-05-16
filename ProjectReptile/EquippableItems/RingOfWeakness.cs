using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.EquippableItems
{
    class RingOfWeakness : EquippableItem
    {
        public RingOfWeakness()
        {
            this.Name = "gold ring";
            this.TrueName = "ring of weakness";
            this.IsCursed = true;
        }

        public override void EquipItem(Player player)
        {
            this.IsEquipped = true;
            player.Strength -= 1;
            player.MaxStrength -= 1;
            player.IsCursed = true;
            MessageBox.Show("You have equipped a Ring of Weakness. Your maximum health decreases.");
        }

        public override void UnEquipItem(Player player)
        {
            this.IsEquipped = false;
            player.Strength += 1;
            player.MaxStrength += 1;
            MessageBox.Show("You have unequipped a Ring of Weakness. Your maximum health increases.");
        }
    }
}
