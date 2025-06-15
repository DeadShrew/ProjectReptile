using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.EquippableItems
{
    class AmuletOfTheLifeDrain : EquippableItem
    {
        public AmuletOfTheLifeDrain()
        {
            this.Name = "amulet";
            this.TrueName = "amulet of life drain";
            this.IsCursed = true;
        }

        public override void EquipItem(Player player)
        {
            this.IsEquipped = true;
            player.Strength -= 1;
            player.MaxStrength -= 1;
            player.IsCursed = true;
            MessageBox.Show("You have equipped an Amulet of Life Drain. Your maximum health decreases.");
        }

        public override void UnEquipItem(Player player)
        {
            this.IsEquipped = false;
            player.Strength += 1;
            player.MaxStrength += 1;
            MessageBox.Show("You have unequipped an Amulet of Life Drain. Your maximum health increases.");
        }
    }
}
