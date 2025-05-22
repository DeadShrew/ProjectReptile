using ProjectReptile.AbstractClasses;
using ProjectReptile.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Landmarks
{
    public class GarbagePit : Landmark
    {
        public GarbagePit()
        {
            this.Name = "garbage pit";
            string relativePath = "QC_Assets\\GarbagePit.png";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            this.landmarkIcon = Image.FromFile(fullPath);

            item = ItemFactory.CreateItem();
        }
    }
}
