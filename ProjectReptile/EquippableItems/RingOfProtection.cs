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
    public class RingOfProtection : EquippableItem
    {
        public RingOfProtection()
        {
            this.Name = "brass ring";
            this.TrueName = "ring of protection";
        }

        public override void EquipItem(Player player)
        {
            this.IsEquipped = true;
            player.Armor += 1;
            MessageBox.Show("You have equipped a Ring of Protection. Your defense increases.");
        }

        public override void UnEquipItem(Player player)
        {
            this.IsEquipped = false;
            player.Armor -= 1;
            MessageBox.Show("You have unequipped a Ring of Protection. Your defense decreases.");
        }
    }
}
