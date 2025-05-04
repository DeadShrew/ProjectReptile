using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile
{
    public class LensOfIdentity : EquippableItem
    {
        public LensOfIdentity()
        {
            this.Name = "magnifying glass";
            this.TrueName = "lens of identity";
        }

        public override void EquipItem(Player player)
        {
            this.IsEquipped = true;
            GlobalStateManager.LensEquipped = true;
            MessageBox.Show("You have equipped the a lens of identity. You now see the true nature of items.");
        }

        public override void UnEquipItem(Player player)
        {
            this.IsEquipped = false;
            GlobalStateManager.LensEquipped = false;
            MessageBox.Show("You have unequipped the a lens of identity. You no longer see the true nature of items.");
        }
    }
}

