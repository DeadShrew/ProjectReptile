using ProjectReptile.AbstractClasses;
using ProjectReptile.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Landmarks
{
    public class OpenGrave : Landmark
    {
        public OpenGrave() 
        {
            this.Name = "open grave";
            string relativePath = "QC_Assets\\OpenGrave.png";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            this.landmarkIcon = Image.FromFile(fullPath);

            Random random = new Random();

            int roll = random.Next(1, 3);

            if (roll == 1)
            {
                item = ItemFactory.CreateConsumable();
            }

            if (roll == 2)
            {
                item = ItemFactory.CreateEquippableItem();
            }
        }
    }
}
