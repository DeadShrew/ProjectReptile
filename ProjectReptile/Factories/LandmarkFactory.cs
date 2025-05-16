using ProjectReptile.AbstractClasses;
using ProjectReptile.Landmarks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectReptile.Factories
{
    internal class LandmarkFactory
    {
        public static Landmark CreateLandmark()
        {
            Random random = new Random();

            int landmark = random.Next(1, 4);

            switch (landmark)
            {
                case 1:
                    return new Mausoleum();

                case 2:
                    return new OpenGrave();

                case 3:
                    return new Chest();
            }
            return null;
        }
    }
}
