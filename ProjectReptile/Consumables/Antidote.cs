using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;

namespace ProjectReptile.Items
{
    public class Antidote : Consumable
    {
        public Antidote()
        {
            this.Name = "Pink Potion";
            this.TrueName = "Antidote";

        }

        public override void ConsumeItem(Player player)
        {
            player.IsPoisoned = false; 

            MessageBox.Show("You have taken an antidote. Your body is cleansed of toxins.");
        }
    }
}
