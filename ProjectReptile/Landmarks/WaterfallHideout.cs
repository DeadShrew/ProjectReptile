using ProjectReptile.AbstractClasses;
using ProjectReptile.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Landmarks
{
    public class WaterfallHideout : Landmark
    {
        public WaterfallHideout()
        {
            this.Name = "waterfall hideout";
            string relativePath = "QC_Assets\\WaterfallHideout.png";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            this.landmarkIcon = Image.FromFile(fullPath);

            item = ItemFactory.CreatePotion();
        }
    }
}
