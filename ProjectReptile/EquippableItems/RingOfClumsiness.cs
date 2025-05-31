using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.EquippableItems
{
    class RingOfClumsiness : EquippableItem
    {
        public RingOfClumsiness()
        {
            this.Name = "copper ring";
            this.TrueName = "ring of clumsiness";
            this.IsCursed = true;
        }

        public override void EquipItem(Player player)
        {
            this.IsEquipped = true;
            player.Dexterity -= 1;
            player.MaxDexterity -= 1;
            player.IsCursed = true;
            MessageBox.Show("You have equipped a Ring of Clumsiness. Your maximum dexterity decreases.");
        }

        public override void UnEquipItem(Player player)
        {
            this.IsEquipped = false;
            player.Dexterity += 1;
            player.MaxDexterity += 1;
            MessageBox.Show("You have unequipped a Ring of Clumsiness. Your maximum dexterity increases.");
        }
    }
}
