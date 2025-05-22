using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;

namespace ProjectReptile.Items
{
    public class PoisonPotion : Consumable
    {
        public PoisonPotion()
        {
            this.Name = "Red Potion";
            this.TrueName = "Poison Potion";
        }

        public override void ConsumeItem(Player player)
        {
            player.IsPoisoned = true;
            MessageBox.Show("You have used a poison potion. Seek an antidote.");
        }
    }
}
