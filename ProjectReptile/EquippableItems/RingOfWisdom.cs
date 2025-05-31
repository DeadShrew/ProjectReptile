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
    public class RingOfWisdom : EquippableItem
    {
        public RingOfWisdom()
        {
            this.Name = "silver ring";
            this.TrueName = "ring of wisdom";
        }

        public override void EquipItem(Player player)
        {
            this.IsEquipped = true;
            player.Intelligence += 1;
            player.ModifiedInt += 1;
            MessageBox.Show("You have equipped a Ring of Wisdom. Your maximum intelligence increases.");
        }

        public override void UnEquipItem(Player player)
        {
            this.IsEquipped = false;
            player.Intelligence -= 1;
            player.ModifiedInt -= 1;
            MessageBox.Show("You have unequipped a Ring of Wisdom. Your maximum intelligence decreases.");
        }
    }
}
