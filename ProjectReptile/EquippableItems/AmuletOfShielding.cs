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
    public class AmuletOfShielding : EquippableItem
    {
        public AmuletOfShielding()
        {
            this.Name = "amulet";
            this.TrueName = "amulet of shielding";
        }

        public override void EquipItem(Player player)
        {
            this.IsEquipped = true;
            player.Armor += 1;
            MessageBox.Show("You have equipped an Amulet of Shielding. Your defense increases.");
        }

        public override void UnEquipItem(Player player)
        {
            this.IsEquipped = false;
            player.Armor -= 1;
            MessageBox.Show("You have unequipped an Amulet of Shielding. Your defense decreases.");
        }
    }
}
