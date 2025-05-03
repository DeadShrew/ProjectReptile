using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;

namespace ProjectReptile.Items
{
    public class RestorationPotion : Consumable
    {
        public RestorationPotion() 
        {
            this.Name = "Red Potion";
            this.TrueName = "Restoration Potion"; 
        }

        public override void ConsumeItem(Player player)
        {
            player.Strength = player.MaxStrength;
            MessageBox.Show("You have used a restoration potion. Your health is restored.");
        }
    }
}
