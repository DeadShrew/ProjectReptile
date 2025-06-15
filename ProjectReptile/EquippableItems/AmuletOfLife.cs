using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;

namespace ProjectReptile
{
    public class AmuletOfLife : EquippableItem
    {
        public AmuletOfLife()
        {
            this.Name = "amulet";
            this.TrueName = "amulet of life";
        }

        public override void EquipItem(Player player)
        {
            this.IsEquipped = true;
            player.Strength += 1;
            player.MaxStrength += 1;
            MessageBox.Show("You have equipped an Amulet of Life. Your maximum health increases.");
        }

        public override void UnEquipItem(Player player)
        {
            this.IsEquipped = false;
            player.Strength -= 1;
            player.MaxStrength -= 1;
            MessageBox.Show("You have unequipped an Amulet of Life. Your maximum health decreases.");
        }
    }
}
