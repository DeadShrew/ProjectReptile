using ProjectReptile.AbstractClasses;
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
            string relativePath = "Images\\Mythos Cultist Test Image.png";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            this.landmarkIcon = Image.FromFile(fullPath);
        }
    }
}
