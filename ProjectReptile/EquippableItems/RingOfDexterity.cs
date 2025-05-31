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
    public class RingOfDexterity : EquippableItem
    {
        public RingOfDexterity()
        {
            this.Name = "copper ring";
            this.TrueName = "ring of dexterity";
        }

        public override void EquipItem(Player player)
        {
            this.IsEquipped = true;
            player.Dexterity += 1;
            player.MaxDexterity += 1;
            MessageBox.Show("You have equipped a Ring of Dexterity. Your maximum dexterity increases.");
        }

        public override void UnEquipItem(Player player)
        {
            this.IsEquipped = false;
            player.Dexterity -= 1;
            player.MaxDexterity -= 1;
            MessageBox.Show("You have unequipped a Ring of Dexterity. Your maximum dexterity decreases.");
        }
    }
}
