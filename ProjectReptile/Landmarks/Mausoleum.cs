using ProjectReptile.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Landmarks
{
    public class Mausoleum : Landmark
    {
        public Mausoleum() 
        {
            this.Name = "mausoleum";
            string relativePath = "Images\\Mythos Cultist Test Image.png";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            this.landmarkIcon = Image.FromFile(fullPath);
        }
    }
}
