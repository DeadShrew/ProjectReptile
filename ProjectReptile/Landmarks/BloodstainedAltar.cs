using ProjectReptile.AbstractClasses;
using ProjectReptile.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Landmarks
{
    public class BloodstainedAltar : Landmark
    {
        public BloodstainedAltar()
        {
            this.Name = "blood-stained altar";
            string relativePath = "QC_Assets\\BloodStainedAltar.png";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            this.landmarkIcon = Image.FromFile(fullPath);

            Random random = new Random();

            int role = random.Next(0, 2);

            if (role == 0)
            {
                item = ItemFactory.CreateScroll();
            }
            else
            {
                item = ItemFactory.CreateTome();
            }
        }
    }
}
