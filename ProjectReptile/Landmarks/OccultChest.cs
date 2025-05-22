using ProjectReptile.AbstractClasses;
using ProjectReptile.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Landmarks
{
    public class OccultChest : Landmark
    {
        public OccultChest ()
        {
            this.Name = "occult chest";
            string relativePath = "QC_Assets\\OccultChest.png";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            this.landmarkIcon = Image.FromFile(fullPath);

            item = ItemFactory.CreateScroll();
        }
    }
}
