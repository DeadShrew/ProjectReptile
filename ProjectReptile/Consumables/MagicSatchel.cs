using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;

namespace ProjectReptile.Items
{
    public class MagicSatchel : Consumable
    {
        public MagicSatchel()
        {
            this.Name = "leather bag";
            this.TrueName = "magic satchel";

        }

        public override void ConsumeItem(Player player)
        {
            player.CarryAmount = 21;

            MessageBox.Show("You have found a magic satchel. Your maximum carry amount has increased.");
        }
    }
}
