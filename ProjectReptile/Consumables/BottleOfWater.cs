﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectReptile.AbstractClasses;
using ProjectReptile.GameObjects;

namespace ProjectReptile.Items
{
    public class BottleOfWater : Consumable
    {
        public BottleOfWater()
        {
            this.Name = "Blue Potion";
            this.TrueName = "Bottle of Water";

        }

        public override void ConsumeItem(Player player)
        {
            MessageBox.Show("You have drank a bottle of water. Nothing happens"); 
        }
    }
}
